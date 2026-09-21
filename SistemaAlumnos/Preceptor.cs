namespace SistemaAlumnos
{
    public class Preceptor : Persona
    {
        public string Curso { get; set; }

        public Preceptor(string nombre, int documento, string curso)
            : base(nombre, documento)
        {
            Curso = curso;
        }

        public override string Presentarse()
        {
            return $"Hola, soy {Nombre}, preceptor del curso {Curso}.";
        }
    }
}