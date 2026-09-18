namespace SistemaAlumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Maria", 123, 6.5, 8.3);
            Alumno alumno2 = new Alumno("Juan", 456, 9.7, 8.5);

            Console.WriteLine($"Nombre: {alumno1.Nombre} - Legajo: {alumno1.Legajo}");
            Console.WriteLine($"Nombre: {alumno2.Nombre} - Legajo: {alumno2.Legajo}");


            alumno1.Nombre = "Ana";
            Console.WriteLine($"Nombre: {alumno1.Nombre} - Legajo: {alumno1.Legajo}");
            Console.WriteLine($"Nombre: {alumno2.Nombre} - Legajo: {alumno2.Legajo}");

            // Alumno alumno3 = new Alumno(); --> da error porque no se puede
            // instanciar un objeto sin pasarle los parámetros que pide 
            // el constructor.
            // "No se ha dado ningun argumento que corresponda al parámetro
            // requerido 'nombre' de 'Alumno.Alumno(string, int, double, double)'"

        }
    }
}
