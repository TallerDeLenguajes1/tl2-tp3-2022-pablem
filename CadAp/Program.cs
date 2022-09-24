internal class Program
{
    private static void Main(string[] args)
    {
        List<Cadete> listaCadetes = cargarCadetes("datosCadetes.csv");
        List<Cadete> listaCadetes2 = cargarCadetes("datosCadetes2.csv");
        List<Pedido> listaPedidos = cargarPedidos("datosClientesYPedidos.csv");
        var cadeteria1 = new Cadeteria("Servimoto YB","4222222",listaCadetes);
        var cadeteria2 = new Cadeteria("Servimoto B Sur","4233333",listaCadetes2);



    }

    private static List<Cadete> cargarCadetes(string ruta)
    {
        Cadete nuevoCadete;
        var nuevaLista = new List<Cadete>();
        var listaCsv = HelperDeArchivo.LeerCsv(ruta);
        
        if (listaCsv != null && listaCsv.Any()) {
            foreach (var cadete in listaCsv) {
                if(cadete == null)
                    break;
                nuevoCadete = new Cadete(cadete[0],cadete[1],cadete[2]);
                nuevaLista.Add(nuevoCadete);
            }
        } else {
            Console.WriteLine("\n(no se encontraron cadetes para cargar)");
        }
        return nuevaLista;
    }

    private static List<Pedido> cargarPedidos(string ruta)
    {
        Pedido nuevoPedido;
        Cliente nuevoCliente;
        var nuevaLista = new List<Pedido>();
        var listaCsv = HelperDeArchivo.LeerCsv(ruta);
        
        if (listaCsv != null && listaCsv.Any()) {
            foreach (var pedido in listaCsv) {
                if(pedido == null)
                    break;
                nuevoCliente = new Cliente(pedido[0],pedido[1],pedido[2],pedido[3]);
                nuevoPedido = new Pedido(pedido[4],nuevoCliente);
                nuevaLista.Add(nuevoPedido);
            }
        } else {
            Console.WriteLine("\n(no se encontraron pedidos para cargar)");
        }
        return nuevaLista;
    }
}