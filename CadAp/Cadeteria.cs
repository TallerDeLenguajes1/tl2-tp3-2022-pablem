public class Cadeteria
{
    string nombre;
    string telefono;
    List<Cadete> listaCadetes;

    //Constructor
    public Cadeteria(string nombre, string telefono, List<Cadete> listaCadetes)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.listaCadetes = listaCadetes;
    }

    //Getters & Setters
    public string Nombre { get => nombre; set => nombre = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public List<Cadete> ListaCadetes { get => listaCadetes; set => listaCadetes = value; }

    //Métodos

}