using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial_Aplicada1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void registrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro Re = new Registro();
            Re.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.Consultas c = new Consultas.Consultas();
            c.Show();
            
        }
    }
}
