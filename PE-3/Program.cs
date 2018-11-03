
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Practicas pe3 = new Practicas();

            MENU:
            Console.Clear();
            Console.WriteLine("Que numero de practica desea ver");
            Console.WriteLine("1. -Practica 1:Vacas");
            Console.WriteLine("2. -Practica 2:Torre de hanoi");
            Console.WriteLine("3. -Practica 3: Administrador de tareas");
            Console.WriteLine("0. Ninguna: Salir");
            int numero = Int32.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    pe3.P1Vacas();
                    goto MENU;
                case 2:
                    pe3.P2TorresHanoi();
                    goto MENU;
                case 3:
                    pe3.P3AdministradorDeTareas();
                    goto MENU;                    
                case 0:
                    Console.WriteLine("Adios");
                    break;
                default:
                    break;
            }
          

        }
        
        




    }
}
