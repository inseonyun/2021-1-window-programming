using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactProject
{
    public partial class ContactForm : Form
    {
        Contact c = null;
        public ContactForm()
        {
            InitializeComponent();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            string company = txtCompany.Text;
            string cellPhone = txtCellPhone.Text;
            string tel = txtTel.Text;
            string mail = txtMail.Text;

            c = new Contact(name, age, company, cellPhone, tel, mail);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            txtPrint.Text = c.ToString();
        }
    }
}
