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
    public partial class TelaCadTarefa : Form
    {
        public TelaCadTarefa()
        {
            InitializeComponent();
        }

        private void tarefaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tarefaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tDataSet);

        }

        private void TelaCadTarefa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tDataSet.Status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.tDataSet.Status);
            // TODO: esta linha de código carrega dados na tabela 'tDataSet.Usuário'. Você pode movê-la ou removê-la conforme necessário.
            this.usuárioTableAdapter.Fill(this.tDataSet.Usuário);
            // TODO: esta linha de código carrega dados na tabela 'tDataSet.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.tDataSet.Tarefa);

        }

        private void fkUsuárioLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
