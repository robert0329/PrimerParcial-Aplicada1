using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace PrimerParcial_Aplicada1
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        private Clientes LlenarClase()
        {
            Clientes Usuario = new Clientes();

            Usuario.Nombre = NombretextBox.Text;
            Usuario.FechaNacimiento = FechamaskedTextBox.Text;
            Usuario.LimiteDeCredito = LimitetextBox.Text;


            return Usuario;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes User = new Clientes();
            User = LlenarClase();

            if (ClientesBLL.Guardar(User))
            {
                MessageBox.Show("Guardo con exito");
            }

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            NombretextBox.Text = "";
            FechamaskedTextBox.Text = "";
            LimitetextBox.Text = "";
        }
    }
}
