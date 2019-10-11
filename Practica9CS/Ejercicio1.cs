using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9CS
{
    class Ejercicio1
    {
        public static List<string> Frutas = new List<string>();
        static void agregar()
        {
            string agregar = "";
            while (agregar != "0")
            {
                Console.WriteLine("Ingrese el nombre de la fruta que desea agregar o ingrese 0 si desea salir");
                agregar = Console.ReadLine();
                Frutas.Add(agregar.ToUpper());
                if (agregar == "0")
                {
                    Frutas.Remove("0");
                }
            }
            Console.Clear();
            menuPrincipal();
        }

        static void Mostrar()
        {
            Console.WriteLine("Frutas: ");
            int T = 1;
            foreach (string item in Frutas)
            {
                Console.WriteLine($"{T}. {item}");
                T++;
            }
            Console.WriteLine("Presione <Enter> para regresar al menú principal");
            Console.ReadKey();
            Console.Clear();
            menuPrincipal();
        }

        static void Agregarxpos()
        {
            string agregar = "";
            int index = 0;
            bool condicion;
            while (agregar != "0")
            {
                Console.WriteLine("Ingrese el nombre de la fruta (0 para salir)");
                agregar = Console.ReadLine();
                if (agregar == "0")
                {
                    break;
                }
                do
                {
                    Console.WriteLine("Ingrese la posición en el que quiere añadirlo: ");
                    condicion = Int32.TryParse(Console.ReadLine(), out index);
                    if (index - 1 > Frutas.Count)
                    {

                        Console.WriteLine("La posición que ingreso es incorrecta");
                        Console.WriteLine("Presione <Enter> para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        Agregarxpos();
                    }
                } while (condicion == false);
                Frutas.Insert(index - 1, agregar.ToUpper());
                if (agregar == "0")
                {
                    Frutas.Remove("0");
                }
            }
            Console.Clear();
            menuPrincipal();
        }

        static void Eliminar()
        {
            string eliminar = "";
            while (eliminar != "0")
            {
                Console.WriteLine("Ingrese el nombre de la fruta a eliminar (0 para salir)");
                eliminar = Console.ReadLine();
                Frutas.Remove(eliminar.ToUpper());
            }
            Console.Clear();
            menuPrincipal();
        }
        static void Buscar()
        {
            string fruta = "";
            while (fruta != "0")
            {
                Console.WriteLine("Ingrese el nombre de la fruta que desea buscar o ingrese 0 si desea salir");
                fruta = Console.ReadLine();
                if (Frutas.Contains(fruta.ToUpper()))
                {
                    Console.WriteLine($"Fruta encontrada en la posición {Frutas.IndexOf(fruta.ToUpper()) + 1}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Fruta no encontrada");
                    Console.WriteLine();
                }
            }
            Console.Clear();
            menuPrincipal();
        }
        static void Limpiar()
        {
            Frutas.Clear();
            Console.WriteLine("Lista vaciada con exito");
            Console.Clear();
            menuPrincipal();

        }
        static void Main(string[] args)
        {
            menuPrincipal();
            Console.WriteLine("Presione <Enter> para continuar...");
            Console.ReadKey();
        }


        static void menuPrincipal()
        {
            int menu;
            Console.WriteLine("1. Agregar a la lista");
            Console.WriteLine("2. Mostrar lista");
            Console.WriteLine("3. Insertar en la lista");
            Console.WriteLine("4. Eliminar de la lista");
            Console.WriteLine("5. Buscar en la lista");
            Console.WriteLine("6. Vaciar lista");
            Console.WriteLine("7. Salir");
            Console.WriteLine( "seleccione una opcion: ");
            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.Clear();
                    agregar();
                    break;
                case 2:
                    Console.Clear();
                    Mostrar();
                    break;
                case 3:
                    Console.Clear();
                    Agregarxpos();
                    break;
                case 4:
                    Console.Clear();
                    Eliminar();
                    break;
                case 5:
                    Console.Clear();
                    Buscar();
                    break;
                case 6:
                    Console.Clear();
                    Limpiar();
                    break;
                case 7:
                    Environment.Exit(7);
                    break;
            }


        }

    }
}
