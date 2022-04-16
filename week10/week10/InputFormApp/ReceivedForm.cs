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
    public partial class ReceivedForm : Form
    {
        public ReceivedForm()
        {
            InitializeComponent();
        }
        public ReceivedForm(Contact c)
        {
            InitializeComponent(); // InitializeComponent();이게 호출이 되어야 텍스트 박스 등 컨트롤 객체들이 생성 된다.

            txtName.Text = c.Name;
            txtAge.Text = c.Age + "";
            txtGender.Text = c.Gender;
            txtYear.Text = c.Year + "";
            txtMonth.Text = c.Month + "";
            txtDay.Text = c.Day + "";
            txtFavorite.Text = c.Favorite;
        }
        public ReceivedForm(string name, int age, string gender, int year, int month, int day, string favorite)
        {
            InitializeComponent(); // InitializeComponent();이게 호출이 되어야 텍스트 박스 등 컨트롤 객체들이 생성 된다.

            txtName.Text = name;
            txtAge.Text = age + "";
            txtGender.Text = gender;
            txtYear.Text = year + "";
            txtMonth.Text = month + "";
            txtDay.Text = day.ToString();
            txtFavorite.Text = favorite;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
