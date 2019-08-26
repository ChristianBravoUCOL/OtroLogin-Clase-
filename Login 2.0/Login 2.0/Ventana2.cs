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
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Visible = true;
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;
            if(cbC.Checked == true)
            {
                conteo++;
            }
            if (cbB.Checked == true)
            {
                conteo++;
            }
            if(rbTarjeta.Checked==true)
            {
                seleccion = "Tarjeta de Crédito";
            }
            else
            {
                seleccion = "PayPal";
            }
            MessageBox.Show("Has seleccionado" + conteo +
                " cursos y tu médoto de pago es " +
                seleccion);
        }
    }
}
