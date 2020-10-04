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
    public partial class FormularioPrincipal : Form
    {
        private Cola cola = new Cola(10);

        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {

            if (cola.IsFull() == false)
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
            if (cola.IsEmpty() == false)
            {
                Alumno alumnoBorrado = cola.Dequeue();
                MessageBox.Show("El alumno borrado es: " + alumnoBorrado.Nombre);
                listBoxAlumnos.Items.RemoveAt(0);   //Borra el primer valor de la cola
            }
            else
            {
                MessageBox.Show("Cola vacia...");
            }
        }

        private void buttonTope_Click(object sender, EventArgs e)   // Mira el primer item que esta en la Cola
        {
            if (cola.IsEmpty() == false)
            {
                MessageBox.Show(cola.Peek().Nombre);
            }
            else
            {
                MessageBox.Show("No hay nada para mostrar...");
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)  // Cierra el Form
        {
            Application.Exit();
        }

        private void buttonFormulario_Click(object sender, EventArgs e) //Abre le Formulario
        {
            FormularioSecundario f = new FormularioSecundario();
            if(f.ShowDialog() == DialogResult.OK)
            {
                if (cola.IsFull() == false)
                {
                    Alumno alumno = new Alumno();
                    alumno.Nombre = f.nombre;
                    alumno.Apellido = f.apellido;
                    cola.Enqueue(alumno);
                    listBoxAlumnos.Items.Add(alumno.Nombre + " " + alumno.Apellido);
                }
                else
                {
                    MessageBox.Show("Cola llena...");
                }
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
