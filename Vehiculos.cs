using System;

namespace ExamenParcial2
{
    class Vehiculos
    {
        public int año;
        public string marca,modelo,tipo;
        
        public Vehiculos(){
            Console.WriteLine("Ingresa el tipo de vehiculo\nAutomovil\nMotocicleta");
            tipo=Console.ReadLine();
            Console.WriteLine("Ingresa el modelo del vehículo");
            modelo=Console.ReadLine();
            Console.WriteLine("Ingresa el año del vehículo");
            año=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la marca del vehículo");
            marca=Console.ReadLine();
        }
        public int DiasVehiculo(){
            int dias=(2021-año)*365;
            return dias;
        }
        public void Imprimir(){
            Console.WriteLine("Los datos del vehículo son:");
            Console.Write("Tipo: "+tipo+"\n");
            Console.Write("Modelo: "+modelo+"\n");
            Console.Write("Año: "+año+"\n");
            Console.Write("Marca: "+marca+"\n");
        }
    }
}
