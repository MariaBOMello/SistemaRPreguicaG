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

        public FrmListaCampanhas()
        {
            InitializeComponent();
            CarregarCampanhas();  // chama o método ao abrir a janela
        }

        public void CarregarCampanhas()
        {
            string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";
            campanhas.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Alterei apenas o nome da tabela para Campanhas_Nova e incluí o Id
                string query = "SELECT Id, Nome, NexBase, NumeroJogadores FROM Campanhas_Nova";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Campanha c = new Campanha
                        {
                            Id = reader.GetInt32(0),          // adicionando o Id
                            Nome = reader.GetString(1),
                            NexBase = reader.GetInt32(2),
                            NumeroJogadores = reader.GetInt32(3)
                        };

                        campanhas.Add(c);
                    }
                }
            }
        }

        private void FrmListaCampanhas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rPGdbDataSet1.Campanhas_Nova'. Você pode movê-la ou removê-la conforme necessário.
            this.campanhas_NovaTableAdapter.Fill(this.rPGdbDataSet1.Campanhas_Nova);
            // Comentado ou atualizado conforme necessidade, pois a tabela antiga não existe
            // this.campanhasTableAdapter.Fill(this.rPGdbDataSet.Campanhas);
        }

        private void BtnSelecionarCampanha_Click(object sender, EventArgs e)
        {
            if (DgvListaCampanhas.SelectedRows != null)
            {
                // Usa o Id da tabela nova
                FrmDadosCampanha frmDados = new FrmDadosCampanha(
                    Convert.ToInt32(DgvListaCampanhas.CurrentRow.Cells[0].Value)
                );
                frmDados.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma Campanha.");
            }
        }

        private void DgvListaCampanhas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnExcluirCampanha_Click(object sender, EventArgs e)
        {
            if (DgvListaCampanhas.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha para excluir.");
                return;
            }

            int id = Convert.ToInt32(DgvListaCampanhas.CurrentRow.Cells["Id"].Value);

            string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string queryDelete = "DELETE FROM SuaTabela WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            // Remove do DataGridView
            DgvListaCampanhas.Rows.Remove(DgvListaCampanhas.CurrentRow);

            MessageBox.Show("Campanha apagada com sucesso!");
        }

        private void BtnVizualizarCampanha_Click(object sender, EventArgs e)
        {
            if (DgvListaCampanhas.SelectedRows != null && DgvListaCampanhas.CurrentRow != null)
            {
                // Pega o Id da campanha selecionada
                int idCampanha = Convert.ToInt32(DgvListaCampanhas.CurrentRow.Cells[0].Value);

                // Abre a janela de visualização, passando o Id
                FrmVizualizarCampanha frmVisualizar = new FrmVizualizarCampanha(idCampanha);
                frmVisualizar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma Campanha.");
            }
        }
    }
}