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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login, senha, master;
            Thread nt;

            login = textBox1.Text;
            senha = textBox2.Text;

            master = "admin";

            if (login == master && senha == master)
            {

                MessageBox.Show("Voce esta logado");

                this.Close();
                nt = new Thread(novoform);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();

            }
            else
            {
                MessageBox.Show("Login ou senha inválidos!");
            }
        }

        private void novoform()
        {
            Application.Run(new Form2());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                string login, senha, master;
                Thread nt;

                login = textBox1.Text;
                senha = textBox2.Text;

                master = "admin";

                if (login == master && senha == master)
                {

                    MessageBox.Show("Voce esta logado");

                    this.Close();
                    nt = new Thread(novoform);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();

                }
                else
                {
                    MessageBox.Show("Login ou senha inválidos!");
                }
            }
        }
    }
}
