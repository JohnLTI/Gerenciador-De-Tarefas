﻿using System;
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
    public partial class TelaCadStatus : Form
    {
        public TelaCadStatus()
        {
            InitializeComponent();
        }

        private void statusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tDataSet);
            this.statusTableAdapter.Fill(this.tDataSet.Status);

        }

        private void TelaCadStatus_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tDataSet.Status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.tDataSet.Status);

        }
    }
}
