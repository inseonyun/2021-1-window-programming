using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointExam
{
    /*
    public class Point
    {
        여기도 클래스 생성 가능한 위치3
    }
    */
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PointForm());
        }
    }
    /*
    public class Point
    {
        여기에도 클래스 생성 가능한 위치2
    }
    */
}
