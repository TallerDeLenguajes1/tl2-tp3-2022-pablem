public class Persona
{
    int id;
    string nombre;
    string direccion;
    string telefono;

    public Persona(int id, string nombre, string direccion, string telefono)
    {
        Id = id;
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
    }
    
    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
}


public class Cliente : Persona
{
    string referenciaDireccion;

    //Constructor
    public Cliente(int id, string nom, string dir, string tel,string referenciaDireccion) : base(id,nom,dir,tel)
    {
        this.ReferenciaDireccion = referenciaDireccion;
    }
    //Getters & Setters
    public string ReferenciaDireccion { get => referenciaDireccion; set => referenciaDireccion = value; }


}

public class Cadete : Persona
{
    List<Pedido> listaPedidos;
    
    //Constructor
    public Cadete(int id, string nom, string dir, string tel) : base(id,nom,dir,tel)
    {
        ListaPedidos = new List<Pedido>();
    }
    //Getters & Setters
    public List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }

    //Métodos de cadete:
    public void jornalACobrar() {

    }
}
