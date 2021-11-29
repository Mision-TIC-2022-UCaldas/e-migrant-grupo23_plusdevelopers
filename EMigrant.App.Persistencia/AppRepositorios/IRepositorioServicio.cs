using System.Security.AccessControl;
using System.Collections.Generic;
using EMigrant.App.Dominio.Entidades;

namespace EMigrant.App.Persistencia.AppRepositorios
{
    public interface IRepositorioServicio
    {
        Servicio CrearServicio(Servicio servicio);
        Servicio ActualizarServicio(Servicio servicio);
        void EliminarServicio(int idServicio);
        Servicio ObtenerServicio(int idServicio);
        IEnumerable<Servicio> ObtenerTodosLosServicios();
    }
}