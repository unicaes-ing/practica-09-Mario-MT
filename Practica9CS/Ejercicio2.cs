using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9CS
{
    class Ejercicio2
    {
        public struct Alumno
        {
            public string carnet;
            public string nombre;
            public string carrera;
            private double cum;

            public void setCum(double cum)
            {
                if (cum >= 0 && cum <= 10)
                {
                    this.cum = cum;
                }
            }
            public double getCum()
            {
                return cum;
            }
        }
        static void Main(string[] args)
        {
            Alumno alumnos = new Alumno();
            Dictionary<string, Alumno> Datos = new Dictionary<string, Alumno>();
            int menu;
            do
            {
                Console.WriteLine("[1] Agregar Alumno");
                Console.WriteLine("[2] Mostrar Alumnos");
                Console.WriteLine("[3] Eliminar Alumno");
                Console.WriteLine("[4] Buscar Alumno");
                Console.WriteLine("[5] Vaciar Diccionario");
                Console.WriteLine("[6] Salir");
                    Console.WriteLine("Elija una opción");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {

                    case 1:
                        Console.WriteLine("Ingrese su Carnet");
                        alumnos.carnet = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del estudiante");
                        alumnos.nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la carrera");
                        alumnos.carrera = Console.ReadLine();
                        Console.WriteLine("Ingrese el CUM");
                        alumnos.setCum(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 2:
                        Console.Clear();
                        foreach (KeyValuePair<string, Alumno> datos in Datos)
                        {
                            Console.WriteLine(datos);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        string carnet;
                        Console.WriteLine("Ingrese el carnet del alumno que desea eliminar");
                        carnet = Console.ReadLine();
                        Datos.Remove(carnet);
                        foreach (KeyValuePair<string, Alumno> datos in Datos)
                        {
                            Console.WriteLine(datos);
                        }

                        break;
                    case 4:
                        Console.Clear();
                        string Alumno;
                        Console.WriteLine("Ingrese el alumno que desea buscar");
                        Alumno = Console.ReadLine();

                        do
                        {


                            Console.WriteLine("El alumno se encuentra en la lista.");


                        } while ((Datos.ContainsKey(Alumno)));
                        break;
                    case 5:
                        Console.Clear();
                        Datos.Clear();
                        break;
                    case 6:


                        break;

                }
                Console.Clear();
            } while (menu != -1);

        }
    }
}
