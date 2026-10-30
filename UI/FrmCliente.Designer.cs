namespace UI
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            grid = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            txtCorreo = new TextBox();
            txtDni = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 0;
            label1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(81, 22);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Apellidos, nombres, DNI";
            txtBuscar.Size = new Size(561, 25);
            txtBuscar.TabIndex = 1;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(648, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(93, 28);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = true;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            grid.BackgroundColor = SystemColors.ControlLightLight;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(18, 63);
            grid.MultiSelect = false;
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(956, 358);
            grid.TabIndex = 18;
            grid.SelectionChanged += grid_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 433);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 3;
            label2.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 433);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 5;
            label3.Text = "Nombres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 491);
            label4.Name = "label4";
            label4.Size = new Size(33, 17);
            label4.TabIndex = 9;
            label4.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(612, 433);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 7;
            label5.Text = "Correo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(224, 491);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 11;
            label6.Text = "Teléfono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(426, 491);
            label7.Name = "label7";
            label7.Size = new Size(65, 17);
            label7.TabIndex = 13;
            label7.Text = "Dirección:";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(18, 453);
            txtApellidos.MaxLength = 150;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(267, 25);
            txtApellidos.TabIndex = 4;
            txtApellidos.Enter += txtApellidos_Enter;
            txtApellidos.Leave += txtApellidos_Leave;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(318, 453);
            txtNombres.MaxLength = 150;
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(270, 25);
            txtNombres.TabIndex = 6;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(612, 453);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(360, 25);
            txtCorreo.TabIndex = 8;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(18, 511);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(179, 25);
            txtDni.TabIndex = 10;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(224, 511);
            txtTelefono.MaxLength = 9;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(179, 25);
            txtTelefono.TabIndex = 12;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(426, 511);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(546, 25);
            txtDireccion.TabIndex = 14;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(20, 568);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(170, 31);
            btnNuevo.TabIndex = 15;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(196, 568);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 31);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(372, 568);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 31);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombres);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtDni);
            Controls.Add(txtApellidos);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(grid);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView grid;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private TextBox txtCorreo;
        private TextBox txtDni;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}