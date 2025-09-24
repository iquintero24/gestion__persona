
namespace models.Empleado;

/// <summary>
/// Clase <c>Empleado</c> representa a un empleado.
/// </summary>
public class Empleado: Persona.Persona
{

    public string Puesto { get; set; } = string.Empty; // puesto del empleado
    public double Salario { get; set; } // salario del empleado

    public Empleado(string nombre, string apellido, int edad, string cargo)
        : base(nombre, apellido, edad)
    {
        Puesto = cargo;
    }

    /// <summary>
    ///  Calcular la bonificación del empleado, que es el 10% de su salario.
    /// </summary>
    /// <returns>La bonificacion del trabajador.</returns>
    private string CalcularBonificacion()
    {
        double bonificacion = Salario * 0.10;
        return $"La bonificación del empleado {Nombre} {Apellido} es de: {bonificacion}";
    }

    /// <summary>
    /// Mostrar la información del empleado en la consola.
    /// </summary>
    /// <returns>void</returns>
   public override void MostrarInformacion()
    {
        
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Apellido: {Apellido}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Número de Identificación: {NumeroDeIdentificacion}");
        Console.WriteLine($"Puesto: {Puesto}");
        Console.WriteLine($"Salario: {Salario}");
        Console.WriteLine(CalcularBonificacion());
    }
}
