
namespace EstoqueV1
{
    partial class Pesquisar
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
            this.rbNomeProduto = new System.Windows.Forms.RadioButton();
            this.rbDatadeEntrda = new System.Windows.Forms.RadioButton();
            this.rbDataSaida = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // rbNomeProduto
            // 
            this.rbNomeProduto.AutoSize = true;
            this.rbNomeProduto.Location = new System.Drawing.Point(24, 21);
            this.rbNomeProduto.Name = "rbNomeProduto";
            this.rbNomeProduto.Size = new System.Drawing.Size(107, 17);
            this.rbNomeProduto.TabIndex = 0;
            this.rbNomeProduto.TabStop = true;
            this.rbNomeProduto.Text = "Nome do produto";
            this.rbNomeProduto.UseVisualStyleBackColor = true;
            // 
            // rbDatadeEntrda
            // 
            this.rbDatadeEntrda.AutoSize = true;
            this.rbDatadeEntrda.Location = new System.Drawing.Point(24, 54);
            this.rbDatadeEntrda.Name = "rbDatadeEntrda";
            this.rbDatadeEntrda.Size = new System.Drawing.Size(102, 17);
            this.rbDatadeEntrda.TabIndex = 1;
            this.rbDatadeEntrda.TabStop = true;
            this.rbDatadeEntrda.Text = "Data de entrada";
            this.rbDatadeEntrda.UseVisualStyleBackColor = true;
            // 
            // rbDataSaida
            // 
            this.rbDataSaida.AutoSize = true;
            this.rbDataSaida.Location = new System.Drawing.Point(24, 88);
            this.rbDataSaida.Name = "rbDataSaida";
            this.rbDataSaida.Size = new System.Drawing.Size(91, 17);
            this.rbDataSaida.TabIndex = 2;
            this.rbDataSaida.TabStop = true;
            this.rbDataSaida.Text = "Data de saida";
            this.rbDataSaida.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(584, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(358, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(536, 236);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(322, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(314, 160);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 270);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.rbDataSaida);
            this.Controls.Add(this.rbDatadeEntrda);
            this.Controls.Add(this.rbNomeProduto);
            this.Name = "Pesquisar";
            this.Text = "Pesquisar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbNomeProduto;
        private System.Windows.Forms.RadioButton rbDatadeEntrda;
        private System.Windows.Forms.RadioButton rbDataSaida;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListView listView1;
    }
}