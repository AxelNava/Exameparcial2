using System;

namespace ExamenParcial2
{
    class Cuadrilateros:FiguraGeometrica
    {
        public override void Area()
        {
            double basec;
            double alturac;
            
            Console.WriteLine("Ingresa la base de la figura");
            basec=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la altura de la figura");
            alturac=double.Parse(Console.ReadLine());
            this.area=basec*alturac;
            Console.WriteLine("El área es"+area+"\n");
        }
    }
}
