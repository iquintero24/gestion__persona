using models.Cliente;
using models.Empleado;

public static class Administracion
{

    /// <summary>
    /// Crear un nuevo empleado solicitando los datos por consola.
    /// </summary>
    /// <returns></returns>
    public static Empleado CrearEmpleado()
    {
        Console.Write("Ingrese el nombre del empleado: ");
        string nombre = Console.ReadLine() ?? string.Empty;

        Console.Write("Ingrese el apellido del empleado: ");
        string apellido = Console.ReadLine() ?? string.Empty;

        Console.Write("Ingrese la edad del empleado: ");
        int edad;
        while (!int.TryParse(Console.ReadLine(), out edad) || edad <= 0)
        {
            Console.Write("Por favor, ingrese una edad válida: ");
        }

        Console.Write("Ingrese el puesto del empleado: ");
        string puesto = Console.ReadLine() ?? string.Empty;

        Console.Write("Ingrese el salario del empleado: ");
        double salario = double.Parse(Console.ReadLine() ?? "0");

        return new Empleado(nombre, apellido, edad, puesto) { Salario = salario };
    }

    ///<summary>
    /// Crear un nuevo cliente solicitando los datos por consola.
    /// </summary>
    /// <returns></returns>

    public static Cliente crearCliente()
    {
        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine() ?? string.Empty;

        Console.Write("Ingrese el apellido del cliente: ");
        string apellido = Console.ReadLine() ?? string.Empty;

        Console.Write("Ingrese la edad del cliente: ");
        int edad;
        while (!int.TryParse(Console.ReadLine(), out edad) || edad <= 0)
        {
            Console.Write("Por favor, ingrese una edad válida: ");
        }

        Console.Write("Ingrese el email del cliente: ");
        string email = Console.ReadLine() ?? string.Empty;

        Console.Write("Ingrese el teléfono del cliente: ");
        string telefono = Console.ReadLine() ?? string.Empty;

        var cliente = new Cliente(nombre, apellido, edad, email) { telefono = telefono };
        Console.WriteLine($"Cliente {nombre} {apellido} creado con éxito.");
        return cliente;
        
    }

    /// <summary>
    /// Mostrar un título en la consola con un formato específico.
    /// </summary>
    /// <param name="titulo">El título a mostrar</param>
    /// <returns>void</returns>
    public static void MostrarTitulo(string titulo)
    {
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine($"   {titulo.ToUpper()}   ");
        Console.WriteLine("=================================");
    }

    /// <summary>
    /// mostrar pie de página en la consola.
    /// </summary>
    /// <returns>void</returns>
    public static void MostrarPie(string pie)
    {
        Console.WriteLine("=================================");
        Console.WriteLine($"   {pie}   ");
        Console.WriteLine("=================================");
    }

    /// <summary>
    /// mostrar seprador en la consola.
    /// </summary>
    /// <returns>void</returns>
    public static void MostrarSeparador()
    {
        Console.WriteLine("---------------------------------");
    }

}