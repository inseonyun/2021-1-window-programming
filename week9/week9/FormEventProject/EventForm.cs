using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEventProject
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            /*
            // 폼이 load 될 때 보여지는 제목을 아래와 같이 바꿈
            this.Text = "load 이벤트 테스트";
            // 폼의 사이즈를 폼을 Load 하며 바꿈
            this.Width = 800;
            this.Height = 300;
            */
            // 폼의 사이즈를 문자열로 만들고 그 문자열을 메시지 박스에 넣음
            string forminfo = "EventForm의 넓이 : " + this.Width + ", 높이 : " + this.Height;
            MessageBox.Show(forminfo);
        }

        private void lblOut_MouseMove(object sender, MouseEventArgs e)
        {
            lblOut.Text = "마우스 좌표: x =" + e.X + ", y = " + e.Y;
        }

        private void EventForm_MouseMove(object sender, MouseEventArgs e)
        {
            lblOut.Text = "마우스위치: x =" + e.X + ", y = " + e.Y;
        }

        private void EventForm_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("버튼:" + e.Button.ToString(), "MouseClick Event");
        }

        private void EventForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 보통 keyPress는 어떠한 키가 눌렸을 때 사용
            // keyPress에선 쉬프트, 컨트롤, 알트, 캡스락 등이 눌려도 인식 안 함
            MessageBox.Show("KeyChar : " + e.KeyChar.ToString(), "KeyPress Event");
        }

        private void EventForm_KeyDown(object sender, KeyEventArgs e)
        {
            // keyDown은 어떠한 키가 눌려있는가 할 때 사용
            // keyDown은 알트, 쉬프트같은 특수키 인식 됨
            MessageBox.Show("KeyCode : " + e.KeyCode.ToString(), "KeyDown Event");
        }
    }
}
