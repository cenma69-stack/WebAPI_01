using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Modelos
{
    public class Genero
    {
        [Key] public int Id { get; set; }
        public string Name_Genero { get; set; }

        //navegacion
        public List<Libro>? Libros { get; set; }
    }
}
