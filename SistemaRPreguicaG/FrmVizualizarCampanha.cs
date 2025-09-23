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
            // TODO: esta linha de código carrega dados na tabela 'rPGdbDataSet5.Campanhas_Nova'. Você pode movê-la ou removê-la conforme necessário.
            this.campanhas_NovaTableAdapter.Fill(this.rPGdbDataSet5.Campanhas_Nova);

        }
    }
}
