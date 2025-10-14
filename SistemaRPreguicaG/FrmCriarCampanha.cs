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
    public partial class FrmCriarCampanha : Form
    {
        private int usuarioLogadoId;

        public FrmCriarCampanha(int idUsuario)
        {
            InitializeComponent();
            usuarioLogadoId = idUsuario;
        }

        private void BtnSalvarNovaCampanha_Click(object sender, EventArgs e)
        {
            // Validação básica
            if (string.IsNullOrWhiteSpace(TxtNomeCampanha.Text) ||
                string.IsNullOrWhiteSpace(TxtNexBaseJogadores.Text) ||
                string.IsNullOrWhiteSpace(TxtNumeroJogadores.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TxtNexBaseJogadores.Text, out int nexBase) ||
                !int.TryParse(TxtNumeroJogadores.Text, out int numeroJogadores))
            {
                MessageBox.Show("NEX Base e Número de Jogadores devem ser números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nome = TxtNomeCampanha.Text.Trim();
            string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Campanhas_Nova (Nome, NexBase, NumeroJogadores, IdUsuario) " +
                                   "VALUES (@Nome, @NexBase, @NumeroJogadores, @IdUsuario)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@NexBase", nexBase);
                        cmd.Parameters.AddWithValue("@NumeroJogadores", numeroJogadores);
                        cmd.Parameters.AddWithValue("@IdUsuario", usuarioLogadoId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Campanha salva no banco com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos
                TxtNomeCampanha.Clear();
                TxtNexBaseJogadores.Clear();
                TxtNumeroJogadores.Clear();

                this.Close(); // fecha a janela
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a campanha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}