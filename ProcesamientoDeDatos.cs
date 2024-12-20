using System.Collections.Generic;

using System.Net.NetworkInformation;

namespace FinalTaller{

    public static class ProcesamientoDeDatos{

        public static int ContarProductos(List<Producto> listaDeProductos){
            return listaDeProductos.Count();
        }

        //VER NO FUNCIONA
        public static int ContarProductosPor(List<Producto> listaDeProductos, String marca, String categoria){       
            List<Producto> lista = listaDeProductos.Where(p => p.marca == marca).ToList();
            return lista.Count();
        }

        
        public static float PrecioPromedio(List<Producto> listaDeProductos,  String categoria){
            List<Producto> lista = listaDeProductos.Where(p => p.categoria == categoria).ToList();
            return (float)lista.Average(p => p.precio);
            
        }

        
        public static List<Producto> ProductosAReponer(List<Producto> listaDeProductos, int stock){
            List<Producto> productosAReponer = listaDeProductos.Where(p => p.stock <= stock).ToList();
            return productosAReponer;
        
        }

        public static Producto GetProducto(List<Producto> listaDeProductos, int idProducto){
            return listaDeProductos.Find(p => p.id == idProducto);
        }
    }

}