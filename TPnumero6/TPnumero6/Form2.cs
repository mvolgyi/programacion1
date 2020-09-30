using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPnumero6.Modelo;

namespace TPnumero6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private string _nombre;
        private string _apellido;
        public string nombre
        {
            get { return _nombre; }
            set { nombre = value; }
        }

        
        public string apellido
        {
            get { return _apellido; }
            set { apellido = value; }
        }
        public string TextBoxtextBoxNombre
        {
            get { return textBoxNombre.Text; }
        }

        public string TextBoxtextBoxApellido
        {
            get { return textBoxApellido.Text; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            _nombre = textBoxNombre.Text;
            _apellido = textBoxApellido.Text;
        }


    }
}
