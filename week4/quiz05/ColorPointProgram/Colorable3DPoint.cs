using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPointProgram
{
    class Colorable3DPoint : Point
    {
        private int z;
        private string color;

        //x와 y는 상위 클래스에 있는 생성자에서 초기화 : base()
        //단, 상위 클래스 생성자 초기화를 먼저 해주어야 함.
        public Colorable3DPoint(int x, int y, int z, string color) : base(x, y)
        {
            this.z = z;
            this.color = color;
        }
        public void SetZ(int z)
        {
            this.z = z;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public int GetZ()
        {
            return this.z;
        }
        public string GetColor()
        {
            return this.color;
        }
        public void MoveTo(int x, int y, int z)
        {
            base.MoveTo(x, y); // 상위 클래스의 있는 메소드라는걸 명시 base.
            this.z = z;        // 단, 하위 클래스에서 재정의 할 때 매개변수 개수가 다르면 생략해주어도 됨
        }
        public void MoveBy(int x, int y, int z)
        {
            MoveBy(x, y);
            this.z = this.z + z;
        }
        public override string ToString()
        {
            //하위 클래스에서 재정의하는 메소드가 상위 클래스랑 완전 동일하기 떄문에
            //base. 키워드 사용
            return base.ToString() + ", z : " + this.z + ", color : " + this.color;
        }
    }
}
