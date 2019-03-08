using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica8WebNotice.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required]
        public string Nombre { get; set; }
        public ICollection<Noticia> Noticias { get; set; }
    }
}
