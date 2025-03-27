namespace drug1
{
    partial class Expired_drug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expired_drug));
            this.drugstoreDataSet = new drug1.drugstoreDataSet();
            this.закончившиеся_лекарстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.закончившиеся_лекарстваTableAdapter = new drug1.drugstoreDataSetTableAdapters.Закончившиеся_лекарстваTableAdapter();
            this.tableAdapterManager = new drug1.drugstoreDataSetTableAdapters.TableAdapterManager();
            this.закончившиеся_лекарстваBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.закончившиеся_лекарстваBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.закончившиеся_лекарстваDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.закончившиеся_лекарстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.закончившиеся_лекарстваBindingNavigator)).BeginInit();
            this.закончившиеся_лекарстваBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.закончившиеся_лекарстваDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // drugstoreDataSet
            // 
            this.drugstoreDataSet.DataSetName = "drugstoreDataSet";
            this.drugstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // закончившиеся_лекарстваBindingSource
            // 
            this.закончившиеся_лекарстваBindingSource.DataMember = "Закончившиеся лекарства";
            this.закончившиеся_лекарстваBindingSource.DataSource = this.drugstoreDataSet;
            // 
            // закончившиеся_лекарстваTableAdapter
            // 
            this.закончившиеся_лекарстваTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.dealerTableAdapter = null;
            this.tableAdapterManager.drug_for_shipmentTableAdapter = null;
            this.tableAdapterManager.drug_soldTableAdapter = null;
            this.tableAdapterManager.drugTableAdapter = null;
            this.tableAdapterManager.ordered_drugsTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.recipeTableAdapter = null;
            this.tableAdapterManager.saleTableAdapter = null;
            this.tableAdapterManager.shipmentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = drug1.drugstoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // закончившиеся_лекарстваBindingNavigator
            // 
            this.закончившиеся_лекарстваBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.закончившиеся_лекарстваBindingNavigator.BindingSource = this.закончившиеся_лекарстваBindingSource;
            this.закончившиеся_лекарстваBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.закончившиеся_лекарстваBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.закончившиеся_лекарстваBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.закончившиеся_лекарстваBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.закончившиеся_лекарстваBindingNavigatorSaveItem});
            this.закончившиеся_лекарстваBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.закончившиеся_лекарстваBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.закончившиеся_лекарстваBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.закончившиеся_лекарстваBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.закончившиеся_лекарстваBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.закончившиеся_лекарстваBindingNavigator.Name = "закончившиеся_лекарстваBindingNavigator";
            this.закончившиеся_лекарстваBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.закончившиеся_лекарстваBindingNavigator.Size = new System.Drawing.Size(800, 38);
            this.закончившиеся_лекарстваBindingNavigator.TabIndex = 0;
            this.закончившиеся_лекарстваBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 33);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // закончившиеся_лекарстваBindingNavigatorSaveItem
            // 
            this.закончившиеся_лекарстваBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.закончившиеся_лекарстваBindingNavigatorSaveItem.Enabled = false;
            this.закончившиеся_лекарстваBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("закончившиеся_лекарстваBindingNavigatorSaveItem.Image")));
            this.закончившиеся_лекарстваBindingNavigatorSaveItem.Name = "закончившиеся_лекарстваBindingNavigatorSaveItem";
            this.закончившиеся_лекарстваBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.закончившиеся_лекарстваBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // закончившиеся_лекарстваDataGridView
            // 
            this.закончившиеся_лекарстваDataGridView.AutoGenerateColumns = false;
            this.закончившиеся_лекарстваDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.закончившиеся_лекарстваDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.закончившиеся_лекарстваDataGridView.DataSource = this.закончившиеся_лекарстваBindingSource;
            this.закончившиеся_лекарстваDataGridView.Location = new System.Drawing.Point(45, 85);
            this.закончившиеся_лекарстваDataGridView.Name = "закончившиеся_лекарстваDataGridView";
            this.закончившиеся_лекарстваDataGridView.RowHeadersWidth = 62;
            this.закончившиеся_лекарстваDataGridView.RowTemplate.Height = 28;
            this.закончившиеся_лекарстваDataGridView.Size = new System.Drawing.Size(570, 220);
            this.закончившиеся_лекарстваDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_drug";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_drug";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name_of_drug";
            this.dataGridViewTextBoxColumn2.HeaderText = "name_of_drug";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "остаток";
            this.dataGridViewTextBoxColumn3.HeaderText = "остаток";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Expired_drug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.закончившиеся_лекарстваDataGridView);
            this.Controls.Add(this.закончившиеся_лекарстваBindingNavigator);
            this.Name = "Expired_drug";
            this.Text = "Expired_drug";
            this.Load += new System.EventHandler(this.Expired_drug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.закончившиеся_лекарстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.закончившиеся_лекарстваBindingNavigator)).EndInit();
            this.закончившиеся_лекарстваBindingNavigator.ResumeLayout(false);
            this.закончившиеся_лекарстваBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.закончившиеся_лекарстваDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private drugstoreDataSet drugstoreDataSet;
        private System.Windows.Forms.BindingSource закончившиеся_лекарстваBindingSource;
        private drugstoreDataSetTableAdapters.Закончившиеся_лекарстваTableAdapter закончившиеся_лекарстваTableAdapter;
        private drugstoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator закончившиеся_лекарстваBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton закончившиеся_лекарстваBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView закончившиеся_лекарстваDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}