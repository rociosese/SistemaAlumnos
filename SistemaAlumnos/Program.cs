namespace SistemaAlumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Maria Perez", 123);
            Alumno alumno2 = new Alumno("Juan Gonzalez", 456);


            if (!alumno1.CargarNotas(6.5, 8.3))
            {
                Console.WriteLine("Las notas del alumno 1 son inválidas");
            }

            if (!alumno2.CargarNotas(9.7, 8.5))
            {
                Console.WriteLine("Las notas del alumno 2 son inválidas");
            }

            List<Alumno> alumnos = new List<Alumno>();

            alumnos.Add(alumno1);
            alumnos.Add(alumno2);

            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno);
            }

            int opcion = 0;

            while (opcion != 6)
            {
                Console.WriteLine("\n--- SISTEMA DE ALUMNOS ---");
                Console.WriteLine("1. Agregar alumno");
                Console.WriteLine("2. Listar alumnos");
                Console.WriteLine("3. Buscar alumno por legajo");
                Console.WriteLine("4. Mostrar promedio general");
                Console.WriteLine("5. Mostrar cantidad de aprobados");
                Console.WriteLine("6. Salir");

                Console.Write("Elegi una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Legajo: ");
                    int legajo = int.Parse(Console.ReadLine());

                    Alumno nuevoAlumno = new Alumno(nombre, legajo);

                    Console.Write("Nota 1: ");
                    double nota1 = double.Parse(Console.ReadLine());

                    Console.Write("Nota 2: ");
                    double nota2 = double.Parse(Console.ReadLine());

                    if (nuevoAlumno.CargarNotas(nota1, nota2))
                    {
                        alumnos.Add(nuevoAlumno);
                        Console.WriteLine("Alumno agregado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Las notas son invalidas.");
                    }
                }

                else if (opcion == 2)
                {
                    foreach (Alumno alumno in alumnos)
                    {
                        Console.WriteLine(alumno);
                    }
                }

                else if (opcion == 3)
                {
                    Console.Write("Ingrese el legajo: ");
                    int legajoBuscado = int.Parse(Console.ReadLine());

                    Alumno alumnoEncontrado = null;

                    foreach (Alumno alumno in alumnos)
                    {
                        if (alumno.Legajo == legajoBuscado)
                        {
                            alumnoEncontrado = alumno;
                        }
                    }

                    if (alumnoEncontrado != null)
                    {
                        Console.WriteLine(alumnoEncontrado);
                    }
                    else
                    {
                        Console.WriteLine("No existe un alumno con ese legajo.");
                    }
                }

                else if (opcion == 4)
                {
                    if (alumnos.Count == 0)
                    {
                        Console.WriteLine("No hay alumnos cargados.");
                    }
                    else
                    {
                        double sumaPromedios = 0;

                        foreach (Alumno alumno in alumnos)
                        {
                            sumaPromedios = sumaPromedios + alumno.Promedio();
                        }

                        double promedioGeneral = sumaPromedios / alumnos.Count;

                        Console.WriteLine($"Promedio general del curso: {promedioGeneral}");
                    }
                }

                else if (opcion == 5)
                {
                    int cantidadAprobados = 0;

                    foreach (Alumno alumno in alumnos)
                    {
                        if (alumno.EstaAprobado())
                        {
                            cantidadAprobados++;
                        }
                    }

                    Console.WriteLine($"Cantidad de alumnos aprobados: {cantidadAprobados}");
                }

                else if (opcion == 6)
                {
                    Console.WriteLine("Saliendo del programa...");
                }

                else
                {
                    Console.WriteLine("Opcion invalida.");
                }
            }
        }
    }
}


