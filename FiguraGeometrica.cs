using System;

namespace ExamenParcial2
{
    class FiguraGeometrica
    {
        
        public int cantidadvertice,cantidadlados;
        public double area, perimetro;
        public string nombre;
        public void Capturar(){
            Console.WriteLine("Ingresa el nombre de la figura");
            nombre=Console.ReadLine();
            Console.WriteLine("Ingresa la cantidad de vertices de la figura");
            cantidadvertice=int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la cantidad de lados de la figura");
            cantidadlados=int.Parse(Console.ReadLine());
        }
        public void Imprimir(){
            Console.WriteLine("Nombre de la figura: "+nombre);
            Console.WriteLine("Número de lados: "+cantidadlados);   
            Console.WriteLine("Número de vertices: "+cantidadvertice);   
        }
        
        public virtual void Area(){

        }
    }
}
