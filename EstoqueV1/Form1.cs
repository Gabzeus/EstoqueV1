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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "Admin" & txtSenha.Text == "Admin")
                { MessageBox.Show("Bem vindo");
                  
                    this.Hide();
                    Form2 ViewCad = new Form2();
                    ViewCad.Closed += (s, args) => this.Close();
                    ViewCad.Show();

                }
                else
                { MessageBox.Show("Tente novamente"); }
            }
            catch (Exception)
            {

                throw;
            }

           

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
