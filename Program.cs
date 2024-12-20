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
            
            
            //int cantidadDeProductos = ProcesamientoDeDatos.ContarProductos(listaDeProductos);
            //int ProductosSmartPhoneApple = ProcesamientoDeDatos.ContarProductosPor(listaDeProductos, "Apple", "smartphones");
            float PrecioPromedioLaptop = ProcesamientoDeDatos.PrecioPromedio(listaDeProductos, "laptop");
            float PrecioPromedioSmarthphones = ProcesamientoDeDatos.PrecioPromedio(listaDeProductos, "smartphones");
            int BajosProducto = ProcesamientoDeDatos.ProductosAReponer(listaDeProductos, 50).Count();

            Producto nuevoProducto = new Producto();
            nuevoProducto = ProcesamientoDeDatos.GetProducto(listaDeProductos, 5);
            String NombreProducto = nuevoProducto.titulo;

            //Informe nuevoInforme = new Informe(cantidadDeProductos, ProductosSmartPhoneApple, PrecioPromedioLaptop, PrecioPromedioSmarthphones, BajosProducto, NombreProducto);

            //cargador.GuardarInforme("Respuesta.json", nuevoInforme);

        }
    }
}
