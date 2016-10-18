using Entidades;
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

namespace PrimerParcial_Aplicada1.Consultas
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }
        public List<Clientes> lista = new List<Clientes>();
        
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(FiltrotextBox.Text))
            {
                lista = BLL.ClientesBLL.GetLista(Convert.ToInt32(FiltrotextBox.Text));
            }
            dataGridView.DataSource = lista;
        }

        private void EliminarButton_Click_1(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(ID.Text);
            ClientesBLL.Eliminar(b);
        }
    }
}

