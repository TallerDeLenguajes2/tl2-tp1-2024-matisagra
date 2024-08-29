public class Pedido
{
    private int nro;
    private string obs;
    private Cliente cliente;
    private string estado;

    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => obs; set => obs = value; }
    public Cliente Cliente { get => cliente; set => cliente = value; }
    public string Estado { get => estado; set => estado = value; }

    public Pedido(int nro, string obs, string estado,string cliNombre,string cliDireccion,string cliTelefono,string cliIndicacionesDireccion)
    {
        this.nro = nro;
        this.obs = obs;
        cliente = new Cliente(cliNombre, cliDireccion, cliTelefono, cliIndicacionesDireccion);
        this.estado = estado;
    }

    public void VerDireccionCliente()
    {
        Console.WriteLine($"Dirección del cliente: {cliente.Direccion} {cliente.DatosReferenciaDireccion}");
    }

    public void VerDatosCliente()
    {
        Console.WriteLine($"Datos del cliente: {cliente.Nombre}, Teléfono: {cliente.Telefono}");
    }

    public void CambiarEstado(string nuevoEstado)
    {
        estado = nuevoEstado;
    }

}