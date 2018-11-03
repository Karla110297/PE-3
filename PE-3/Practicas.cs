using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3
{
    public class Practicas
    {

        public void P1Vacas()
        {
            /* 1.- Supongamos que Bob tiene cuatro vacas que quiere cruzar por un puente,
          * pero solo un yugo, que puede sostener hasta dos vacas, lado a lado, atadas
          * al yugo.El yugo es demasiado pesado para que lo lleve a través del puente, 
          * pero puede atar(y desatar) vacas a él en muy poco tiempo.De sus cuatro vacas,
          * Mazie puede cruzar el puente en 2 minutos, Daisy puede cruzarlo en 4 minutos, 
          * Crazy puede cruzarlo en 10 minutos y Lazy puede cruzar en 20 minutos.
          * Por supuesto, cuando dos vacas están atadas al yugo, deben ir a la velocidad 
          * de la vaca más lenta.Describe cómo Bob puede conseguir que todas sus vacas 
          * crucen el puente en 34 minutos*/


            List<Vacas> vacas = new List<Vacas>// lista de vacas que tiene Bob 
            {
             new Vacas ("mazie", 2),//llama a la clase Vacas y asigna nombre y tiempo a cada vaca
             new Vacas ("daisy", 4),
             new Vacas ("crazy", 10),
             new Vacas("lazy", 20)
            };

            List<Vacas> sinPasarPuente = new List<Vacas>();//lista de vacas que no han pasado
            sinPasarPuente.Add(vacas.ElementAt(0));
            sinPasarPuente.Add(vacas.ElementAt(1));
            sinPasarPuente.Add(vacas.ElementAt(2));
            sinPasarPuente.Add(vacas.ElementAt(3));

            Vacas[] yugo = new Vacas[2];//Yugo, este solo puede tener dos vacas por lo que se hace en un arreglo

            List<Vacas> PasoPuente = new List<Vacas>();//lista de vacas que estan en el otro lado del puente

            int sumaTiempo = 0; //aqui se ara la suma de tiempo que llevan las vacas cada vez que recorren el tiempo
            int recorrido = 0;//recorrido en el que va el problema

            imprimirVacas(sumaTiempo, sinPasarPuente, yugo, PasoPuente, recorrido);//lamo a funcion para imprimir estado


            //primera vuelta
            recorrido++;

            yugo[0] = vacas.ElementAt(0);//pongo en el yugo la vaca mazie
            yugo[1] = vacas.ElementAt(1);//pongo en el yugo a vaca daisy

            sinPasarPuente.Remove(vacas.ElementAt(0));//paso el puente por lo que elimino vaca de esta lista
            sinPasarPuente.Remove(vacas.ElementAt(1));


            sumaTiempo += vacas.ElementAt(1).Tiempo;//sumo tiempo de recorrido

            PasoPuente.Add(vacas.ElementAt(0));//agrego vacas  porque ya pasaron el puente
            PasoPuente.Add(vacas.ElementAt(1));

            imprimirVacas(sumaTiempo, sinPasarPuente, yugo, PasoPuente, recorrido);//lamo a funcion para imprimir estado

            //regreso
            recorrido++;

            PasoPuente.Remove(vacas.ElementAt(1));// elimino de lista de los que ya pasaron porque daisy se va a regresar
            yugo[0] = null;// el yugo en posicion 0 se queda vacio porque mazie se queda al otro lado de puente


            sumaTiempo += vacas.ElementAt(1).Tiempo;//sumo tiempo de recorrido de regreso de daisy

            sinPasarPuente.Add(vacas.ElementAt(1)); //regreso a daisy en lista sin pasar


            imprimirVacas(sumaTiempo, sinPasarPuente, yugo, PasoPuente, recorrido);//lamo a funcion para imprimir estado
            yugo[1] = null;// el yugo en posicion 1  queda vacio puesto que se quita a daisy del yugo


            //segunda vuelta
            recorrido++;
            yugo[0] = vacas.ElementAt(2);//pongo en el yugo la vaca crazy
            yugo[1] = vacas.ElementAt(3);//pongo en el yugo a vaca lazy

            sinPasarPuente.Remove(vacas.ElementAt(2));//pasaron el puente por lo que elimino vacas de esta lista
            sinPasarPuente.Remove(vacas.ElementAt(3));


            sumaTiempo += vacas.ElementAt(3).Tiempo;//sumo tiempo de recorrido

            PasoPuente.Add(vacas.ElementAt(2));//agrego vacas  porque ya pasaron el puente
            PasoPuente.Add(vacas.ElementAt(3));

            imprimirVacas(sumaTiempo, sinPasarPuente, yugo, PasoPuente, recorrido);//lamo a funcion para imprimir estado

            //regreso
            recorrido++;
            PasoPuente.Remove(vacas.ElementAt(0));// eliminoa mazie de lista de los que ya pasaron porque mazie se va a regresar
            yugo[0] = null; yugo[1] = null;// el yugo  se queda vacio porque crazy y lazy se quedan al otro lado de puente
            yugo[0] = vacas.ElementAt(0);//pongo en el yugo a vaca mazie

            sumaTiempo += vacas.ElementAt(0).Tiempo;//sumo tiempo de recorrido de regreso de mazie

            sinPasarPuente.Add(vacas.ElementAt(0)); //regreso a mazie en lista sin pasar

            imprimirVacas(sumaTiempo, sinPasarPuente, yugo, PasoPuente, recorrido);//lamo a funcion para imprimir estado

            //tercera vuelta

            recorrido++;
            yugo[1] = vacas.ElementAt(1);//pongo en el yugo a vaca daisy

            sinPasarPuente.Remove(vacas.ElementAt(0));//pasaron el puente por lo que elimino vacas de esta lista
            sinPasarPuente.Remove(vacas.ElementAt(1));


            sumaTiempo += vacas.ElementAt(1).Tiempo;//sumo tiempo de recorrido

            PasoPuente.Add(vacas.ElementAt(0));//agrego vacas  porque ya pasaron el puente
            PasoPuente.Add(vacas.ElementAt(1));

            imprimirVacas(sumaTiempo, sinPasarPuente, yugo, PasoPuente, recorrido);//lamo a funcion para imprimir estado

        }

        public void P2TorresHanoi()
        {
            Stack <int> origen = new Stack<int>();//pila de origen 
            Stack<int> auxiliar = new Stack<int>();//pila auxiliar
            Stack<int> destino = new Stack<int>();//pila a donde se deben mover los discos en orden de mayor a menor


            Console.WriteLine("¿Cuantos discos quieres en tu torre?");
            int torres = Int32.Parse(Console.ReadLine());

            for(int i = torres; i > 0; i--)
            {
                origen.Push(i);
            }

            hanoi(torres, origen, auxiliar, destino);
            imprimirHanoi(origen, auxiliar, destino);

            Console.ReadKey();
        }

        public void P3AdministradorDeTareas()
        {
            /*Agregar y ver tareas numero ID,Tareas con nombre, fecha de inicio, status, fecha de finalizacion, descripcion
             * Debe haber listas globales, listas pendientes, listas terminadas, Lista en proceso   */

            List<Tareas> globales= new List<Tareas>();//lista de todas las tareas
            List<Tareas> pendientes = new List<Tareas>();//lista de tareas pendientes
            List<Tareas> enProceso = new List<Tareas>();//lista de tareas en proceso
            List<Tareas> terminadas = new List<Tareas>();//listas terminadas

            MENUTAREAS:
            Console.WriteLine("Que desea hacer en el administrador de tareas (insertar numero)");//da a elgir al usuario que actividad desea realizar
            Console.WriteLine("1. Agregrar tarea");
            Console.WriteLine("2. Ver Tareas");
            Console.WriteLine("0. Ninguna: Salir");
            int numero = Int32.Parse(Console.ReadLine());
            
            switch (numero)
            {
                case 1://caso uno es para agregar una tarea a listas
                    Console.WriteLine("Numero de Id de la tarea"); //pregunta los atributos del archivo
                    int numeroID = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Nombre de documento");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("fecha de inicio");
                    string fechaInicio = Console.ReadLine();
                    Console.WriteLine("Status");
                    string status= Console.ReadLine();
                    Console.WriteLine("fecha de finalizacion");
                    string fechaFinalizacion = Console.ReadLine();
                    Console.WriteLine("descripcion");
                    string descripcion = Console.ReadLine();

                    switch (status)// dependiendo del estatus que le dio el usuario se agrega a determinada lista
                    {//segun el caso agrega en la lista correspondiente el nuevo elemento mandando llamar 
                      //a la clase e ingresando los datos que se pidieron al usuario
                        case "pendiente":
                            pendientes.Add(new Tareas(numeroID, nombre, fechaInicio, status, fechaFinalizacion, descripcion));
                            break;
                        case "en proceso":
                            enProceso.Add(new Tareas(numeroID, nombre, fechaInicio, status, fechaFinalizacion, descripcion));
                            break;
                        case "terminado":
                            terminadas.Add(new Tareas(numeroID, nombre, fechaInicio, status, fechaFinalizacion, descripcion)); 
                            break;
                        default:
                            
                            break;
                    }
                    //se agrega tambien en globales puesto que todos deben ingresarse aqui
                    globales.Add(new Tareas(numeroID, nombre, fechaInicio, status, fechaFinalizacion,  descripcion));

                    goto MENUTAREAS;//REGRESA A MENU DE TAREAS es decir a los caso de agregar o ver iniciales
                    
                case 2://caso dos es para ver elementos de una lista determinada
                    Console.WriteLine("¿En que lista se encuentra la tarea que desea ver (insertar numero)?");//da a escoger la lista
                    Console.WriteLine("1. Pendientes");
                    Console.WriteLine("2. En proceso");
                    Console.WriteLine("3. Terminadas");
                    int numEleccion = Int32.Parse(Console.ReadLine());
                    switch (numEleccion)
                    {
                        case 1:
                            ver(pendientes);//llama a la funcion ver que es para ver los elementos de la lista ya sean todos o uno solo
                            
                            break;
                        case 2:
                            ver(enProceso);
                            break;
                        case 3:
                            ver(terminadas);
                            break;
                        default:

                            break;
                    }
                    goto MENUTAREAS;
                   
                case 0:
                    break;
                default:
                    break;
            }


        }

        static void imprimirVacas(int sumaTiempo, List<Vacas> sinPasarPuente, Vacas[] yugo, List<Vacas> PasoPuente, int recorrido)//imprimir lo que transcurre cada vuelta
        {
            Console.WriteLine("presione una tecla");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Recorrido: " + recorrido);
            Console.Write("Vacas sin pasar puente: ");

            foreach (Vacas x in sinPasarPuente)
            {
                Console.Write(x.Nombre + "  ");
            }

            Console.WriteLine();

            Console.Write("Vacas en yugo: ");

            foreach (Vacas x in yugo)
            {
                if (x != null)
                {
                    Console.Write(x.Nombre + "  ");
                }
            }

            Console.WriteLine();

            Console.Write("Vacas que ya pasaron puente: ");

            foreach (Vacas x in PasoPuente)
            {
                Console.Write(x.Nombre + "  ");
            }

            Console.WriteLine();

            Console.WriteLine("tiempo transcurrido: {0}", sumaTiempo);

            Console.WriteLine();
        }

        static void ver(List<Tareas>lista)//funcion para dar a elegir entre si ver todos los elementos de la lista o uno en especifico
        {
            Console.WriteLine("Ver todos o elegir elemento de la lista(insertar numero)");
            Console.WriteLine("1. Ver todos los elementos");
            Console.WriteLine("2. Ver un solo elemento de la lista");
            int opcion = Int32.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    foreach (Tareas elemento in lista)//imprime todos los elementos de la lista
                    {
                        elemento.imprimir();
                    }
                    break;
                case 2:
                    Console.WriteLine("orden numerico en el que esta el elemento que desea ver");//pide el numero del elemento que desea ver para poder buscarlo y mostrarlo
                    int orden = Int32.Parse(Console.ReadLine());
                    lista.ElementAt(orden-1).imprimir();//resta un elemento porque la lista empieza en 0
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
        }


        static void hanoi(int n,Stack<int>o,Stack<int>a, Stack<int>d)
        {

            imprimirHanoi(o, a, d);


            if (n == 1)
            {
                d.Push(o.Pop());
            }
            else
            {
                hanoi(n - 1, o, d, a);

                imprimirHanoi(o, a, d);

                hanoi(1, o, a, d);

                imprimirHanoi(o, a, d);

                hanoi(n - 1, a, o, d);
                

            }

            imprimirHanoi(o, a, d);
        }

        static void imprimirHanoi(Stack<int> o, Stack<int> a, Stack<int> d)
        {
            Console.WriteLine("presione una tecla");
            Console.ReadKey();
            Console.Clear();

            Console.Write("origen:\n ");
            foreach (int num in o)
            {
                Console.Write(num + "\n ");
            }

            Console.WriteLine();
            Console.Write("auxiliar: \n");
            foreach (int num in a)
            {
                Console.Write(num + "\n ");
            }

            Console.WriteLine();
            Console.Write("destino:\n ");
            foreach (int num in d)
            {
                Console.Write(num + "\n ");
            }

            Console.WriteLine();
        }
    }
}
