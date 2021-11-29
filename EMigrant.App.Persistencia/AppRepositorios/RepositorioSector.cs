using System;
using System.Linq;
using System.Collections.Generic;
using EMigrant.App.Dominio.Entidades;

namespace EMigrant.App.Persistencia.AppRepositorios
{
    public class RepositorioSector: IRepositorioSector
    {
        private readonly AppContext appContext;

        public RepositorioSector(AppContext appContext){
            this.appContext = appContext;
        }
        public Sector CrearSector(Sector sector){
            var sectorCrear = appContext.Sectores.Add(sector);
            appContext.SaveChanges();
            return sectorCrear.Entity;
        }
        public Sector ActualizarSector(Sector sector){
            var sectorEncontrado = appContext.Sectores.FirstOrDefault(s => s.Id == sector.Id);
            if(sectorEncontrado != null){
                sectorEncontrado.Nombre = sector.Nombre;
                appContext.SaveChanges();
            }
            return sectorEncontrado;
        }
        public void EliminarSector(int idSector){
            var sectorEncontrado = appContext.Sectores.FirstOrDefault(s => s.Id == idSector);
            if(sectorEncontrado == null)
                return;
            appContext.Sectores.Remove(sectorEncontrado);
            appContext.SaveChanges();
        }
        public Sector ObtenerSector(int idSector){
            return appContext.Sectores.FirstOrDefault(s => s.Id == idSector);
        }
        public IEnumerable<Sector> ObtenerTodosLosSectores(){
            return appContext.Sectores;
        }
    }
}