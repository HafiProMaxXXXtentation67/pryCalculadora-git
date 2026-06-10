using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCalculadora
{
    public partial class frmCalculadora : Form
    {
        //Objeto
        clsCalculadora calc = new clsCalculadora();
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            calc.N1 = float.Parse(txtN1.Text);
            calc.N2 = float.Parse(txtN2.Text);

            txtResultado.Text = calc.Sumar().ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            calc.N1 = float.Parse(txtN1.Text);
            calc.N2 = float.Parse(txtN2.Text);

            txtResultado.Text = calc.Restar().ToString();
        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            calc.N1 = float.Parse(txtN1.Text);
            calc.N2 = float.Parse(txtN2.Text);

            txtResultado.Text = calc.Multiplicar().ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            calc.N1 = float.Parse(txtN1.Text);
            calc.N2 = float.Parse(txtN2.Text);

            txtResultado.Text = calc.Dividir().ToString();
        }
    }
}
