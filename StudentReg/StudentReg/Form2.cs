using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentReg
{
    
    public partial class Form2 : Form
    {

        public Form1 x;
        public Form2(Form1 x)
        {
            InitializeComponent();
            
            label1.Text = x.name;
            label2.Text = x.regNo;
            label3.Text = x.radio;

            label4.Text = x.day; label5.Text = x.month; label6.Text = x.year;

            label7.Text = x.theDate;



        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit or no?",
                   "My First Application",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
   
        }
    }
}

