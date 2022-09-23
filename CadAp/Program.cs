internal class Program
{
    private static void Main(string[] args)
    {
        List<Cadete> listaCadetes = cargarCadetes();






        List<Cadete> cargarCadetes(){
            var lista = HelperDeArchivo.LeerCsv("datosCadetes.csv");
            if (lista != null && lista.Any()) {
                // int id;
                string nombre;
                string direccion;
                string telefono;
                foreach (var cadete in lista) {
                    if(cadete == null)
                        break;
                    // id = cadete[0];
                    nombre = cadete[0];
                    direccion = cadete[1];
                    telefono = cadete[2];
                }
            } else {
                Console.WriteLine("\n()");
            }

        }
        void cargarClientes(List<string[]> lista){

        }
        void cargarCadeteria(List<string[]> lista){

        }

    }

}