﻿using System;
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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cklb_Permissoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            if (txtbSenha.Text == txtSenhaConf.Text & txtEmail.Text == txtConfEmail.Text)
            {

                string addUser = "INSERT INTO Contas (Nome, Senha, Email) VALUES ('" + TxtNomeUser.Text + "', '" + txtbSenha + "', '" + txtEmail.Text + "')";

                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fabio.pastorio\OneDrive - SENAC - SC\Documentos\GitHub\EstoqueV1\EstoqueV1\Db_Estoques.mdf;Integrated Security=True;Connect Timeout=30");

                SqlCommand cmd = new SqlCommand(addUser, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
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
            else
            {       
                MessageBox.Show("Os dados dos campos de confirmação (senha/e-mail) não correspondem com a primeira digitação. Tente novamente.");
            }
        }

        private void txtbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaConf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
