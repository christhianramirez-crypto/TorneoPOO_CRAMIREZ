using System;
using System.Collections.Generic;
using System.Text;

namespace TorneoPOO_CRAMIREZ.Models
{
    public class Jugador
    {
        //ATRIBUTOS O CARACTERISTICAS
        private string nombre;
        private int edad;
        private int numero;
        private string posicion;
        private string lugarNacimiento;
        private string cedula;
        private decimal sueldo;
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad
        {
            get => edad;
            set
            {
                if (!EsMayorEdad(value))
                {
                    throw new Exception("El jugador debe ser mayor de edad");
                }
                edad = value;
            }

        }
        public int Numero
        {
            get => numero;
            set
            {
                if (!EsNumeroValido(value))
                {
                    throw new Exception("El número de la camiseta no es válido");
                }
                numero = value;
            }
        }
        public string Posicion { get => posicion; set => posicion = value; }
        public string LugarNacimiento { get => lugarNacimiento; set => lugarNacimiento = value; }
        public string Cedula
        {
            get => cedula;
            set
            {
                if (value.Length != 10)
                {
                    throw new Exception("La cédula debe tener 10 dígitos");
                }
                cedula = value;
            }
        }
        public decimal Sueldo
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("El sueldo no puede ser menor o igual a cero");
                }
                sueldo = value;
            }
        }


        //Constructor
        public Jugador(string nombre, int edad, int numero, string posicion, string lugarNacimiento, string cedula, decimal sueldo)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Numero = numero;
            this.Posicion = posicion;
            this.LugarNacimiento = lugarNacimiento;
            this.Cedula = cedula;
            this.Sueldo = sueldo;
        }



        //METODOS, COMPORTAMIENTOS O FUNCIONES
        public void Presentar()
        {
            Console.WriteLine($"Hola soy {this.Nombre} tengo {this.Edad} años y mi número es el {this.Numero}");
        }

        public Boolean EsMayorEdad(int edad)
        {
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean EsNumeroValido(int numero)
        {
            if (numero > 0 && numero < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
