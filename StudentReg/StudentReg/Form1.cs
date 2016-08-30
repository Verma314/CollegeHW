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
    public partial class Form1 : Form
    {

        public String name;
        public String regNo;
        public String radio;
        public String day;
        public String month;
        public String year;
        public String theDate;

        public Form1()
        {
            InitializeComponent();
             for (int i =1960 ; i <= 2000; i++)
            {
                string[] numbers = { i.ToString() };
                comboBox3.Items.AddRange(numbers);
            }
            for (int i = 1; i <= 31; i++)
            {
                string[] numbers = { i.ToString() };
                comboBox1.Items.AddRange(numbers);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.month = comboBox2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.day = comboBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                this.radio = radioButton1.Text;
            else
                this.radio = radioButton2.Text;
        }

      


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //checking radio button values

           

            Form2 m = new Form2(this);
    
            m.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.regNo = textBox2.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.year = comboBox3.Text;
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            this.theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



    }
}
