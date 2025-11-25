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

        public FrmListaCampanhas(int idUsuario)
        {
            InitializeComponent();
            usuarioLogadoId = idUsuario;
            CarregarCampanhas();
        }

        public void CarregarCampanhas()
        {
            string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";
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

        // ✅ BOTÃO CORRIGIDO - Agora abre FrmMenuCampanha
        private void BtnVizualizarCampanha_Click(object sender, EventArgs e)
        {
            if (DgvListaCampanhas.CurrentRow != null)
            {
                int idCampanha = Convert.ToInt32(DgvListaCampanhas.CurrentRow.Cells[0].Value);
                string nomeCampanha = DgvListaCampanhas.CurrentRow.Cells[1].Value.ToString();

                // ✅ AGORA ABRE O MENU DA CAMPANHA
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

            int id = Convert.ToInt32(DgvListaCampanhas.CurrentRow.Cells[0].Value);

            try
            {
                string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string queryUpdate = "UPDATE Campanhas_Unificada SET Estado_Atual = 'Inativa' WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Campanha inativada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarCampanhas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inativar campanha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Método vazio - apenas para resolver o erro
        }

        // ✅ BOTÃO ADICIONADO - Gerenciar Personagens
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

        private void DgvListaCampanhas_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void FrmListaCampanhas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rPGdbDataSet23.Campanhas_Nova'. Você pode movê-la ou removê-la conforme necessário.
            this.campanhas_NovaTableAdapter.Fill(this.rPGdbDataSet23.Campanhas_Nova);

        }
    }
}