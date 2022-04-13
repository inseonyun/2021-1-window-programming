using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateCallWindowApp
{
    public partial class DelegateCalcForm : Form
    {
        public delegate void Calc(int value1, int value2);
        Calc cal;

        public DelegateCalcForm()
        {
            InitializeComponent();
        }
        private void Add(int value1, int value2)
        {
            txtResult.Text += value1 + " + " + value2 + " = " + (value1 + value2) + Environment.NewLine;
        }
        private void Subtract(int value1, int value2)
        {
            txtResult.Text += value1 + " - " + value2 + " = " + (value1 - value2) + Environment.NewLine;
        }
        private void Multiple(int value1, int value2)
        {
            txtResult.Text += value1 + " * " + value2 + " = " + (value1 * value2) + Environment.NewLine;
        }
        private void Division(int value1, int value2)
        {
            txtResult.Text += value1 + " / " + value2 + " = " + (value1 / value2) + Environment.NewLine;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int v1 = int.Parse(txtValue1.Text);
            int v2 = int.Parse(txtValue2.Text);

            cal += new Calc(Add);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int v1 = int.Parse(txtValue1.Text);
            int v2 = int.Parse(txtValue2.Text);

            cal += new Calc(Subtract);
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            int v1 = int.Parse(txtValue1.Text);
            int v2 = int.Parse(txtValue2.Text);

            cal += new Calc(Multiple);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int v1 = int.Parse(txtValue1.Text);
            int v2 = int.Parse(txtValue2.Text);

            cal += new Calc(Division);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int v1 = int.Parse(txtValue1.Text);
            int v2 = int.Parse(txtValue2.Text);

            cal(v1, v2);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = ""; //텍스트상자는 +=하지 않으면 덮어씌우기 떄문
            cal = null; //델리게이트 초기화도 해줌 안 해주면 이전 위임한게 계속 누적 됨
        }
    }
}
