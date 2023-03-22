using Evaluacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Evaluacion.Controllers
{
    public class EncuestaController : Controller
    {
        EncuestaLibrery.Class1 a = new EncuestaLibrery.Class1(); 
        // GET: Encuesta
        public ActionResult Index()
        {
            var encuesta = a.Listar();
         
            return View(encuesta);
        }



        public ActionResult Create()
        {
            return View(new EncuestaLibrery.Encuesta ());
        }
        [HttpPost]
        public ActionResult Create(EncuestaLibrery.Encuesta itm)
        {
            a.Agregar(itm);
            return View("Index", a.Listar());
        }

        public ActionResult Edit(int id)
        {
            return View(a.Buscar(id));

        }

        [HttpPost]

        public ActionResult Edit(EncuestaLibrery.Encuesta item)
        {
            a.Editar(item);
            return View("Index", a.Listar());

        }

        public ActionResult Delete(int Id)
        {
            return View(a.Buscar(Id));
        }

        [HttpPost]
        public ActionResult Delete(EncuestaLibrery.Encuesta item)
        {
            a.Eliminar(item);
            return View("index", a.Listar());
        }

    }
}