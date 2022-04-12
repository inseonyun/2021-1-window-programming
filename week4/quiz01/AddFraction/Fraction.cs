using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddFraction
{
    class Fraction
    {
        int numerator1, numerator2, numerator3;
        int denominator1, denominator2, denominator3;
        int a, b, r;    // 결과 값의 분자, 분모의 최대 공약수를 구하기 위한 변수

        public Fraction(int numerator1,int denominator1, int numerator2, int denominator2)
        {
            this.numerator1 = numerator1;
            this.denominator1 = denominator1;
            this.numerator2 = numerator2;
            this.denominator2 = denominator2;
            numerator3 = 0;
            denominator3 = 0;
        }
        public void AddFraction()
        {
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
            if (denominator3 > numerator3)
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
            while (true)
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
        }
        public int GetNumerator3()
        {
            return numerator3;
        }
        public int GetDenominator3()
        {
            return denominator3;
        }
    }
}
