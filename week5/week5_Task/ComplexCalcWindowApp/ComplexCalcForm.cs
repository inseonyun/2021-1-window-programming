using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexCalcWindowApp
{
    public partial class ComplexCalcForm : Form
    {
        ComplexArray carr = null;
        public ComplexCalcForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Complex c1 = new Complex(double.Parse(txtCAReal.Text), double.Parse(txtCAImaginary.Text));
            Complex c2 = new Complex(double.Parse(txtCBReal.Text), double.Parse(txtCBImaginary.Text));
            carr = new ComplexArray();
            carr[0] = c1;
            carr[1] = c2;
            carr[2] = c1 + c2;

            txtCCReal.Text = carr[2].PrintReal();
            txtCCImaginary.Text = carr[2].PrintImaginary();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Complex c1 = new Complex(double.Parse(txtCAReal.Text), double.Parse(txtCAImaginary.Text));
            Complex c2 = new Complex(double.Parse(txtCBReal.Text), double.Parse(txtCBImaginary.Text));
            carr = new ComplexArray();
            carr[0] = c1;
            carr[1] = c2;
            carr[2] = c1 * c2;

            txtCCReal.Text = carr[2].PrintReal();
            txtCCImaginary.Text = carr[2].PrintImaginary();
        }
    }
}
