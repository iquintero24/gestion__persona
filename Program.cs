 // Crear un empleado
        var empleado = Administracion.CrearEmpleado();
        Administracion.MostrarSeparador();
        empleado.MostrarInformacion();

        Console.ReadKey();

        // Crear un cliente
        var cliente = Administracion.crearCliente();
        Administracion.MostrarSeparador();
        cliente.MostrarInformacion();

        Console.ReadKey();