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

            Console.WriteLine($"Nombre: {alumno1.Nombre} - Legajo: {alumno1.Legajo}");
            Console.WriteLine($"Nombre: {alumno2.Nombre} - Legajo: {alumno2.Legajo}");


            alumno1.Nombre = "Ana Fernandez";
            Console.WriteLine($"Nombre: {alumno1.Nombre} - Legajo: {alumno1.Legajo}");
            Console.WriteLine($"Nombre: {alumno2.Nombre} - Legajo: {alumno2.Legajo}");

            // Alumno alumno3 = new Alumno(); --> da error porque no se puede
            // instanciar un objeto sin pasarle los parámetros que pide 
            // el constructor.
            // "No se ha dado ningun argumento que corresponda al parámetro
            // requerido 'nombre' de 'Alumno.Alumno(string, int, double, double)'"

            Console.WriteLine($"Promedio de {alumno1.Nombre}: {alumno1.Promedio()}");
            Console.WriteLine($"Promedio de {alumno2.Nombre}: {alumno2.Promedio()}");

            Console.WriteLine($"¿{alumno1.Nombre} está aprobado? {alumno1.EstaAprobado()}");
            Console.WriteLine($"¿{alumno2.Nombre} está aprobado? {alumno2.EstaAprobado()}");

            alumno1.SubirNota();
            Console.WriteLine($"Promedio de {alumno1.Nombre} después de subir las notas: {alumno1.Promedio()}");
            alumno2.SubirNota();
            Console.WriteLine($"Promedio de {alumno2.Nombre} después de subir las notas: {alumno2.Promedio()}");


            Console.WriteLine(alumno1);
            Console.WriteLine(alumno2);

            //alumno1.Nota1 = 5.5;
        }
    }
}
