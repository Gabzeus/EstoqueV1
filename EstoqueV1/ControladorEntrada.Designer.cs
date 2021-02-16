
namespace EstoqueV1
{
    partial class ControladorEntrada
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.DtgvDadosCad = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.ColumNomeCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumQtdCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumValorCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosCad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quantidade";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(140, 40);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(59, 20);
            this.txtQtd.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(104, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Nome";
            // 
            // DtgvDadosCad
            // 
            this.DtgvDadosCad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDadosCad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumNomeCad,
            this.ColumQtdCad,
            this.ColumValorCad,
            this.Data_entrada});
            this.DtgvDadosCad.Location = new System.Drawing.Point(20, 66);
            this.DtgvDadosCad.Name = "DtgvDadosCad";
            this.DtgvDadosCad.Size = new System.Drawing.Size(444, 241);
            this.DtgvDadosCad.TabIndex = 21;
            this.DtgvDadosCad.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(35, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(332, 321);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(241, 24);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 24;
            this.lblValor.Text = "Valor";
            this.lblValor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(329, 24);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(84, 13);
            this.lblDataEntrada.TabIndex = 25;
            this.lblDataEntrada.Text = "Data de entrada";
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(332, 40);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtDataEntrada.TabIndex = 3;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(244, 40);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(47, 20);
            this.txtValor.TabIndex = 2;
            // 
            // ColumNomeCad
            // 
            this.ColumNomeCad.HeaderText = "Nome do produto";
            this.ColumNomeCad.Name = "ColumNomeCad";
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
            // Data_entrada
            // 
            this.Data_entrada.HeaderText = "Data de entrada";
            this.Data_entrada.Name = "Data_entrada";
            // 
            // ControladorEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 356);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.DtgvDadosCad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "ControladorEntrada";
            this.Text = "Entrada de produto";
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosCad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView DtgvDadosCad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNomeCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumQtdCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumValorCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_entrada;
    }
}