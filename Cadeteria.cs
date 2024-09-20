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
            return 0;  // Retornamos 0 si no se encuentra el cadete
        }

        List<Pedidos> pedidosDelCadete = ListadoPedidos
            .Where(p => p.Cadete != null && p.Cadete.Id == idCadete)
            .ToList();

        return pedidosDelCadete.Count * 500;
    }


    public string AsignarCadeteAPedido(int idCadete, int idPedido)
    {
        Cadete cadeteSeleccionado = ListadoCadetes1.FirstOrDefault(c => c.Id == idCadete);
        if (cadeteSeleccionado == null)
        {
            return "Cadete no encontrado.";
        }

        Pedidos pedidoSeleccionado = ListadoPedidos.FirstOrDefault(p => p.Nro == idPedido);
        if (pedidoSeleccionado == null)
        {
            return "Pedido no encontrado.";
        }

        pedidoSeleccionado.Cadete = cadeteSeleccionado;
        return $"El cadete {cadeteSeleccionado.Nombre} ha sido asignado al pedido {pedidoSeleccionado.Nro}.";
    }



    public string ReasignarCadeteAPedido(int nroPedido, int idNuevoCadete)
    {
        Pedidos pedido = ListadoPedidos.FirstOrDefault(p => p.Nro == nroPedido);
        if (pedido == null)
        {
            return "Pedido no encontrado.";
        }

        Cadete nuevoCadete = ListadoCadetes1.FirstOrDefault(c => c.Id == idNuevoCadete);
        if (nuevoCadete == null)
        {
            return "Cadete no encontrado.";
        }

        string mensaje = $"El pedido {pedido.Nro} estaba asignado al cadete {pedido.Cadete?.Nombre ?? "ninguno"}. Reasignando al nuevo cadete {nuevoCadete.Nombre}...";
        pedido.Cadete = nuevoCadete;
        return $"{mensaje} Pedido {pedido.Nro} reasignado al cadete {nuevoCadete.Nombre} exitosamente.";
    }



    public string AgregarCadete(Cadete cadete)
    {
        ListadoCadetes1.Add(cadete);
        return $"Cadete {cadete.Nombre} agregado exitosamente.";
    }

    public string EliminarCadete(int idCadete)
    {
        Cadete cadete = ListadoCadetes1.FirstOrDefault(c => c.Id == idCadete);
        if (cadete == null)
        {
            return "Cadete no encontrado.";
        }
        ListadoCadetes1.Remove(cadete);
        return $"Cadete {cadete.Nombre} eliminado exitosamente.";
    }
    


}