namespace EspacioCadeteria;

public class Cadeteria
{
    private string nombre;
    private string telefono;
    private List<Cadete> listadoCadetes;

    private List<Pedidos> listadoPedidos;

    public Cadeteria()
    {
    }

    public Cadeteria(string nombre, string telefono)
    {
        this.Nombre = nombre;
        this.Telefono = telefono;
        this.ListadoCadetes1 = new List<Cadete>();
        this.ListadoPedidos = new List<Pedidos>();
    }

    public string Nombre
    {
        get => nombre;
        private set => nombre = value;
    }
    public string Telefono
    {
        get => telefono;
        private set => telefono = value;
    }
    
    public List<Pedidos> ListadoPedidos { get => listadoPedidos; set => listadoPedidos = value; }
    public List<Cadete> ListadoCadetes1 { get => listadoCadetes; set => listadoCadetes = value; }

    public int JornalACobrar(int idCadete)
    {
        Cadete cadeteSeleccionado = ListadoCadetes1.FirstOrDefault(c => c.Id == idCadete);

        if (cadeteSeleccionado == null)
        {
            Console.WriteLine("Cadete no encontrado.");
            return 0;
        }

        List<Pedidos> pedidosDelCadete = new List<Pedidos>();

        // Recorrer cada pedido en la lista de pedidos de la cadetería
        foreach (Pedidos pedido in ListadoPedidos)
        {
            // Comprobar si el pedido tiene un cadete asignado
            if (pedido.Cadete != null)
            {
                // Verificar si el ID del cadete del pedido coincide con el ID proporcionado
                if (pedido.Cadete.Id == idCadete)
                {
                    // Si coincide, agregar el pedido a la lista de pedidos del cadete
                    pedidosDelCadete.Add(pedido);
                }
            }
        }

        return pedidosDelCadete.Count * 500;
    }

    public void AsignarCadeteAPedido(int idCadete, int idPedido)
    {
        // Buscar el cadete por su ID
        Cadete cadeteSeleccionado = ListadoCadetes1.FirstOrDefault(c => c.Id == idCadete);
        if (cadeteSeleccionado == null)
        {
            Console.WriteLine("Cadete no encontrado.");
            return;
        }

        // Buscar el pedido por su número
        Pedidos pedidoSeleccionado = ListadoPedidos.FirstOrDefault(p => p.Nro == idPedido);
        if (pedidoSeleccionado == null)
        {
            Console.WriteLine("Pedido no encontrado.");
            return;
        }

        // Asignar el cadete al pedido
        pedidoSeleccionado.Cadete = cadeteSeleccionado;
        Console.WriteLine($"El cadete {cadeteSeleccionado.Nombre} ha sido asignado al pedido {pedidoSeleccionado.Nro}.");
    }


    public void ReasignarCadeteAPedido(int nroPedido, int idNuevoCadete)
    {
        // Buscar el pedido por su número
        Pedidos pedido = ListadoPedidos.FirstOrDefault(p => p.Nro == nroPedido);
        if (pedido == null)
        {
            Console.WriteLine("Pedido no encontrado.");
            return;
        }

        // Buscar el nuevo cadete por su ID
        Cadete nuevoCadete = ListadoCadetes1.FirstOrDefault(c => c.Id == idNuevoCadete);
        if (nuevoCadete == null)
        {
            Console.WriteLine("Cadete no encontrado.");
            return;
        }

        // Verificar si el pedido ya tiene un cadete asignado
        if (pedido.Cadete != null)
        {
            Console.WriteLine($"El pedido {pedido.Nro} estaba asignado al cadete {pedido.Cadete.Nombre}. Reasignando al nuevo cadete {nuevoCadete.Nombre}...");
        }

        // Asignar el nuevo cadete al pedido
        pedido.Cadete = nuevoCadete;
        Console.WriteLine($"Pedido {pedido.Nro} reasignado al cadete {nuevoCadete.Nombre} exitosamente.");
    }

    
    public void EliminarCadete(Cadete cadete)
    {
        ListadoCadetes1.Remove(cadete);
    }
    public void AgregarCadete(Cadete cadete)
    {
        ListadoCadetes1.Add(cadete);
    }


}