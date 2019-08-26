using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();//Cierra el formulario
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="juancho" 
                && txtPassword.Text =="123tamarindo")
            {
                MessageBox.Show("Bienvenido Sr Don Juancho");
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña no valido");
                txtUsuario.Text = "";
                txtPassword.Text = "";
                txtUsuario.Focus();
            }

        }
    }
}
