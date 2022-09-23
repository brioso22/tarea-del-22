using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_7
{
    public partial class Form1 : Form
    {
        Empleados Empleados = new Empleados();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") {

                errorProvider1.SetError(txtID,"Debe ingresar un dato valido ");
                txtID.Focus();
                return;
            }
            if (txtnombre.Text == "")
            {
                errorProvider2.SetError(txtnombre, "debe ingresar un dato valido");
                txtnombre.Focus();
                return;

            }
            if (txtDUI.Text == "")
            {
                la.SetError(txtDUI, "debe ingresar un dato valido");
                txtDUI.Focus();
                return;

            }
            if (txtsalario.Text == "")
            {
                la.SetError(txtsalario, "debe ingresar un dato valido");
                txtsalario.Focus();
                return;

            }

            else
            {
            Empleados.Id = Convert.ToInt32(txtID.Text);
            Empleados.Nombre = txtnombre.Text;
            Empleados.Dui = Convert.ToInt32(txtDUI.Text);
            Empleados.Salario = Convert.ToDouble(txtsalario.Text);

                txtrespuesta.Text = " !El dato se guardo con exito¡ ";
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                    }

        private void txtrespuesta_Click(object sender, EventArgs e)
        {

        }

        private void btAFP_Click(object sender, EventArgs e)
        {
            txtAFP.Text = Empleados.AFP(Empleados.Salario).ToString();
            
        }

        private void txtisss_Click(object sender, EventArgs e)
        {
            txtiss.Text = Empleados.ISSS(Empleados.Salario).ToString();
        }

        private void buSalNet_Click(object sender, EventArgs e)
        {
            txtsalnet.Text = Empleados.Salnet(Empleados.Salario).ToString();
        }
    }
}
