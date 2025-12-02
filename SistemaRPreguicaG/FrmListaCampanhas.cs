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
    public partial class FrmListaCampanhas : Form
    {
        private List<Campanha> campanhas = new List<Campanha>();
        private int usuarioLogadoId;
        private string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";

        public FrmListaCampanhas(int idUsuario)
        {
            InitializeComponent();
            usuarioLogadoId = idUsuario;
            CarregarCampanhas();
        }

        public void CarregarCampanhas()
        {
            campanhas.Clear();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT Id, Nome, NexBase, NumeroJogadores 
                                     FROM Campanhas_Unificada 
                                     WHERE IdUsuario=@IdUsuario AND Estado_Atual = 'Ativa'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdUsuario", usuarioLogadoId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Campanha c = new Campanha
                                {
                                    Id = reader.GetInt32(0),
                                    Nome = reader.GetString(1),
                                    NexBase = reader.GetInt32(2),
                                    NumeroJogadores = reader.GetInt32(3)
                                };
                                campanhas.Add(c);
                            }
                        }
                    }
                }

                DgvListaCampanhas.DataSource = null;
                DgvListaCampanhas.DataSource = campanhas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar campanhas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSelecionarCampanha_Click(object sender, EventArgs e)
        {
            if (DgvListaCampanhas.CurrentRow != null)
            {
                int idCampanha = Convert.ToInt32(DgvListaCampanhas.CurrentRow.Cells[0].Value);
                FrmDadosCampanha frmDados = new FrmDadosCampanha(idCampanha);
                frmDados.ShowDialog();
                CarregarCampanhas();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma Campanha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnVizualizarCampanha_Click(object sender, EventArgs e)
        {
            if (DgvListaCampanhas.CurrentRow != null)
            {
                int idCampanha = Convert.ToInt32(DgvListaCampanhas.CurrentRow.Cells[0].Value);
                string nomeCampanha = DgvListaCampanhas.CurrentRow.Cells[1].Value.ToString();

                FrmMenuCampanha frmMenu = new FrmMenuCampanha(idCampanha, nomeCampanha);
                frmMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma Campanha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnInativarCampanha_Click(object sender, EventArgs e)
        {
            if (DgvListaCampanhas.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma campanha para inativar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idCampanha = Convert.ToInt32(DgvListaCampanhas.CurrentRow.Cells[0].Value);
                string nomeCampanha = DgvListaCampanhas.CurrentRow.Cells[1].Value.ToString();

                var resultado = MessageBox.Show($"Inativar a campanha '{nomeCampanha}'?",
                                              "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "UPDATE Campanhas_Unificada SET Estado_Atual = 'Inativa' WHERE Id = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", idCampanha);
                            int linhasAfetadas = cmd.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("✅ Campanha inativada!", "Sucesso",
                                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CarregarCampanhas();
                            }
                            else
                            {
                                MessageBox.Show("Campanha não encontrada.", "Aviso",
                                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGerenciarPersonagens_Click(object sender, EventArgs e)
        {
            if (DgvListaCampanhas.CurrentRow != null)
            {
                int idCampanha = Convert.ToInt32(DgvListaCampanhas.CurrentRow.Cells[0].Value);
                FrmPersonagens frmPersonagens = new FrmPersonagens(usuarioLogadoId, idCampanha);
                frmPersonagens.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma Campanha primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Método vazio
        }

        private void DgvListaCampanhas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Método vazio
        }

        private void FrmListaCampanhas_Load(object sender, EventArgs e)
        {
            // COMENTAR se tiver estas linhas:
            // this.campanhas_UnificadaTableAdapter.Fill(this.rPGdbDataSet25.Campanhas_Unificada);
            // this.campanhas_NovaTableAdapter.Fill(this.rPGdbDataSet23.Campanhas_Nova);
        }
    }
}