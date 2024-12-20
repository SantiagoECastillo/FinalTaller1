
namespace FinalTaller{
    public class Producto{

        public int id {get; set;}
        public String? titulo {get; set;}
        public String? descripcion {get; set;}
        public int precio {get; set;}
        public float porcentajeDeDescuento {get; set;}
        public float rating {get; set;}
        public int stock {get; set;}
        public String? marca { get; set; }
        public String? categoria {get; set;}

        public float PrecioConDescuento(float descuento){
            return precio * descuento;
        }




    }
}