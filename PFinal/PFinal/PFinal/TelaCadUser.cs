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
    public partial class TelaCadUser : Form
    {
        public TelaCadUser()
        {
            InitializeComponent();
        }

        private void usuárioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuárioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tDataSet);

        }

        private void TelaCadUser_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tDataSet.Usuário'. Você pode movê-la ou removê-la conforme necessário.
            this.usuárioTableAdapter.Fill(this.tDataSet.Usuário);

        }
    }
}
