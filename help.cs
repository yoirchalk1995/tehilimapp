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
            richTextBox1.Enabled = false;
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.Select(0, 0);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
