using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayFormApp
{
    public partial class ArrayForm : Form
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public ArrayForm()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(txtIndex.Text);
                txtOutput.Text = this.arr[index] + "";
            }catch(FormatException fe)
            {
                txtOutput.Text = "정수형 인덱스가 입력되지 않았습니다.";
            }catch(IndexOutOfRangeException ioe)
            {
                txtOutput.Text = "인덱스가 배열의 범위를 벗어났습니다.";
            }
            
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    txtOutput.Text += arr[i];
                }
                else
                {
                    txtOutput.Text += arr[i] + ", ";
                }
            }
        }
    }
}
