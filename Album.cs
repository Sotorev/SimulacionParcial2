using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimulacionParcial
{
    public class Album
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public List<Cancion> Canciones { get; set; }
        public DateTime Publicacion { get; set; }
    }
}