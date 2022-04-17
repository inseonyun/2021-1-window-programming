using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDialogApp
{
    public partial class UserDialog1Form : Form
    {
        private string parameter;

        public string Parameter
        {
            get
            {
                return parameter;
            }
            set
            {
                this.parameter = value;
            }
        }

        public UserDialog1Form()
        {
            InitializeComponent();
        }
        public UserDialog1Form(string txtParameter)
        {
            this.parameter = txtParameter; //이 경우 변수이기 때문에 Initial~()보다 이전에 선언 되도 문제 없음
            InitializeComponent();
            //this.txtParameter.Text = txtParameter; // 이 경우에는 객체 생성 전이기 때문에 무조건 initial~()보다 뒤에 있어야함
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserDialog1Form_Load(object sender, EventArgs e)
        {
            txtParameter.Text = parameter;
        }
    }
}
