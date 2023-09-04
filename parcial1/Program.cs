internal class Program
{
    private static void Main(string[] args)
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("menu de opciones ");
            Console.WriteLine("1 ejercicio ");
            Console.WriteLine("2 ejercicio ");
            Console.WriteLine("3 salir ");
            Console.WriteLine("digite una opcion");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("CANCIONES MP3");
                    cancionesmp3();
                    break;
                case 2:
                    Console.WriteLine("GESTION DE ALUMNOS");
                    gestionDeAlumno();
                    break;
                case 3:
                    Console.WriteLine("SALIR PRESIONE ENTER  ");
                    break;


            }

        } while (opcion != 3);
    }

    //1.Crear distintos arreglos que almacenen datos de una canción en formato MP3: Artista, Título, Duración (en segundos),
    //Tamaño del fichero (en KB). El programa debe pedir los datos de una canción al usuario,
    //almacenarlos en dichas estructuras (arreglos) y después mostrarlos en pantalla.  
    static void cancionesmp3()
    {


        string[] Artista = new string[2];
        String[] Titulo = new string[2];
        int[] Segundos = new int[0];
        int[] TamañoKG = new int[0];
        int seg = 0;
        int tamaKG = 0;



        for (int i = 0; i < Artista.Length; i++)
        {
            Console.WriteLine("nombre de artista", i + 1);
            Artista[i] = Console.ReadLine();

            for (int j = 0; i < Titulo.Length; j++)
            {
                Console.WriteLine("nombre de la cancion", j + 1);
                Titulo[j] = Console.ReadLine();

                while (int.TryParse(Console.ReadLine(), out seg))
                {
                    Console.WriteLine("ingrese los segundos ");
                    Segundos[seg] = seg;

                    while (int.TryParse(Console.ReadLine(), out tamaKG))
                    {
                        Console.WriteLine("ingrese el tamaño de la cancion ");
                        TamañoKG[tamaKG] = tamaKG;

                    }
                }


            }
        }

        //2.Un centro escolar desea realizar la gestión de sus alumnos el cual desea almacenar los siguientes
        //datos: código, nombre completo, fecha de nacimiento, grado, y el año de registro. 
        //La aplicación debe permitir en cualquier momento.
        //•Agregar un alumno. 
        //mostrar listado de libros 
        //•Buscar libro por código 
        //•editar la información de un libro buscado por código
        //•Donde se tenga que mostrar información debe verse en formato de tabla. 
        static void gestionAlumno()
        {
            int[] codigo = new int[0];
            string[] alumno = new string[5];
            string[] fechasNacimiento = new string[8];
            int[] grado = new int[2];
            int[] añosRegistro = new int[10];
        }
    }
    private static int numAlumnos;

    static void gestionDeAlumno()
    {
        bool estudiante = false;

        while (!estudiante)
        {
            Console.Clear();
            Console.WriteLine("1. Agregar Alumno");
            Console.WriteLine("2. Mostrar Listado de alumnos");
            Console.WriteLine("3. Buscar alumno por Código");
            Console.WriteLine("4. Editar Información de un alumno por Código");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");


            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        AgregarAlumno();
                        break;
                    case 2:
                        MostrarListadoestudiante();
                        break;
                    case 3:
                        BuscarEstudianteCodigo();
                        break;
                    case 4:
                        EditarPorCodigo();
                        break;
                    case 5:
                        estudiante = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione Enter para volver al menú.");

                        Console.ReadLine();
                        break;
                }

            }
        }
    }
    static void AgregarAlumno()
    {
        Console.Clear();
        Console.WriteLine("Agregar Alumno");

        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());
        codigo = codigo;

        Console.Write("Nombre completo: ");
        string nombre = Console.ReadLine();
        nombre = nombre;

        Console.Write("fecha de nacimiento: ");
        string fechaNacimiento = Console.ReadLine();
        fechaNacimiento = fechaNacimiento;


        Console.Write("Grado: ");
        int grado = int.Parse(Console.ReadLine());
        grado = grado;

        Console.Write("Año de registro: ");
        if (int.TryParse(Console.ReadLine(), out int añoRegistro))
        {
            añoRegistro = añoRegistro;
        }
        else
        {
            Console.WriteLine("Año de registro no válido.");
            return;
        }

        numAlumnos++;
        Console.WriteLine("Alumno agregado con éxito. Presione Enter para volver al menú.");
        Console.ReadLine();
        Console.WriteLine("codigo: " + codigo + "nombre: " + nombre + "fecha de nacimiento: " + fechaNacimiento + "grado: " + grado + "año de registro: " + añoRegistro);
    }

    static void MostrarListadoestudiante()
    {
        Console.Clear();
        Console.WriteLine("Listado de alumnos: ");

        if (numAlumnos == 0)
        {
            Console.WriteLine("No hay alumnos registrados.");
        }
        else
        {
            Console.WriteLine("codigo, nombre, grado, años de registro");
            for (int i = 0; i < numAlumnos; i++) ;



        }

        Console.WriteLine("Presione Enter para volver al menú.");
        Console.ReadLine();
    }

    static void BuscarEstudianteCodigo()
    {
        Console.Clear();
        Console.WriteLine("Buscar alumno por Código");
        Console.Write("Ingrese el código de alumno: ");
        string codigoBuscado = Console.ReadLine();



        Console.WriteLine("Presione Enter para volver al menú.");
        Console.ReadLine();
    }

    static void EditarPorCodigo()
    {
        Console.Clear();
        Console.WriteLine("Editar Información de un Alumno por Código");
        Console.Write("Ingrese el código del alumno a editar: ");
        string codigoBuscado = Console.ReadLine();



        Console.ReadKey();
    }




}