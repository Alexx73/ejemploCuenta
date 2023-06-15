using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploCuenta
{
    public partial class F_principal : Form
    {
        Cuenta miCuenta;
        public F_principal()
        {
            InitializeComponent();
             miCuenta = new Cuenta(0010, 5000);
            double montoExtraer;
        }

        private void F_principal_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double montoExtraccion;
            F_secundaria vExtraer = new F_secundaria();

            // abre ventana secundaria

            if (vExtraer.ShowDialog() == DialogResult.OK )
            {
                montoExtraccion = Convert.ToDouble(vExtraer.textBox2.Text) ;
                if (miCuenta.Extraccion(montoExtraccion))
                {

                    //label1_Click.Text = "tt";
                    label1.Text = "exito";
                }
                else
                {
                    label1.Text = "error en la operacion";
                }

            } else
            {
                MessageBox.Show("cancelado por el usuario");
            }

            vExtraer.Dispose();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            miCuenta.Deposito(3000);
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text =  miCuenta.Saldo.ToString("$ 0.00");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
