﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Pelicula
    {
        private String s_idPelicula;
        private String s_Titulo;
        private String s_Generos;
        private String s_Clasificacion;
        private DateTime dt_FecEstreno;
        private String s_Director;
        private String s_Sinopsis;
        private String s_ImagenURL;
        private TimeSpan ts_Duracion;
        private String s_TrailerURL;
        private bool b_Estado;

        public Pelicula()
        {

        }

        public String idPelicula
        {
            set { s_idPelicula = value; }
            get { return s_idPelicula; }
        }

        public String Titulo
        {
            set { s_Titulo = value; }
            get { return s_Titulo; }
        }
        public String Generos
        {
            set { s_Generos = value; }
            get { return s_Generos; }
        }
        public String Clasificacion
        {
            set { s_Clasificacion = value; }
            get { return s_Clasificacion; }
        }
        public DateTime FecEstreno
        {
            set { dt_FecEstreno = value; }
            get { return dt_FecEstreno; }
        }
        public String Director
        {
            set { s_Director = value; }
            get { return s_Director; }
        }
        public String Sinopsis
        {
            set { s_Sinopsis = value; }
            get { return s_Sinopsis; }
        }
        public String ImagenURL
        {
            set { s_ImagenURL = value; }
            get { return s_ImagenURL; }
        }
        public TimeSpan Duracion
        {
            set { ts_Duracion = value; }
            get { return ts_Duracion; }
        }
        public String TrailerURL
        {
            set { s_TrailerURL = value; }
            get { return s_TrailerURL; }
        }
        public bool Estado
        {
            set { b_Estado = value; }
            get { return b_Estado; }
        }
    }
}
