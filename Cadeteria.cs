public class Cadeteria
{

    private string nombre;
    private string telefono;
    private List<Cadete> listadoCadetes;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    internal List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }

    public Cadeteria(string nombre, string telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.listadoCadetes = new List<Cadete>();
    }

    public void CargarDatosCadeteriaCSV(string nombreArchivo)
    {
        var arregloCadeteria = File.ReadAllText(nombreArchivo).Split(",");
        nombre = arregloCadeteria[0];
        telefono = arregloCadeteria[1];
    }

    public void CargarDatosCadetesCSV(string nombreArchivo)
    {
        var arregloLineas = File.ReadAllLines(nombreArchivo);
        foreach (var linea in arregloLineas)
        {
            var arregloCadete = linea.Split(",");
            var cadete = new Cadete(int.Parse(arregloCadete[0]), arregloCadete[1], arregloCadete[2], arregloCadete[3]);
            listadoCadetes.Add(cadete);
        }
    }

    public void AltaPedido()
    {
        Console.WriteLine("Ingrese el número del pedido:");
        int nro = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la observación del pedido:");
        string obs = Console.ReadLine();

        Console.WriteLine("Ingrese el estado del pedido (pendiente, en proceso, entregado):");
        string estado = Console.ReadLine();

        Console.WriteLine("Ingrese los datos del Cliente:");
        Console.Write("\tNombre: ");
        var cliNombre = Console.ReadLine();

        Console.Write("\tDirección: ");
        var cliDireccion = Console.ReadLine();

        Console.Write("\tTeléfono: ");
        var cliTelefono = Console.ReadLine();

        Console.Write("\tIndicaciones dirección: ");
        var cliIndicacionesDireccion = Console.ReadLine();

        Pedido pedidoAux = new Pedido(nro, obs, estado, cliNombre, cliDireccion, cliTelefono, cliIndicacionesDireccion);

        Console.WriteLine($"El Pedido N° {nro} se ha creado Correctamente.");
    }

    public void AsignarPedidoACadete()
    {
        Console.WriteLine("Ingrese el número del pedido a asignar:");
        int nroPedido = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el ID del cadete que recibirá el pedido:");
        int idCadete = int.Parse(Console.ReadLine());

        var cadete = listadoCadetes.Find(c => c.Id == idCadete);
        if (cadete != null)
        {
            var pedido = cadete.ListaPedidos.Find(p => p.Nro == nroPedido);
            if (pedido != null)
            {
                Console.WriteLine("El pedido ya está asignado a este cadete.");
            }
            else
            {
                Console.WriteLine("El pedido vacio.");
            }
        }
        else
        {
            Console.WriteLine("Cadete no encontrado.");
        }
    }

    public void CambiarEstadoPedido()
    {
        Console.WriteLine("Ingrese el número del pedido:");
        int nroPedido = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el nuevo estado del pedido:");
        string nuevoEstado = Console.ReadLine();

        foreach (var cadete in listadoCadetes)
        {
            var pedido = cadete.ListaPedidos.Find(p => p.Nro == nroPedido);
            if (pedido != null)
            {
                pedido.Estado = nuevoEstado;
                Console.WriteLine("Estado del pedido cambiado con éxito.");
                return;
            }
        }

        Console.WriteLine("Pedido no encontrado.");
    }

    public void ReasignarPedidoACadete()
    {
        Console.WriteLine("Ingrese el número del pedido a reasignar:");
        int nroPedido = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el nuevo ID del cadete que recibirá el pedido:");
        int nuevoIdCadete = int.Parse(Console.ReadLine());

        var nuevoCadete = listadoCadetes.Find(c => c.Id == nuevoIdCadete);
        if (nuevoCadete != null)
        {
            foreach (var cadete in listadoCadetes)
            {
                var pedido = cadete.ListaPedidos.Find(p => p.Nro == nroPedido);
                if (pedido != null)
                {
                    cadete.EliminarPedido(nroPedido);
                    nuevoCadete.AgregarPedido(pedido);
                    Console.WriteLine("Pedido reasignado con éxito.");
                    return;
                }
            }
        }
        else
        {
            Console.WriteLine("Nuevo cadete no encontrado.");
        }

        Console.WriteLine("Pedido no encontrado.");
    }





}
