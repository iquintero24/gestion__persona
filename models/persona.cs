namespace models.Persona;

/// <summary>
/// Clase <c>Persona</c> representa a una persona.
/// </summary>
public abstract class Persona
{
    public Guid Id { get; protected set; } = Guid.NewGuid(); // id unico de cada persona
    public string Nombre { get;  protected set; } = string.Empty; // nombre de la persona
    public string Apellido { get; protected set; } = string.Empty; // apellido de la persona
    public int Edad { get; protected set; } // edad de la persona
    public string NumeroDeIdentificacion { get; protected set; } = string.Empty; // numero de identificacion de la persona

    protected Persona(string nombre, string apellido, int edad)
    {
        Id = Guid.NewGuid();
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
    }


    /// <summary>
    /// Mostrar la información de la persona en la consola.
    /// </summary>
    /// <returns>void</returns>

    public abstract void MostrarInformacion();
   
}