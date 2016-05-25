namespace WindowsAppCsharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DataGridViewPessoas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BindingSourcePessoas = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourcePessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewPessoas
            // 
            this.DataGridViewPessoas.AllowUserToAddRows = false;
            this.DataGridViewPessoas.AllowUserToDeleteRows = false;
            this.DataGridViewPessoas.AutoGenerateColumns = false;
            this.DataGridViewPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome});
            this.DataGridViewPessoas.DataSource = this.BindingSourcePessoas;
            this.DataGridViewPessoas.Location = new System.Drawing.Point(12, 21);
            this.DataGridViewPessoas.Name = "DataGridViewPessoas";
            this.DataGridViewPessoas.ReadOnly = true;
            this.DataGridViewPessoas.Size = new System.Drawing.Size(375, 279);
            this.DataGridViewPessoas.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 60;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 250;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(412, 32);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 1;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(412, 59);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(161, 20);
            this.TxtNome.TabIndex = 2;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(519, 32);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(54, 23);
            this.BtnPesquisar.TabIndex = 3;
            this.BtnPesquisar.Text = "...";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(412, 86);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(498, 86);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 5;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 335);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.DataGridViewPessoas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourcePessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewPessoas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.BindingSource BindingSourcePessoas;
    }
}

