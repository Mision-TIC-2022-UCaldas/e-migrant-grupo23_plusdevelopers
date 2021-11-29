using System;
using System.Linq;
using System.Collections.Generic;
using EMigrant.App.Dominio.Entidades;

namespace EMigrant.App.Persistencia.AppRepositorios
{
    public class RepositorioTipoServicio: IRepositorioTipoServicio
    {
        private readonly AppContext appContext;

        public RepositorioTipoServicio(AppContext appContext){
            this.appContext = appContext;
        }
        public TipoServicio CrearTipoServicio(TipoServicio tipoServicio){
            var tipoServicioCrear = appContext.TiposServicio.Add(tipoServicio);
            appContext.SaveChanges();
            return tipoServicioCrear.Entity;
        }
        public TipoServicio ActualizarTipoServicio(TipoServicio tipoServicio){
            var tipoServicioEncontrado = appContext.TiposServicio.FirstOrDefault(ts => ts.Id == tipoServicio.Id);
            if(tipoServicioEncontrado != null){
                tipoServicioEncontrado.Nombre = tipoServicio.Nombre;
                appContext.SaveChanges();
            }
            return tipoServicioEncontrado;
        }
        public void EliminarTipoServicio(int idTipoServicio){
            var tipoServicioEncontrado = appContext.TiposServicio.FirstOrDefault(ts => ts.Id == idTipoServicio);
            if(tipoServicioEncontrado == null)
                return;
            appContext.TiposServicio.Remove(tipoServicioEncontrado);
            appContext.SaveChanges();
        }
        public TipoServicio ObtenerTipoServicio(int idTipoServicio){
            return appContext.TiposServicio.FirstOrDefault(ts => ts.Id == idTipoServicio);
        }
        public IEnumerable<TipoServicio> ObtenerTodosLosTiposServicio(){
            return appContext.TiposServicio;
        }
    }
}