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
                int idGerado;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "INSERT INTO Campanhas_Unificada (Nome, NexBase, NumeroJogadores, IdUsuario, Estado_Atual) " +
                                   "VALUES (@Nome, @NexBase, @NumeroJogadores, @IdUsuario, 'Ativa'); " +
                                   "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@NexBase", nexBase);
                        cmd.Parameters.AddWithValue("@NumeroJogadores", numeroJogadores);
                        cmd.Parameters.AddWithValue("@IdUsuario", usuarioLogadoId);

                        idGerado = (int)cmd.ExecuteScalar();
                    }
                }

                MessageBox.Show("Campanha criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtNomeCampanha.Clear();
                TxtNexBaseJogadores.Clear();
                TxtNumeroJogadores.Clear();

                FrmDadosCampanha frmDados = new FrmDadosCampanha(idGerado);
                frmDados.ShowDialog();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a campanha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}