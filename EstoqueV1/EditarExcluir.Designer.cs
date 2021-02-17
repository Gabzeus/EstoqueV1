
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
            this.components = new System.ComponentModel.Container();
            this.DtgvDadosEstoque = new System.Windows.Forms.DataGridView();
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
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEstoquesDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_EstoquesDataSet1 = new EstoqueV1.Db_EstoquesDataSet1();
            this.produtosTableAdapter = new EstoqueV1.Db_EstoquesDataSet1TableAdapters.ProdutosTableAdapter();
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoquesDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_EstoquesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgvDadosEstoque
            // 
            this.DtgvDadosEstoque.AllowUserToAddRows = false;
            this.DtgvDadosEstoque.AllowUserToDeleteRows = false;
            this.DtgvDadosEstoque.AllowUserToOrderColumns = true;
            this.DtgvDadosEstoque.AutoGenerateColumns = false;
            this.DtgvDadosEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDadosEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn});
            this.DtgvDadosEstoque.DataSource = this.produtosBindingSource1;
            this.DtgvDadosEstoque.Location = new System.Drawing.Point(23, 78);
            this.DtgvDadosEstoque.Name = "DtgvDadosEstoque";
            this.DtgvDadosEstoque.ReadOnly = true;
            this.DtgvDadosEstoque.Size = new System.Drawing.Size(443, 78);
            this.DtgvDadosEstoque.TabIndex = 25;
            this.DtgvDadosEstoque.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(23, 172);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(391, 172);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(149, 33);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 23;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(41, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(86, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(38, 33);
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
            this.txtQtd.Location = new System.Drawing.Point(264, 49);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(83, 20);
            this.txtQtd.TabIndex = 2;
            this.txtQtd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(364, 33);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 13);
            this.lblValor.TabIndex = 29;
            this.lblValor.Text = "Estoque";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(261, 33);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(61, 13);
            this.lblQtd.TabIndex = 30;
            this.lblQtd.Text = "Fornecedor";
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtEditCat
            // 
            this.txtEditCat.Location = new System.Drawing.Point(152, 49);
            this.txtEditCat.Name = "txtEditCat";
            this.txtEditCat.Size = new System.Drawing.Size(86, 20);
            this.txtEditCat.TabIndex = 1;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.dbEstoquesDataSet1BindingSource;
            // 
            // dbEstoquesDataSet1BindingSource
            // 
            this.dbEstoquesDataSet1BindingSource.DataSource = this.db_EstoquesDataSet1;
            this.dbEstoquesDataSet1BindingSource.Position = 0;
            // 
            // db_EstoquesDataSet1
            // 
            this.db_EstoquesDataSet1.DataSetName = "Db_EstoquesDataSet1";
            this.db_EstoquesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "Produtos";
            this.produtosBindingSource1.DataSource = this.db_EstoquesDataSet1;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            this.fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            this.fornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            this.estoqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditarExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 246);
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
<<<<<<< Updated upstream
            this.Text = "Edição";
=======
            this.Text = "EditarExcluir";
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            this.Load += new System.EventHandler(this.EditarExcluir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoquesDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_EstoquesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
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
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtEditCat;
        private System.Windows.Forms.BindingSource dbEstoquesDataSet1BindingSource;
        private Db_EstoquesDataSet1 db_EstoquesDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private Db_EstoquesDataSet1TableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource produtosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
    }
}