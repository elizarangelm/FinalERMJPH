using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalERMJPH.API.Models
{
    [Table("Celulares")]
    public class Celular
    {
            [Key]
            public int Id { get; set; }
            [MaxLength(30)]
            [Required]
            public string Nombre { get; set; }
            [MaxLength(200)]
            public string Descripcion { get; set; }
            [Required]
            public int Precio { get; set; }
            [Required]
            [MaxLength(30)]
            public string Referencia { get; set; } 
    }
}