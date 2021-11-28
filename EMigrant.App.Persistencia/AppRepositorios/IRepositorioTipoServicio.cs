using System.Security.AccessControl;
using System.Collections.Generic;
using EMigrant.App.Dominio.Entidades;

namespace EMigrant.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTipoServicio
    {
        Sector CrearTipoServicio(TipoServicio tipoServicio);
        Sector ActualizarTipoServicio(TipoServicio tipoServicio);
        void EliminarTipoServicio(int idTipoServicio);
        Sector ObtenerTipoServicio(int idTipoServicio);
        IEnumerable<TipoServicio> ObtenerTodosLosTiposServicio();
    }
}