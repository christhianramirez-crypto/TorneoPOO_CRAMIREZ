using TorneoPOO_CRAMIREZ.Models;

Jugador objJugador1 = new Jugador();

objJugador1.Nombre = "Piero Hincapié";
objJugador1.Numero = 3;
objJugador1.Posicion = "Defensa";
objJugador1.Edad = 24;

Jugador objJugador2 = new Jugador();

objJugador2.Nombre = "Enner Valencia";
objJugador2.Numero = 13;
objJugador2.Posicion = "Delantero";
objJugador2.Edad = 39;

Equipo objEquipo1= new Equipo();

objEquipo1.Nombre = "IDV";
objEquipo1.Ciudad = "Quito";
objEquipo1.Jugadores = new List<Jugador>();

objEquipo1.AgregarJugador(objJugador1);
objEquipo1.AgregarJugador(objJugador2);



objEquipo1.ListarPlantilla();

Jugador objJugador3 = new Jugador();

objJugador3.Nombre = "Gabriel Cortes";
objJugador3.Numero = 8;
objJugador3.Posicion = "Medio Campo";
objJugador3.Edad = 36;


Jugador objJugador4 = new Jugador();

objJugador4.Nombre = "Damian Diaz";
objJugador4.Numero = 10;
objJugador4.Posicion = "Media Punta";
objJugador4.Edad = 40;


Equipo objEquipo2 = new Equipo();

objEquipo2.Nombre = "Barcelona";
objEquipo2.Ciudad = "Guayaquil";
objEquipo2.Jugadores = new List<Jugador>();

objEquipo2.AgregarJugador(objJugador3);
objEquipo2.AgregarJugador(objJugador4);



objEquipo2.ListarPlantilla();

Partido objPartido1 = new Partido();
objPartido1.Programar(objEquipo1, objEquipo2, DateTime.Now, "Quito");
objPartido1.MostrarResumen();