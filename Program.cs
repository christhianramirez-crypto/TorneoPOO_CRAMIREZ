using TorneoPOO_CRAMIREZ.Generales;
using TorneoPOO_CRAMIREZ.Models;

int opcion = 0;
Jugador objJug1 = new Jugador("Eduardo", 20, 10, "Delantero", "Quito", "1234567890", 50000);
Database.Jugadores.Add(objJug1);
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
    Console.WriteLine("7.- Crear Partidos");
    Console.WriteLine("8.- Salir");
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
            crearPartido();
            break;
        case 8:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción inválida. Por favor, intente nuevamente.");
            break;
    }

} while (opcion != 8);

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

void crearPartido()
{
    Console.Clear();
}

void crearEquipo()
{
    Console.Clear();
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