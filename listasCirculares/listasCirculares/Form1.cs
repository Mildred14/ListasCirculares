using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listasCirculares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ruta rutaNueva = new Ruta();
        Base b1;
        private void AGREGAR_Click(object sender, EventArgs e)
        {
            string nombre = BASE.Text;
            int minutos = Convert.ToInt32(MINUTOS.Text);
            b1 = new Base(nombre, minutos);
            rutaNueva.agregar(b1);
            BASE.Clear();
            MINUTOS.Clear();
        }

        private void REPORTE_Click(object sender, EventArgs e)
        {
            ReporteBox.Text = rutaNueva.reporte();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Base b1;
            string nombre = BASE.Text;
            b1 = rutaNueva.buscar(nombre);
            if (b1 != null)
            {
                ReporteBox.Text = b1.ToString();
            }
        }

        private void agregarINICIO_Click(object sender, EventArgs e)
        {
            string nombre = BASE.Text;
            int minutos = Convert.ToInt32(MINUTOS.Text);
            b1 = new Base(nombre, minutos);
            rutaNueva.agregarInicio(b1);
            BASE.Clear();
            MINUTOS.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = BASE.Text;
            rutaNueva.eliminar(nombre);
        }

        private void eliminarUltimo_Click(object sender, EventArgs e)
        {
            rutaNueva.eliminarUltimo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = BASE.Text;
            int minutos = Convert.ToInt32(MINUTOS.Text);
            b1 = new Base(nombre, minutos);
            rutaNueva.insertarDespues(seleccionBase.Text,b1);
            BASE.Clear();
            MINUTOS.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReporteBox.Text = rutaNueva.recorrido(BASE.Text, horaInicio.Value, horaFin.Value);
        }

        private void horaFin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
