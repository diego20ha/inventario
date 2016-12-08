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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            try
            {
                using (inventarioEntities inventario = new inventarioEntities())
                {
                    inventario.Configuration.AutoDetectChangesEnabled = false;

                    var roles = (from role in inventario.rol
                                       select role).ToList();

                    if (roles.Count > 0)
                    {
                        cmbRol.ValueMember = "idrol";
                        cmbRol.DisplayMember = "nombre";
                        cmbRol.DataSource = roles;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading roles.", "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
