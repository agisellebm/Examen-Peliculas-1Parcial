using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasEXAMNE
{
    class Peliculas
    {
        public string Titulo { get; set; }
        private int _añodeestreno;
        public int AñoDeEstreno
        {
            get
            {
                return _añodeestreno;
            }
            set
            {
                if(value > 1800 && value < 2019)
                {
                    _añodeestreno = value;
                }
                else
                {
                    throw new Exception("no esta el año correcto");
                }
            }
        }
        public string Director { get; set; }

        public string PaisOrigen { get; set; }
        public string Genero { get; set; }


        private int _duracion;


        public int Duracion
        {
            get
            {
                return _duracion;
            }
            set
            {
                if (value > 0)
                {
                    _duracion = value;
                }
                else
                {
                    throw new Exception("no duracion");
                }
            }
        }

        private double _rating;
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _rating = value;
                }
                else
                {
                    throw new Exception("no rating de imdb");
                }
            }
        }

        public string Sinopsis { get; set; }




        public Peliculas()
        {
            Titulo = "no titulo";
            AñoDeEstreno = 0;
            Director = "no director";
            Genero = "no genero";
            PaisOrigen = "no pais de origen";
            Duracion = 0;
            Rating = 0;
            Sinopsis = "no sinopsis";

        }

        public Peliculas(string titulo, string director, string genero, 
            string paisorigen, string sinopsis, int añodeestreno, int duracion, 
            double rating)
        { 
            Titulo = titulo;
            Genero = genero;
            Director = director;
            Sinopsis = sinopsis;
            PaisOrigen = paisorigen;
            Duracion = duracion;
            AñoDeEstreno = añodeestreno;
            Rating = rating;

        }
    }
}