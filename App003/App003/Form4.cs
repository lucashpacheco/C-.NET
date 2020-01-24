using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App003
{
    public partial class Form4 : Form
    {
        int tempo, minuto, segundo = 0;

     /* int tempo == 0;
        int minuto == 0;
        int segundo== 0;
     */
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            tempo = Convert.ToInt32(textBox1.Text);

            if(tempo >= 60)
            {
                minuto = tempo / 60;
                segundo = tempo % 60;
            }
            else
            {
                minuto = 0;
                segundo = tempo;

            }
            label2.Text = "0" + minuto + ":" + segundo;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo = segundo - 1; //segundo--
            if(minuto > 0 && segundo <= 0)
            {
                segundo = 59;
                minuto--;
            }
            label2.Text = "0" + minuto + ":" + segundo;
            if(minuto == 0 && segundo == 0)
            {
                pictureBox1.Visible = true;
                timer1.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
