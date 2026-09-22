namespace SistemaAlumnos
{
    public interface IExportable
    {
        string ExportarLinea();
    }

    // Al agregar ExportarEncabezado() da error ya que 
    // las clases que implementan IExportable deben implementar todos sus métodos.
}