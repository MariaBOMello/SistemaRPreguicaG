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
    public partial class FrmVizualizarNPCs : Form
    {
        private int idCampanha;
        private string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";

        public FrmVizualizarNPCs(int idCampanha)
        {
            InitializeComponent();
            this.idCampanha = idCampanha;
            this.Text = "NPCs da Campanha";
            CarregarNPCs();
        }

        private void CarregarNPCs()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT 
                                    Id_NPC,
                                    Nome,
                                    Funcao,
                                    Observacoes
                                    FROM NPCs 
                                    WHERE Id_Campanha = @IdCampanha 
                                    AND Estado_Atual = 'Ativa'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdCampanha", idCampanha);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DgvNPCs.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar NPCs: " + ex.Message, "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnInativarNPC_Click(object sender, EventArgs e)
        {
            if (DgvNPCs.CurrentRow == null)
            {
                MessageBox.Show("Selecione um NPC para inativar.", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idNPC = Convert.ToInt32(DgvNPCs.CurrentRow.Cells[0].Value);
            string nomeNPC = DgvNPCs.CurrentRow.Cells[1].Value.ToString();

            var resultado = MessageBox.Show($"Inativar o NPC '{nomeNPC}'?",
                                          "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "UPDATE NPCs SET Estado_Atual = 'Inativa' WHERE Id_NPC = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", idNPC);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("✅ NPC inativado!", "Sucesso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarNPCs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}", "Erro",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVizualizarNPCs_Load(object sender, EventArgs e)
        {
            // COMENTAR se tiver esta linha:
            // this.nPCsTableAdapter.Fill(this.rPGdbDataSet22.NPCs);
        }
    }
}