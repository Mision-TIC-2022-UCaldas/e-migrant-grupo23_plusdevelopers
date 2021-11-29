using System.Security.AccessControl;
using System.Collections.Generic;
using EMigrant.App.Dominio.Entidades;

namespace EMigrant.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEntidad
    {
        Entidad CrearEntidad(Entidad entidad);
        Entidad ActualizarEntidad(Entidad entidad);
        void EliminarEntidad(int idEntidad);
        Entidad ObtenerEntidad(int idEntidad);
        IEnumerable<Entidad> ObtenerTodasLasEntidades();
    }
}