using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionAddProject
{
    public partial class FractionAddForm : Form
    {
        public FractionAddForm()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int numerator1, numerator2, numerator3 = 0;
            int denominator1, denominator2, denominator3 = 0;
            int a, b, r;    // 결과 값의 분자, 분모의 최대 공약수를 구하기 위한 변수

            numerator1 = int.Parse(txtNumerator1.Text);
            numerator2 = int.Parse(txtNumerator2.Text);
            denominator1 = int.Parse(txtDenominator1.Text);
            denominator2 = int.Parse(txtDenominator2.Text);

            if (denominator1 == denominator2)
            {
                denominator3 = denominator1;
                numerator3 = numerator1 + numerator2;
            }
            else
            {
                // 분모가 같지 않다면 통분하여 계산, 결과를 약분
                denominator3 = denominator1 * denominator2;
                numerator3 = numerator1 * denominator2 + numerator2 * denominator1;
            }
            // 분자와 분모를 비교하여 큰 값을 a에 초기화
            if(denominator3 > numerator3)
            {
                a = denominator3;
                b = numerator3;
            }
            else
            {
                a = numerator3;
                b = denominator3;
            }
            // 유클리드 호제법으로 최대 공약수 구하기
            while(true)
            {
                r = a % b;
                if (r == 0)
                    break;
                a = b;
                b = r;
            }
            //구해진 최대 공약수 b로 나누어 기약분수를 만듦
            denominator3 /= b;
            numerator3 /= b;

            txtDenominator3.Text = denominator3 + "";
            txtNumerator3.Text = numerator3.ToString();

        }
    }
}
