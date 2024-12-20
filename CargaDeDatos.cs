using System.Text.Json;

using System.Text.Json;

namespace FinalTaller{
    public class CargaDeDatos{
        public List<Producto> LeerProductos(String nombreArchivo){
            if(File.Exists(nombreArchivo)){
                string productos = File.ReadAllText(nombreArchivo);
                List<Producto>? listaDeProductos = JsonSerializer.Deserialize<List<Producto>>(productos);
                Console.WriteLine("Productos cargados con exito");
                return listaDeProductos;
            }else{
                Console.WriteLine("Ocurrio un error");
                throw new ArgumentNullException();
            }
        }
    }

}