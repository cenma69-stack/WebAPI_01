using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Libreria.Modelos;
//using WebAPI_01;

    public class LibreriaAPIContext : DbContext
    {
        public LibreriaAPIContext (DbContextOptions<LibreriaAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Libreria.Modelos.Autor> Autores { get; set; } = default!;

        public DbSet<Libreria.Modelos.Genero> Genero { get; set; } = default!;

        public DbSet<Libreria.Modelos.Libro> Libros { get; set; } = default!;
    }
