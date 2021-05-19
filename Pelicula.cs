using System;
using System.Collections.Generic;
namespace ExamenParcial2
{
    class Pelicula
    {
        public Dictionary<string, string> Peliculasdic=new Dictionary<string, string>();
        public Pelicula(){
            char sino;
            do{
                Console.WriteLine("Ingresa la opción que quieras hacer");
                Console.WriteLine("[1]Agregar\n[2]Eliminar\n[3]Consultar\n[4]Imprimir");
                byte eleccion=byte.Parse(Console.ReadLine());
                    
                switch(eleccion){
                    case 1:
                    Agregar();
                    break;
                    case 2:
                    Eliminar();
                    break;
                    case 3:
                    Consultar();
                    break;
                    case 4:
                    Imprimir();
                    break;
                }
                Console.Write("¿Quieres otra opción? s/n: ");
                sino=char.Parse(Console.ReadLine());
            }while(sino!='n');
        }
        public void Agregar(){
            Console.WriteLine("Ingresa el nombre de la película, luego pulsa enter,seguido de la duaración");
            Peliculasdic.Add("Nombre"+Console.ReadLine(),"Duración"+Console.ReadLine());
            
        }
        public void Eliminar(){
            bool encontrado;
            string nombrepeli;
            do{
            Console.WriteLine("Ingresa el nombre de la película");
            nombrepeli=Console.ReadLine();
            encontrado=Peliculasdic.ContainsKey(nombrepeli);
            if(encontrado==true){
                Peliculasdic.Remove(nombrepeli);
            }else{
                Console.WriteLine("Vuelve a ingresar el nombre de la pelicula");
            }
            }while(encontrado==false);
        }
        public void Consultar(){
            string nombrepeli;
            bool encontrado; 
            Console.WriteLine("Ingresa el nombre de la película");
            nombrepeli=Console.ReadLine();
            encontrado=Peliculasdic.ContainsKey(nombrepeli);
            if(encontrado==true){
                Console.WriteLine("Los datos de la película son: ");
                Console.Write("Nombre: "+nombrepeli+Peliculasdic[nombrepeli]);
            }else{
                Console.WriteLine("El nombre de la pelicula que ingresaste no está");
            }
            
        }
        public void Imprimir(){
            
            for(int i=0;i<Peliculasdic.Count;i++){
                Console.Write("Peliculas\n");
                
                Console.WriteLine(Peliculasdic);
                //Console.Write("Nombre: "+nombrepeli+"Duración: "+Peliculasdic[nombrepeli]);
            }
        }
    }
}
