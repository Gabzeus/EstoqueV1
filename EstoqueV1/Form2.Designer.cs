
namespace EstoqueV1
{
    partial class Form2
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
            this.DtgvDadosCad = new System.Windows.Forms.DataGridView();
            this.BtnCategoriaNova = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.TabCadItem = new System.Windows.Forms.TabPage();
            this.btnSaidaItem = new System.Windows.Forms.Button();
            this.BtnAtualizarCad = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnExcluirCad = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnAttEstoq = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnExcluirEstoq = new System.Windows.Forms.Button();
            this.DtgvDadosEstoque = new System.Windows.Forms.DataGridView();
            this.ColumIdEstoq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTipoEstoq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumNomeEstoq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditEstoq = new System.Windows.Forms.Button();
            this.BtnEstoqNew = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.BtnExcluirUser = new System.Windows.Forms.Button();
            this.DtgvDadosUser = new System.Windows.Forms.DataGridView();
            this.BtnNewDadosUser = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnSaldo = new System.Windows.Forms.Button();
            this.BtnCheckQtd = new System.Windows.Forms.Button();
            this.BtnAttGrafico = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_EstoquesDataSet1 = new EstoqueV1.Db_EstoquesDataSet1();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new EstoqueV1.Db_EstoquesDataSet1TableAdapters.ProdutosTableAdapter();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsávelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdMinimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdMaximaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosCad)).BeginInit();
            this.TabMenu.SuspendLayout();
            this.TabCadItem.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosEstoque)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosUser)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_EstoquesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgvDadosCad
            // 
            this.DtgvDadosCad.AllowUserToAddRows = false;
            this.DtgvDadosCad.AllowUserToDeleteRows = false;
            this.DtgvDadosCad.AllowUserToOrderColumns = true;
            this.DtgvDadosCad.AutoGenerateColumns = false;
            this.DtgvDadosCad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDadosCad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.dataEntradaDataGridViewTextBoxColumn,
            this.dataValidadeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.responsávelDataGridViewTextBoxColumn,
            this.qtdMinimaDataGridViewTextBoxColumn,
            this.qtdMaximaDataGridViewTextBoxColumn});
            this.DtgvDadosCad.DataSource = this.produtosBindingSource;
            this.DtgvDadosCad.Location = new System.Drawing.Point(171, 73);
            this.DtgvDadosCad.Name = "DtgvDadosCad";
            this.DtgvDadosCad.ReadOnly = true;
            this.DtgvDadosCad.Size = new System.Drawing.Size(409, 241);
            this.DtgvDadosCad.TabIndex = 0;
            this.DtgvDadosCad.TabStop = false;
            this.DtgvDadosCad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnCategoriaNova
            // 
            this.BtnCategoriaNova.Location = new System.Drawing.Point(626, 73);
            this.BtnCategoriaNova.Name = "BtnCategoriaNova";
            this.BtnCategoriaNova.Size = new System.Drawing.Size(131, 23);
<<<<<<< Updated upstream
            this.BtnCategoriaNova.TabIndex = 2;
            this.BtnCategoriaNova.Text = "&Cadastrar item";
=======
            this.BtnCategoriaNova.TabIndex = 0;
            this.BtnCategoriaNova.Text = "&Cadastrar produto";
>>>>>>> Stashed changes
            this.BtnCategoriaNova.UseVisualStyleBackColor = true;
            this.BtnCategoriaNova.Click += new System.EventHandler(this.BtnCategoriaNova_Click);
            // 
            // btnEditar
            // 
<<<<<<< Updated upstream
            this.btnEditar.Location = new System.Drawing.Point(626, 204);
=======
            this.btnEditar.Location = new System.Drawing.Point(18, 132);
>>>>>>> Stashed changes
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(131, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "&Editar ";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.TabCadItem);
            this.TabMenu.Controls.Add(this.tabPage2);
            this.TabMenu.Controls.Add(this.tabPage1);
            this.TabMenu.Controls.Add(this.tabPage3);
            this.TabMenu.Location = new System.Drawing.Point(12, 12);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(984, 573);
            this.TabMenu.TabIndex = 4;
            // 
            // TabCadItem
            // 
            this.TabCadItem.Controls.Add(this.btnSaidaItem);
            this.TabCadItem.Controls.Add(this.BtnAtualizarCad);
            this.TabCadItem.Controls.Add(this.button2);
            this.TabCadItem.Controls.Add(this.BtnExcluirCad);
            this.TabCadItem.Controls.Add(this.DtgvDadosCad);
            this.TabCadItem.Controls.Add(this.btnEditar);
            this.TabCadItem.Controls.Add(this.BtnCategoriaNova);
            this.TabCadItem.Location = new System.Drawing.Point(4, 22);
            this.TabCadItem.Name = "TabCadItem";
            this.TabCadItem.Padding = new System.Windows.Forms.Padding(3);
            this.TabCadItem.Size = new System.Drawing.Size(976, 547);
            this.TabCadItem.TabIndex = 0;
            this.TabCadItem.Text = "Produtos";
            this.TabCadItem.UseVisualStyleBackColor = true;
            this.TabCadItem.Click += new System.EventHandler(this.TabCadItem_Click);
            // 
            // btnSaidaItem
            // 
<<<<<<< Updated upstream
            this.btnSaidaItem.Location = new System.Drawing.Point(30, 151);
=======
            this.btnSaidaItem.Location = new System.Drawing.Point(630, 85);
>>>>>>> Stashed changes
            this.btnSaidaItem.Name = "btnSaidaItem";
            this.btnSaidaItem.Size = new System.Drawing.Size(131, 23);
            this.btnSaidaItem.TabIndex = 1;
            this.btnSaidaItem.Text = "&Saida de item";
            this.btnSaidaItem.UseVisualStyleBackColor = true;
            this.btnSaidaItem.Click += new System.EventHandler(this.btnSaidaItem_Click);
            // 
            // BtnAtualizarCad
            // 
            this.BtnAtualizarCad.Location = new System.Drawing.Point(30, 73);
            this.BtnAtualizarCad.Name = "BtnAtualizarCad";
            this.BtnAtualizarCad.Size = new System.Drawing.Size(131, 23);
            this.BtnAtualizarCad.TabIndex = 0;
            this.BtnAtualizarCad.Text = "&Adicionar item";
            this.BtnAtualizarCad.UseVisualStyleBackColor = true;
            this.BtnAtualizarCad.Click += new System.EventHandler(this.BtnAtualizarCad_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Confirmar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnExcluirCad
            // 
            this.BtnExcluirCad.Location = new System.Drawing.Point(626, 151);
            this.BtnExcluirCad.Name = "BtnExcluirCad";
            this.BtnExcluirCad.Size = new System.Drawing.Size(131, 23);
            this.BtnExcluirCad.TabIndex = 3;
            this.BtnExcluirCad.Text = "&Excluir";
            this.BtnExcluirCad.UseVisualStyleBackColor = true;
            this.BtnExcluirCad.Click += new System.EventHandler(this.BtnExcluirCad_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnAttEstoq);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.BtnExcluirEstoq);
            this.tabPage2.Controls.Add(this.DtgvDadosEstoque);
            this.tabPage2.Controls.Add(this.BtnEditEstoq);
            this.tabPage2.Controls.Add(this.BtnEstoqNew);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edição de Estoque";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnAttEstoq
            // 
            this.BtnAttEstoq.Location = new System.Drawing.Point(18, 283);
            this.BtnAttEstoq.Name = "BtnAttEstoq";
            this.BtnAttEstoq.Size = new System.Drawing.Size(131, 26);
            this.BtnAttEstoq.TabIndex = 3;
            this.BtnAttEstoq.Text = "&Atualizar Estoque";
            this.BtnAttEstoq.UseVisualStyleBackColor = true;
            this.BtnAttEstoq.Click += new System.EventHandler(this.BtnAttEstoq_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(527, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "&Confirmar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnExcluirEstoq
            // 
            this.BtnExcluirEstoq.Location = new System.Drawing.Point(18, 212);
            this.BtnExcluirEstoq.Name = "BtnExcluirEstoq";
            this.BtnExcluirEstoq.Size = new System.Drawing.Size(131, 23);
            this.BtnExcluirEstoq.TabIndex = 2;
            this.BtnExcluirEstoq.Text = "&Excluir";
            this.BtnExcluirEstoq.UseVisualStyleBackColor = true;
            this.BtnExcluirEstoq.Click += new System.EventHandler(this.BtnExcluirEstoq_Click);
            // 
            // DtgvDadosEstoque
            // 
            this.DtgvDadosEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDadosEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumIdEstoq,
            this.ColumTipoEstoq,
            this.ColumNomeEstoq});
            this.DtgvDadosEstoque.Location = new System.Drawing.Point(175, 68);
            this.DtgvDadosEstoque.Name = "DtgvDadosEstoque";
            this.DtgvDadosEstoque.Size = new System.Drawing.Size(430, 241);
            this.DtgvDadosEstoque.TabIndex = 6;
            this.DtgvDadosEstoque.TabStop = false;
            // 
            // ColumIdEstoq
            // 
            this.ColumIdEstoq.HeaderText = "Id";
            this.ColumIdEstoq.Name = "ColumIdEstoq";
            // 
            // ColumTipoEstoq
            // 
            this.ColumTipoEstoq.HeaderText = "Tipo de estoque";
            this.ColumTipoEstoq.Name = "ColumTipoEstoq";
            // 
            // ColumNomeEstoq
            // 
            this.ColumNomeEstoq.HeaderText = "Nome do estoque";
            this.ColumNomeEstoq.Name = "ColumNomeEstoq";
            // 
            // BtnEditEstoq
            // 
            this.BtnEditEstoq.Location = new System.Drawing.Point(18, 135);
            this.BtnEditEstoq.Name = "BtnEditEstoq";
            this.BtnEditEstoq.Size = new System.Drawing.Size(131, 23);
            this.BtnEditEstoq.TabIndex = 1;
            this.BtnEditEstoq.Text = "&Editar ";
            this.BtnEditEstoq.UseVisualStyleBackColor = true;
            this.BtnEditEstoq.Click += new System.EventHandler(this.BtnEditEstoq_Click);
            // 
            // BtnEstoqNew
            // 
            this.BtnEstoqNew.Location = new System.Drawing.Point(18, 68);
            this.BtnEstoqNew.Name = "BtnEstoqNew";
            this.BtnEstoqNew.Size = new System.Drawing.Size(131, 23);
            this.BtnEstoqNew.TabIndex = 0;
            this.BtnEstoqNew.Text = "&Estoque novo";
            this.BtnEstoqNew.UseVisualStyleBackColor = true;
            this.BtnEstoqNew.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnAddUser);
            this.tabPage1.Controls.Add(this.BtnExcluirUser);
            this.tabPage1.Controls.Add(this.DtgvDadosUser);
            this.tabPage1.Controls.Add(this.BtnNewDadosUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 547);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Configuração de conta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(18, 169);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(131, 23);
            this.BtnAddUser.TabIndex = 2;
            this.BtnAddUser.Text = "&Adicionar usuario";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // BtnExcluirUser
            // 
            this.BtnExcluirUser.Location = new System.Drawing.Point(18, 112);
            this.BtnExcluirUser.Name = "BtnExcluirUser";
            this.BtnExcluirUser.Size = new System.Drawing.Size(131, 23);
            this.BtnExcluirUser.TabIndex = 1;
            this.BtnExcluirUser.Text = "&Excluir";
            this.BtnExcluirUser.UseVisualStyleBackColor = true;
            this.BtnExcluirUser.Click += new System.EventHandler(this.BtnExcluirUser_Click);
            // 
            // DtgvDadosUser
            // 
            this.DtgvDadosUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDadosUser.Location = new System.Drawing.Point(171, 34);
            this.DtgvDadosUser.Name = "DtgvDadosUser";
            this.DtgvDadosUser.Size = new System.Drawing.Size(357, 241);
            this.DtgvDadosUser.TabIndex = 6;
            this.DtgvDadosUser.TabStop = false;
            this.DtgvDadosUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // BtnNewDadosUser
            // 
            this.BtnNewDadosUser.Location = new System.Drawing.Point(18, 56);
            this.BtnNewDadosUser.Name = "BtnNewDadosUser";
            this.BtnNewDadosUser.Size = new System.Drawing.Size(131, 23);
            this.BtnNewDadosUser.TabIndex = 0;
            this.BtnNewDadosUser.Text = "&Alterar dados ";
            this.BtnNewDadosUser.UseVisualStyleBackColor = true;
            this.BtnNewDadosUser.Click += new System.EventHandler(this.BtnNewDadosUser_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BtnSaldo);
            this.tabPage3.Controls.Add(this.BtnCheckQtd);
            this.tabPage3.Controls.Add(this.BtnAttGrafico);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 547);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Rotinas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnSaldo
            // 
            this.BtnSaldo.Location = new System.Drawing.Point(18, 199);
            this.BtnSaldo.Name = "BtnSaldo";
            this.BtnSaldo.Size = new System.Drawing.Size(131, 26);
            this.BtnSaldo.TabIndex = 2;
            this.BtnSaldo.Text = "&Saldo";
            this.BtnSaldo.UseVisualStyleBackColor = true;
            // 
            // BtnCheckQtd
            // 
            this.BtnCheckQtd.Location = new System.Drawing.Point(18, 111);
            this.BtnCheckQtd.Name = "BtnCheckQtd";
            this.BtnCheckQtd.Size = new System.Drawing.Size(139, 39);
            this.BtnCheckQtd.TabIndex = 1;
            this.BtnCheckQtd.Text = "&Verificar quantidade de produto";
            this.BtnCheckQtd.UseVisualStyleBackColor = true;
            // 
            // BtnAttGrafico
            // 
            this.BtnAttGrafico.Location = new System.Drawing.Point(18, 45);
            this.BtnAttGrafico.Name = "BtnAttGrafico";
            this.BtnAttGrafico.Size = new System.Drawing.Size(139, 23);
            this.BtnAttGrafico.TabIndex = 0;
            this.BtnAttGrafico.Text = "&Atualizar grafico";
            this.BtnAttGrafico.UseVisualStyleBackColor = true;
            // 
            // db_EstoquesDataSet1
            // 
            this.db_EstoquesDataSet1.DataSetName = "Db_EstoquesDataSet1";
            this.db_EstoquesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.db_EstoquesDataSet1;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
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
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataEntradaDataGridViewTextBoxColumn
            // 
            this.dataEntradaDataGridViewTextBoxColumn.DataPropertyName = "DataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.HeaderText = "DataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.Name = "dataEntradaDataGridViewTextBoxColumn";
            this.dataEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataValidadeDataGridViewTextBoxColumn
            // 
            this.dataValidadeDataGridViewTextBoxColumn.DataPropertyName = "DataValidade";
            this.dataValidadeDataGridViewTextBoxColumn.HeaderText = "DataValidade";
            this.dataValidadeDataGridViewTextBoxColumn.Name = "dataValidadeDataGridViewTextBoxColumn";
            this.dataValidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responsávelDataGridViewTextBoxColumn
            // 
            this.responsávelDataGridViewTextBoxColumn.DataPropertyName = "Responsável";
            this.responsávelDataGridViewTextBoxColumn.HeaderText = "Responsável";
            this.responsávelDataGridViewTextBoxColumn.Name = "responsávelDataGridViewTextBoxColumn";
            this.responsávelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtdMinimaDataGridViewTextBoxColumn
            // 
            this.qtdMinimaDataGridViewTextBoxColumn.DataPropertyName = "QtdMinima";
            this.qtdMinimaDataGridViewTextBoxColumn.HeaderText = "QtdMinima";
            this.qtdMinimaDataGridViewTextBoxColumn.Name = "qtdMinimaDataGridViewTextBoxColumn";
            this.qtdMinimaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtdMaximaDataGridViewTextBoxColumn
            // 
            this.qtdMaximaDataGridViewTextBoxColumn.DataPropertyName = "QtdMaxima";
            this.qtdMaximaDataGridViewTextBoxColumn.HeaderText = "QtdMaxima";
            this.qtdMaximaDataGridViewTextBoxColumn.Name = "qtdMaximaDataGridViewTextBoxColumn";
            this.qtdMaximaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.TabMenu);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
<<<<<<< Updated upstream
            this.Text = "Menu";
=======
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosCad)).EndInit();
            this.TabMenu.ResumeLayout(false);
            this.TabCadItem.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosEstoque)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosUser)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_EstoquesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgvDadosCad;
        private System.Windows.Forms.Button BtnCategoriaNova;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.TabPage TabCadItem;
        private System.Windows.Forms.Button BtnExcluirCad;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnExcluirEstoq;
        private System.Windows.Forms.DataGridView DtgvDadosEstoque;
        private System.Windows.Forms.Button BtnEditEstoq;
        private System.Windows.Forms.Button BtnEstoqNew;
        private System.Windows.Forms.Button BtnAtualizarCad;
        private System.Windows.Forms.Button BtnAttEstoq;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnExcluirUser;
        private System.Windows.Forms.Button BtnNewDadosUser;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BtnSaldo;
        private System.Windows.Forms.Button BtnCheckQtd;
        private System.Windows.Forms.Button BtnAttGrafico;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Button btnSaidaItem;
        private System.Windows.Forms.DataGridView DtgvDadosUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumIdEstoq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTipoEstoq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNomeEstoq;
        private Db_EstoquesDataSet1 db_EstoquesDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private Db_EstoquesDataSet1TableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsávelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdMinimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdMaximaDataGridViewTextBoxColumn;
    }
}