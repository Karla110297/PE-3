using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3
{
    class Vacas
    {
        //atributos
        string nombre;
        int tiempo;


        //propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }

        //constructores
        public Vacas() { }


        public Vacas(string nombre, int tiempo)
        {
            this.nombre = nombre;
            this.tiempo = tiempo;

        }
    }
}
