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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Usuário\Desktop\Trabalhos - Mestrado\PROGRAMAÇÃO\GitHub\EstoqueV1\EstoqueV1\Db_Estoques.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        public static string loginEmUso = "";
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" & txtSenha.Text == "")
            {
                MessageBox.Show("Bem vindo");

                this.Hide();
                Form2 ViewCad = new Form2();
                ViewCad.Closed += (s, args) => this.Close();
                ViewCad.Show();
            }
            else
            {
                string login = txtUser.Text;
                string senha = txtSenha.Text;
                string selectLogin = $"SELECT * FROM Contas WHERE Login = '{login}' AND Senha = '{senha}'";

                cmd = new SqlCommand(selectLogin, conn);
                conn.Open();
                try
                {
                    var autenticaLogin = cmd.ExecuteScalar();
                    if (autenticaLogin != null)
                    {
                        loginEmUso = login;

                        MessageBox.Show("Bem vindo");

                        this.Hide();
                        Form2 ViewCad = new Form2();
                        ViewCad.Closed += (s, args) => this.Close();
                        ViewCad.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tente novamente");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            
           
             
        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        public static string LoginEmUso()
        {
            return loginEmUso;
        }
    }
}
