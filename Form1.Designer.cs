
namespace CadastroWindownsForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dgvdataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textIdade = new System.Windows.Forms.TextBox();
            this.textFuncao = new System.Windows.Forms.TextBox();
            this.textSalario = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FuncionarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioFuncao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Função";
            // 
            // dgvdataGridView
            // 
            this.dgvdataGridView.AllowUserToDeleteRows = false;
            this.dgvdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FuncionarioId,
            this.FuncionarioNome,
            this.FuncionarioIdade,
            this.FuncionarioFuncao,
            this.FuncionarioSalario,
            this.FuncionarioCidade,
            this.FuncionarioBairro,
            this.FuncionarioEndereco});
            this.dgvdataGridView.Location = new System.Drawing.Point(306, 24);
            this.dgvdataGridView.Name = "dgvdataGridView";
            this.dgvdataGridView.ReadOnly = true;
            this.dgvdataGridView.Size = new System.Drawing.Size(751, 363);
            this.dgvdataGridView.TabIndex = 3;
            this.dgvdataGridView.DoubleClick += new System.EventHandler(this.dgvdataGridView_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salario";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(77, 24);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(154, 20);
            this.textNome.TabIndex = 5;
            // 
            // textIdade
            // 
            this.textIdade.Location = new System.Drawing.Point(77, 61);
            this.textIdade.Name = "textIdade";
            this.textIdade.Size = new System.Drawing.Size(154, 20);
            this.textIdade.TabIndex = 6;
            // 
            // textFuncao
            // 
            this.textFuncao.Location = new System.Drawing.Point(77, 103);
            this.textFuncao.Name = "textFuncao";
            this.textFuncao.Size = new System.Drawing.Size(154, 20);
            this.textFuncao.TabIndex = 7;
            // 
            // textSalario
            // 
            this.textSalario.Location = new System.Drawing.Point(77, 143);
            this.textSalario.Name = "textSalario";
            this.textSalario.Size = new System.Drawing.Size(154, 20);
            this.textSalario.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(204, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(106, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(77, 255);
            this.textEndereco.Multiline = true;
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(154, 56);
            this.textEndereco.TabIndex = 16;
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(77, 181);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(154, 20);
            this.textCidade.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cidade";
            // 
            // textBairro
            // 
            this.textBairro.Location = new System.Drawing.Point(77, 218);
            this.textBairro.Name = "textBairro";
            this.textBairro.Size = new System.Drawing.Size(154, 20);
            this.textBairro.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Bairro";
            // 
            // FuncionarioId
            // 
            this.FuncionarioId.DataPropertyName = "FuncionarioId";
            this.FuncionarioId.Frozen = true;
            this.FuncionarioId.HeaderText = "ID";
            this.FuncionarioId.MinimumWidth = 6;
            this.FuncionarioId.Name = "FuncionarioId";
            this.FuncionarioId.ReadOnly = true;
            this.FuncionarioId.Width = 46;
            // 
            // FuncionarioNome
            // 
            this.FuncionarioNome.DataPropertyName = "FuncionarioNome";
            this.FuncionarioNome.Frozen = true;
            this.FuncionarioNome.HeaderText = "Nome";
            this.FuncionarioNome.Name = "FuncionarioNome";
            this.FuncionarioNome.ReadOnly = true;
            this.FuncionarioNome.Width = 110;
            // 
            // FuncionarioIdade
            // 
            this.FuncionarioIdade.DataPropertyName = "FuncionarioIdade";
            this.FuncionarioIdade.Frozen = true;
            this.FuncionarioIdade.HeaderText = "Idade";
            this.FuncionarioIdade.Name = "FuncionarioIdade";
            this.FuncionarioIdade.ReadOnly = true;
            this.FuncionarioIdade.Width = 50;
            // 
            // FuncionarioFuncao
            // 
            this.FuncionarioFuncao.DataPropertyName = "FuncionarioFuncao";
            this.FuncionarioFuncao.Frozen = true;
            this.FuncionarioFuncao.HeaderText = "Função";
            this.FuncionarioFuncao.Name = "FuncionarioFuncao";
            this.FuncionarioFuncao.ReadOnly = true;
            // 
            // FuncionarioSalario
            // 
            this.FuncionarioSalario.DataPropertyName = "FuncionarioSalario";
            this.FuncionarioSalario.Frozen = true;
            this.FuncionarioSalario.HeaderText = "Salario";
            this.FuncionarioSalario.Name = "FuncionarioSalario";
            this.FuncionarioSalario.ReadOnly = true;
            this.FuncionarioSalario.Width = 80;
            // 
            // FuncionarioCidade
            // 
            this.FuncionarioCidade.DataPropertyName = "FuncionarioCidade";
            this.FuncionarioCidade.Frozen = true;
            this.FuncionarioCidade.HeaderText = "Cidade";
            this.FuncionarioCidade.Name = "FuncionarioCidade";
            this.FuncionarioCidade.ReadOnly = true;
            // 
            // FuncionarioBairro
            // 
            this.FuncionarioBairro.DataPropertyName = "FuncionarioBairro";
            this.FuncionarioBairro.Frozen = true;
            this.FuncionarioBairro.HeaderText = "Bairro";
            this.FuncionarioBairro.Name = "FuncionarioBairro";
            this.FuncionarioBairro.ReadOnly = true;
            // 
            // FuncionarioEndereco
            // 
            this.FuncionarioEndereco.DataPropertyName = "FuncionarioEndereco";
            this.FuncionarioEndereco.Frozen = true;
            this.FuncionarioEndereco.HeaderText = "Endereço";
            this.FuncionarioEndereco.Name = "FuncionarioEndereco";
            this.FuncionarioEndereco.ReadOnly = true;
            this.FuncionarioEndereco.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 414);
            this.Controls.Add(this.textBairro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textSalario);
            this.Controls.Add(this.textFuncao);
            this.Controls.Add(this.textIdade);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvdataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Funcionario ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvdataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textIdade;
        private System.Windows.Forms.TextBox textFuncao;
        private System.Windows.Forms.TextBox textSalario;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionarioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionarioNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionarioIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionarioFuncao;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionarioSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionarioCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionarioBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionarioEndereco;
        private System.Windows.Forms.TextBox textBairro;
        private System.Windows.Forms.Label label7;
    }
}

