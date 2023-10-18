using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace nameapp
{
    public partial class helpForm : Form
    {
        public helpForm()
        {
            InitializeComponent();
            text();
        }


        private void text()
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.WordWrap = true;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;

            textBox3.ReadOnly = true;


            textBox1.Text = "Welcome to tehilim name genarator.";

            textBox2.Text = "input the name for which you want to recieve the פסוקים from פרק קי\"ח";
            textBox3.Text = "once you have generated the text for your name you will be given the option to add קרע שטן" +
                "if you enter a second name the previouse text will be cleared";

            textBox1.SelectionStart = 0;


        }
    }
}
