
namespace EstoqueV1
{
    partial class CatCadastro
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
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtgvDadosCad = new System.Windows.Forms.DataGridView();
            this.ColumNomeCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumQtdCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumValorCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosCad)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(414, 36);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.ReadOnly = true;
            this.TxtValor.Size = new System.Drawing.Size(32, 20);
            this.TxtValor.TabIndex = 0;
            this.TxtValor.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(27, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(104, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(411, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Valor";
            this.lblId.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(309, 309);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(12, 309);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(297, 36);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(36, 20);
            this.txtQtd.TabIndex = 2;
            this.txtQtd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(24, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantidade";
            // 
            // DtgvDadosCad
            // 
            this.DtgvDadosCad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDadosCad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumNomeCad,
            this.ColumCateg,
            this.ColumQtdCad,
            this.ColumValorCad});
            this.DtgvDadosCad.Location = new System.Drawing.Point(27, 62);
            this.DtgvDadosCad.Name = "DtgvDadosCad";
            this.DtgvDadosCad.Size = new System.Drawing.Size(444, 241);
            this.DtgvDadosCad.TabIndex = 7;
            // 
            // ColumNomeCad
            // 
            this.ColumNomeCad.HeaderText = "Nome";
            this.ColumNomeCad.Name = "ColumNomeCad";
            // 
            // ColumCateg
            // 
            this.ColumCateg.HeaderText = "Categoria";
            this.ColumCateg.Name = "ColumCateg";
            // 
            // ColumQtdCad
            // 
            this.ColumQtdCad.HeaderText = "Quantidade";
            this.ColumQtdCad.Name = "ColumQtdCad";
            // 
            // ColumValorCad
            // 
            this.ColumValorCad.HeaderText = "Valor";
            this.ColumValorCad.Name = "ColumValorCad";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(156, 20);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(159, 36);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 9;
            // 
            // CatCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 358);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.DtgvDadosCad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.lblNome);
            this.Name = "CatCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CatCadastro";
            this.Load += new System.EventHandler(this.CatCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosCad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DtgvDadosCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNomeCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumQtdCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumValorCad;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
    }
}