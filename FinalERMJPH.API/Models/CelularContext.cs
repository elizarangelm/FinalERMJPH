using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalERMJPH.API.Models
{
    public class CelularContext:DbContext
    {
        public CelularContext() : base("FinalERMJPHConnection")
        {

        }
        public DbSet<Celular> Celulares { get; set; }
    }
}