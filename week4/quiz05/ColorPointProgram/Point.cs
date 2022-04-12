using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPointProgram
{
    class Point
    {
        private int x;  //자동으로 private으로 생성되지만 명시해주는 것이 좋음
        private int y;
        
        public Point(int x, int y) //생성자
        {
            this.x = x;
            this.y = y;
        }
        //C#에서는 메소드 첫글자를 대문자로 하는게 관례
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public void MoveTo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void MoveBy(int moveX, int moveY)
        {
            this.x = this.x + moveX;
            this.y = this.y + moveY;
        }
        //toString 메소드 재정의 꼭!!override 키워드 명시!!
        public override string ToString()
        {
            return "x : " + this.x + ", y : " + this.y;
        }
    }
}
