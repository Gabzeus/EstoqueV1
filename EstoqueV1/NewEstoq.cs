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
    public partial class NewEstoq : Form
    {
        public NewEstoq()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zeus\source\repos\EstoqueV1\EstoqueV1\Db_Estoques.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewEstoq_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {            
            string criarTabCategoria = "CREATE TABLE IF NOT EXISTS Categorias (idcategoria INT NOT NULL, nome VARCHAR(45) NULL DEFAULT NULL, PRIMARY KEY(idcategoria))";

            cmd = new SqlCommand(criarTabCategoria, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            string criarTabProduto = "CREATE TABLE IF NOT EXISTS 'Produtos' ('idproduto' INT NOT NULL, 'nome' VARCHAR(45) NULL DEFAULT NULL, 'quantidade' INT NULL DEFAULT NULL, 'dataEntrada' DATE NULL DEFAULT NULL, 'dataValidade' DATE NULL DEFAULT NULL, 'valor' INT NULL, 'QtdMáxima' INT NULL, 'QtdMínima' INT NULL, PRIMARY KEY('idproduto'))";

            cmd = new SqlCommand(criarTabProduto, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            string criarTabProdutoCat = "CREATE TABLE IF NOT EXISTS 'Produtos_por_Categoria' ('produto_idproduto' INT NOT NULL, 'categoria_idcategoria' INT NOT NULL, PRIMARY KEY('produto_idproduto', 'categoria_idcategoria'), INDEX 'fk_produto_has_categoria_categoria1_idx' ('categoria_idcategoria' ASC) VISIBLE, INDEX 'fk_produto_has_categoria_produto_idx' ('produto_idproduto' ASC) VISIBLE, CONSTRAINT 'fk_produto_has_categoria_categoria1' FOREIGN KEY('categoria_idcategoria') REFERENCES 'estoque'.'categoria' ('idcategoria'), CONSTRAINT 'fk_produto_has_categoria_produto' FOREIGN KEY('produto_idproduto')";

            cmd = new SqlCommand(criarTabProdutoCat, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            string criarEstoque = $"CREATE TABLE IF NOT EXISTS {txtNome.Text} (``idestoque` INT NOT NULL, `nome` VARCHAR(45) NULL DEFAULT NULL, `produto_has_categoria_produto_idproduto` INT NOT NULL, `produto_has_categoria_categoria_idcategoria` INT NOT NULL, PRIMARY KEY(`idestoque`), INDEX `fk_estoque_produto_has_categoria1_idx` (`produto_has_categoria_produto_idproduto` ASC, `produto_has_categoria_categoria_idcategoria` ASC) VISIBLE, CONSTRAINT `fk_estoque_produto_has_categoria1` FOREIGN KEY(`produto_has_categoria_produto_idproduto` , `produto_has_categoria_categoria_idcategoria`)";

            cmd = new SqlCommand(criarEstoque, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
