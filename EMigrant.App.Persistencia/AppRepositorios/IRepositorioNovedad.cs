using System.Security.AccessControl;
using System.Collections.Generic;
using EMigrant.App.Dominio.Entidades;

namespace EMigrant.App.Persistencia.AppRepositorios
{
    public interface IRepositorioNovedad
    {
        Novedad CrearNovedad(Novedad novedad);
        Novedad ActualizarNovedad(Novedad novedad);
        void EliminarNovedad(int idNovedad);
        Novedad ObtenerNovedad(int idNovedad);
        IEnumerable<Novedad> ObtenerTodasLasNovedades();
    }
}