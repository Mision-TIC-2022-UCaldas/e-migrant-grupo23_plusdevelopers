using System.Security.AccessControl;
using System.Collections.Generic;
using EMigrant.App.Dominio.Entidades;

namespace EMigrant.App.Persistencia.AppRepositorios
{
    public interface IRepositorioSector
    {
        Sector CrearSector(Sector sector);
        Sector ActualizarSector(Sector sector);
        void EliminarSector(int idSector);
        Sector ObtenerSector(int idSector);
        IEnumerable<Sector> ObtenerTodosLosSectores();
    }
}