using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueV1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnNewDadosUser_Click(object sender, EventArgs e)
        {
            ControladorUser UserAdmin = new ControladorUser();
            UserAdmin.ShowDialog();
        }

        private void BtnCategoriaNova_Click(object sender, EventArgs e)
        {
            ProdutoCadastro CadTela = new ProdutoCadastro();
            CadTela.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewEstoq cadEstoq = new NewEstoq();
            cadEstoq.ShowDialog();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnExcluirUser_Click(object sender, EventArgs e)
        {
            ControladorUser UserAdmin = new ControladorUser();
            UserAdmin.ShowDialog();
        }

        private void BtnExcluirEstoq_Click(object sender, EventArgs e)
        {
          

        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            AddUser addconta = new AddUser();
            addconta.ShowDialog();

        }

        private void btnSaidaItem_Click(object sender, EventArgs e)
        {
            ControladorSaida controlSaida = new ControladorSaida();
            controlSaida.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarExcluir edit = new EditarExcluir();
            edit.ShowDialog();

        }

        private void BtnExcluirCad_Click_1(object sender, EventArgs e)
        {
            EditarExcluir edit = new EditarExcluir();
            edit.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditEstoq_Click(object sender, EventArgs e)
        {

        }

        private void BtnAttEstoq_Click(object sender, EventArgs e)
        {

        }

        private void BtnAtualizarCad_Click(object sender, EventArgs e)
        {
            ControladorEntrada control = new ControladorEntrada();
            control.ShowDialog();
        }

        private void TabCadItem_Click(object sender, EventArgs e)
        {

        }
    }
}
