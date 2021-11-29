using System;
using System.Linq;
using System.Collections.Generic;
using EMigrant.App.Dominio.Entidades;

namespace EMigrant.App.Persistencia.AppRepositorios
{
    public class RepositorioServicio: IRepositorioServicio
    {
        private readonly AppContext appContext;
        public RepositorioServicio(AppContext appContext){
            this.appContext = appContext;
        }
        public Servicio CrearServicio(Servicio servicio){

            var servicioCrear = appContext.Servicios.Add(servicio);
            appContext.SaveChanges();
            return servicioCrear.Entity;
        }
        public Servicio ActualizarServicio(Servicio servicio){

            var servicioEncontrado = appContext.Servicios.FirstOrDefault(s => s.Id == servicio.Id);
            if(servicioEncontrado != null){
                servicioEncontrado.Nombre = servicio.Nombre;
                servicioEncontrado.MaximoNumeroMigrantes = servicio.MaximoNumeroMigrantes;
                servicioEncontrado.FechaInicio = servicio.FechaInicio;
                servicioEncontrado.FechaFin = servicio.FechaFin;
                servicioEncontrado.Estado = servicio.Estado;
                appContext.SaveChanges();
            }
            return servicioEncontrado;
        }
        public void EliminarServicio(int idServicio){

            var servicioEncontrado = appContext.Servicios.FirstOrDefault(s => s.Id == idServicio);
            if(servicioEncontrado == null)
                return;
            appContext.Servicios.Remove(servicioEncontrado);
            appContext.SaveChanges();
        }
        public Servicio ObtenerServicio(int idServicio){

            return appContext.Servicios.FirstOrDefault(s => s.Id == idServicio);
        }
        public IEnumerable<Servicio> ObtenerTodosLosServicios(){

            return appContext.Servicios;
        }
    }
}