using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C.net_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int clickCent = int.Parse((String)this.lab.Text); //获取当前点击次数
            clickCent++;
            this.lab.Text = clickCent.ToString(); //将点击次数装成字符串，并赋值给conent

            int clickCent1 = int.Parse((String)this.lab1.Text); //获取当前点击次数
            clickCent1 = clickCent + 1;
            this.lab1.Text = clickCent1.ToString(); //将点击次数装成字符串，并赋值给conent

            int clickCent2 = int.Parse((String)this.lab2.Text); //获取当前点击次数
            clickCent2 = clickCent1 + 2;
            this.lab2.Text = clickCent2.ToString(); //将点击次数装成字符串，并赋值给conent
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
