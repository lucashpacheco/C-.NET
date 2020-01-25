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
    public partial class pglogin : Form
    {
        public pglogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login, senha;
            Thread inside;

            login = textBox1.Text;
            senha = textBox2.Text;

            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LogSys;Data Source=DESKTOPW");
            SqlCommand command = new SqlCommand("select * from list_user where Logg=@login and Senha=@senha", sql);
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

            try
            {
                sql.Open();
                SqlDataReader busca = command.ExecuteReader();
                if (busca.HasRows == false)
                {
                    throw new Exception("USER / PASS FAIL");
                }

                busca.Read();
                MessageBox.Show("LOGADO");
                inside = new Thread(in_side);
                inside.SetApartmentState(ApartmentState.STA);
                inside.Start();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
                this.Close();
            }


        }

        private void in_side()
        {
            Application.Run(new principal());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread incad;

            incad = new Thread(in_cad);
            incad.SetApartmentState(ApartmentState.STA);
            incad.Start();
        }

        private void in_cad()
        {
            Application.Run(new cadastro());
        }
    }
}
