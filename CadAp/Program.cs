internal class Program
{
    private static void Main(string[] args)
    {
        List<Cadete> listaCadetes = cargarCadetes("datosCadetes.csv");
        List<Cadete> listaCadetes2 = cargarCadetes("datosCadetes2.csv");
        List<Pedido> listaPedidos = cargarPedidos("datosPedidos.csv");
        var cadeteria1 = new Cadeteria("Servimoto YB","4222222",listaCadetes);
        var cadeteria2 = new Cadeteria("Servimoto B Sur","4233333",listaCadetes2);

        string opcion;
        do {
            Console.Clear();
            mostrarPedidos();
            Console.WriteLine("\nElija la operación:");
            Console.WriteLine("\n(A)signar Cadete   (D)ar de alta   Cambiar (E)stado   Cambiar (C)adete    (S)alir"); //ver cadeteria 2???

            opcion = Console.ReadLine().ToLower();
            if (opcion == "a")
                asignarPedido();
            if (opcion == "d")
                altaPedido();
            if (opcion == "e")
                cambiarEstado();
            if (opcion == "c")
                cambiarCadete();
        } while (opcion != "s");

        //INFORME AL FINAL DE LA JORNADA:

        Console.WriteLine("\nMonto Ganado (en cadetería 1): "+cadeteria1.calcularPago());
        
        
        //PROCEDIMIENTOS PARA CADA OPERACIÓN

        void mostrarPedidos()//argumentos: estados?
        {
            Console.WriteLine("\nLista de pedidos:");
            foreach (var pedido in listaPedidos) //if: estados
            {
                pedido.mostrar();
            }
            Console.WriteLine();
        }

        void asignarPedido()
        {
            Console.Clear();
            foreach (var pedido in listaPedidos) if(pedido.Estado == EstadoPedido.Pendiente)
            {
                pedido.mostrar();
                string op = " ";
                foreach (var cadete in listaCadetes) 
                {
                    Console.WriteLine("\t¿Asignar a cadete "+cadete.Id+" "+cadete.Nombre+"?(s/n)");
                    op = Console.ReadLine().ToLower();
                    if (op == "s") 
                    {
                        cadete.agregarPedido(pedido);
                        pedido.Estado = EstadoPedido.Viajando;
                        break;
                    }
                }
            }
        }
        void altaPedido() 
        {
            Console.Clear();
            foreach (var pedido in listaPedidos) if(pedido.Estado == EstadoPedido.Viajando)
            {
                pedido.mostrar();
                string op = " ";
                Console.WriteLine("\t¿Llegó el pedido?(s/n)");
                op = Console.ReadLine().ToLower();
                if (op == "s") 
                    pedido.Estado = EstadoPedido.Entregado;
            }
        }
        void cambiarEstado()
        {
            Console.Clear();
            foreach (var pedido in listaPedidos) if(pedido.Estado == EstadoPedido.Viajando || pedido.Estado == EstadoPedido.Pendiente)
            {
                pedido.mostrar();
                string op = " ";
                Console.WriteLine("\t¿Anular el pedido?(s/n)");
                op = Console.ReadLine().ToLower();
                if (op == "s") 
                    pedido.Estado = EstadoPedido.Anulado;
            }
        }
        void cambiarCadete() ///Anda pero a qué costo!? xD
        {
            Console.Clear();
            foreach (var cadete in listaCadetes)
            {
                if(cadete.ListaPedidos!=null && cadete.ListaPedidos.Any())
                {
                    string op = " ";
                    foreach (var pedido in cadete.ListaPedidos) if(pedido.Estado == EstadoPedido.Viajando)
                    {
                        pedido.mostrar();
                        Console.WriteLine("\t¿Cambiar cadete "+cadete.Id+" "+cadete.Nombre+"?(s/n)");
                        op = Console.ReadLine().ToLower();
                        if (op == "s") 
                        {
                            string op2 = " ";
                            foreach (var cadt in listaCadetes) 
                                {
                                    Console.WriteLine("\t¿Asignar a cadete "+cadt.Id+" "+cadt.Nombre+"?(s/n)");
                                    op2 = Console.ReadLine().ToLower();
                                    if (op2 == "s") 
                                    {
                                        cadete.ListaPedidos.Remove(pedido);
                                        cadt.agregarPedido(pedido);
                                        break;
                                    }
                                }
                            break;
                        }
                    }
                }
            }
        }
    }

    //MÉTODOS PARA GENERAR EL INFORME 

    void calcularTotal() {

    }

    //MÉTODOS PARA CARGAR DATOS DE CSVs

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
        var nuevaLista = new List<Pedido>();
        var listaCsv = HelperDeArchivo.LeerCsv(ruta);
        
        if (listaCsv != null && listaCsv.Any()) {
            foreach (var pedido in listaCsv) {
                if(pedido == null)
                    break;
                nuevoPedido = new Pedido(pedido[0],pedido[1],pedido[2],pedido[3],pedido[4]);
                nuevaLista.Add(nuevoPedido);
            }
        } else {
            Console.WriteLine("\n(no se encontraron pedidos para cargar)");
        }
        return nuevaLista;
    }
}