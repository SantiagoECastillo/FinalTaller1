
namespace FinalTaller{
    public class Producto{

        public int ID {get; set;}
        public String? Titulo {get; set;}
        public String? Descripcion {get; set;}
        public int Precio {get; set;}
        public float PorcentajeDeDescuento {get; set;}
        public float Rating {get; set;}
        public int Stock {get; set;}
        public String? Marca {get; set;}
        public String? Categoria {get; set;}

        public float PrecioConDescuento(float descuento){
            return Precio * descuento;
        }

        


    }
}