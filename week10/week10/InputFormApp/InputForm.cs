using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputFormApp
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string name;
            int age;
            string gender;
            int year;
            int month;
            int day;
            string favorite = "";

            name = txtName.Text;
            age = int.Parse(txtAge.Text);
            if (rdoMan.Checked)
                gender = "man";
            else
                gender = "woman";
            year = Convert.ToInt32(txtYear.Text);
            month = Convert.ToInt32(txtMonth.Text);
            day = Convert.ToInt32(txtDay.Text);

            if (chkFishing.Checked)
                favorite += "fising" + Environment.NewLine;
            if (chkGaming.Checked)
                favorite += "gaming" + Environment.NewLine;
            if (chkSinging.Checked)
                favorite += "singing" + Environment.NewLine;

            //ReceivedForm rf = new ReceivedForm(name, age, gender, year, month, day, favorite);
            Contact c = new Contact(name, age, gender, year, month, day, favorite); ;
            ReceivedForm rf = new ReceivedForm(c); //객체 정보 전달
            rf.Show();
        }
    }
}
