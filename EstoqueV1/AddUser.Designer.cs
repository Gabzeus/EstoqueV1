
namespace EstoqueV1
{
    partial class AddUser
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
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtbSenha = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtSenhaConf = new System.Windows.Forms.TextBox();
            this.TxtNomeUser = new System.Windows.Forms.TextBox();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.lblConfirme = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(46, 77);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(92, 13);
            this.lblSenha.TabIndex = 24;
            this.lblSenha.Text = "Digite uma senha:";
            this.lblSenha.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbSenha
            // 
            this.txtbSenha.Location = new System.Drawing.Point(144, 77);
            this.txtbSenha.Name = "txtbSenha";
            this.txtbSenha.PasswordChar = '*';
            this.txtbSenha.Size = new System.Drawing.Size(181, 20);
            this.txtbSenha.TabIndex = 20;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(250, 155);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(144, 155);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(-16, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "Id";
            // 
            // txtSenhaConf
            // 
            this.txtSenhaConf.Location = new System.Drawing.Point(144, 110);
            this.txtSenhaConf.Name = "txtSenhaConf";
            this.txtSenhaConf.PasswordChar = '*';
            this.txtSenhaConf.Size = new System.Drawing.Size(181, 20);
            this.txtSenhaConf.TabIndex = 19;
            // 
            // TxtNomeUser
            // 
            this.TxtNomeUser.Location = new System.Drawing.Point(144, 46);
            this.TxtNomeUser.Name = "TxtNomeUser";
            this.TxtNomeUser.ReadOnly = true;
            this.TxtNomeUser.Size = new System.Drawing.Size(181, 20);
            this.TxtNomeUser.TabIndex = 16;
            this.TxtNomeUser.TabStop = false;
            this.TxtNomeUser.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.AutoSize = true;
            this.lblNomeUser.Location = new System.Drawing.Point(48, 46);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(90, 13);
            this.lblNomeUser.TabIndex = 17;
            this.lblNomeUser.Text = "Nome do usuario:";
            // 
            // lblConfirme
            // 
            this.lblConfirme.AutoSize = true;
            this.lblConfirme.Location = new System.Drawing.Point(46, 113);
            this.lblConfirme.Name = "lblConfirme";
            this.lblConfirme.Size = new System.Drawing.Size(92, 13);
            this.lblConfirme.TabIndex = 25;
            this.lblConfirme.Text = "Confirme a senha:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Funcionario"});
            this.checkedListBox1.Location = new System.Drawing.Point(331, 48);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 49);
            this.checkedListBox1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Função";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 190);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lblConfirme);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtbSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtSenhaConf);
            this.Controls.Add(this.TxtNomeUser);
            this.Controls.Add(this.lblNomeUser);
            this.Name = "AddUser";
            this.Text = "Novo usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtbSenha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtSenhaConf;
        private System.Windows.Forms.TextBox TxtNomeUser;
        private System.Windows.Forms.Label lblNomeUser;
        private System.Windows.Forms.Label lblConfirme;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
    }
}