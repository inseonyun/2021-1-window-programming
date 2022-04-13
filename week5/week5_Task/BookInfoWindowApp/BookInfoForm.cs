using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfoWindowApp
{
    public partial class BookInfoForm : Form
    {
        EBook b = null;

        public BookInfoForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            int pages = Convert.ToInt32(txtPages.Text);
            string isbn = txtISBN.Text;
            string publisher = txtPublisher.Text;
            int price = Convert.ToInt32(txtPrice.Text);

            b = new EBook(title, author, pages, isbn, publisher, price);
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            int discount = Convert.ToInt32(txtDiscount.Text);
            b.DiscountPrice(discount);
        }

        private void btnOfs_Click(object sender, EventArgs e)
        {
            b.StockOut();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           txtResult.Text = b.ToString();
        }
    }
}
