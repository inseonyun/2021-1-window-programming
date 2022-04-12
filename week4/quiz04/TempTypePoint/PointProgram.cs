using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempTypePoint
{
    static class PointProgram
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TempTypePointForm());
        }
    }
    public class Point<DataType>
    {
        private DataType x;
        private DataType y;
    
        public Point(DataType x, DataType y)
        {
            this.x = x;
            this.y = y;
        }
        public void MoveTo(DataType x, DataType y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "x : " + x + ", y : " + y;
        }
    }
}
