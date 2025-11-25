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
    public partial class FrmVizualizarMonstros : Form
    {
        private int idCampanha;
        private string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";

        public FrmVizualizarMonstros(int idCampanha)
        {
            InitializeComponent();
            this.idCampanha = idCampanha;
            this.Text = "🐉 MONSTROS - TERRITÓRIO OBSCURO";
            CarregarMonstros();
        }

        private void CarregarMonstros()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT 
                                    Id_Monstro,
                                    Nome,
                                    VD,
                                    PV,
                                    Defesa,
                                    Observacoes
                                    FROM Monstros 
                                    WHERE Id_Campanha = @IdCampanha 
                                    AND Estado_Atual = 'Ativa'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdCampanha", idCampanha);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DgvMonstros.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar monstros: " + ex.Message, "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnInativarMonstro_Click(object sender, EventArgs e)
        {
            if (DgvMonstros.CurrentRow == null)
            {
                MessageBox.Show("Selecione um monstro para inativar.", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idMonstro = Convert.ToInt32(DgvMonstros.CurrentRow.Cells["Id_Monstro"].Value);
            string nomeMonstro = DgvMonstros.CurrentRow.Cells["Nome"].Value.ToString();

            var resultado = MessageBox.Show($"Tem certeza que deseja inativar o monstro '{nomeMonstro}'?",
                                          "Confirmação",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "UPDATE Monstros SET Estado_Atual = 'Inativa' WHERE Id_Monstro = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", idMonstro);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Monstro inativado com sucesso!", "Sucesso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarMonstros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inativar monstro: " + ex.Message, "Erro",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ✅ ADICIONE ESTE MÉTODO SE FALTAR
        private void FrmVizualizarMonstros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rPGdbDataSet24.Monstros'. Você pode movê-la ou removê-la conforme necessário.
            this.monstrosTableAdapter.Fill(this.rPGdbDataSet24.Monstros);
            // Pode ficar vazio ou adicionar inicializações extras
        }
    }
}