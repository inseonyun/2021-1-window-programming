using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointExam
{
    //단 이 위치(메인 폼 위)에는 클래스 생성 불가능!!
    public partial class PointForm : Form
    {
        public PointForm()
        {
            InitializeComponent();
        }
        Point p = null;

        private void btnMake_Click(object sender, EventArgs e)
        {
            int x;
            int y;

            x = int.Parse(txtX.Text);
            y = int.Parse(txtY.Text);

            // 혹은 Point p = new Point(int.Parse(txtX.Text),int.Parse(txtY.Text));
            p = new Point(x, y); //혹은 Point p = new Point(x,y);

            txtPrint.Text = p.ToString();
                                
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            p.MoveTo(int.Parse(txtX.Text), int.Parse(txtY.Text));
            txtPrint.Text = p.ToString();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            p.MoveBy(int.Parse(txtX.Text), int.Parse(txtY.Text));
            txtPrint.Text = p.ToString();
        }
    }
    /*
    public class Point
    {
        클래스를 만들 수 있는 위치 1
    }
    */
}
