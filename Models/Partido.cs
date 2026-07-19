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
            // Validación 1
            if (local == null || visitante == null)
            {
                throw new ArgumentException("Los equipos no pueden ser nulos.");
            }

            // Validación 2
            if (local.Nombre == visitante.Nombre)
            {
                throw new ArgumentException("El equipo local y el visitante no pueden ser el mismo.");
            }

            // Validación 3
            if (string.IsNullOrWhiteSpace(lugar))
            {
                throw new ArgumentException("El lugar del partido no puede estar vacío.");
            }

            // Validación adicional de la fecha
            if (fecha < DateTime.Today)
            {
                throw new ArgumentException("La fecha del partido no puede ser anterior a la fecha actual.");
            }

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
        public void Imprimir()
        {
            Console.WriteLine($"Local      : {Local.Nombre}");
            Console.WriteLine($"Visitante  : {Visitante.Nombre}");
            Console.WriteLine($"Fecha      : {Fecha:dd/MM/yyyy}");
            Console.WriteLine($"Lugar      : {Lugar}");
        }
    }
}