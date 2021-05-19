using System;

namespace ExamenParcial2
{
    class Mamifero
    {
        public int cantidad_extremidades=4,cantidad_dedos,promedioVida=40;
        public string vertebrado="si",cola="si",nace_madre="si";
        public void Imprimir(){
            Console.WriteLine("Datos");
            Console.WriteLine("Cantidad de extremidades: "+cantidad_extremidades);
            Console.WriteLine("Cantidad de dedos: "+cantidad_dedos);
            Console.WriteLine("Promedio de vida: "+promedioVida);
            Console.WriteLine("Es vertebrado"+vertebrado);
            Console.WriteLine("Cola: "+cola);
            Console.WriteLine("Nace de madre: "+nace_madre);
        }
    }
}
