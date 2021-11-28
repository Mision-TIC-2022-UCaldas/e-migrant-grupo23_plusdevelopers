using System;
using System.Linq;
using System.Collections.Generic;
using EMigrant.App.Dominio.Entidades;

namespace EMigrant.App.Persistencia.AppRepositorios
{
    public class RepositorioEntidad: IRepositorioEntidad
    {
        private readonly AppContext appContext;

        public RepositorioEntidad(AppContext appContext){
            this.appContext = appContext;
        }
        public Entidad CrearEntidad(Entidad entidad){
            var entidadCrear = appContext.Entidades.Add(entidad);
            appContext.SaveChanges();
            return entidadCrear.Entity;
        }
        public Entidad ActualizarEntidad(Entidad entidad){
            var entidadEncontrada = appContext.Entidades.FirstOrDefault(e => e.Id == entidad.Id);
            if(entidadEncontrada != null){
                entidadEncontrada.RazonSocial = entidad.RazonSocial;
                entidadEncontrada.Nit = entidad.Nit;
                entidadEncontrada.Direccion = entidad.Direccion;
                entidadEncontrada.Ciudad = entidad.Ciudad;
                entidadEncontrada.Telefono = entidad.Telefono;
                entidadEncontrada.CorreoElectronico = entidad.CorreoElectronico;
                entidadEncontrada.PaginaWeb = entidad.PaginaWeb;
                entidadEncontrada.SectorId = entidad.SectorId;
                entidadEncontrada.TipoServicioId = entidad.TipoServicioId;
                appContext.SaveChanges();
            }
            return entidadEncontrada;
        }
        public void EliminarEntidad(int idEntidad){
            var entidadEncontrada = appContext.Entidades.FirstOrDefault(e => e.Id == idEntidad);
            if(entidadEncontrada == null)
                return;
            appContext.Entidades.Remove(entidadEncontrada);
            appContext.SaveChanges();
        }
        public Entidad ObtenerEntidad(int idEntidad){
            return appContext.Entidades.FirstOrDefault(e => e.Id == idEntidad);
        }
        public IEnumerable<Entidad> ObtenerTodasLasEntidades(){
            return appContext.Entidades;
        }
    }
}