public class Pedido
{
    int nro;
    string obs;
    EstadoPedido estado;
    Cliente cliente;

    //Constructor
    public Pedido(int nro, string obs, EstadoPedido estado, Cliente cliente)
    {
        this.Nro = nro;
        this.Obs = obs;
        this.Estado = estado;
        this.Cliente = cliente;
    }

    //Getters & Setters
    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => obs; set => obs = value; }
    public EstadoPedido Estado { get => estado; set => estado = value; }
    public Cliente Cliente { get => cliente; set => cliente = value; }

    


}