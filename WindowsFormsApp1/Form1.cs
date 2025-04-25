using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("안녕하세요");
            textBox_Print.Text = "이것은 \r\n 텍스트박스 \r\n 예제입니다.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
// 칸 바꾸는 거
    }
}
