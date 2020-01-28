using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Crud_Treino
{
    
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Crud;Data Source=DESKTOPW");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        public Form1()
        {
            InitializeComponent();
            ExibirDados();

        }

        private void ExibirDados()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT * FROM list_users", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LimparDados();
            
        }

        private void LimparDados()
        {
            txtnome.Text = "";
            txtapelido.Text = "";
            txtlogin.Text = "";
            txtsenha.Text = "";
            txtobs.Text = "";
            txtid.Text = "";
            txtnome.Focus();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtnome.Text != "" && txtapelido.Text != "" && txtlogin.Text != "" && txtsenha.Text != "" && txtobs.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO list_users(Nome,Apelido,Logg,Senha,Obs) VALUES(@nome,@apelido,@login,@senha,@obs)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@nome", txtnome.Text);
                    cmd.Parameters.AddWithValue("@apelido", txtapelido.Text);
                    cmd.Parameters.AddWithValue("@login", txtlogin.Text);
                    cmd.Parameters.AddWithValue("@senha", txtsenha.Text);
                    cmd.Parameters.AddWithValue("@obs", txtobs.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro incluído com sucesso...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();
                    ExibirDados();
                    LimparDados();
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtnome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtapelido.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtlogin.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtsenha.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtobs.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtid.Text = Convert.ToString(ID);
            }
            catch
            {
                
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (txtnome.Text != "" && txtapelido.Text != "" && txtlogin.Text != "" && txtsenha.Text != "" && txtobs.Text != "")
            {
                try
                { 
                cmd = new SqlCommand("UPDATE list_users SET Nome=@nome, Apelido=@apelido, Logg=@login, Senha=@senha, Obs=@obs WHERE Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@nome", txtnome.Text);
                cmd.Parameters.AddWithValue("@apelido", txtapelido.Text);
                cmd.Parameters.AddWithValue("@login", txtlogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtsenha.Text);
                cmd.Parameters.AddWithValue("@obs", txtobs.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro atualizado com sucesso...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();
                    ExibirDados();
                    LimparDados();
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (MessageBox.Show("Deseja Deletar este registro ?", "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new SqlCommand("DELETE list_users WHERE Id=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("registro deletado com sucesso...!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        ExibirDados();
                        LimparDados();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para deletar");
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            if (ID != 0)

            {
                try
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    cmd = new SqlCommand("SELECT * FROM list_users WHERE Id=@id", con);
                    adapt.SelectCommand = cmd;
                    cmd.Parameters.AddWithValue("@id", txtidpesquisa.Text);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    
                }
                catch
                {
                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
          
        }
    }

}
