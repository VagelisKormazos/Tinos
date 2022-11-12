using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easter_Project
{
    public partial class Έθιμα : Form
    {
        public Έθιμα()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if(colorDialog1.ShowDialog() == DialogResult.OK)            
            {
                this.BackColor = colorDialog1.Color;

            }
            else
            {
                MessageBox.Show("Operation canceled ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile("textfiles\\Epitafios.txt", RichTextBoxStreamType.PlainText);
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
