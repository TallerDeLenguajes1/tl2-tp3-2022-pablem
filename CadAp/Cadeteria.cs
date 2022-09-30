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
    public int calcularPago() { ///control por fechas?
        int pago = 0;
        foreach (var cadete in listaCadetes)
        {
            pago += cadete.calcularPago(); 
        }
        return pago;
    }

    public void mostrarPedidos() {
         foreach (var cadete in listaCadetes)
        {
            var cons =
                from cad in cadete.ListaPedidos
                where cad.Estado==EstadoPedido.Entregado
                select cad;

            Console.WriteLine($"-Cadete Cód. {cadete.Id} - Pedidos: {cons.Count()} - Ganancia: {}");
        }
    }
}