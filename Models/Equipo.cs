using System;
using System.Collections.Generic;
using System.Text;

namespace TorneoPOO_CRAMIREZ.Models
{
    public class Equipo
    {
        private string nombre;
        private string ciudad;
        private string color;
        private List<Jugador> jugadores;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public string Color { get => color; set => color = value; }

        public Equipo(string nombre, string ciudad, string color)
        {
            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.Jugadores = new List<Jugador>();
            this.color = color;
        }


        public void AgregarJugador(Jugador objJugador)
        {
            this.Jugadores.Add(objJugador);
            Console.WriteLine($"Jugador {objJugador.Nombre} agregado correctamente");
        }

        public void ListarPlantilla()
        {
            Console.WriteLine($"La lista de jugadores del equipo {this.Nombre} de la ciudad de {this.Ciudad} es:");
            foreach (Jugador objJugador in Jugadores)
            {
                objJugador.Imprimir();
                Console.WriteLine("-----------------------------------");
            }
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre del equipo: {this.Nombre}");
            Console.WriteLine($"Ciudad del equipo: {this.Ciudad}");
            Console.WriteLine($"Color del equipo: {this.Color}");
            ListarPlantilla();
        }
    }
}