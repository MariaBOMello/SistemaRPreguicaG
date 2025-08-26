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
                string query = "SELECT Nome, NexBase, NumeroJogadores FROM Campanhas";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Campanha c = new Campanha
                        {
                            Nome = reader.GetString(0),
                            NexBase = reader.GetInt32(1),
                            NumeroJogadores = reader.GetInt32(2)
                        };

                        campanhas.Add(c);
                    }
                }
            }


        }



        private void FrmListaCampanhas_Load(object sender, EventArgs e)
        {
            
            this.campanhasTableAdapter.Fill(this.rPGdbDataSet.Campanhas);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}