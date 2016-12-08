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

        /*
         * Custom functions
         */
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

        private int getNextUserId()
        {
            try
            {
                int id = 1;
                using (inventarioEntities inventario = new inventarioEntities())
                {
                    inventario.Configuration.AutoDetectChangesEnabled = false;

                    var element = (from el in inventario.usuario
                                     select el).ToList();

                    if (element.Count > 0)
                    {
                        id = element.Count + 1;
                    }

                    return id;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error getting usuario next id: " + e, "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        
        private void ParseUsuario()
        {
            int idNextUsuario = getNextUserId();
            usuario newUsuario = new usuario();

            if (idNextUsuario != null)
            {
                newUsuario.idusuario = idNextUsuario;
            }

            if (!String.IsNullOrEmpty(cmbRol.Text))
            {
                newUsuario.idrol = Int32.Parse(cmbRol.SelectedValue.ToString());
            }

            if (!String.IsNullOrEmpty(txtBoxNombre.Text))
            {
                newUsuario.nombreusuario = txtBoxNombre.Text;
            }

            if (!String.IsNullOrEmpty(txtBoxPassword.Text))
            {
                newUsuario.contrasena = txtBoxPassword.Text;
            }

            InsertUser(newUsuario);
        }

        private void InsertUser(usuario user)
        {
            try
            {
                using (inventarioEntities inventario = new inventarioEntities())
                {
                    inventario.Configuration.AutoDetectChangesEnabled = false;

                    if (user != null)
                    {
                        inventario.usuario.Add(user);
                        inventario.SaveChanges();
                        inventario.SaveChanges();
                        this.Close();
                        MessageBox.Show("El Usuario fue agregado exitosamente.", "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error agregando nuevo usuario: " + e, "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Form Events
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ParseUsuario();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
