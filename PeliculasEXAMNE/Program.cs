using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasEXAMNE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlist> playlist = new List<Playlist>();
            Playlist playlist1 = new Playlist("1 Fantasia", "no realidad");
            Playlist playlist2 = new Playlist("2 Drama", "bellas historias");

            playlist.Add(playlist1);
            playlist.Add(playlist2);

            playlist1.playlistpeliculas.Add(new Peliculas
            ("Shrek", "Aileen", "Fantasia", "Estados Unidos", "Shrek un ogro incomprendido", 2001, 10, 9));
            playlist1.playlistpeliculas.Add(new Peliculas
            ("El regreso del hombre lobo", "Aileen Balderrama2", "Terror", "Mexico", "Un lobo que regresa", 2016, 3, 4));
            playlist1.playlistpeliculas.Add(new Peliculas
            ("Arriba las damas alcoholisadas", "Aileen Balderrama3", "Comedia", "Francia", "Damas en una fiesta", 2018, 10, 10));
            playlist1.playlistpeliculas.Add(new Peliculas
            ("Chupitos", "Aileen Balderrama4", "Drama", "Caribe", "La chupitos el regreso", 1972, 1, 4));
            playlist1.playlistpeliculas.Add(new Peliculas
            ("Fatima el demonio", "Aileen Balderrama5", "Horror", "Brasil", "Fatima un demonio indomable", 1988, 10, 4));
            playlist1.playlistpeliculas.Add(new Peliculas
            ("El laberinto de alexia", "Aileen Balderrama6", "Suspenso", "Alemania", "Alexia una fauna con un laberinto", 2000, 10, 7));
            playlist1.playlistpeliculas.Add(new Peliculas
            ("Shrek tercero", "Aileen Balderrama7", "Fantasia1", "Noruega", "Shrek con hijos", 2009, 5, 8));


            playlist2.playlistpeliculas.Add(new Peliculas
            ("Shrek1", "Aileen9", "Fantasia3", "Estados Unidos1", "Shrek un ogro incomprendido", 2001, 10, 9));
            playlist2.playlistpeliculas.Add(new Peliculas
            ("El regreso del hombre lobo1", "Aileen Balderrama10", "Terror1", "Mexico1", "Un lobo que regresa", 2016, 3, 4));
            playlist2.playlistpeliculas.Add(new Peliculas
            ("Arriba las damas alcoholisadas1", "Aileen Balderrama11", "Comedia1", "Francia1", "Damas en una fiesta", 2018, 10, 10));
            playlist2.playlistpeliculas.Add(new Peliculas
            ("Chupitos1", "Aileen Balderrama12", "Drama1", "Caribe1", "La chupitos el regreso", 1972, 1, 4));
            playlist2.playlistpeliculas.Add(new Peliculas
            ("Fatima el demonio1", "Aileen Balderrama13", "Horror1", "Brasil1", "Fatima un demonio indomable", 1988, 10, 4));
            playlist2.playlistpeliculas.Add(new Peliculas
            ("El laberinto de alexia1", "Aileen Balderrama14", "Suspenso1", "Alemania1", "Alexia una fauna con un laberinto", 2000, 10, 7));
            playlist2.playlistpeliculas.Add(new Peliculas
            ("Shrek tercero1", "Aileen Balderrama15", "Fantasia4", "Noruega1", "Shrek con hijos", 2009, 5, 8));





            foreach (Playlist play in playlist)
            {
                Console.WriteLine("*" + play.Titulo + "-" + play.Sinopsis);
                foreach (Peliculas peli in play.playlistpeliculas)
                {
                    Console.WriteLine("1) *" + peli.Titulo);

                    try
                    {
                        peli.AñoDeEstreno = peli.AñoDeEstreno;
                        Console.WriteLine("año:" + peli.AñoDeEstreno);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("el año no es correcto");
                    }

                }
            }


            Console.Read();

        }
    }
}
