using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica8WebNotice.Models
{
    public class Noticia
    {
        public int NoticiaID { get; set; }
   
        [Required]
        public string Titulo { get; set; }
        [DataType(DataType.MultilineText)]
        public string Contenido { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int CategoriaID { get; set; }
        public virtual Categoria Categoria{ get; set; }
    }
}
