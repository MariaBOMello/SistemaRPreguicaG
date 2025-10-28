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

        public FrmVizualizarCampanha(int idCampanha)
        {
            InitializeComponent();
            IdCampanha = idCampanha;
        }

        private void FrmVizualizarCampanha_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlDataAdapter daPersonagens = new SqlDataAdapter("SELECT * FROM Personagens WHERE Id_Campanha = @IdCampanha", con))
                    {
                        daPersonagens.SelectCommand.Parameters.Add("@IdCampanha", SqlDbType.Int).Value = IdCampanha;
                        DataTable dtPersonagens = new DataTable();
                        daPersonagens.Fill(dtPersonagens);
                        DgvPersonagens.DataSource = dtPersonagens;
                    }

                    using (SqlDataAdapter daMonstros = new SqlDataAdapter("SELECT * FROM Monstros WHERE Id_Campanha = @IdCampanha", con))
                    {
                        daMonstros.SelectCommand.Parameters.Add("@IdCampanha", SqlDbType.Int).Value = IdCampanha;
                        DataTable dtMonstros = new DataTable();
                        daMonstros.Fill(dtMonstros);
                        DgvMonstros.DataSource = dtMonstros;
                    }

                    using (SqlDataAdapter daNPCs = new SqlDataAdapter("SELECT * FROM NPCs WHERE Id_Campanha = @IdCampanha", con))
                    {
                        daNPCs.SelectCommand.Parameters.Add("@IdCampanha", SqlDbType.Int).Value = IdCampanha;
                        DataTable dtNPCs = new DataTable();
                        daNPCs.Fill(dtNPCs);
                        DgvNPCs.DataSource = dtNPCs;
                    }

                    using (SqlDataAdapter daSessoes = new SqlDataAdapter("SELECT * FROM SessoesRPG WHERE Id_Campanha = @IdCampanha", con))
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
                MessageBox.Show("Erro ao carregar os dados da campanha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvMonstros_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}