
namespace PFinal
{
    partial class TelaCadStatus
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
            System.Windows.Forms.Label idStatusLabel;
            System.Windows.Forms.Label descriçãoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadStatus));
            this.statusBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idStatusLabel1 = new System.Windows.Forms.Label();
            this.descriçãoTextBox = new System.Windows.Forms.TextBox();
            this.statusDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tDataSet = new PFinal.TDataSet();
            this.statusTableAdapter = new PFinal.TDataSetTableAdapters.StatusTableAdapter();
            this.tableAdapterManager = new PFinal.TDataSetTableAdapters.TableAdapterManager();
            idStatusLabel = new System.Windows.Forms.Label();
            descriçãoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingNavigator)).BeginInit();
            this.statusBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idStatusLabel
            // 
            idStatusLabel.AutoSize = true;
            idStatusLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idStatusLabel.Location = new System.Drawing.Point(11, 41);
            idStatusLabel.Name = "idStatusLabel";
            idStatusLabel.Size = new System.Drawing.Size(72, 18);
            idStatusLabel.TabIndex = 1;
            idStatusLabel.Text = "CÓDIGO:";
            // 
            // descriçãoLabel
            // 
            descriçãoLabel.AutoSize = true;
            descriçãoLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriçãoLabel.Location = new System.Drawing.Point(11, 70);
            descriçãoLabel.Name = "descriçãoLabel";
            descriçãoLabel.Size = new System.Drawing.Size(100, 18);
            descriçãoLabel.TabIndex = 3;
            descriçãoLabel.Text = "DESCRIÇÃO:";
            // 
            // statusBindingNavigator
            // 
            this.statusBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.statusBindingNavigator.BackColor = System.Drawing.Color.White;
            this.statusBindingNavigator.BindingSource = this.statusBindingSource;
            this.statusBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.statusBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.statusBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.statusBindingNavigatorSaveItem});
            this.statusBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.statusBindingNavigator.MoveFirstItem = null;
            this.statusBindingNavigator.MoveLastItem = null;
            this.statusBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.statusBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.statusBindingNavigator.Name = "statusBindingNavigator";
            this.statusBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.statusBindingNavigator.Size = new System.Drawing.Size(705, 27);
            this.statusBindingNavigator.TabIndex = 0;
            this.statusBindingNavigator.Text = "bindingNavigator1";
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
            // statusBindingNavigatorSaveItem
            // 
            this.statusBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statusBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("statusBindingNavigatorSaveItem.Image")));
            this.statusBindingNavigatorSaveItem.Name = "statusBindingNavigatorSaveItem";
            this.statusBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.statusBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.statusBindingNavigatorSaveItem.Click += new System.EventHandler(this.statusBindingNavigatorSaveItem_Click);
            // 
            // idStatusLabel1
            // 
            this.idStatusLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "IdStatus", true));
            this.idStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idStatusLabel1.Location = new System.Drawing.Point(145, 42);
            this.idStatusLabel1.Name = "idStatusLabel1";
            this.idStatusLabel1.Size = new System.Drawing.Size(135, 23);
            this.idStatusLabel1.TabIndex = 2;
            // 
            // descriçãoTextBox
            // 
            this.descriçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Descrição", true));
            this.descriçãoTextBox.Location = new System.Drawing.Point(145, 68);
            this.descriçãoTextBox.Name = "descriçãoTextBox";
            this.descriçãoTextBox.Size = new System.Drawing.Size(135, 22);
            this.descriçãoTextBox.TabIndex = 4;
            // 
            // statusDataGridView
            // 
            this.statusDataGridView.AutoGenerateColumns = false;
            this.statusDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.statusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.statusDataGridView.DataSource = this.statusBindingSource;
            this.statusDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusDataGridView.Location = new System.Drawing.Point(353, 41);
            this.statusDataGridView.Name = "statusDataGridView";
            this.statusDataGridView.RowHeadersWidth = 51;
            this.statusDataGridView.RowTemplate.Height = 24;
            this.statusDataGridView.Size = new System.Drawing.Size(326, 222);
            this.statusDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdStatus";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdStatus";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descrição";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.tDataSet;
            // 
            // tDataSet
            // 
            this.tDataSet.DataSetName = "TDataSet";
            this.tDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StatusTableAdapter = this.statusTableAdapter;
            this.tableAdapterManager.TarefaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PFinal.TDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuárioTableAdapter = null;
            // 
            // TelaCadStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 292);
            this.Controls.Add(this.statusDataGridView);
            this.Controls.Add(idStatusLabel);
            this.Controls.Add(this.idStatusLabel1);
            this.Controls.Add(descriçãoLabel);
            this.Controls.Add(this.descriçãoTextBox);
            this.Controls.Add(this.statusBindingNavigator);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaCadStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE STATUS";
            this.Load += new System.EventHandler(this.TelaCadStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingNavigator)).EndInit();
            this.statusBindingNavigator.ResumeLayout(false);
            this.statusBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TDataSet tDataSet;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private TDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private TDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator statusBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton statusBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idStatusLabel1;
        private System.Windows.Forms.TextBox descriçãoTextBox;
        private System.Windows.Forms.DataGridView statusDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}