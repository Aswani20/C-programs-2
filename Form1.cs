using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value <= 99)
            {
                progressBar1.Value += 1;
            }
            else if (progressBar1.Value == 100) {
                timer1.Stop();
                MessageBox.Show("progress compelet");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog ()== DialogResult.OK) {
                label1.Font = fontDialog1.Font;
            }

        }

        

        
    }
}
