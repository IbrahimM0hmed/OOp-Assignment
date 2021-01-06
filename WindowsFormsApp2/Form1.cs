using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApp2;

namespace OppAssignment 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.Red;
            this.textBox3.BackColor = Color.Green;
           
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox2.BackColor = Color.Blue;
            this.textBox4.BackColor = Color.Yellow;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Font f1 = new Font("Atlantic", 15, FontStyle.Bold);
            Font f3 = new Font("Atlantic", 15, FontStyle.Bold);
            textBox1.Font = f1;
            textBox3.Font = f3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Font f2 = new Font("Atlantic", 15, FontStyle.Bold);
            Font f4= new Font("Atlantic", 15, FontStyle.Bold);
            textBox2.Font = f2;
            textBox4.Font = f4;
        }
    }
}
