using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace App003
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread nt;

            this.Close();

            nt = new Thread(cad);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();


        }

        private void cad()
        {
            Application.Run(new Form3());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread nt2;

            //this.Close();

            nt2 = new Thread(timer);
            nt2.SetApartmentState(ApartmentState.STA);
            nt2.Start();
        }

        private void timer()
        {
            Application.Run(new Form4());
        }
    }
}
