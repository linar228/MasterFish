using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterFish
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

        

            private void postavshic_Enter(object sender, EventArgs e)
        {
            if (postavshic.Text == "Please Enter Name...")
            {
                postavshic.ForeColor = Color.Black;
                postavshic.Text = "";
            }
        }

        private void txt_YourTextBox_Leave(object sender, EventArgs e)
        {
            if (postavshic.Text.Length == 0)
            {
                postavshic.ForeColor = Color.BlueViolet;
                postavshic.Text = "Please Enter Name...";
            }
        }

        private void Fish_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] countries = { "Бразилия", "Аргентина", "Чили", "Уругвай", "Колумбия" };
            Fish.Items.AddRange(countries);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
