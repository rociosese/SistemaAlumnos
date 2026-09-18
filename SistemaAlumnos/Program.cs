namespace SistemaAlumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();

            alumno1.Nombre = "María";
            alumno1.Legajo = 123;
            alumno1.Nota1 = 6.5;
            alumno1.Nota2 = 8.3;

            alumno2.Nombre = "Juan";
            alumno2.Legajo = 456;
            alumno2.Nota1 = 9.7;
            alumno2.Nota2 = 8.5;

            Console.WriteLine($"Nombre: {alumno1.Nombre} - Legajo: {alumno1.Legajo}");
            Console.WriteLine($"Nombre: {alumno2.Nombre} - Legajo: {alumno2.Legajo}");


            alumno1.Nombre = "Ana";
            Console.WriteLine($"Nombre: {alumno1.Nombre} - Legajo: {alumno1.Legajo}");
            Console.WriteLine($"Nombre: {alumno2.Nombre} - Legajo: {alumno2.Legajo}");
        }
    }
}
