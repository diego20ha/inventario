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
    public partial class formAddRole : Form
    {
        public formAddRole()
        {
            InitializeComponent();
        }

        private Boolean validateRoleName(List<rol> rols)
        {
            Boolean roleExists = false;
            for (var i = 0; i < rols.Count; i++)
            {
                if (rols[i].nombre.ToUpper() == txtBoxRoleName.Text.ToUpper())
                {
                    // if role name exists
                    MessageBox.Show("El nombre de Rol ya existe, por favor escriba uno diferente.", "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    roleExists = true;
                    break;
                }
            }

            return roleExists;
        }

        private int getRoleId()
        {
            try
            {
                int id = -1;
                using (inventarioEntities inventario = new inventarioEntities())
                {
                    inventario.Configuration.AutoDetectChangesEnabled = false;

                    var rols = (from role in inventario.rol
                                   select role).ToList();
                    Boolean roleExists = validateRoleName(rols);


                    if (rols.Count > 0 && !roleExists)
                    {
                       
                        id = rols.Count + 1;
                    }

                    return id;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error getting Role id: " + e, "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int rolId = getRoleId();
            string nombreRol = txtBoxRoleName.Text.ToUpper();

            try
            {
                using (inventarioEntities inventario = new inventarioEntities())
                {
                    inventario.Configuration.AutoDetectChangesEnabled = false;

                    rol newRol = new rol();

                    if (rolId != -1 &&
                        nombreRol != null)
                    {
                        newRol.idrol = rolId;
                        newRol.nombre = nombreRol;

                        inventario.rol.Add(newRol);
                        inventario.SaveChanges();
                        this.Close();
                        MessageBox.Show("El Rol de usuario fue agregado exitosamente.", "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error insertando el nuevo Rol: " + error, "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
