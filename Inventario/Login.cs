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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char).13) {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char).13)
            {
                btnSubmit.PerformClick();
            }
        }

        private void checkCredentials() 
        {
            if (string.IsNullOrEmpty(textBoxUser.Text))
            {
                MessageBox.Show("Por favor ingrese su usuario", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUser.Focus();
                return;
            }
            try
            {
                using (inventarioEntities inventario = new inventarioEntities())
                {
                    var user = (from o in inventario.usuario
                                where o.nombreusuario == textBoxUser.Text && o.contrasena == textBoxPassword.Text
                                select o).SingleOrDefault();

                    if (user != null)
                    {
                        var roles = (from role in inventario.rol
                                     where role.idrol == user.idrol
                                     select role.idrol).ToList();

                        MainInventario inventarioForm = new MainInventario();
                        this.Hide();
                        inventarioForm.Show();
                        
                        if(roles.Count > 0)
                        {
                            inventarioForm.showAdminOptions();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El nombre de usuario o contraseña son incorrectos. Por favor intente de nuevo", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            checkCredentials();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkCredentials();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkCredentials();
            }
        }
    }
}
