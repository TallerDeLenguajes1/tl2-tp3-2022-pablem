public class Persona
{
    static private int personasIngresadas = 0;

    int id;
    string nombre;
    string direccion;
    string telefono;
    
    //Constructor Base
    public Persona(string nombre, string direccion, string telefono)
    {
        this.id = ++personasIngresadas;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
    }
    //Getters & Setters Base
    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
}

public class Cliente : Persona
{
    string referenciaDireccion;

    //Constructor
    public Cliente(string nom, string dir, string tel,string referenciaDireccion) : base(nom,dir,tel)
    {
        this.referenciaDireccion = referenciaDireccion;
    }
    //Getters & Setters
    public string ReferenciaDireccion { get => referenciaDireccion; set => referenciaDireccion = value; }
}

public class Cadete : Persona
{
    List<Pedido> listaPedidos;

    //Constructor
    public Cadete(string nom, string dir, string tel) : base(nom,dir,tel)
    {
        listaPedidos = new List<Pedido>();
    }
    //Getters & Setters
    // public List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }

    //Métodos de cadete:
    public void agregarPedido(Pedido pedido) {
        listaPedidos.Add(pedido);
    }

    public void jornalACobrar() {

    }
}
