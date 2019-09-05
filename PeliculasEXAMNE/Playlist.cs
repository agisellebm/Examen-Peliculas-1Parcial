using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasEXAMNE
{
    class Playlist
    {
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public List<Peliculas> playlistpeliculas { get; set; }

        public Playlist()
        {
            Titulo = "No titulo";
            Sinopsis = "No descripcion";
            playlistpeliculas = new List<Peliculas>();
        }

        public Playlist(string titulo, string sinopsis)
        {
            Titulo = titulo;
            Sinopsis = sinopsis;
            playlistpeliculas = new List<Peliculas>();
        }
    }
}
