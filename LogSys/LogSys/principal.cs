using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogSys
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void principal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'logSysDataSet.list_user'. Você pode movê-la ou removê-la conforme necessário.
            this.list_userTableAdapter.Fill(this.logSysDataSet.list_user);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.list_userTableAdapter.FillBy(this.logSysDataSet.list_user);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pesquisaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.list_userTableAdapter.Pesquisa(this.logSysDataSet.list_user);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
