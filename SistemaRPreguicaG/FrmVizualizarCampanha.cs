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
    public partial class FrmVizualizarCampanha : Form
    {
        private int IdCampanha;
        private string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";

        public FrmVizualizarCampanha(int idCampanha)
        {
            InitializeComponent();
            IdCampanha = idCampanha;
        }

        private void FrmVizualizarCampanha_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // PERSONAGENS
                    using (SqlDataAdapter daPersonagens = new SqlDataAdapter(
                        "SELECT * FROM Personagens WHERE Id_Campanha = @IdCampanha AND Estado_Atual = 'Ativa'", con))
                    {
                        daPersonagens.SelectCommand.Parameters.Add("@IdCampanha", SqlDbType.Int).Value = IdCampanha;
                        DataTable dtPersonagens = new DataTable();
                        daPersonagens.Fill(dtPersonagens);
                        DgvPersonagens.DataSource = dtPersonagens;
                    }

                    // MONSTROS
                    using (SqlDataAdapter daMonstros = new SqlDataAdapter(
                        "SELECT * FROM Monstros WHERE Id_Campanha = @IdCampanha AND Estado_Atual = 'Ativa'", con))
                    {
                        daMonstros.SelectCommand.Parameters.Add("@IdCampanha", SqlDbType.Int).Value = IdCampanha;
                        DataTable dtMonstros = new DataTable();
                        daMonstros.Fill(dtMonstros);
                        DgvMonstros.DataSource = dtMonstros;
                    }

                    // NPCs
                    using (SqlDataAdapter daNPCs = new SqlDataAdapter(
                        "SELECT * FROM NPCs WHERE Id_Campanha = @IdCampanha AND Estado_Atual = 'Ativa'", con))
                    {
                        daNPCs.SelectCommand.Parameters.Add("@IdCampanha", SqlDbType.Int).Value = IdCampanha;
                        DataTable dtNPCs = new DataTable();
                        daNPCs.Fill(dtNPCs);
                        DgvNPCs.DataSource = dtNPCs;
                    }

                    // SESSÕES
                    using (SqlDataAdapter daSessoes = new SqlDataAdapter(
                        "SELECT * FROM SessoesRPG WHERE Id_Campanha = @IdCampanha AND Estado_Atual = 'Ativa'", con))
                    {
                        daSessoes.SelectCommand.Parameters.Add("@IdCampanha", SqlDbType.Int).Value = IdCampanha;
                        DataTable dtSessoes = new DataTable();
                        daSessoes.Fill(dtSessoes);
                        DgvSessoes.DataSource = dtSessoes;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados da campanha: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InativarRegistro(string tabela, int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = $"UPDATE {tabela} SET Estado_Atual = 'Inativa' WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inativar registro em {tabela}: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnInativarPersonagem_Click(object sender, EventArgs e)
        {
            if (DgvPersonagens.CurrentRow != null)
            {
                int id = Convert.ToInt32(DgvPersonagens.CurrentRow.Cells["Id"].Value);
                InativarRegistro("Personagens", id);
                MessageBox.Show("Personagem inativado com sucesso!");
                CarregarDados();
            }
            else
            {
                MessageBox.Show("Selecione um personagem para inativar.");
            }
        }

        private void BtnInativarMonstro_Click(object sender, EventArgs e)
        {
            if (DgvMonstros.CurrentRow != null)
            {
                int id = Convert.ToInt32(DgvMonstros.CurrentRow.Cells["Id"].Value);
                InativarRegistro("Monstros", id);
                MessageBox.Show("Monstro inativado com sucesso!");
                CarregarDados();
            }
            else
            {
                MessageBox.Show("Selecione um monstro para inativar.");
            }
        }

        private void BtnInativarNPC_Click(object sender, EventArgs e)
        {
            if (DgvNPCs.CurrentRow != null)
            {
                int id = Convert.ToInt32(DgvNPCs.CurrentRow.Cells["Id"].Value);
                InativarRegistro("NPCs", id);
                MessageBox.Show("NPC inativado com sucesso!");
                CarregarDados();
            }
            else
            {
                MessageBox.Show("Selecione um NPC para inativar.");
            }
        }

        private void BtnInativarSessao_Click(object sender, EventArgs e)
        {
            if (DgvSessoes.CurrentRow != null)
            {
                int id = Convert.ToInt32(DgvSessoes.CurrentRow.Cells["Id"].Value);
                InativarRegistro("SessoesRPG", id);
                MessageBox.Show("Sessão inativada com sucesso!");
                CarregarDados();
            }
            else
            {
                MessageBox.Show("Selecione uma sessão para inativar.");
            }
        }

        private void DgvMonstros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mantido propositalmente vazio
        }
    }
}