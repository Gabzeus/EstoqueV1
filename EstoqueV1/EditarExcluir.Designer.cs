
namespace EstoqueV1
{
    partial class EditarExcluir
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
            this.DtgvDadosEstoque = new System.Windows.Forms.DataGridView();
            this.ColumNomePRod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtEditCat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgvDadosEstoque
            // 
            this.DtgvDadosEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDadosEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumNomePRod,
            this.ColumCateg,
            this.ColumQtd,
            this.ColumValor});
            this.DtgvDadosEstoque.Location = new System.Drawing.Point(23, 78);
            this.DtgvDadosEstoque.Name = "DtgvDadosEstoque";
            this.DtgvDadosEstoque.Size = new System.Drawing.Size(443, 41);
            this.DtgvDadosEstoque.TabIndex = 25;
            this.DtgvDadosEstoque.TabStop = false;
            // 
            // ColumNomePRod
            // 
            this.ColumNomePRod.HeaderText = "Nome";
            this.ColumNomePRod.Name = "ColumNomePRod";
            // 
            // ColumCateg
            // 
            this.ColumCateg.HeaderText = "Categoria";
            this.ColumCateg.Name = "ColumCateg";
            // 
            // ColumQtd
            // 
            this.ColumQtd.HeaderText = "Quantidade";
            this.ColumQtd.Name = "ColumQtd";
            // 
            // ColumValor
            // 
            this.ColumValor.HeaderText = "Valor";
            this.ColumValor.Name = "ColumValor";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(23, 125);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(391, 125);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(181, 36);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 23;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(86, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(73, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(89, 13);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome do produto";
            // 
            // btnExcluir
            // 
            this.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExcluir.Location = new System.Drawing.Point(472, 96);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "&Exlcuir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(301, 52);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(33, 20);
            this.txtQtd.TabIndex = 2;
            this.txtQtd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(391, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(388, 36);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 29;
            this.lblValor.Text = "Valor";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(298, 36);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(62, 13);
            this.lblQtd.TabIndex = 30;
            this.lblQtd.Text = "Quantidade";
            // 
            // btnEditar
            // 
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditar.Location = new System.Drawing.Point(472, 49);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtEditCat
            // 
            this.txtEditCat.Location = new System.Drawing.Point(184, 52);
            this.txtEditCat.Name = "txtEditCat";
            this.txtEditCat.Size = new System.Drawing.Size(86, 20);
            this.txtEditCat.TabIndex = 1;
            // 
            // EditarExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 163);
            this.Controls.Add(this.txtEditCat);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.DtgvDadosEstoque);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "EditarExcluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edição";
            this.Load += new System.EventHandler(this.EditarExcluir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgvDadosEstoque;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNomePRod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumValor;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtEditCat;
    }
}