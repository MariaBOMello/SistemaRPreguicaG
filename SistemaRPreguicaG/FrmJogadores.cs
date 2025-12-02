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
    public partial class FrmJogadores : Form
    {
        private int usuarioLogadoId;
        private string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";

        public FrmJogadores(int idUsuario)
        {
            InitializeComponent();
            usuarioLogadoId = idUsuario;
            CarregarComboBox();
        }

        private void CarregarComboBox()
        {
            CbxExperiencia.Items.AddRange(new string[] {
                "Iniciante", "Intermediário", "Experiente", "Mestre"
            });
        }

        

        private void LimparCampos()
        {
            TxtNome.Clear();
            TxtEmail.Clear();
            TxtTelefone.Clear();
            CbxExperiencia.SelectedIndex = -1;
            DtpDataNascimento.Value = DateTime.Today;
            DtpDataNascimento.Checked = false;
        }
        private void FrmJogadores_Load(object sender, EventArgs e)
        {
            // Pode ficar vazio
        }

        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            string nome = TxtNome.Text.Trim();
            string email = TxtEmail.Text.Trim();
            string telefone = TxtTelefone.Text.Trim();
            string experiencia = CbxExperiencia.Text;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O nome do jogador é obrigatório!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime? dataNascimento = null;
            if (DtpDataNascimento.Checked)
            {
                dataNascimento = DtpDataNascimento.Value;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"INSERT INTO Jogadores 
                                    (Nome, Email, Telefone, DataNascimento, ExperienciaRPG, Id_Usuario, Estado_Atual)
                                    VALUES (@Nome, @Email, @Telefone, @DataNascimento, @ExperienciaRPG, @IdUsuario, 'Ativo')";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                        cmd.Parameters.AddWithValue("@Telefone", string.IsNullOrEmpty(telefone) ? (object)DBNull.Value : telefone);
                        cmd.Parameters.AddWithValue("@DataNascimento", dataNascimento.HasValue ? (object)dataNascimento.Value : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@ExperienciaRPG", string.IsNullOrEmpty(experiencia) ? (object)DBNull.Value : experiencia);
                        cmd.Parameters.AddWithValue("@IdUsuario", usuarioLogadoId);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Jogador cadastrado com sucesso!", "Sucesso",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampos();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar jogador: " + ex.Message, "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}