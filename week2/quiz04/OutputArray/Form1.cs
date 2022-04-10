using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutputArray
{
    public partial class FrmOutputArray : Form
    {
        public FrmOutputArray()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            int []array = {1, 3, 4, 5, 6, 7, 9, 8, 2, 0 };

            for (int i = 0; i < array.Length - 1; i++)
            {
                txtArray.Text += array[i] + ",";
                if(i == 8) //반복문을 배열의 길이만큼 반복하면 인덱스 구분 쉼표가 마지막에도 출력되기 때문에 배열의 마지막은 출력을 달리함
                {
                    txtArray.Text += array[i+1] + "";
                }
            }
        }
    }
}
