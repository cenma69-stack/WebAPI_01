using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Modelos
{
    public class Libro
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }

        //FK
        public int GeneroId { get; set; }
        public int AutorId {  get; set; }
        
        //navegacion - relacion
        

    }
}
