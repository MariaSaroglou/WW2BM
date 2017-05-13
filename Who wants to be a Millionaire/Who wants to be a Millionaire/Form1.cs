using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Who_wants_to_be_a_Millionaire
{
    public partial class Form1 : Form
    {
        SoundPlayer intro = new SoundPlayer(Properties.Resources.intro);
        public static int i = 0;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form2()).Show();
            intro.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            intro.PlayLooping();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                intro.Stop();
                pictureBox1.BackgroundImage = Properties.Resources.s1m;
                i = 1;
            }
            else
            {   
                intro.Play();
                pictureBox1.BackgroundImage = Properties.Resources.s1;
                i = 0;
            }
        }
    }
}
