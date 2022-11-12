using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Easter_Project
{
    public partial class Form1 : Form

    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            player.URL = "Shekinah Rodz in Tinos Jazz Festival.mp3";
            player.close();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ιστορία f2 = new Ιστορία();
            this.Hide();
            f2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Αξιοθέατα f2 = new Αξιοθέατα();
            this.Hide();
            f2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Έθιμα f2 = new Έθιμα();
            this.Hide();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Παραλίες f2 = new Παραλίες();
            this.Hide();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Φαγητό f2 = new Φαγητό();
            this.Hide();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ΟΤόπος f2 = new ΟΤόπος();
            this.Hide();
            f2.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        int NumberOfClick = 0;
        public void button8_Click(object sender, EventArgs e)
        {
            
            ++NumberOfClick;
            switch (NumberOfClick)
            {
                case 1:
                    // this is the first click
                    player.controls.play();
                    break;
                case 2:
                    // this is the second click
                    player.close();                    
                    NumberOfClick = 0;
                    break;
            }
                    


        }

        

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;

            }
            else
            {
                MessageBox.Show("Operation canceled ");
            }

        }
    }
}
