namespace drug1
{
    partial class buy
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
            this.recipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeTableAdapter = new drug1.drugstoreDataSetTableAdapters.recipeTableAdapter();
            this.tableAdapterManager = new drug1.drugstoreDataSetTableAdapters.TableAdapterManager();
            this.drugstoreDataSet4 = new drug1.drugstoreDataSet4();
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_TableAdapter = new drug1.drugstoreDataSet4TableAdapters.Выдача_справок_о_продаже_лекарств_за_период_или_на_дату_TableAdapter();
            this.tableAdapterManager1 = new drug1.drugstoreDataSet4TableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.startDateToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.startDateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.endDateToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.endDateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_BindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // drugstoreDataSet
            // 
            this.drugstoreDataSet.DataSetName = "drugstoreDataSet";
            this.drugstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipeBindingSource
            // 
            this.recipeBindingSource.DataMember = "recipe";
            this.recipeBindingSource.DataSource = this.drugstoreDataSet;
            // 
            // recipeTableAdapter
            // 
            this.recipeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dealerTableAdapter = null;
            this.tableAdapterManager.drug_for_shipmentTableAdapter = null;
            this.tableAdapterManager.drug_soldTableAdapter = null;
            this.tableAdapterManager.drugTableAdapter = null;
            this.tableAdapterManager.ordered_drugsTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.recipeTableAdapter = this.recipeTableAdapter;
            this.tableAdapterManager.saleTableAdapter = null;
            this.tableAdapterManager.shipmentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = drug1.drugstoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // drugstoreDataSet4
            // 
            this.drugstoreDataSet4.DataSetName = "drugstoreDataSet4";
            this.drugstoreDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // выдача_справок_о_продаже_лекарств_за_период_или_на_дату_BindingSource
            // 
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_BindingSource.DataMember = "Выдача справок о продаже лекарств за период или на дату ";
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_BindingSource.DataSource = this.drugstoreDataSet4;
            // 
            // выдача_справок_о_продаже_лекарств_за_период_или_на_дату_TableAdapter
            // 
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = drug1.drugstoreDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startDateToolStripLabel,
            this.startDateToolStripTextBox,
            this.endDateToolStripLabel,
            this.endDateToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1505, 38);
            this.fillToolStrip.TabIndex = 0;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // startDateToolStripLabel
            // 
            this.startDateToolStripLabel.Name = "startDateToolStripLabel";
            this.startDateToolStripLabel.Size = new System.Drawing.Size(89, 33);
            this.startDateToolStripLabel.Text = "StartDate:";
            // 
            // startDateToolStripTextBox
            // 
            this.startDateToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startDateToolStripTextBox.Name = "startDateToolStripTextBox";
            this.startDateToolStripTextBox.Size = new System.Drawing.Size(100, 38);
            // 
            // endDateToolStripLabel
            // 
            this.endDateToolStripLabel.Name = "endDateToolStripLabel";
            this.endDateToolStripLabel.Size = new System.Drawing.Size(83, 33);
            this.endDateToolStripLabel.Text = "EndDate:";
            // 
            // endDateToolStripTextBox
            // 
            this.endDateToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.endDateToolStripTextBox.Name = "endDateToolStripTextBox";
            this.endDateToolStripTextBox.Size = new System.Drawing.Size(100, 38);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(37, 33);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView
            // 
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView.AutoGenerateColumns = false;
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView.DataSource = this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_BindingSource;
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView.Location = new System.Drawing.Point(368, 132);
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView.Name = "выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView";
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView.RowHeadersWidth = 62;
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView.RowTemplate.Height = 28;
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView.Size = new System.Drawing.Size(1047, 220);
            this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_sale";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_sale";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_drug";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_drug";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name_of_drug";
            this.dataGridViewTextBoxColumn3.HeaderText = "name_of_drug";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "quantity_sold";
            this.dataGridViewTextBoxColumn4.HeaderText = "quantity_sold";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn5.HeaderText = "price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "total_revenue";
            this.dataGridViewTextBoxColumn6.HeaderText = "total_revenue";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 450);
            this.Controls.Add(this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Name = "buy";
            this.Text = "buy";
            this.Load += new System.EventHandler(this.buy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_BindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private drugstoreDataSet drugstoreDataSet;
        private System.Windows.Forms.BindingSource recipeBindingSource;
        private drugstoreDataSetTableAdapters.recipeTableAdapter recipeTableAdapter;
        private drugstoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private drugstoreDataSet4 drugstoreDataSet4;
        private System.Windows.Forms.BindingSource выдача_справок_о_продаже_лекарств_за_период_или_на_дату_BindingSource;
        private drugstoreDataSet4TableAdapters.Выдача_справок_о_продаже_лекарств_за_период_или_на_дату_TableAdapter выдача_справок_о_продаже_лекарств_за_период_или_на_дату_TableAdapter;
        private drugstoreDataSet4TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel startDateToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox startDateToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel endDateToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox endDateToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView выдача_справок_о_продаже_лекарств_за_период_или_на_дату_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}