using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncuestaLibrery
{
    public class Class1
    {
        EncuestaTareaEntities db = new EncuestaTareaEntities();

        public List<Encuesta> Listar()
        {
            var encuesta = from a in db.Encuesta
                           select a;
            return encuesta.ToList();
        }


        public void Agregar(Encuesta itm)
        {
            db.Encuesta.Add(itm);
            db.SaveChanges();
        }

        public EncuestaLibrery.Encuesta Buscar(int id)
        {
            var encuesta = from a in db.Encuesta
                           where a.id == id
                           select a;

            return encuesta.FirstOrDefault();
        }

        public void Editar(EncuestaLibrery.Encuesta item)
        {
            var encuesta = (from a in db.Encuesta
                            where a.id == item.id
                            select a).FirstOrDefault();

            encuesta.equipo = item.equipo;
            encuesta.nombreArea = item.nombreArea;
           

            db.SaveChanges();
        }
        public void Eliminar(EncuestaLibrery.Encuesta item)
        {
            var encuesta = (from a in db.Encuesta
                            where a.id == item.id
                            select a).FirstOrDefault();

            db.Encuesta.Remove(encuesta);
            db.SaveChanges();
        }
    }
}
