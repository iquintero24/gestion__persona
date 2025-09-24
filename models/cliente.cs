namespace models.Cliente;

/// <summary>
/// Clase <c>Cliente</c> representa a un cliente.
/// </summary>

public class Cliente : Persona.Persona
{
    public string Email { get; set; } = string.Empty; // email del cliente
    public string telefono { get; set; } = string.Empty; // telefono del cliente

    public Cliente(string nombre, string apellido, int edad, string email)
        : base(nombre, apellido, edad)
    {
        Email = email;
    }


    /// <summary>
    /// Mostrar la información del cliente en la consola.
    /// </summary>
    /// <returns>void</returns>


    public override void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Apellido: {Apellido}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Número de Identificación: {NumeroDeIdentificacion}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Teléfono: {telefono}");
    }

}
