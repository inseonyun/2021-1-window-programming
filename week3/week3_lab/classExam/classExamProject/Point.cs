using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classExamProject
{
    // 새 항목 추가로 클래스를 만들 수 있다.
    class Point
    {
        private int x;
        int y; // 지정자 생략시 private
        public static readonly double Pi = 3.14; //public을 변수에 사용하는 일반적인 예

        // 생성자를 이용하여 변수 초기화 외부에서 생성자 접근을 위해 public 사용
        public Point()
        {
            x = y = 10;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //접근자, 수정자 get메소드, set 메소드 -> c#에서는 프로패티로 만듦(나중에)
        public int getX()
        {
            return this.x;
        }
        //정보제공 - 문자열 형태로, C#에서는 재정의 하는 것을 반드시 명시해주어야 함
        public override string ToString()
        {
            return "x : " + x + ", y : " + y;
        }
    }
}
