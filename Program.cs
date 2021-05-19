using System;

namespace ExamenParcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validador;
            char ayuda;
            int eleccion;
            Console.WriteLine("Bienvenido al programa para el examen parcial :D");
            do{
                Console.WriteLine("Por favor, ingresa el programa que quieras usar");
                Console.WriteLine("[1]Vehículos\n[2]Películas\n[3]Figura geometrica\n[4]Mamifero");
                eleccion=Validaciones();
                switch(eleccion){
                    case 1:
                    Console.WriteLine("Ingresa el número de vehiculos que quieras ingresar");
                    int vehiculo=Validaciones();
                    Vehiculos[] clasvehi=new Vehiculos[vehiculo];
                    for(int i=0;i<vehiculo;i++){
                        clasvehi[i]=new Vehiculos();
                        Console.WriteLine(clasvehi[i].DiasVehiculo());
                        clasvehi[i].Imprimir();

                    }
                    
                    break;
                    case 2:
                    Pelicula claspeli=new Pelicula();
                    
                    break;
                    case 3:
                    
                    Console.WriteLine("Ingresa la figura que quieras hacer");
                        Console.Write("[1]Cuadrado\n[2]Rectangulo\n[3]Pentafono\n[4]Salir");
                        byte eleccion3=byte.Parse(Console.ReadLine());
                        switch(eleccion3){
                            case 1:
                            Cuadrado clascuad=new Cuadrado();
                            clascuad.Capturar();
                            clascuad.Area();
                            clascuad.Imprimir();
                            break;
                            case 2:
                            Rectangulo clasrect=new Rectangulo();
                            clasrect.Capturar();
                            clasrect.Area();
                            clasrect.Imprimir();
                            break;
                            case 3:
                            Pentagono claspent=new Pentagono();
                            claspent.Capturar();
                            claspent.Area();
                            claspent.Imprimir();
                            break;
                        }
                    break;
                    case 4:
                    Humano clashum=new Humano();
                    clashum.Imprimir();
                    Perro clasperro=new Perro();
                    clasperro.Imprimir();
                    Gato clasgat=new Gato();
                    clasgat.Imprimir();
                    break;
                }
                Console.WriteLine("Ingresa s/n para repetir");
                validador=char.TryParse(Console.ReadLine(),out ayuda);
            }while(ayuda!='n');
        }
        static int Validaciones(){
            bool ayuda;
                int valordevuelto;
            do{
                
                ayuda=int.TryParse(Console.ReadLine(),out valordevuelto);
                if(ayuda==false){

                }
            }while(ayuda==false);
            return valordevuelto;

        }
    }
}
