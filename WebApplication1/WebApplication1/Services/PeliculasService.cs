using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class PeliculasService
    {
        public Pelicula ObtenerPelicula(){
            return new Pelicula()
            {
                Titulo = "Interestelar",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2013,11,26)
            };
        }
        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Interestelar",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2013, 11, 26)
            };
            var pelicula2 = new Pelicula()
            {
                Titulo = "The NoteBook",
                Duracion = 117,
                Pais = "USA",
                Publicacion = new DateTime(2013, 11, 26)
            };

            return new List<Pelicula> { pelicula1, pelicula2 };
        }
    }
}