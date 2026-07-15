using System;
using System.Collections.Generic;
using System.Text;

namespace TorneoPOO_CRAMIREZ.Models
{
    public class Equipo
    {
        private string nombre;
        private string ciudad;
        private List<Jugador> jugadores;
        private string color;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public string Color { get => color; set => color = value; }

        public Equipo(string nombre, string ciudad, string color)
        {
            // Validación 1
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre del equipo no puede estar vacío.");
            }

            // Validación 2
            if (string.IsNullOrWhiteSpace(color))
            {
                throw new ArgumentException("El color del equipo no puede estar vacío.");
            }

            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.Color = color;
            this.Jugadores = new List<Jugador>();
        }

        public void AgregarJugador(Jugador objJugador)
        {
            // Validación 3
            if (objJugador == null)
            {
                Console.WriteLine("No se puede agregar un jugador nulo.");
                return;
            }

            if (Jugadores.Exists(j => j.Nombre == objJugador.Nombre))
            {
                Console.WriteLine("El jugador ya pertenece al equipo.");
                return;
            }

            Jugadores.Add(objJugador);
            Console.WriteLine($"Jugador {objJugador.Nombre} agregado correctamente.");
        }

        public void ListarPlantilla()
        {
            if (Jugadores.Count == 0)
            {
                Console.WriteLine($"El equipo {Nombre} no tiene jugadores registrados.");
                return;
            }

            Console.WriteLine($"La lista de jugadores del equipo {Nombre} de la ciudad de {Ciudad} es:");

            foreach (Jugador objJugador in Jugadores)
            {
                objJugador.Presentar();
            }
        }
    }
}