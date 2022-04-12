using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPointProgram
{
    public partial class ColorPointForm : Form
    {
        Colorable3DPoint c3p = null;

        public ColorPointForm()
        {
            InitializeComponent();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            int z;
            string color;

            x = int.Parse(txtX.Text);
            y = Convert.ToInt32(txtY.Text);
            z = Convert.ToInt32(txtZ.Text);
            color = txtColor.Text;

            c3p = new Colorable3DPoint(x, y, z, color);

            //getX는 정수를 리턴, 문자열로 변환해서 텍스트박스 저장
            txtXPrint.Text = Convert.ToString(c3p.GetX()); // Convert 키워드 사용이 젤 바람직
            txtYPrint.Text = Convert.ToString(c3p.GetY());
            txtZPrint.Text = c3p.GetZ().ToString();
            txtColorPrint.Text = c3p.GetColor();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            int z;
            string color;

            x = int.Parse(txtX.Text);
            y = Convert.ToInt32(txtY.Text);
            z = Convert.ToInt32(txtZ.Text);
            color = txtColor.Text;

            c3p.MoveTo(x, y, z);
            print3DPoint();
        }
        private void print3DPoint()
        {
            txtXPrint.Text = Convert.ToString(c3p.GetX()); // Convert 키워드 사용이 젤 바람직
            txtYPrint.Text = Convert.ToString(c3p.GetY());
            txtZPrint.Text = c3p.GetZ().ToString();
            txtColorPrint.Text = c3p.GetColor();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            int z;
            string color;

            x = int.Parse(txtX.Text);
            y = Convert.ToInt32(txtY.Text);
            z = Convert.ToInt32(txtZ.Text);
            color = txtColor.Text;

            c3p.MoveBy(x, y, z);

            print3DPoint();
        }

        private void btnChangeX_Click(object sender, EventArgs e)
        {
            int x;
            x = Convert.ToInt32(txtX.Text);
            c3p.SetX(x);
            print3DPoint();
        }

        private void btnChangeY_Click(object sender, EventArgs e)
        {
            int y;
            y = int.Parse(txtY.Text);
            c3p.SetY(y);
            print3DPoint();
        }

        private void btnChangeZ_Click(object sender, EventArgs e)
        {
            int z;
            z = int.Parse(txtZ.Text);
            c3p.SetZ(z);
            print3DPoint();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            c3p.SetColor(txtColor.Text);
            print3DPoint();
        }
    }
}
