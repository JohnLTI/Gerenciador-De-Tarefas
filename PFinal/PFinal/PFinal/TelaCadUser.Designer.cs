
namespace PFinal
{
    partial class TelaCadUser
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
            System.Windows.Forms.Label idUsuárioLabel;
            System.Windows.Forms.Label nomeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadUser));
            this.tDataSet = new PFinal.TDataSet();
            this.usuárioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuárioTableAdapter = new PFinal.TDataSetTableAdapters.UsuárioTableAdapter();
            this.tableAdapterManager = new PFinal.TDataSetTableAdapters.TableAdapterManager();
            this.usuárioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usuárioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idUsuárioLabel1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.usuárioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idUsuárioLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuárioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuárioBindingNavigator)).BeginInit();
            this.usuárioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuárioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idUsuárioLabel
            // 
            idUsuárioLabel.AutoSize = true;
            idUsuárioLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idUsuárioLabel.Location = new System.Drawing.Point(12, 50);
            idUsuárioLabel.Name = "idUsuárioLabel";
            idUsuárioLabel.Size = new System.Drawing.Size(30, 18);
            idUsuárioLabel.TabIndex = 1;
            idUsuárioLabel.Text = "ID:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(12, 81);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(60, 18);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "NOME:";
            // 
            // tDataSet
            // 
            this.tDataSet.DataSetName = "TDataSet";
            this.tDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuárioBindingSource
            // 
            this.usuárioBindingSource.DataMember = "Usuário";
            this.usuárioBindingSource.DataSource = this.tDataSet;
            // 
            // usuárioTableAdapter
            // 
            this.usuárioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TarefaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PFinal.TDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuárioTableAdapter = this.usuárioTableAdapter;
            // 
            // usuárioBindingNavigator
            // 
            this.usuárioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usuárioBindingNavigator.BackColor = System.Drawing.Color.White;
            this.usuárioBindingNavigator.BindingSource = this.usuárioBindingSource;
            this.usuárioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuárioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usuárioBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.usuárioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.usuárioBindingNavigatorSaveItem});
            this.usuárioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuárioBindingNavigator.MoveFirstItem = null;
            this.usuárioBindingNavigator.MoveLastItem = null;
            this.usuárioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuárioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuárioBindingNavigator.Name = "usuárioBindingNavigator";
            this.usuárioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuárioBindingNavigator.Size = new System.Drawing.Size(553, 27);
            this.usuárioBindingNavigator.TabIndex = 0;
            this.usuárioBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // usuárioBindingNavigatorSaveItem
            // 
            this.usuárioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuárioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuárioBindingNavigatorSaveItem.Image")));
            this.usuárioBindingNavigatorSaveItem.Name = "usuárioBindingNavigatorSaveItem";
            this.usuárioBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.usuárioBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.usuárioBindingNavigatorSaveItem.Click += new System.EventHandler(this.usuárioBindingNavigatorSaveItem_Click);
            // 
            // idUsuárioLabel1
            // 
            this.idUsuárioLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuárioBindingSource, "IdUsuário", true));
            this.idUsuárioLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUsuárioLabel1.Location = new System.Drawing.Point(94, 50);
            this.idUsuárioLabel1.Name = "idUsuárioLabel1";
            this.idUsuárioLabel1.Size = new System.Drawing.Size(100, 24);
            this.idUsuárioLabel1.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuárioBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(94, 78);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 22);
            this.nomeTextBox.TabIndex = 4;
            // 
            // usuárioDataGridView
            // 
            this.usuárioDataGridView.AutoGenerateColumns = false;
            this.usuárioDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.usuárioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuárioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.usuárioDataGridView.DataSource = this.usuárioBindingSource;
            this.usuárioDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usuárioDataGridView.Location = new System.Drawing.Point(227, 50);
            this.usuárioDataGridView.Name = "usuárioDataGridView";
            this.usuárioDataGridView.RowHeadersWidth = 51;
            this.usuárioDataGridView.RowTemplate.Height = 24;
            this.usuárioDataGridView.Size = new System.Drawing.Size(303, 252);
            this.usuárioDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdUsuário";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdUsuário";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // TelaCadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(553, 324);
            this.Controls.Add(this.usuárioDataGridView);
            this.Controls.Add(idUsuárioLabel);
            this.Controls.Add(this.idUsuárioLabel1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.usuárioBindingNavigator);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaCadUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE USUÁRIO";
            this.Load += new System.EventHandler(this.TelaCadUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuárioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuárioBindingNavigator)).EndInit();
            this.usuárioBindingNavigator.ResumeLayout(false);
            this.usuárioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuárioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TDataSet tDataSet;
        private System.Windows.Forms.BindingSource usuárioBindingSource;
        private TDataSetTableAdapters.UsuárioTableAdapter usuárioTableAdapter;
        private TDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuárioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usuárioBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idUsuárioLabel1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DataGridView usuárioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}