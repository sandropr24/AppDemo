using System;
using System.Collections.Generic;
using System.Text;

//Invocar capa Entidades
using Entidades;

namespace DAL
{
    public interface IClienteDal
    {
        //Listar <Cliente> Entidad (CAPA)
        //Se utilizará para consultar todos los datos | buscador
        Task<List<Cliente>> ListarAsync(string? buscar = null, CancellationToken ct = default);

        //Obtener <Clase?>
        //Podemos retornar una clase o un NULL
        Task<Cliente?> ObtenerAsync(int id, CancellationToken ct = default);

        //Crear
        Task<Cliente?> CrearAsync(Cliente cliente, CancellationToken ct = default);

        //Actualizar
        //No retorna valor, pero sí define un método ASÍNCRONO
        Task ActualizarAsync(Cliente cliente, CancellationToken ct = default);

        //Eliminar
        Task EliminarAsync(int id, CancellationToken ct = default);
    }
}
