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
        public FrmCriarCampanha()
        {
            InitializeComponent();
        }

        private void BtnSalvarNovaCampanha_Click(object sender, EventArgs e)
        {
            string nome = TxtNomeCampanha.Text;
            int nexBase = int.Parse(TxtNexBaseJogadores.Text);
            int numeroJogadores = int.Parse(TxtNumeroJogadores.Text);

            // Aqui você coloca a string de conexão
            string connectionString = @"Server=localhost;Database=RPGdb;Trusted_Connection=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "INSERT INTO Campanhas (Nome, NexBase, NumeroJogadores) VALUES (@Nome, @NexBase, @NumeroJogadores)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@NexBase", nexBase);
                    cmd.Parameters.AddWithValue("@NumeroJogadores", numeroJogadores);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Campanha salva no banco com sucesso!");

            TxtNomeCampanha.Clear();
            TxtNexBaseJogadores.Clear();
            TxtNumeroJogadores.Clear();
        }
    }
