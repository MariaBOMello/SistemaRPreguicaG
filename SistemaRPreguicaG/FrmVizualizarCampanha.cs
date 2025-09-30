using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // TODO: esta linha de código carrega dados na tabela 'rPGdbDataSet11.NPCs'. Você pode movê-la ou removê-la conforme necessário.
            this.nPCsTableAdapter.Fill(this.rPGdbDataSet11.NPCs);
            // TODO: esta linha de código carrega dados na tabela 'rPGdbDataSet10.Monstros'. Você pode movê-la ou removê-la conforme necessário.
            this.monstrosTableAdapter.Fill(this.rPGdbDataSet10.Monstros);
            // TODO: esta linha de código carrega dados na tabela 'rPGdbDataSet9.SessoesRPG'. Você pode movê-la ou removê-la conforme necessário.
            this.sessoesRPGTableAdapter.Fill(this.rPGdbDataSet9.SessoesRPG);
            // TODO: esta linha de código carrega dados na tabela 'rPGdbDataSet8.Personagens'. Você pode movê-la ou removê-la conforme necessário.
            this.personagensTableAdapter.Fill(this.rPGdbDataSet8.Personagens);
            // TODO: esta linha de código carrega dados na tabela 'rPGdbDataSet5.Campanhas_Nova'. Você pode movê-la ou removê-la conforme necessário.
            this.campanhas_NovaTableAdapter.Fill(this.rPGdbDataSet5.Campanhas_Nova);

        }

        private void DgvMonstros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
