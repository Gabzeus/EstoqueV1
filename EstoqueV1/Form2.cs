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
            CatCadastro CadTela = new CatCadastro();
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
            ControladorUser UserAdmin = new ControladorUser();
            UserAdmin.ShowDialog();

        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            AddUser addconta = new AddUser();
            addconta.ShowDialog();

        }
    }
}
