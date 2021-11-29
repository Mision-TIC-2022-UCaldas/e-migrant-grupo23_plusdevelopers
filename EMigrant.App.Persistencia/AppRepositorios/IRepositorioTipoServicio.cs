using System.Security.AccessControl;
using System.Collections.Generic;
using EMigrant.App.Dominio.Entidades;

namespace EMigrant.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTipoServicio
    {
        TipoServicio CrearTipoServicio(TipoServicio tipoServicio);
        TipoServicio ActualizarTipoServicio(TipoServicio tipoServicio);
        void EliminarTipoServicio(int idTipoServicio);
        TipoServicio ObtenerTipoServicio(int idTipoServicio);
        IEnumerable<TipoServicio> ObtenerTodosLosTiposServicio();
    }
}