namespace Crud_Treino
{
    partial class telaprincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.novobutton = new System.Windows.Forms.Button();
            this.reloadbutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.removebutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.txtidpesquisa = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtapelido = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 184);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(636, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // novobutton
            // 
            this.novobutton.Location = new System.Drawing.Point(573, 51);
            this.novobutton.Name = "novobutton";
            this.novobutton.Size = new System.Drawing.Size(75, 23);
            this.novobutton.TabIndex = 1;
            this.novobutton.Text = "NOVO";
            this.novobutton.UseVisualStyleBackColor = true;
            this.novobutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // reloadbutton
            // 
            this.reloadbutton.Location = new System.Drawing.Point(573, 99);
            this.reloadbutton.Name = "reloadbutton";
            this.reloadbutton.Size = new System.Drawing.Size(75, 23);
            this.reloadbutton.TabIndex = 2;
            this.reloadbutton.Text = "SALVAR";
            this.reloadbutton.UseVisualStyleBackColor = true;
            this.reloadbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(573, 123);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 3;
            this.addbutton.Text = "ADCIONAR";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // removebutton
            // 
            this.removebutton.Location = new System.Drawing.Point(573, 147);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(75, 23);
            this.removebutton.TabIndex = 4;
            this.removebutton.Text = "REMOVER";
            this.removebutton.UseVisualStyleBackColor = true;
            this.removebutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(575, 9);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 5;
            this.searchbutton.Text = "PESQUISAR";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtidpesquisa
            // 
            this.txtidpesquisa.Location = new System.Drawing.Point(469, 9);
            this.txtidpesquisa.Name = "txtidpesquisa";
            this.txtidpesquisa.Size = new System.Drawing.Size(100, 20);
            this.txtidpesquisa.TabIndex = 6;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(118, 82);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 7;
            // 
            // txtapelido
            // 
            this.txtapelido.Location = new System.Drawing.Point(118, 118);
            this.txtapelido.Name = "txtapelido";
            this.txtapelido.Size = new System.Drawing.Size(100, 20);
            this.txtapelido.TabIndex = 8;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(342, 118);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(100, 20);
            this.txtsenha.TabIndex = 9;
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(342, 82);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(100, 20);
            this.txtlogin.TabIndex = 11;
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(118, 149);
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(324, 20);
            this.txtobs.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "APELIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "LOGIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "SENHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "OBS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "PESQUISA POR ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "id";
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.Location = new System.Drawing.Point(118, 50);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(0, 13);
            this.txtid.TabIndex = 20;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(118, 50);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 21;
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(573, 75);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 22;
            this.editar.Text = "EDITAR";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // telaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtapelido);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtidpesquisa);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.removebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.reloadbutton);
            this.Controls.Add(this.novobutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "telaprincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.novobutton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button novobutton;
        private System.Windows.Forms.Button reloadbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button removebutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox txtidpesquisa;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtapelido;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtid;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button editar;
    }
}

