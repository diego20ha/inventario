using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class MainInventario : Form
    {
        public MainInventario()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuAddEntradaBtn_Click(object sender, EventArgs e)
        {
            AddRecibo entrada = new AddRecibo();
            entrada.Show();
            this.Hide();
        }

        private void MenuAddSalidaBtn_Click(object sender, EventArgs e)
        {
            AddSalida salida = new AddSalida();
            salida.Show();
            this.Hide();
        }
    }
}
