using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasCirculares
{
    class Base
    {
        private string _nombre;
        private int _min;
        private Base _siguiente;
        private Base _anterior;
        public Base (string nombre, int min)
        {
            _nombre = nombre;
            _min = min;
        }
        public string nombre
        {
            get { return _nombre; }
            set { nombre = value; }
        }
        public int min
        {
            get { return _min; }
            set { min = value; }
        }
        public Base siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public Base anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }
        public override string ToString()
        {
            string show = "" ;
            show += "Nombre de la Base: " + nombre + " "+ "Min: " + min + Environment.NewLine;
            return show;


        }
    }
}
