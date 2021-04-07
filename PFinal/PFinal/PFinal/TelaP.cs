using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFinal
{
    public partial class TelaP : Form
    {
        public TelaP()
        {
            InitializeComponent();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCadStatus cadStatus = new TelaCadStatus();
            cadStatus.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaCadTarefa cadTarefa = new TelaCadTarefa();
            cadTarefa.ShowDialog();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TelaCadUser cadUser = new TelaCadUser();
            cadUser.ShowDialog();
        }

        private void tarefaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.selectQueryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tDataSet);

        }

        private void TelaP_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tDataSet.SelectQuery'. Você pode movê-la ou removê-la conforme necessário.
            this.selectQueryTableAdapter.Fill(this.tDataSet.SelectQuery);

        }

        private void arquivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.selectQueryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tDataSet);
            this.selectQueryTableAdapter.Fill(this.tDataSet.SelectQuery);
        }
    }
}
