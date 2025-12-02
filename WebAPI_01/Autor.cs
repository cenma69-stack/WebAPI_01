using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Modelos
{
    public class Autor
    {
        [Key] public int Id { get; set;}
        public string Nombre_Autor { get; set;} 

        //navegacion
        public List<Libro>? Libros {  get; set;}     
    }
}
