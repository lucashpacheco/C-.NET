using System;
using Crud_2.repository;
using Crud_2.register;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_2
{
    public partial class tela_principal : Form
    {
        private Register Register
        {
            get
            {
                return new Register()
                {
                    Id = string.IsNullOrEmpty(txtid.Text) ? 0 : int.Parse(txtid.Text),
                    Nome = txtnome.Text,
                    Sobrenome = txtsobrenome.Text,
                    Telefone = txttelefone.Text,
                    Login = txtlogin.Text,
                    Senha = txtsenha.Text
                };
            }
        }

        private List<TextBox> _textBoxes;

        public tela_principal()
        {
            InitializeComponent();
            _textBoxes = new List<TextBox>()
            {
                txtid,
                txtnome,
                txtsobrenome,
                txttelefone,
                txtlogin,
                txtsenha
            };
            ExibirDados();

        }



        private void ExibirDados()
        {
            try
            {
                var register = Repository.GetAllRegisters();

                dataGridView1.DataSource = register;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimparDados(List<TextBox> texts)
        {
                texts.ForEach(x => {
                    x.Text = "";
                });
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                var register = Repository.GetRegistersById(int.Parse(txtidsearch.Text));

                dataGridView1.DataSource = register;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tela_principal_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {

            
                Repository.InsertRegisters(Register);
                ExibirDados();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                ExibirDados();
            }
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            try
            {


                Repository.DeleteRegisters(Register);
                ExibirDados();
                LimparDados(_textBoxes);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ExibirDados();
            }
        }

        private void cleanbutton_Click(object sender, EventArgs e)
        {
            LimparDados(_textBoxes);
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {


                Repository.EditRegisters(Register);
                ExibirDados();
                LimparDados(_textBoxes);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ExibirDados();
            }
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            PassarDados();
            ExibirDados();
        }

        private void PassarDados()
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                MessageBox.Show("CLIQUE EM 'SALVAR' PARA ATUALIZAR AS INFORMAÇOES DO REGISTRO ABERTO");
                try
                {


                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (row.IsNewRow) continue;
                        txtid.Text = Convert.ToString(row.Cells[0].Value);
                        txtnome.Text = Convert.ToString(row.Cells[1].Value);
                        txtsobrenome.Text = Convert.ToString(row.Cells[2].Value);
                        txtlogin.Text = Convert.ToString(row.Cells[3].Value);
                        txtsenha.Text = Convert.ToString(row.Cells[4].Value);
                        txttelefone.Text = Convert.ToString(row.Cells[5].Value);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }
    }
}