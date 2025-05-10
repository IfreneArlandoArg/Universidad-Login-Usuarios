using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        BLLEstudiante bllEstudiante = new BLLEstudiante();
        BLLProfesor bllProfesor = new BLLProfesor();
        
        private void chBVerPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chBVerPass.Checked)
            {
                txtPassword.PasswordChar = char.MinValue;
            }
            else 
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void chBNoTengoCuenta_CheckedChanged(object sender, EventArgs e)
        {
            if (chBNoTengoCuenta.Checked) 
            { 
              btnRegistrar.Visible = true;
            }
            else 
            { 
              btnRegistrar.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                BEUsuario UsuarioVerificado;

                if (bllEstudiante.IsUserRegistered(txtEmail.Text, txtPassword.Text, out UsuarioVerificado) || bllProfesor.IsUserRegistered(txtEmail.Text, txtPassword.Text, out UsuarioVerificado))
                {
                    //Logica Singleton 
                    //Establecimiento de usuario actual

                    MessageBox.Show($"Bienenido {UsuarioVerificado.Categoria}, {UsuarioVerificado.Nombre}, {UsuarioVerificado.Apellido}... ");
                }
                else 
                { 
                   //Logica para registrar nuevo usuario...
                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
