
namespace PFinal
{
    partial class TelaCadTarefa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label descriçãoLabel;
            System.Windows.Forms.Label fkUsuárioLabel;
            System.Windows.Forms.Label fkStatusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadTarefa));
            this.tDataSet = new PFinal.TDataSet();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarefaTableAdapter = new PFinal.TDataSetTableAdapters.TarefaTableAdapter();
            this.tableAdapterManager = new PFinal.TDataSetTableAdapters.TableAdapterManager();
            this.tarefaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tarefaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.descriçãoTextBox = new System.Windows.Forms.TextBox();
            this.fkUsuárioComboBox = new System.Windows.Forms.ComboBox();
            this.usuárioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuárioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fkStatusComboBox = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuárioTableAdapter = new PFinal.TDataSetTableAdapters.UsuárioTableAdapter();
            this.statusTableAdapter = new PFinal.TDataSetTableAdapters.StatusTableAdapter();
            this.usuárioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            descriçãoLabel = new System.Windows.Forms.Label();
            fkUsuárioLabel = new System.Windows.Forms.Label();
            fkStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingNavigator)).BeginInit();
            this.tarefaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuárioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuárioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuárioBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.Color.Black;
            idLabel.Location = new System.Drawing.Point(20, 43);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(30, 18);
            idLabel.TabIndex = 1;
            idLabel.Text = "ID:";
            // 
            // descriçãoLabel
            // 
            descriçãoLabel.AutoSize = true;
            descriçãoLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriçãoLabel.ForeColor = System.Drawing.Color.Black;
            descriçãoLabel.Location = new System.Drawing.Point(20, 98);
            descriçãoLabel.Name = "descriçãoLabel";
            descriçãoLabel.Size = new System.Drawing.Size(100, 18);
            descriçãoLabel.TabIndex = 3;
            descriçãoLabel.Text = "DESCRIÇÃO:";
            // 
            // fkUsuárioLabel
            // 
            fkUsuárioLabel.AutoSize = true;
            fkUsuárioLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fkUsuárioLabel.ForeColor = System.Drawing.Color.Black;
            fkUsuárioLabel.Location = new System.Drawing.Point(20, 148);
            fkUsuárioLabel.Name = "fkUsuárioLabel";
            fkUsuárioLabel.Size = new System.Drawing.Size(84, 18);
            fkUsuárioLabel.TabIndex = 5;
            fkUsuárioLabel.Text = "USUÁRIO:";
            fkUsuárioLabel.Click += new System.EventHandler(this.fkUsuárioLabel_Click);
            // 
            // fkStatusLabel
            // 
            fkStatusLabel.AutoSize = true;
            fkStatusLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fkStatusLabel.ForeColor = System.Drawing.Color.Black;
            fkStatusLabel.Location = new System.Drawing.Point(20, 179);
            fkStatusLabel.Name = "fkStatusLabel";
            fkStatusLabel.Size = new System.Drawing.Size(76, 18);
            fkStatusLabel.TabIndex = 7;
            fkStatusLabel.Text = "STATUS:";
            // 
            // tDataSet
            // 
            this.tDataSet.DataSetName = "TDataSet";
            this.tDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataMember = "Tarefa";
            this.tarefaBindingSource.DataSource = this.tDataSet;
            // 
            // tarefaTableAdapter
            // 
            this.tarefaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TarefaTableAdapter = this.tarefaTableAdapter;
            this.tableAdapterManager.UpdateOrder = PFinal.TDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuárioTableAdapter = null;
            // 
            // tarefaBindingNavigator
            // 
            this.tarefaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tarefaBindingNavigator.BackColor = System.Drawing.Color.White;
            this.tarefaBindingNavigator.BindingSource = this.tarefaBindingSource;
            this.tarefaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tarefaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tarefaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tarefaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tarefaBindingNavigatorSaveItem});
            this.tarefaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tarefaBindingNavigator.MoveFirstItem = null;
            this.tarefaBindingNavigator.MoveLastItem = null;
            this.tarefaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tarefaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tarefaBindingNavigator.Name = "tarefaBindingNavigator";
            this.tarefaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tarefaBindingNavigator.Size = new System.Drawing.Size(384, 27);
            this.tarefaBindingNavigator.TabIndex = 0;
            this.tarefaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tarefaBindingNavigatorSaveItem
            // 
            this.tarefaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tarefaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tarefaBindingNavigatorSaveItem.Image")));
            this.tarefaBindingNavigatorSaveItem.Name = "tarefaBindingNavigatorSaveItem";
            this.tarefaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tarefaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tarefaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tarefaBindingNavigatorSaveItem_Click_1);
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "Id", true));
            this.idLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel1.ForeColor = System.Drawing.Color.Black;
            this.idLabel1.Location = new System.Drawing.Point(146, 43);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(148, 23);
            this.idLabel1.TabIndex = 2;
            // 
            // descriçãoTextBox
            // 
            this.descriçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "Descrição", true));
            this.descriçãoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriçãoTextBox.Location = new System.Drawing.Point(146, 69);
            this.descriçãoTextBox.Multiline = true;
            this.descriçãoTextBox.Name = "descriçãoTextBox";
            this.descriçãoTextBox.Size = new System.Drawing.Size(148, 70);
            this.descriçãoTextBox.TabIndex = 4;
            // 
            // fkUsuárioComboBox
            // 
            this.fkUsuárioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tarefaBindingSource, "FkUsuário", true));
            this.fkUsuárioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuárioBindingSource1, "Nome", true));
            this.fkUsuárioComboBox.DataSource = this.usuárioBindingSource;
            this.fkUsuárioComboBox.DisplayMember = "Nome";
            this.fkUsuárioComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fkUsuárioComboBox.FormattingEnabled = true;
            this.fkUsuárioComboBox.Location = new System.Drawing.Point(146, 146);
            this.fkUsuárioComboBox.Name = "fkUsuárioComboBox";
            this.fkUsuárioComboBox.Size = new System.Drawing.Size(148, 24);
            this.fkUsuárioComboBox.TabIndex = 6;
            this.fkUsuárioComboBox.ValueMember = "Usuário.IdUsuário";
            // 
            // usuárioBindingSource1
            // 
            this.usuárioBindingSource1.DataMember = "Usuário";
            this.usuárioBindingSource1.DataSource = this.tDataSet;
            // 
            // usuárioBindingSource
            // 
            this.usuárioBindingSource.DataMember = "Usuário";
            this.usuárioBindingSource.DataSource = this.tDataSet;
            // 
            // fkStatusComboBox
            // 
            this.fkStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tarefaBindingSource, "FkStatus", true));
            this.fkStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Descrição", true));
            this.fkStatusComboBox.DataSource = this.statusBindingSource;
            this.fkStatusComboBox.DisplayMember = "Descrição";
            this.fkStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fkStatusComboBox.FormattingEnabled = true;
            this.fkStatusComboBox.Location = new System.Drawing.Point(146, 179);
            this.fkStatusComboBox.Name = "fkStatusComboBox";
            this.fkStatusComboBox.Size = new System.Drawing.Size(148, 24);
            this.fkStatusComboBox.TabIndex = 8;
            this.fkStatusComboBox.ValueMember = "IdStatus";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.tDataSet;
            // 
            // tDataSetBindingSource
            // 
            this.tDataSetBindingSource.DataSource = this.tDataSet;
            this.tDataSetBindingSource.Position = 0;
            // 
            // tDataSetBindingSource1
            // 
            this.tDataSetBindingSource1.DataSource = this.tDataSet;
            this.tDataSetBindingSource1.Position = 0;
            // 
            // usuárioTableAdapter
            // 
            this.usuárioTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // usuárioBindingSource2
            // 
            this.usuárioBindingSource2.DataMember = "Usuário";
            this.usuárioBindingSource2.DataSource = this.tDataSet;
            // 
            // TelaCadTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 257);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(descriçãoLabel);
            this.Controls.Add(this.descriçãoTextBox);
            this.Controls.Add(fkUsuárioLabel);
            this.Controls.Add(this.fkUsuárioComboBox);
            this.Controls.Add(fkStatusLabel);
            this.Controls.Add(this.fkStatusComboBox);
            this.Controls.Add(this.tarefaBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaCadTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE TAREFA";
            this.Load += new System.EventHandler(this.TelaCadTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingNavigator)).EndInit();
            this.tarefaBindingNavigator.ResumeLayout(false);
            this.tarefaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuárioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuárioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuárioBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TDataSet tDataSet;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private TDataSetTableAdapters.TarefaTableAdapter tarefaTableAdapter;
        private TDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tarefaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tarefaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox descriçãoTextBox;
        private System.Windows.Forms.ComboBox fkUsuárioComboBox;
        private System.Windows.Forms.ComboBox fkStatusComboBox;
        private System.Windows.Forms.BindingSource tDataSetBindingSource;
        private System.Windows.Forms.BindingSource tDataSetBindingSource1;
        private System.Windows.Forms.BindingSource usuárioBindingSource;
        private TDataSetTableAdapters.UsuárioTableAdapter usuárioTableAdapter;
        private System.Windows.Forms.BindingSource usuárioBindingSource1;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private TDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.BindingSource usuárioBindingSource2;
    }
}