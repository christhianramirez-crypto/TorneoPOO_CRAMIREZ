using System;
using System.Collections.Generic;
using System.Text;

namespace TorneoPOO_CRAMIREZ.Models
{
    public class Partido
    {
        private int id; //IDENTIFICADOR UNICO DEL PARTIDO OJOOOOOOOOOOOOO
        private Equipo local;
        private Equipo visitante;
        private DateTime fecha;
        private string lugar;

        public Equipo Local { get => local; set => local = value; }
        public Equipo Visitante { get => visitante; set => visitante = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Lugar { get => lugar; set => lugar = value; }

        public Partido(Equipo local, Equipo visitante, DateTime fecha, string lugar)
        {
            this.Local = local;
            this.Visitante = visitante;
            this.Fecha = fecha;
            this.Lugar = lugar;
        }



        public void MostrarResumen()
        {
            Console.WriteLine($"Hay un partido programado entre el local {this.Local.Nombre} y el visitante {this.Visitante.Nombre} en el lugar {this.Lugar}");
        }

        //AÑADIR IMPRIMIR PARTIDO

    }
}