

namespace FinalTaller{
    public class Informe{
       

        public int CantidadDeProductos {get; set;}
        public int ProductosSmartPhoneAppli {get; set;}
        public float PrecioPromedioLaptop {get; set;}
        public float PrecoPromedioSmartPhone {get; set;}
        public int BajosDeStock {get; set;}
        public String? NombreProducto {get; set;}
        
        public Informe(int cantidadDeProductos, int productosSmartPhoneAppli, float precioPromedioLaptop, float precoPromedioSmartPhone, int bajosDeStock, string? nombreProducto)
        {
            CantidadDeProductos = cantidadDeProductos;
            ProductosSmartPhoneAppli = productosSmartPhoneAppli;
            PrecioPromedioLaptop = precioPromedioLaptop;
            PrecoPromedioSmartPhone = precoPromedioSmartPhone;
            BajosDeStock = bajosDeStock;
            NombreProducto = nombreProducto;
        }
        
    }
}