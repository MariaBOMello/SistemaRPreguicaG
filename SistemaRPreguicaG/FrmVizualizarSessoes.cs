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
    public partial class FrmVizualizarSessoes : Form
    {
        private int idCampanha;
        private string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";

        public FrmVizualizarSessoes(int idCampanha)
        {
            InitializeComponent();
            this.idCampanha = idCampanha;
            this.Text = "Sessões da Campanha";
            CarregarSessoes();
        }

        private void CarregarSessoes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT 
                                    Id,
                                    DataInicio,
                                    DataFim,
                                    Observacoes
                                    FROM SessoesRPG 
                                    WHERE Id_Campanha = @IdCampanha 
                                    AND Estado_Atual = 'Ativa'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdCampanha", idCampanha);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DgvSessoes.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar sessões: " + ex.Message, "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnInativarSessao_Click(object sender, EventArgs e)
        {
            if (DgvSessoes.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma sessão para inativar.", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idSessao = Convert.ToInt32(DgvSessoes.CurrentRow.Cells[0].Value);
                DateTime dataSessao = Convert.ToDateTime(DgvSessoes.CurrentRow.Cells[1].Value);

                var resultado = MessageBox.Show($"Inativar a sessão de {dataSessao:dd/MM/yyyy}?",
                                              "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "UPDATE SessoesRPG SET Estado_Atual = 'Inativa' WHERE Id = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", idSessao);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("✅ Sessão inativada!", "Sucesso",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarSessoes();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVizualizarSessoes_Load(object sender, EventArgs e)
        {
            // COMENTAR se tiver esta linha:
            // this.sessoesRPGTableAdapter.Fill(this.rPGdbDataSet21.SessoesRPG);
        }

    }

}