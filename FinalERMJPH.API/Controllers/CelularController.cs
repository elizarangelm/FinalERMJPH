using FinalERMJPH.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalERMJPH.API.Controllers
{
    public class CelularController : ApiController
    {
        [HttpGet]
        public IEnumerable<Celular> Get()
        {

            using (var context = new CelularContext())
            {
                return context.Celulares.ToList();
            }
        }


        [HttpGet]
        public Celular Get(int id)
        {

            using (var context = new CelularContext())
            {
                return context.Celulares.FirstOrDefault(x => x.Id == id);
            }
        }
        [HttpPost]
        public Celular Post(Celular celular)
        {
            using (var context = new CelularContext())
            {
                context.Celulares.Add(celular);
                context.SaveChanges();
                return celular;
            }

        }


        [HttpPut]
        public Celular Put(Celular celular)
        {
            using (var context = new CelularContext())
            {
                var celularActualizar = context.Celulares.FirstOrDefault(x => x.Id == celular.Id);
                celularActualizar.Nombre = celular.Nombre;
                celularActualizar.Descripcion = celular.Descripcion;
                celularActualizar.Precio = celular.Precio;
                celularActualizar.Referencia = celular.Referencia;
                context.SaveChanges();
                return celular;
            }

        }

        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new CelularContext())
            {
                var celularEliminar = context.Celulares.FirstOrDefault(x => x.Id == id);
                context.Celulares.Remove(celularEliminar);

                context.SaveChanges();
                return true;
            }

        }

    }

}