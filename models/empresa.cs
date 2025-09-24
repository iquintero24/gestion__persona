namespace models.Empresa;

class Empresa
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public List<Empleado.Empleado> Empleados { get; set; } = new List<Empleado.Empleado>();
    public List<Cliente.Cliente> Clientes { get; set; } = new List<Cliente.Cliente>();


    public Empresa(string nombre, string direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
        Empleados = new List<Empleado.Empleado>();
    }

    /// <summary>
    /// AgregarEmpleado: Este método permitirá agregar un empleado a la lista de empleados de la empresa.
    /// </summary>
    /// <param name="empleado">Empleado a agregar</param>
    /// <returns>void</returns>
    public void AgregarEmpleado(Empleado.Empleado empleado)
    {
        Empleados.Add(empleado);
    }

    /// <summary>
    /// Crear Clientes de la empresa
    /// </summary>
    /// <param name="cliente">Cliente a agregar</param>
    /// <returns>void</returns>
    
    public void AgregarCliente(Cliente.Cliente cliente)
    {
        Clientes.Add(cliente);
    }


    /// <summary>
    /// Eliminar empleado de la lista de empleados de la empresa por nombre y apellido.
    /// </summary>
    /// <param name="nombre">Nombre del empleado a eliminar</param>
    /// <param name="apellido">Apellido del empleado a eliminar</param>
    /// <returns>void</returns>

    public void EliminarEmpleado(string nombre, string apellido)
    {
        var empleadoAEliminar = Empleados.FirstOrDefault(e => e.Nombre == nombre && e.Apellido == apellido);
        if (empleadoAEliminar != null)
        {
            Empleados.Remove(empleadoAEliminar);
            Console.WriteLine($"Empleado {nombre} {apellido} eliminado.");
        }
        else
        {
            Console.WriteLine($"Empleado {nombre} {apellido} no encontrado.");
        }
    }

    /// <summary>
    /// Eliminar cliente de la lista de clientes de la empresa por nombre y apellido.
    /// </summary>
    /// <param name="nombre">Nombre del cliente a eliminar</param>
    /// <param name="apellido">Apellido del cliente a eliminar</param>
    /// <returns>void</returns>
    
    public void EliminarCliente(string nombre, string apellido)
    {
        var clienteAEliminar = Clientes.FirstOrDefault(c => c.Nombre == nombre && c.Apellido == apellido);
        if (clienteAEliminar != null)
        {
            Clientes.Remove(clienteAEliminar);
            Console.WriteLine($"Cliente {nombre} {apellido} eliminado.");
        }
        else
        {
            Console.WriteLine($"Cliente {nombre} {apellido} no encontrado.");
        }
    }

    /// <summary>
    /// Mostrar todos los empleados de la empresa.
    /// </summary>
    /// <returns>void</returns>

    public void MostrarEmpleados()
    {
        Console.WriteLine("--- Empleados de la empresa ---");
        foreach (var empleado in Empleados)
        {
            empleado.MostrarInformacion();
            Console.WriteLine("-----------------------");
        }
    }

    ///<summary>
    /// Mostrar todos los clientes de la empresa.
    /// </summary>
    /// <returns>void</returns> 
    
    public void MostrarClientes()
    {   
        Console.WriteLine("--- Clientes de la empresa ---");
        foreach (var cliente in Clientes)
        {
            cliente.MostrarInformacion();
            Console.WriteLine("-----------------------");
        }
    }

    /// <summary>
    /// Actualizar un empleado de la lista por su numero de identificacion.
    /// </summary>
    /// <param name="numeroDeIdentificacion">Numero de identificacion del empleado a actualizar</param>
    /// <param name="nuevoEmpleado">Nuevo empleado con los datos actualizados</param>
    /// <returns>void</returns>

  

    public Empleado.Empleado? BuscarEmpleadoPorNumeroDeIdentificacion(string numeroDeIdentificacion)
    {
        var Empleado = Empleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
        if (Empleado != null)
        {
            return Empleado;
        }
        else
        {
            Console.WriteLine($"Empleado con ID {numeroDeIdentificacion} no encontrado.");
            return null;
        }
    }

    /// <summary>
    /// Mostrar Empleados por cargo
    /// </summary>
    /// <param name="cargo">Cargo del empleado a buscar</param>
    /// <returns>void</returns>

    public void MostrarEmpleadosPorCargo(string cargo)
    {
        var empleadosPorCargo = Empleados.Where(e => e.Puesto == cargo).ToList();
        if (empleadosPorCargo.Count > 0)
        {
            foreach (var empleado in empleadosPorCargo)
            {
                empleado.MostrarInformacion();
                Console.WriteLine("-----------------------");
            }
        }
        else
        {
            Console.WriteLine($"No se encontraron empleados con el cargo {cargo}.");
        }
    }
}