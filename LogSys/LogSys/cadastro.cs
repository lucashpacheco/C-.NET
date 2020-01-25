using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LogSys
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login, senha, nome;
            
            login = textBox1.Text;
            senha = textBox2.Text;
            nome = textBox3.Text;
            

            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LogSys;Data Source=DESKTOPW");
            SqlCommand command = new SqlCommand("insert into list_user(Logg, Senha, Nome) values(@login, @senha, @nome)",sql);
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;

            if(login != "" && senha != "" && nome != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("CAD COM SUCESSO");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sql.Close();
                }

            }
            else
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS");
            }


            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
