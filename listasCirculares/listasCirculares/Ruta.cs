using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasCirculares
{
    class Ruta
    {
        public Base primerbase = null;
  
        public Ruta() { primerbase = null; }
        public void agregar(Base base1)
        {
            if (primerbase == null)
            {
                primerbase = base1;
                primerbase.siguiente = base1;
                primerbase.anterior = base1;
            }
            else
            {  primerbase.anterior.siguiente = base1;
                    base1.anterior = primerbase.anterior;
                    base1.siguiente = primerbase;
                    primerbase.anterior = base1; }
        }
        public void agregarInicio(Base base1)
        {
            if (primerbase == null)
            {
                primerbase = base1;
                primerbase.siguiente = base1;
                primerbase.anterior = base1;
            }
            else
            {
                base1.anterior = primerbase.anterior;
                base1.siguiente = primerbase;
                primerbase.anterior.siguiente = base1;
                primerbase.anterior = base1;
                primerbase= base1;

            }
        }
        public Base buscar (string Nombre)
        {
            if (primerbase != null)
                return buscar(primerbase, Nombre);
                    return null;
        }
        private Base buscar (Base baseRequerida, string Nombre)
        {
            if (baseRequerida.nombre == Nombre)
                return baseRequerida;
            else
            {
                return buscar(baseRequerida.siguiente, Nombre);
            }
           
        }
        public string eliminar(string Nombre)
        {
            Base buscarBase = buscar(Nombre);
            if (buscarBase!=null){
                if (buscarBase.siguiente==buscarBase && buscarBase.anterior==buscarBase)
                {
                    primerbase = null;
                    
                }
                else
                {
                    buscarBase.anterior.siguiente = buscarBase.siguiente;
                    buscarBase.siguiente.anterior = buscarBase.anterior;
                    if (buscarBase == primerbase)
                        primerbase = primerbase.siguiente;
                    return "";
                }
            }
            return null;
        }
        public void insertarDespues (string Nombre, Base nuevaBase)
        {
            Base encontrarBase = buscar(Nombre);
            if (encontrarBase != null)
            {
                encontrarBase.siguiente = nuevaBase;
                nuevaBase.anterior.siguiente = encontrarBase.siguiente;
                nuevaBase.siguiente=encontrarBase;
                nuevaBase.anterior = encontrarBase;
            }
            else
            {
                agregar(nuevaBase);
            }
        }
        public string eliminarPrimero()
        {
            if (primerbase != null)
            {
                Base temp = primerbase.siguiente;
                temp = temp.siguiente;
                temp.anterior.siguiente = null;
                temp.anterior = null;
                return "";
            }
            else
            {
                return "";
            }
        }
        public string eliminarUltimo()
        {
            if ( primerbase != null)
            {
                Base temp = primerbase.anterior;
                temp = temp.anterior;
                temp.siguiente.anterior = null;
                temp.siguiente = null;
                return "";
            }
            else
            {
                return null;
            }
        }
        public string recorrido (string nombre, DateTime inicio, DateTime fin)
        {
            Base buscarBase = buscar(nombre);
            if (buscarBase != null)
                return recorrido(buscarBase, inicio, fin);
            else
                return "";
        }
        private string recorrido (Base ultimo, DateTime inicio, DateTime fin)
        {
            string ruta = "";
            DateTime suma = inicio.AddMinutes(ultimo.siguiente.min);
            if (suma <= fin)
            {
                ruta += ultimo.nombre + inicio.ToShortTimeString() + Environment.NewLine + recorrido(ultimo.siguiente, suma, fin);
            }
            else
            {
                ruta += ultimo.nombre + inicio.ToShortTimeString();
            }
            return ruta;
        }
        public string reporte()
        {
            string cadena = ToString() + Environment.NewLine;
            Base temporal = primerbase;
            do
            {
                cadena += "" + temporal.ToString();
                temporal = temporal.siguiente;
            }
            while (temporal != null && temporal != primerbase);
            return cadena;
        }
        
    }
}
