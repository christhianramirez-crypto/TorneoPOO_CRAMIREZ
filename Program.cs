using TorneoPOO_CRAMIREZ.Generales;
using TorneoPOO_CRAMIREZ.Models;

int opcion = 0;
Jugador objJug1 = new Jugador("Christhian", 44, 18, "Volante", "Milagro", "0919509448", 80000);
Jugador objJug2 = new Jugador("David", 34, 14, "Defensa", "Cuenca", "0123456789", 60000);
Jugador objJug3 = new Jugador("Emiliano", 26, 23, "Arquero", "Daule", "1234567890", 90000);
Database.Jugadores.Add(objJug1);
Database.Jugadores.Add(objJug2);
Database.Jugadores.Add(objJug3);
do
{
    Console.Clear();
    Console.WriteLine("****************Bienvenido al Torneo de Futbol - ISTLC 2026****************");
    Console.WriteLine("Menú de Opciones:");
    Console.WriteLine("1.- Crear Jugadores");
    Console.WriteLine("2.- Listar Jugadores");
    Console.WriteLine("3.- Buscar Jugador");
    Console.WriteLine("4.- Actualizar Jugador");
    Console.WriteLine("5.- Eliminar Jugador");
    Console.WriteLine("6.- Crear Equipos");
    Console.WriteLine("7.- Listar Equipos");
    Console.WriteLine("8.- Buscar Equipo");
    Console.WriteLine("9.- Actualizar Equipos");//********************
    Console.WriteLine("10.- Eliminar Equipos");//********************
    Console.WriteLine("11.- Crear Partidos");//********************
    Console.WriteLine("12.- Listar Partidos");//********************
    Console.WriteLine("13.- Buscar Partido");//********************
    Console.WriteLine("14.- Actualizar Partido");//********************
    Console.WriteLine("15.- Eliminar Partido");//********************
    Console.WriteLine("16.- Salir");
    Console.WriteLine("");
    Console.Write("Ingrese una opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());


    switch (opcion)
    {
        case 1:
            crearJugador();
            break;
        case 2:
            listarJugadores();
            break;
        case 3:
            BuscarJugador();
            break;
        case 4:
            ActualizarJugador();
            break;
        case 5:
            EliminarJugador();
            break;
        case 6:
            crearEquipo();
            break;
        case 7:
            listarEquipos();
            break;
        case 8:
            buscarEquipo();
            break;
        case 9:
            actualizarEquipo();
            break;
        case 10:
            eliminarEquipo();
            break;
        case 11:
            crearPartido();
            break;
        case 12:
            listarPartidos();
            break;
        case 13:
            buscarPartido();
            break;
        case 14:
            actualizarPartido();
            break;
        case 15:
            eliminarPartido();
            break;
        case 16:
            Console.WriteLine("Saliendo del programa...");
            break;
    }

} while (opcion != 16);

void eliminarPartido()
{
    Console.Clear();
    Console.WriteLine("**********Eliminar Partido**********");

    Console.Write("Nombre del equipo local: ");
    string nombre = Console.ReadLine();

    Partido partido = Database.Partidos.Find(p => p.Local.Nombre.ToUpper() == nombre.ToUpper());

    if (partido != null)
    {
        partido.Imprimir();

        Console.Write("¿Desea eliminar este partido? S/N: ");

        if (Console.ReadLine().ToUpper() == "S")
        {
            Database.Partidos.Remove(partido);
            Console.WriteLine("Partido eliminado correctamente.");
        }
    }
    else
    {
        Console.WriteLine("Partido no encontrado.");
    }

    Console.ReadLine();
}
void actualizarPartido()
{
    Console.Clear();
    Console.WriteLine("**********Actualizar Partido**********");

    Console.Write("Nombre del equipo local: ");
    string nombre = Console.ReadLine();

    Partido partido = Database.Partidos.Find(p => p.Local.Nombre.ToUpper() == nombre.ToUpper());

    if (partido != null)
    {
        Console.Write("Nuevo lugar: ");
        partido.Lugar = Console.ReadLine();

        Console.Write("Nueva fecha: ");
        partido.Fecha = Convert.ToDateTime(Console.ReadLine());

        Console.WriteLine("Partido actualizado.");
    }
    else
    {
        Console.WriteLine("Partido no encontrado.");
    }

    Console.ReadLine();
}
void buscarPartido()
{
    Console.Clear();
    Console.WriteLine("**********Buscar Partido**********");

    Console.Write("Nombre del equipo local: ");
    string nombre = Console.ReadLine();

    Partido partido = Database.Partidos.Find(p => p.Local.Nombre.ToUpper() == nombre.ToUpper());

    if (partido != null)
    {
        partido.Imprimir();
    }
    else
    {
        Console.WriteLine("Partido no encontrado.");
    }

    Console.ReadLine();
}
void listarPartidos()
{
    Console.Clear();
    Console.WriteLine("**********Lista de Partidos**********");

    foreach (Partido partido in Database.Partidos)
    {
        partido.Imprimir();
        Console.WriteLine("--------------------------------");
    }

    Console.ReadLine();
}
void crearPartido()
{
    Console.Clear();
    Console.WriteLine("**********Crear Partido**********");

    Console.Write("Nombre del equipo local: ");
    string local = Console.ReadLine();

    Equipo objLocal = Database.Equipos.Find(e => e.Nombre.ToUpper() == local.ToUpper());

    Console.Write("Nombre del equipo visitante: ");
    string visitante = Console.ReadLine();

    Equipo objVisitante = Database.Equipos.Find(e => e.Nombre.ToUpper() == visitante.ToUpper());

    if (objLocal != null && objVisitante != null)
    {
        Console.Write("Lugar: ");
        string lugar = Console.ReadLine();

        Console.Write("Fecha (dd/mm/yyyy): ");
        DateTime fecha = Convert.ToDateTime(Console.ReadLine());

        Partido partido = new Partido(objLocal, objVisitante, fecha, lugar);

        Database.Partidos.Add(partido);

        Console.WriteLine("Partido creado correctamente.");
    }
    else
    {
        Console.WriteLine("Uno de los equipos no existe.");
    }

    Console.ReadLine();
}

void eliminarEquipo()
{
    Console.Clear();
    Console.WriteLine("**********Eliminar Equipo**********");
    Console.Write("Ingrese el nombre del equipo: ");
    string nombre = Console.ReadLine();

    Equipo objEquipo = Database.Equipos.Find(e => e.Nombre.ToUpper() == nombre.ToUpper());

    if (objEquipo != null)
    {
        objEquipo.Imprimir();

        Console.Write("¿Desea eliminar este equipo? S/N: ");

        if (Console.ReadLine().ToUpper() == "S")
        {
            Database.Equipos.Remove(objEquipo);
            Console.WriteLine("Equipo eliminado.");
        }
    }
    else
    {
        Console.WriteLine("Equipo no encontrado.");
    }

    Console.ReadLine();
}

void actualizarEquipo()
{
    Console.Clear();
    Console.WriteLine("**********Actualizar Equipo**********");
    Console.Write("Ingrese el nombre del equipo: ");
    string nombre = Console.ReadLine();

    Equipo objEquipo = Database.Equipos.Find(e => e.Nombre.ToUpper() == nombre.ToUpper());

    if (objEquipo != null)
    {
        objEquipo.Imprimir();

        Console.Write("Nuevo nombre: ");
        objEquipo.Nombre = Console.ReadLine();

        Console.Write("Nueva ciudad: ");
        objEquipo.Ciudad = Console.ReadLine();

        Console.Write("Nuevo color: ");
        objEquipo.Color = Console.ReadLine();

        Console.WriteLine("Equipo actualizado correctamente.");
    }
    else
    {
        Console.WriteLine("Equipo no encontrado.");
    }

    Console.ReadLine();
}

void buscarEquipo()
{
    Console.Clear();
    Console.WriteLine("**********Buscar Equipo**********");
    Console.WriteLine("Ingrese el nombre del equipo a buscar: ");
    string nombre_ingresado = Console.ReadLine();
    Equipo objEquipo = Database.Equipos.Find(j => j.Nombre.ToUpper() == nombre_ingresado.ToUpper());
    if (objEquipo != null)
    {
        Console.WriteLine("Equipo encontrado:");
        Console.WriteLine("-----------------------------------");
        objEquipo.Imprimir();
    }
    else
    {
        Console.WriteLine("Equipo no encontrado.");
    }
    Console.ReadLine();
}

void listarEquipos()
{
    Console.Clear();
    Console.WriteLine("**********Equipos Creados**********");
    foreach (Equipo equipo in Database.Equipos)
    {
        equipo.Imprimir();
        Console.WriteLine("-----------------------------------");
    }
    Console.ReadLine();
}

void ActualizarEquipo()
{

    Console.Clear();
    Console.WriteLine("**********Actualizar Equipo**********");
    Console.WriteLine("Ingrese la cédula del equipo a actualizar: ");
    string nombre_ingresado = Console.ReadLine();
    Equipo objEquipo = Database.Equipos.Find(j => j.Nombre.ToUpper() == nombre_ingresado.ToUpper());
    if (objEquipo != null)
    {



    }
    else
    {
        Console.WriteLine("Equpo no encontrado.");
    }
    Console.ReadLine();
}

void EliminarJugador()
{
    Console.Clear();
    Console.WriteLine("**********Elimar Jugador**********");
    Console.WriteLine("Ingrese la cédula del jugador a eliminar: ");
    string cedulaIngresada = Console.ReadLine();
    Jugador objJugador = Database.Jugadores.Find(j => j.Cedula == cedulaIngresada);
    if (objJugador != null)
    {
        Console.WriteLine("-----------------------------------");
        objJugador.Imprimir();
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"¿Está seguro de que desea eliminar al jugador {objJugador.Nombre} ? S/N:");
        if (Console.ReadLine().ToUpper() == "S")
        {
            Database.Jugadores.Remove(objJugador);
            Console.WriteLine("Jugador eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("Operación cancelada.");
        }
    }
    else
    {
        Console.WriteLine("Jugador no encontrado.");
    }
    Console.ReadLine();
}

void ActualizarJugador()
{
    Console.Clear();
    Console.WriteLine("**********Actualizar Jugador**********");
    Console.WriteLine("Ingrese la cédula del jugador a actualizar: ");
    string cedulaIngresada = Console.ReadLine();
    Jugador objJugador = Database.Jugadores.Find(j => j.Cedula == cedulaIngresada);
    if (objJugador != null)
    {
        Console.WriteLine("Jugador encontrado:");
        Console.WriteLine("-----------------------------------");
        objJugador.Imprimir();
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Ingrese el nuevo nombre del jugador: ");
        objJugador.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la nueva edad del jugador: ");
        objJugador.Edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el nuevo número del jugador: ");
        objJugador.Numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la nueva posición del jugador: ");
        objJugador.Posicion = Console.ReadLine();
        Console.WriteLine("Ingrese el nuevo lugar de nacimiento del jugador: ");
        objJugador.LugarNacimiento = Console.ReadLine();
        Console.WriteLine("Ingrese el nuevo sueldo del jugador: ");
        objJugador.Sueldo = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Jugador actualizado exitosamente.");
    }
    else
    {
        Console.WriteLine("Jugador no encontrado.");
    }
    Console.ReadLine();
}

void BuscarJugador()
{
    Console.Clear();
    Console.WriteLine("**********Buscar Jugador**********");
    Console.WriteLine("Ingrese la cédula del jugador a buscar: ");
    string cedulaIngresada = Console.ReadLine();
    Jugador objJugador = Database.Jugadores.Find(j => j.Cedula == cedulaIngresada);
    if (objJugador != null)
    {
        Console.WriteLine("Jugador encontrado:");
        Console.WriteLine("-----------------------------------");
        objJugador.Imprimir();
    }
    else
    {
        Console.WriteLine("Jugador no encontrado.");
    }
    Console.ReadLine();
}

void listarJugadores()
{
    Console.Clear();
    Console.WriteLine("**********Jugadores Creados**********");
    foreach (Jugador jugador in Database.Jugadores)
    {
        jugador.Imprimir();
        Console.WriteLine("-----------------------------------");
    }
    Console.ReadLine();
}

void CrearPartido()
{
    Console.Clear();
}

void crearEquipo()
{
    Console.Clear();
    Console.WriteLine("**********Crear Equipo**********");
    Console.WriteLine("Ingrese el nombre del equipo: ");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la ciudad del equipo: ");
    string ciudad = Console.ReadLine();
    Console.WriteLine("Ingrese el color del equipo: ");
    string color = Console.ReadLine();

    Equipo objEquipo = new Equipo(nombre, ciudad, color);
    Console.WriteLine("Equipo creado exitosamente.");
    string respuesta = "";
    do
    {
        Console.WriteLine("¿Desea Ingresar Jugadores? S/N");
        respuesta = Console.ReadLine();
        if (respuesta.ToUpper() == "S")
        {
            Console.WriteLine("Ingrese la cédula del jugador a fichar");
            string cedulaIngresada = Console.ReadLine();
            Jugador objJugador = Database.Jugadores.Find(x => x.Cedula == cedulaIngresada);
            if (objJugador != null)
            {
                objEquipo.AgregarJugador(objJugador);
                objJugador.Fichar(objEquipo);
            }
            else
            {
                Console.WriteLine("Jugador no encontrado.");
            }
        }

    } while (respuesta == "S");
    Database.Equipos.Add(objEquipo);
    Console.ReadLine();

}

void crearJugador()
{
    Console.Clear();
    Console.WriteLine("**********Crear Jugador**********");
    Console.WriteLine("Ingrese el nombre del jugador: ");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la edad del jugador: ");
    int edad = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el número del jugador: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese la posición del jugador: ");
    string posicion = Console.ReadLine();
    Console.WriteLine("Ingrese el lugar de nacimiento del jugador: ");
    string lugarNacimiento = Console.ReadLine();
    Console.WriteLine("Ingrese la cédula del jugador: ");
    string cedula = Console.ReadLine();
    Console.WriteLine("Ingrese el sueldo del jugador: ");
    decimal sueldo = Convert.ToDecimal(Console.ReadLine());

    Jugador objJugador = new Jugador(nombre, edad, numero, posicion, lugarNacimiento, cedula, sueldo);
    Database.Jugadores.Add(objJugador);
    Console.WriteLine("Jugador creado exitosamente.");
    Console.ReadLine();
}


//Jugador objJugador1 = new Jugador("Piero Hincapié", 22, 3, "Defensa Central","Esmeraldas","0910655467",45000);

//Jugador objJugador2 = new Jugador("Enner Valencia",38, 13, "Delantero","Guayaquil","0999999999",30000);

//Equipo objEquipo1= new Equipo("Emelec","Guayaquil","Azul");

//objEquipo1.AgregarJugador(objJugador1);
//objEquipo1.AgregarJugador(objJugador2);


//objEquipo1.ListarPlantilla();

//Jugador objJugador3 = new Jugador("Moiséc Caicedo", 23, 23, "Volante de Marca", "Esmeraldas", "0910655467", 80000);


//Jugador objJugador4 = new Jugador("Neiser Reascos", 45, 18, "Lateral Izquierdo", "Esmeraldas", "0910655467", 15000);

//Equipo objEquipo2 = new Equipo("Barcelona","Guayaquil","Amarillo");

//objEquipo2.AgregarJugador(objJugador3);
//objEquipo2.AgregarJugador(objJugador4);



//objEquipo2.ListarPlantilla();

//Partido objPartido1= new Partido(objEquipo1, objEquipo2, DateTime.Now, "Guayaquil");
//objPartido1.MostrarResumen();