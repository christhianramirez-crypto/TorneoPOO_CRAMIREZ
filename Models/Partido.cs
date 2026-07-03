using System;
using System.Collections.Generic;
using System.Text;

namespace TorneoPOO_CRAMIREZ.Models
{
    public class Partido
    {
        public Equipo Local { get; set; }
        public Equipo Visitante { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }

        public void Programar(Equipo local, Equipo visitante, DateTime fecha, string lugar)
        {
            this.Lugar = lugar;
            this.Local = local;
            this.Visitante = visitante;
            this.Fecha = fecha;
            Console.WriteLine("Partido programado correctamente");
        }

        public void MostrarResumen()
        {
            Console.WriteLine($"Hay un partido programado entre el local {this.Local.Nombre} y el visitante {this.Visitante.Nombre} en el lugar {this.Lugar}");
        }
    }
}
