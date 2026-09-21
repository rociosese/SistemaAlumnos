namespace SistemaAlumnos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Documento { get; set; }

        public Persona(string nombre, int documento)
        {
            Nombre = nombre;
            Documento = documento;
        }

        public virtual string Presentarse()
        // Al borrar "virtual" aparece el error CS0506:
        // las clases hijas no pueden sobrescribir Presentarse() usando override.
        {
            return $"Hola, soy {Nombre}.";
        }
    }
}