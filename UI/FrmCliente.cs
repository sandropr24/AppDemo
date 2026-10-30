using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

using BOL;
using DAL;
using Entidades;

namespace UI
{
    public partial class FrmCliente : Form
    {
        private readonly ClienteBol _bol;
        private int _idActual; //0 = nuevo

        private bool _cargandoGrid; //Evita la seleccion mientras se renderiza los datos

        //Definir constante
        Color colorActivo = Color.LightYellow;
        Color colorBase = Color.White;


        //Constructor
        public FrmCliente(ClienteBol bol)
        {
            InitializeComponent(); //Construir UI

            _bol = bol;

            //Enlace EVENTO...
            Load += async (_, _) => await CargarAsync();
        }

        //Enviar la información obtenida del API REST al GRID
        private async Task CargarListAsync()
        {
            var lista = await _bol.ListarAsync(txtBuscar.Text);

            _cargandoGrid = true;
            grid.DataSource = lista;
            grid.ClearSelection();
            _cargandoGrid = false;

            configurarGrid();
        }

        private async Task EjecutarAsync(Func<Task> action)
        {
            Control? foco = null; //ReglaNegocioExcepcion -> Error -> CONTROL

            try
            {
                UseWaitCursor = true;
                Enabled = true;
                await action();
            }
            catch (ReglaNegocioException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //ReglaNegocio solo nos indica el nombre del campo: apellidos, nombres, dni, etc. (txtApellidos, txtNombres, txtDni)
                foco = ex.Campo switch
                {
                    nameof(Cliente.Apellidos) => txtApellidos,
                    nameof(Cliente.Nombres) => txtNombres,
                    nameof(Cliente.Dni) => txtDni,
                    nameof(Cliente.Telefono) => txtTelefono,
                    nameof(Cliente.Correo) => txtCorreo,
                    _ => null
                };
            }
            catch (ApiException ex)
            {
                MessageBox.Show(ex.Message, "Error en el servidor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("El servidor está demasiado ocupado", "Tiempo agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message, "No hay comunicación server", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Enabled = true;
                UseWaitCursor = false;
            }

            foco?.Focus(); //Elemento activo
        }

        private Task CargarAsync() => EjecutarAsync(CargarListAsync);

        private async Task GuardarAsync()
        {
            var cliente = new Cliente
            {
                Id = _idActual,
                Apellidos = txtApellidos.Text,
                Nombres = txtNombres.Text,
                Dni = txtDni.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Correo = txtCorreo.Text
            };

            await EjecutarAsync(async () =>
            {
                await _bol.GuardarAsync(cliente);
                await CargarListAsync(); //Actualizar GRID
                LimpiarFormulario();

                MessageBox.Show("Cliente guardado", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }

        private void LimpiarFormulario()
        {
            _idActual = 0;
            txtApellidos.Clear();
            txtNombres.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            grid.ClearSelection();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            await GuardarAsync();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloDigitos(sender, e);
        }
        /// <summary>
        /// Bloquea cualquier caracter ingresando a excepcion de numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



        private static void SoloDigitos(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloDigitos(sender, e);
        }

        private void configurarGrid()
        {
            //Ancho columnas
            grid.Columns[0].Visible = false;
            grid.Columns[1].Width = 170;
            grid.Columns[2].Width = 170;
            grid.Columns[5].Width = 200;
            grid.Columns[6].Width = 200;


            //  Filas cereadas
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            txtApellidos.BackColor = colorActivo;
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            txtApellidos.BackColor = colorBase;
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            //Este eveneto se ejecuta cuando cambias la fila activa
            MostrarSeleccionado();
        }

        private void MostrarSeleccionado()
        {
            if (_cargandoGrid || grid.SelectedRows.Count == 0) return;
            if (grid.SelectedRows[0].DataBoundItem is not Cliente c) return; //API

            _idActual = c.Id;
            txtApellidos.Text = c.Apellidos;
            txtNombres.Text = c.Nombres;
            txtDireccion.Text = c.Direccion;
            txtDni.Text = c.Dni;
            txtTelefono.Text = c.Telefono;
            txtCorreo.Text = c.Correo;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            await EliminarAsync();
        }

        public async Task EliminarAsync()
        {
            if (_idActual == 0) return;

            string datosCliente = $"{txtApellidos.Text}{txtNombres.Text}";
            DialogResult rpta = MessageBox.Show(
                $"¿Desea eliminar al cliente {datosCliente}?",
                "Confirmar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rpta == DialogResult.No) return;

            var id = _idActual;

            //1. Eliminar > 2. Actualizar
            await EjecutarAsync(async () =>
            {
                await _bol.EliminarAsync(id);
                await CargarListAsync();
            });

            LimpiarFormulario();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await CargarAsync();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            //Identificar el ENTER
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnBuscar.PerformClick();
            }
        }
    }
}
