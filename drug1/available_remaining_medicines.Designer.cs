namespace drug1
{
    partial class available_remaining_medicines
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
            this.drugstoreDataSet = new drug1.drugstoreDataSet();
            this.закончившиеся_лекарстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.закончившиеся_лекарстваTableAdapter = new drug1.drugstoreDataSetTableAdapters.Закончившиеся_лекарстваTableAdapter();
            this.tableAdapterManager = new drug1.drugstoreDataSetTableAdapters.TableAdapterManager();
            this.drugstoreDataSet5 = new drug1.drugstoreDataSet5();
            this.остаток_лекарствBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.остаток_лекарствTableAdapter = new drug1.drugstoreDataSet5TableAdapters.остаток_лекарствTableAdapter();
            this.tableAdapterManager1 = new drug1.drugstoreDataSet5TableAdapters.TableAdapterManager();
            this.остаток_лекарствDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.закончившиеся_лекарстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.остаток_лекарствBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.остаток_лекарствDataGridView)).BeginInit();
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
            // drugstoreDataSet5
            // 
            this.drugstoreDataSet5.DataSetName = "drugstoreDataSet5";
            this.drugstoreDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // остаток_лекарствBindingSource
            // 
            this.остаток_лекарствBindingSource.DataMember = "остаток лекарств";
            this.остаток_лекарствBindingSource.DataSource = this.drugstoreDataSet5;
            // 
            // остаток_лекарствTableAdapter
            // 
            this.остаток_лекарствTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = drug1.drugstoreDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // остаток_лекарствDataGridView
            // 
            this.остаток_лекарствDataGridView.AutoGenerateColumns = false;
            this.остаток_лекарствDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.остаток_лекарствDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.остаток_лекарствDataGridView.DataSource = this.остаток_лекарствBindingSource;
            this.остаток_лекарствDataGridView.Location = new System.Drawing.Point(12, 34);
            this.остаток_лекарствDataGridView.Name = "остаток_лекарствDataGridView";
            this.остаток_лекарствDataGridView.RowHeadersWidth = 62;
            this.остаток_лекарствDataGridView.RowTemplate.Height = 28;
            this.остаток_лекарствDataGridView.Size = new System.Drawing.Size(699, 220);
            this.остаток_лекарствDataGridView.TabIndex = 0;
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
            // available_remaining_medicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.остаток_лекарствDataGridView);
            this.Name = "available_remaining_medicines";
            this.Text = "available_remaining_medicines";
            this.Load += new System.EventHandler(this.available_remaining_medicines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.закончившиеся_лекарстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.остаток_лекарствBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.остаток_лекарствDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private drugstoreDataSet drugstoreDataSet;
        private System.Windows.Forms.BindingSource закончившиеся_лекарстваBindingSource;
        private drugstoreDataSetTableAdapters.Закончившиеся_лекарстваTableAdapter закончившиеся_лекарстваTableAdapter;
        private drugstoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private drugstoreDataSet5 drugstoreDataSet5;
        private System.Windows.Forms.BindingSource остаток_лекарствBindingSource;
        private drugstoreDataSet5TableAdapters.остаток_лекарствTableAdapter остаток_лекарствTableAdapter;
        private drugstoreDataSet5TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView остаток_лекарствDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}