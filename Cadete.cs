
public class Cadete
{
    private int id;
    private string nombre;
    private string direccion;
    private string telefono;
    private List<Pedido> listaPedidos;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    internal List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }


    public Cadete(int id, string nombre, string direccion, string telefono)
    {
        this.id = id;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
        this.listaPedidos = new List<Pedido>();
    }

    public int JornalACobrar(List<Pedido> listaPedidos)
    {
        return listaPedidos.Count * 500;
    }

    public void AsignarPedido(Pedido pedido)
    {
        listaPedidos.Add(pedido);
    }

    public void EliminarPedido(Pedido pedido)
    {
        listaPedidos.Remove(pedido);
    }

    public decimal CalcularJornal()
    {
        return listaPedidos.Count * 500;
    }

    public void AgregarPedido(Pedido pedido)
    {
        listaPedidos.Add(pedido);
    }

    public void EliminarPedido(int nroPedido)
    {
        var pedido = listaPedidos.Find(p => p.Nro == nroPedido);
        if (pedido != null)
        {
            listaPedidos.Remove(pedido);
        }
    }



}
