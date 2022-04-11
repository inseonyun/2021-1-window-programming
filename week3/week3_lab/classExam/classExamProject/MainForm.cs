using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classExamProject
{
    /*
    class Exam
    {
        MainForm.cs는 기존 partial class 위에 클래스를 생성하면 
        MainForm 디자인이 깨진다. 그러므로 상단에는 생성 불가
    }
    */
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Point p = null;
            p = new Point(int.Parse(txtX.Text), int.Parse(txtY.Text));

            txtR.Text = p.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
