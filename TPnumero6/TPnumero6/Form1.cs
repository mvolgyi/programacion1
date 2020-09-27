using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPnumero6.Modelo;

namespace TPnumero6
{
    public partial class Form1 : Form
    {
        private Cola cola;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            cola = new Cola(5);

            if (!cola.IsFull())
            {
                Alumno alumno = new Alumno();
                alumno.Nombre = textBoxCarga.Text;
                cola.Enqueue(alumno);
                listBoxAlumnos.Items.Add(alumno.Nombre);
                textBoxCarga.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Cola llena...");
            }
        }


        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (!cola.IsEmpty())
            {
                Alumno alumnoBorrado = cola.Dequeue();
                if (alumnoBorrado != null)
                {
                    MessageBox.Show("El alumno borrado es: " + alumnoBorrado.Nombre);
                }
                listBoxAlumnos.Items.Remove(alumnoBorrado.Nombre);
            }
            else
            {
                MessageBox.Show("Cola vacia...");
            }
        }

        private void buttonTope_Click(object sender, EventArgs e)
        {
            if (!cola.IsEmpty())
            {
                MessageBox.Show(cola.Peek().Nombre);
            }
            else
            {
                MessageBox.Show("No hay nada para mostrar...");
            }
        }


        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
