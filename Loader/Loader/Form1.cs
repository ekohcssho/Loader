using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinitySeal;

namespace Loader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TrinitySeal.Seal.Secret = "v2CoBd2LLcoy9K8T73WwYcYDl9rx3xwx2UNODOknucnms";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            if (TrinitySeal.ProgramVariables.Freemode == true)
            {
                //This is if you make it go in freemode 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool response = TrinitySeal.Seal.Login(textBox1.Text, textBox2.Text);
            if (response)
            {
                Panel Pan = new Panel();
                Pan.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register fm = new Register();
            fm.Show();
            this.Hide();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
              bool response = TrinitySeal.Seal.Login(textBox1.Text, textBox2.Text);
            if (response)
            {
                Panel Pan = new Panel();
                Pan.Show();
                this.Hide();
            }
        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MetroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
