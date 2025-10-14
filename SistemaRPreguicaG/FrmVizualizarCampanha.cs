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

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Carrega Personagens da campanha
                string queryPersonagens = "SELECT * FROM Personagens WHERE Id_Campanha = @IdCampanha";
                SqlDataAdapter daPersonagens = new SqlDataAdapter(queryPersonagens, con);
                daPersonagens.SelectCommand.Parameters.AddWithValue("@IdCampanha", IdCampanha);
                DataTable dtPersonagens = new DataTable();
                daPersonagens.Fill(dtPersonagens);
                DgvPersonagens.DataSource = dtPersonagens;

                // Carrega Monstros da campanha
                string queryMonstros = "SELECT * FROM Monstros WHERE Id_Campanha = @IdCampanha";
                SqlDataAdapter daMonstros = new SqlDataAdapter(queryMonstros, con);
                daMonstros.SelectCommand.Parameters.AddWithValue("@IdCampanha", IdCampanha);
                DataTable dtMonstros = new DataTable();
                daMonstros.Fill(dtMonstros);
                DgvMonstros.DataSource = dtMonstros;

                // Carrega NPCs da campanha
                string queryNPCs = "SELECT * FROM NPCs WHERE Id_Campanha = @IdCampanha";
                SqlDataAdapter daNPCs = new SqlDataAdapter(queryNPCs, con);
                daNPCs.SelectCommand.Parameters.AddWithValue("@IdCampanha", IdCampanha);
                DataTable dtNPCs = new DataTable();
                daNPCs.Fill(dtNPCs);
                DgvNPCs.DataSource = dtNPCs;

                // Carrega Sessões da campanha
                string querySessoes = "SELECT * FROM SessoesRPG WHERE Id_Campanha = @IdCampanha";
                SqlDataAdapter daSessoes = new SqlDataAdapter(querySessoes, con);
                daSessoes.SelectCommand.Parameters.AddWithValue("@IdCampanha", IdCampanha);
                DataTable dtSessoes = new DataTable();
                daSessoes.Fill(dtSessoes);
                DgvSessoes.DataSource = dtSessoes;
            }
        }

        private void DgvMonstros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pode deixar vazio
        }
    }
}