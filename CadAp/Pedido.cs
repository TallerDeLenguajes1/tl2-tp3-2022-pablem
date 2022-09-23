public class Pedido
{
    static private int pedidosRealizados = 0;

    int nro;
    string obs;
    EstadoPedido estado;
    Cliente cliente;

    //Constructor
    // public Pedido() {
    //     this.Nro = ++pedidosRealizados;
    //     this.Estado = EstadoPedido.pendiente;
    //     this.Cliente = cliente;
    // }
    public Pedido(string obs, EstadoPedido estado, Cliente cliente)
    {
        this.Nro = ++pedidosRealizados;
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