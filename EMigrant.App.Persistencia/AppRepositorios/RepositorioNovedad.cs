using System;
using System.Linq;
using System.Collections.Generic;
using EMigrant.App.Dominio.Entidades;

namespace EMigrant.App.Persistencia.AppRepositorios
{
    public class RepositorioNovedad
    {
        private readonly AppContext appContext;

        public RepositorioNovedad(AppContext appContext){
            this.appContext = appContext;
        }
        public Novedad CrearNovedad(Novedad novedad){
            var novedadCrear = appContext.Novedades.Add(novedad);
            appContext.SaveChanges();
            return novedadCrear.Entity;
        }
        public Novedad ActualizarNovedad(Novedad novedad){
            var novedadEncontrada = appContext.Novedades.FirstOrDefault(n => n.Id == novedad.Id);
            if(novedadEncontrada != null){
                novedadEncontrada.Fecha = novedad.Fecha;
                novedadEncontrada.NumeroDias = novedad.NumeroDias;
                novedadEncontrada.TextoExplicativo = novedad.TextoExplicativo;
                appContext.SaveChanges();
            }
            return novedadEncontrada;
        }
        public void EliminarNovedad(int idNovedad){
            var novedadEncontrada = appContext.Novedades.FirstOrDefault(n => n.Id == idNovedad);
            if(novedadEncontrada == null)
                return;
            appContext.Novedades.Remove(novedadEncontrada);
            appContext.SaveChanges();
        }
        public Novedad ObtenerNovedad(int idNovedad){
            return appContext.Novedades.FirstOrDefault(n => n.Id == idNovedad);
        }
        public IEnumerable<Novedad> ObtenerTodasLasNovedades(){
            return appContext.Novedades;
        }
    }
}