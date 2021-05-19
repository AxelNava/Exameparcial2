using System;

namespace ExamenParcial2
{
    class Poligonos:FiguraGeometrica
    {
        public override void Area()
        {
            double basec;
            Console.WriteLine("Ingresa el apotema de la figura");
            basec=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el perimetro de la figura");
            this.perimetro=double.Parse(Console.ReadLine());
            this.area=(basec*perimetro)/2;
            Console.Write("El área es: "+area+"\n");
        }
    }
}
