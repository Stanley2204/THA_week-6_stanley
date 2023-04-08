using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_week_6_stanley
{
    public partial class Form1 : Form
    {
        Form2 nextform = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) < 4)
            {
                MessageBox.Show("INPUTTT WOIII");
            }
            else
            {
                Form2.sizing = Convert.ToInt32(textBox1.Text);
                nextform.Show();
            }

        }
    }
}
