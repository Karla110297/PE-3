using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3
{
    class Tareas
    {
        //atributos
        int numeroID;
        string nombre;
        string fechaInicio;
        string status;
        string fechaFinalizacion;
        string descripcion;

        //propiedades
        public int NumeroID
        {
            get { return numeroID; }
            set { numeroID = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        public string FechaFinalizacion
        {
            get { return fechaFinalizacion; }
            set { fechaFinalizacion = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        //Constructores
        public Tareas() { }


        public Tareas(int numeroID, string nombre, string fechaInicio, string status, string fechaFinalizacion, string descripcion)
        {
            this.numeroID = numeroID;
            this.nombre = nombre;
            this.fechaInicio = fechaInicio;
            this.status = status;
            this.fechaFinalizacion = fechaFinalizacion;
            this.descripcion = descripcion;

        }

       //metodo
        public void imprimir()//imprime los datos de la tarea
        {
            Console.WriteLine("numero de ID: {0} \nnombre: {1} \nfecha en que se comenzo:{2}\nStatus:{3}" +
                "\nFecha de finalizacion:{4}\nDescripcion{5}", numeroID, nombre, fechaInicio, status, fechaFinalizacion, descripcion);
            Console.WriteLine();
        }

    }
}
