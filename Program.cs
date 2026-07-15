using TorneoPOO_CRAMIREZ.Models;

Jugador objJugador1 = new Jugador("Piero Hincapié", 22, 3, "Defensa Central","Esmeraldas","0910655467",45000);

Jugador objJugador2 = new Jugador("Enner Valencia",38, 13, "Delantero","Guayaquil","0999999999",30000);

Equipo objEquipo1= new Equipo("Emelec","Guayaquil","Azul");

objEquipo1.AgregarJugador(objJugador1);
objEquipo1.AgregarJugador(objJugador2);


objEquipo1.ListarPlantilla();

Jugador objJugador3 = new Jugador("Moiséc Caicedo", 23, 23, "Volante de Marca", "Esmeraldas", "0910655467", 80000);


Jugador objJugador4 = new Jugador("Neiser Reascos", 45, 18, "Lateral Izquierdo", "Esmeraldas", "0910655467", 15000);

Equipo objEquipo2 = new Equipo("Barcelona","Guayaquil","Amarillo");

objEquipo2.AgregarJugador(objJugador3);
objEquipo2.AgregarJugador(objJugador4);



objEquipo2.ListarPlantilla();

Partido objPartido1= new Partido(objEquipo1, objEquipo2, DateTime.Now, "Guayaquil");
objPartido1.MostrarResumen();