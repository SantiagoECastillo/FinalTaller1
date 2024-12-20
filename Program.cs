using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace FinalTaller{
    class Program{

        public static void Main(String [] args){

            List<Producto> listaDeProductos = new List<Producto>();
            String archivo = "Productos.json";
            CargaDeDatos cargador = new CargaDeDatos();
            listaDeProductos = cargador.LeerProductos(archivo);
            
            
            //Console.WriteLine(ProcesamientoDeDatos.ContarProductos(listaDeProductos));
            //Console.WriteLine(ProcesamientoDeDatos.ContarProductosPor(listaDeProductos, "Apple", "smartphones"));


        }
    }
}
