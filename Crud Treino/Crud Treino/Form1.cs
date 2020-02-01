using Crud_Treino.Models;
using Crud_Treino.Repositories;
using Crud_Treino.Validacoes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Crud_Treino
{

    public partial class telaprincipal : Form
    {
        private Register Register
        {
            get
            {
                return new Register()
                {
                    Id = string.IsNullOrEmpty(textID.Text) ? 0 : int.Parse(textID.Text),
                    Nome = txtnome.Text,
                    Apelido = txtapelido.Text,
                    Login = txtlogin.Text,
                    Obs = txtobs.Text,
                    Senha = txtsenha.Text
                };
            }
        }

        private List<TextBox> _textBoxes;

        public telaprincipal()
        {
            InitializeComponent();
            _textBoxes = new List<TextBox>()
            {
                textID,
                txtnome,
                txtapelido,
                txtlogin,
                txtsenha,
                txtobs
            };

            ExibirDados();
        }

        private void ExibirDados()
        {
            try
            {
                
               
                var registers = Form1Repository.GetAllRegisters();

                dataGridView1.DataSource = registers;
                
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
        }

        private void LimparDados()
        {
            Utils.Utils.CleanTextBox(_textBoxes);

            txtnome.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparDados();
            ExibirDados();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FormValidation.ValidaCadastro(_textBoxes))
            {
                try
                {
                    var qtdInserted = Form1Repository.InsertRegister(Register);

                    if (qtdInserted > 0)
                        MessageBox.Show("Registro incluído com sucesso...");
                    else
                        throw new Exception("Nenhum registro inserido");

                    LimparDados();
                    ExibirDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    ExibirDados();
                    LimparDados();
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha os campos destacados.");
            }
        }
        
                
        
                
        private void PassarDadosForm()
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
                        textID.Text = Convert.ToString(row.Cells[0].Value);
                        txtnome.Text = Convert.ToString(row.Cells[1].Value);
                        txtapelido.Text = Convert.ToString(row.Cells[2].Value);
                        txtlogin.Text = Convert.ToString(row.Cells[3].Value);
                        txtsenha.Text = Convert.ToString(row.Cells[4].Value);
                        txtobs.Text = Convert.ToString(row.Cells[5].Value);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FormValidation.ValidaCadastro(_textBoxes))
            {
                try
                {
                    var qtdExecuted = Form1Repository.UpdateRegister(Register);

                    if (qtdExecuted > 0)
                        MessageBox.Show("Registro atualizado com sucesso...");
                    else
                        throw new Exception("Nunehum registro foi atualizado...");

                    LimparDados();
                    ExibirDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
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
            if (!FormValidation.ValidaCadastro(_textBoxes))
                MessageBox.Show("Por favor selecione um registro");

            var dialog = MessageBox.Show("Deseja Deletar este registro ?", "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                if (Register.Id == 0)
                    throw new Exception("Por favor selecione um registro para deletar");
                try
                {
                    var qtdExecuted = Form1Repository.DeleteRegister(Register.Id);

                    if (qtdExecuted > 0)
                        MessageBox.Show("registro deletado com sucesso...!");
                    else
                        throw new Exception($"Nenhum registro encontrado com o id: {Register.Id}");

                    ExibirDados();
                    LimparDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    ExibirDados();
                    LimparDados();
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para deletar");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidpesquisa.Text))
            {
                ExibirDados();
                
                return;
            }

            try
            {
                var register = Form1Repository.GetRegisterById(int.Parse(txtidpesquisa.Text));

                dataGridView1.DataSource = register;
                
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
        }

        private void novobutton_Load(object sender, EventArgs e)
        {

        }

        private void editar_Click(object sender, EventArgs e)
        {
            PassarDadosForm();
        }
    }
}
