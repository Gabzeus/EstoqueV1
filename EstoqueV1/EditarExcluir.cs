using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EstoqueV1
{
    public partial class EditarExcluir : Form
    {
        public EditarExcluir()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Usuário\Desktop\TrabalhosMestrado\PROGRAMAÇÃO\GitHub\EstoqueV1\EstoqueV1\Db_Estoques.mdf;Integrated Security=True;Connect Timeout=30");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

<<<<<<< Updated upstream
        private void EditarExcluir_Load(object sender, EventArgs e)
        {

=======
        private void btnEditar_Click(object sender, EventArgs e)
        {


            // FAZER AS CONDICIONAIS - editar só os campos preenchidos




            string editaProduto = "UPDATE INTO Produtos (Nome, Categoria, Estoque) VALUES ()";


            SqlCommand cmd = new SqlCommand(editaProduto, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Produto alterado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void EditarExcluir_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_EstoquesDataSet1.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtosTableAdapter.Fill(this.db_EstoquesDataSet1.Produtos);


            SqlDataAdapter da;
            BindingSource bsource = new BindingSource();
            DataSet ds = null;
            string carregaProdutos;
        
            carregaProdutos = "SELECT IdProduto, Nome, Categoria, Estoque, Fornecedor FROM Produtos";
            da = new SqlDataAdapter(carregaProdutos, conn);
            conn.Open();
            ds = new DataSet();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            da.Fill(ds, "Produtos");
            bsource.DataSource = ds.Tables["Produtos"];
            DtgvDadosEstoque.DataSource = bsource;
            conn.Close();
>>>>>>> Stashed changes
        }
    }
}
