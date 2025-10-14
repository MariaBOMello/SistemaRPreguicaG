using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRPreguicaG
{
    public partial class FrmTelaLogin : Form
    {
        public FrmTelaLogin()
        {
            InitializeComponent();
        }

         
        



        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (email == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT Id, Email FROM Usuarios WHERE Email=@Email AND Senha=@Senha";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idUsuario = reader.GetInt32(0);
                            string emailUsuario = reader.GetString(1);

                            // Abre a tela inicial passando os dados do usuário
                            FrmTelaInicial telaInicial = new FrmTelaInicial(idUsuario, emailUsuario);
                            telaInicial.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("E-mail ou senha incorretos!");
                        }
                    }
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmTelaCadastro cadastro = new FrmTelaCadastro();
            cadastro.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
