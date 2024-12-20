using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text;
using System.IO;

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
        public void GuardarInforme(String nombreArchivo, Informe informe){
            string jsonString = JsonSerializer.Serialize<Informe>(informe);
            
            FileStream fs = new FileStream(nombreArchivo, FileMode.OpenOrCreate);
            using (StreamWriter strwriter = new StreamWriter(fs))
            {
                strwriter.WriteLine(jsonString);
                strwriter.Close();
            }

        }

    }



}