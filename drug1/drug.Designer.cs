namespace drug1
{
    partial class drug
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
            System.Windows.Forms.Label name_of_drugLabel;
            System.Windows.Forms.Label manufacturerLabel;
            System.Windows.Forms.Label active_ingredientsLabel;
            System.Windows.Forms.Label expiration_dateLabel;
            System.Windows.Forms.Label dosageLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label compositionLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label is_recipe_requiredLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drug));
            this.drugstoreDataSet = new drug1.drugstoreDataSet();
            this.drugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugTableAdapter = new drug1.drugstoreDataSetTableAdapters.drugTableAdapter();
            this.tableAdapterManager = new drug1.drugstoreDataSetTableAdapters.TableAdapterManager();
            this.drugBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.drugBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.name_of_drugTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.active_ingredientsTextBox = new System.Windows.Forms.TextBox();
            this.expiration_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dosageTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.compositionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.is_recipe_requiredCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.drugDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            name_of_drugLabel = new System.Windows.Forms.Label();
            manufacturerLabel = new System.Windows.Forms.Label();
            active_ingredientsLabel = new System.Windows.Forms.Label();
            expiration_dateLabel = new System.Windows.Forms.Label();
            dosageLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            compositionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            is_recipe_requiredLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingNavigator)).BeginInit();
            this.drugBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // name_of_drugLabel
            // 
            name_of_drugLabel.AutoSize = true;
            name_of_drugLabel.Location = new System.Drawing.Point(183, 81);
            name_of_drugLabel.Name = "name_of_drugLabel";
            name_of_drugLabel.Size = new System.Drawing.Size(84, 20);
            name_of_drugLabel.TabIndex = 3;
            name_of_drugLabel.Text = "название:";
            name_of_drugLabel.Click += new System.EventHandler(this.name_of_drugLabel_Click);
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Location = new System.Drawing.Point(183, 113);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new System.Drawing.Size(96, 20);
            manufacturerLabel.TabIndex = 5;
            manufacturerLabel.Text = "поставщик:";
            // 
            // active_ingredientsLabel
            // 
            active_ingredientsLabel.AutoSize = true;
            active_ingredientsLabel.Location = new System.Drawing.Point(156, 145);
            active_ingredientsLabel.Name = "active_ingredientsLabel";
            active_ingredientsLabel.Size = new System.Drawing.Size(163, 20);
            active_ingredientsLabel.TabIndex = 7;
            active_ingredientsLabel.Text = "активное вещество:";
            // 
            // expiration_dateLabel
            // 
            expiration_dateLabel.AutoSize = true;
            expiration_dateLabel.Location = new System.Drawing.Point(183, 178);
            expiration_dateLabel.Name = "expiration_dateLabel";
            expiration_dateLabel.Size = new System.Drawing.Size(82, 20);
            expiration_dateLabel.TabIndex = 9;
            expiration_dateLabel.Text = "годен до:";
            // 
            // dosageLabel
            // 
            dosageLabel.AutoSize = true;
            dosageLabel.Location = new System.Drawing.Point(183, 209);
            dosageLabel.Name = "dosageLabel";
            dosageLabel.Size = new System.Drawing.Size(94, 20);
            dosageLabel.TabIndex = 11;
            dosageLabel.Text = "дозировка:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(183, 241);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(102, 20);
            quantityLabel.TabIndex = 13;
            quantityLabel.Text = "количество:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(183, 273);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(40, 20);
            typeLabel.TabIndex = 15;
            typeLabel.Text = "тип:";
            // 
            // compositionLabel
            // 
            compositionLabel.AutoSize = true;
            compositionLabel.Location = new System.Drawing.Point(183, 305);
            compositionLabel.Name = "compositionLabel";
            compositionLabel.Size = new System.Drawing.Size(65, 20);
            compositionLabel.TabIndex = 17;
            compositionLabel.Text = "состав:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(183, 337);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(49, 20);
            priceLabel.TabIndex = 19;
            priceLabel.Text = "цена:";
            // 
            // is_recipe_requiredLabel
            // 
            is_recipe_requiredLabel.AutoSize = true;
            is_recipe_requiredLabel.Location = new System.Drawing.Point(183, 371);
            is_recipe_requiredLabel.Name = "is_recipe_requiredLabel";
            is_recipe_requiredLabel.Size = new System.Drawing.Size(112, 20);
            is_recipe_requiredLabel.TabIndex = 21;
            is_recipe_requiredLabel.Text = "рецепторное:";
            // 
            // drugstoreDataSet
            // 
            this.drugstoreDataSet.DataSetName = "drugstoreDataSet";
            this.drugstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drugBindingSource
            // 
            this.drugBindingSource.DataMember = "drug";
            this.drugBindingSource.DataSource = this.drugstoreDataSet;
            // 
            // drugTableAdapter
            // 
            this.drugTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dealerTableAdapter = null;
            this.tableAdapterManager.drug_for_shipmentTableAdapter = null;
            this.tableAdapterManager.drug_soldTableAdapter = null;
            this.tableAdapterManager.drugTableAdapter = this.drugTableAdapter;
            this.tableAdapterManager.ordered_drugsTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.recipeTableAdapter = null;
            this.tableAdapterManager.saleTableAdapter = null;
            this.tableAdapterManager.shipmentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = drug1.drugstoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // drugBindingNavigator
            // 
            this.drugBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.drugBindingNavigator.BindingSource = this.drugBindingSource;
            this.drugBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.drugBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.drugBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.drugBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.drugBindingNavigatorSaveItem});
            this.drugBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.drugBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.drugBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.drugBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.drugBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.drugBindingNavigator.Name = "drugBindingNavigator";
            this.drugBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.drugBindingNavigator.Size = new System.Drawing.Size(1393, 33);
            this.drugBindingNavigator.TabIndex = 0;
            this.drugBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
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
            // drugBindingNavigatorSaveItem
            // 
            this.drugBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drugBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("drugBindingNavigatorSaveItem.Image")));
            this.drugBindingNavigatorSaveItem.Name = "drugBindingNavigatorSaveItem";
            this.drugBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.drugBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.drugBindingNavigatorSaveItem.Click += new System.EventHandler(this.drugBindingNavigatorSaveItem_Click);
            // 
            // name_of_drugTextBox
            // 
            this.name_of_drugTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "name_of_drug", true));
            this.name_of_drugTextBox.Location = new System.Drawing.Point(325, 78);
            this.name_of_drugTextBox.Name = "name_of_drugTextBox";
            this.name_of_drugTextBox.Size = new System.Drawing.Size(200, 26);
            this.name_of_drugTextBox.TabIndex = 4;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "manufacturer", true));
            this.manufacturerTextBox.Location = new System.Drawing.Point(325, 110);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(200, 26);
            this.manufacturerTextBox.TabIndex = 6;
            // 
            // active_ingredientsTextBox
            // 
            this.active_ingredientsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "active_ingredients", true));
            this.active_ingredientsTextBox.Location = new System.Drawing.Point(325, 142);
            this.active_ingredientsTextBox.Name = "active_ingredientsTextBox";
            this.active_ingredientsTextBox.Size = new System.Drawing.Size(200, 26);
            this.active_ingredientsTextBox.TabIndex = 8;
            // 
            // expiration_dateDateTimePicker
            // 
            this.expiration_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.drugBindingSource, "expiration_date", true));
            this.expiration_dateDateTimePicker.Location = new System.Drawing.Point(325, 174);
            this.expiration_dateDateTimePicker.Name = "expiration_dateDateTimePicker";
            this.expiration_dateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.expiration_dateDateTimePicker.TabIndex = 10;
            // 
            // dosageTextBox
            // 
            this.dosageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "dosage", true));
            this.dosageTextBox.Location = new System.Drawing.Point(325, 206);
            this.dosageTextBox.Name = "dosageTextBox";
            this.dosageTextBox.Size = new System.Drawing.Size(200, 26);
            this.dosageTextBox.TabIndex = 12;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(325, 238);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(200, 26);
            this.quantityTextBox.TabIndex = 14;
            // 
            // compositionTextBox
            // 
            this.compositionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "composition", true));
            this.compositionTextBox.Location = new System.Drawing.Point(325, 302);
            this.compositionTextBox.Name = "compositionTextBox";
            this.compositionTextBox.Size = new System.Drawing.Size(200, 26);
            this.compositionTextBox.TabIndex = 18;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(325, 334);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 26);
            this.priceTextBox.TabIndex = 20;
            // 
            // is_recipe_requiredCheckBox
            // 
            this.is_recipe_requiredCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.drugBindingSource, "is_recipe_required", true));
            this.is_recipe_requiredCheckBox.Location = new System.Drawing.Point(325, 366);
            this.is_recipe_requiredCheckBox.Name = "is_recipe_requiredCheckBox";
            this.is_recipe_requiredCheckBox.Size = new System.Drawing.Size(200, 24);
            this.is_recipe_requiredCheckBox.TabIndex = 22;
            this.is_recipe_requiredCheckBox.Text = "да";
            this.is_recipe_requiredCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 32);
            this.button1.TabIndex = 23;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 32);
            this.button2.TabIndex = 24;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 32);
            this.button3.TabIndex = 25;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(162, 477);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 32);
            this.button4.TabIndex = 26;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(293, 477);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 32);
            this.button5.TabIndex = 27;
            this.button5.Text = "следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(433, 477);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 32);
            this.button6.TabIndex = 28;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(293, 533);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 32);
            this.button7.TabIndex = 29;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "type", true));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "антибиотик",
            "",
            "обезболивающее",
            "кардиопрепарат",
            "витамины",
            "антигистамин",
            "снижение холестерина",
            "фермент",
            "противоязвенный",
            "противокашлевой",
            "анальгетик",
            "гормональный",
            "гепатопротектор"});
            this.typeComboBox.Location = new System.Drawing.Point(325, 268);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(200, 28);
            this.typeComboBox.TabIndex = 30;
            // 
            // drugDataGridView
            // 
            this.drugDataGridView.AutoGenerateColumns = false;
            this.drugDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drugDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn1});
            this.drugDataGridView.DataSource = this.drugBindingSource;
            this.drugDataGridView.Location = new System.Drawing.Point(574, 64);
            this.drugDataGridView.Name = "drugDataGridView";
            this.drugDataGridView.RowHeadersWidth = 62;
            this.drugDataGridView.RowTemplate.Height = 28;
            this.drugDataGridView.Size = new System.Drawing.Size(819, 220);
            this.drugDataGridView.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_drug";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_drug";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "manufacturer";
            this.dataGridViewTextBoxColumn3.HeaderText = "manufacturer";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "active_ingredients";
            this.dataGridViewTextBoxColumn4.HeaderText = "active_ingredients";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "expiration_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "expiration_date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dosage";
            this.dataGridViewTextBoxColumn6.HeaderText = "dosage";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn7.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn8.HeaderText = "type";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "composition";
            this.dataGridViewTextBoxColumn9.HeaderText = "composition";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn10.HeaderText = "price";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "is_recipe_required";
            this.dataGridViewCheckBoxColumn1.HeaderText = "is_recipe_required";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // drug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 585);
            this.Controls.Add(this.drugDataGridView);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(name_of_drugLabel);
            this.Controls.Add(this.name_of_drugTextBox);
            this.Controls.Add(manufacturerLabel);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(active_ingredientsLabel);
            this.Controls.Add(this.active_ingredientsTextBox);
            this.Controls.Add(expiration_dateLabel);
            this.Controls.Add(this.expiration_dateDateTimePicker);
            this.Controls.Add(dosageLabel);
            this.Controls.Add(this.dosageTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(compositionLabel);
            this.Controls.Add(this.compositionTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(is_recipe_requiredLabel);
            this.Controls.Add(this.is_recipe_requiredCheckBox);
            this.Controls.Add(this.drugBindingNavigator);
            this.Name = "drug";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingNavigator)).EndInit();
            this.drugBindingNavigator.ResumeLayout(false);
            this.drugBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private drugstoreDataSet drugstoreDataSet;
        private System.Windows.Forms.BindingSource drugBindingSource;
        private drugstoreDataSetTableAdapters.drugTableAdapter drugTableAdapter;
        private drugstoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator drugBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton drugBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox name_of_drugTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox active_ingredientsTextBox;
        private System.Windows.Forms.DateTimePicker expiration_dateDateTimePicker;
        private System.Windows.Forms.TextBox dosageTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox compositionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.CheckBox is_recipe_requiredCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.DataGridView drugDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}