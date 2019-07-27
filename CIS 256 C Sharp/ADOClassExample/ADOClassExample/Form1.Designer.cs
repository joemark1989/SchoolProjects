namespace ADOClassExample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label playerIDpkLabel;
            System.Windows.Forms.Label birthStateLabel;
            System.Windows.Forms.Label birthCityLabel;
            System.Windows.Forms.Label deathDateLabel;
            System.Windows.Forms.Label deathStateLabel;
            System.Windows.Forms.Label deathCityLabel;
            System.Windows.Forms.Label nameFirstLabel;
            System.Windows.Forms.Label nameLastLabel;
            System.Windows.Forms.Label nameGivenLabel;
            System.Windows.Forms.Label deathCountryLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.baseball2015DataSet = new ADOClassExample.Baseball2015DataSet();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new ADOClassExample.Baseball2015DataSetTableAdapters.PlayersTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.playerIDpkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameFirstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGivenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deathStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deathCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new ADOClassExample.Baseball2015DataSetTableAdapters.TableAdapterManager();
            this.playerIDpkTextBox = new System.Windows.Forms.TextBox();
            this.birthStateTextBox = new System.Windows.Forms.TextBox();
            this.birthCityTextBox = new System.Windows.Forms.TextBox();
            this.deathDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deathStateTextBox = new System.Windows.Forms.TextBox();
            this.deathCityTextBox = new System.Windows.Forms.TextBox();
            this.nameFirstTextBox = new System.Windows.Forms.TextBox();
            this.nameLastTextBox = new System.Windows.Forms.TextBox();
            this.nameGivenTextBox = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deathCountryTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            playerIDpkLabel = new System.Windows.Forms.Label();
            birthStateLabel = new System.Windows.Forms.Label();
            birthCityLabel = new System.Windows.Forms.Label();
            deathDateLabel = new System.Windows.Forms.Label();
            deathStateLabel = new System.Windows.Forms.Label();
            deathCityLabel = new System.Windows.Forms.Label();
            nameFirstLabel = new System.Windows.Forms.Label();
            nameLastLabel = new System.Windows.Forms.Label();
            nameGivenLabel = new System.Windows.Forms.Label();
            deathCountryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseball2015DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIDpkDataGridViewTextBoxColumn,
            this.nameLastDataGridViewTextBoxColumn,
            this.nameFirstDataGridViewTextBoxColumn,
            this.nameGivenDataGridViewTextBoxColumn,
            this.birthStateDataGridViewTextBoxColumn,
            this.birthCityDataGridViewTextBoxColumn,
            this.deathStateDataGridViewTextBoxColumn,
            this.deathCityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            // 
            // baseball2015DataSet
            // 
            this.baseball2015DataSet.DataSetName = "Baseball2015DataSet";
            this.baseball2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.baseball2015DataSet;
            this.playersBindingSource.CurrentChanged += new System.EventHandler(this.playersBindingSource_CurrentChanged);
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.playersBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1159, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // playerIDpkDataGridViewTextBoxColumn
            // 
            this.playerIDpkDataGridViewTextBoxColumn.DataPropertyName = "playerIDpk";
            this.playerIDpkDataGridViewTextBoxColumn.HeaderText = "playerIDpk";
            this.playerIDpkDataGridViewTextBoxColumn.Name = "playerIDpkDataGridViewTextBoxColumn";
            this.playerIDpkDataGridViewTextBoxColumn.ReadOnly = true;
            this.playerIDpkDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameLastDataGridViewTextBoxColumn
            // 
            this.nameLastDataGridViewTextBoxColumn.DataPropertyName = "nameLast";
            this.nameLastDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.nameLastDataGridViewTextBoxColumn.Name = "nameLastDataGridViewTextBoxColumn";
            this.nameLastDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameFirstDataGridViewTextBoxColumn
            // 
            this.nameFirstDataGridViewTextBoxColumn.DataPropertyName = "nameFirst";
            this.nameFirstDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.nameFirstDataGridViewTextBoxColumn.Name = "nameFirstDataGridViewTextBoxColumn";
            this.nameFirstDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameGivenDataGridViewTextBoxColumn
            // 
            this.nameGivenDataGridViewTextBoxColumn.DataPropertyName = "nameGiven";
            this.nameGivenDataGridViewTextBoxColumn.HeaderText = "Given";
            this.nameGivenDataGridViewTextBoxColumn.Name = "nameGivenDataGridViewTextBoxColumn";
            this.nameGivenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthStateDataGridViewTextBoxColumn
            // 
            this.birthStateDataGridViewTextBoxColumn.DataPropertyName = "birthState";
            this.birthStateDataGridViewTextBoxColumn.HeaderText = "Birth State";
            this.birthStateDataGridViewTextBoxColumn.Name = "birthStateDataGridViewTextBoxColumn";
            this.birthStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthCityDataGridViewTextBoxColumn
            // 
            this.birthCityDataGridViewTextBoxColumn.DataPropertyName = "birthCity";
            this.birthCityDataGridViewTextBoxColumn.HeaderText = "Birth City";
            this.birthCityDataGridViewTextBoxColumn.Name = "birthCityDataGridViewTextBoxColumn";
            this.birthCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deathStateDataGridViewTextBoxColumn
            // 
            this.deathStateDataGridViewTextBoxColumn.DataPropertyName = "deathState";
            this.deathStateDataGridViewTextBoxColumn.HeaderText = "Death State";
            this.deathStateDataGridViewTextBoxColumn.Name = "deathStateDataGridViewTextBoxColumn";
            this.deathStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deathCityDataGridViewTextBoxColumn
            // 
            this.deathCityDataGridViewTextBoxColumn.DataPropertyName = "deathCity";
            this.deathCityDataGridViewTextBoxColumn.HeaderText = "Death City";
            this.deathCityDataGridViewTextBoxColumn.Name = "deathCityDataGridViewTextBoxColumn";
            this.deathCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlayersTableAdapter = this.playersTableAdapter;
            this.tableAdapterManager.UpdateOrder = ADOClassExample.Baseball2015DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // playerIDpkLabel
            // 
            playerIDpkLabel.AutoSize = true;
            playerIDpkLabel.Location = new System.Drawing.Point(7, 31);
            playerIDpkLabel.Name = "playerIDpkLabel";
            playerIDpkLabel.Size = new System.Drawing.Size(64, 13);
            playerIDpkLabel.TabIndex = 2;
            playerIDpkLabel.Text = "player IDpk:";
            // 
            // playerIDpkTextBox
            // 
            this.playerIDpkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "playerIDpk", true));
            this.playerIDpkTextBox.Location = new System.Drawing.Point(89, 28);
            this.playerIDpkTextBox.Name = "playerIDpkTextBox";
            this.playerIDpkTextBox.ReadOnly = true;
            this.playerIDpkTextBox.Size = new System.Drawing.Size(200, 20);
            this.playerIDpkTextBox.TabIndex = 3;
            // 
            // birthStateLabel
            // 
            birthStateLabel.AutoSize = true;
            birthStateLabel.Location = new System.Drawing.Point(7, 57);
            birthStateLabel.Name = "birthStateLabel";
            birthStateLabel.Size = new System.Drawing.Size(58, 13);
            birthStateLabel.TabIndex = 4;
            birthStateLabel.Text = "birth State:";
            // 
            // birthStateTextBox
            // 
            this.birthStateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "birthState", true));
            this.birthStateTextBox.Location = new System.Drawing.Point(89, 54);
            this.birthStateTextBox.Name = "birthStateTextBox";
            this.birthStateTextBox.Size = new System.Drawing.Size(200, 20);
            this.birthStateTextBox.TabIndex = 5;
            // 
            // birthCityLabel
            // 
            birthCityLabel.AutoSize = true;
            birthCityLabel.Location = new System.Drawing.Point(7, 83);
            birthCityLabel.Name = "birthCityLabel";
            birthCityLabel.Size = new System.Drawing.Size(50, 13);
            birthCityLabel.TabIndex = 6;
            birthCityLabel.Text = "birth City:";
            // 
            // birthCityTextBox
            // 
            this.birthCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "birthCity", true));
            this.birthCityTextBox.Location = new System.Drawing.Point(89, 80);
            this.birthCityTextBox.Name = "birthCityTextBox";
            this.birthCityTextBox.Size = new System.Drawing.Size(200, 20);
            this.birthCityTextBox.TabIndex = 7;
            // 
            // deathDateLabel
            // 
            deathDateLabel.AutoSize = true;
            deathDateLabel.Location = new System.Drawing.Point(7, 110);
            deathDateLabel.Name = "deathDateLabel";
            deathDateLabel.Size = new System.Drawing.Size(63, 13);
            deathDateLabel.TabIndex = 8;
            deathDateLabel.Text = "death Date:";
            // 
            // deathDateDateTimePicker
            // 
            this.deathDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.playersBindingSource, "deathDate", true));
            this.deathDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deathDateDateTimePicker.Location = new System.Drawing.Point(89, 106);
            this.deathDateDateTimePicker.Name = "deathDateDateTimePicker";
            this.deathDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.deathDateDateTimePicker.TabIndex = 9;
            // 
            // deathStateLabel
            // 
            deathStateLabel.AutoSize = true;
            deathStateLabel.Location = new System.Drawing.Point(7, 161);
            deathStateLabel.Name = "deathStateLabel";
            deathStateLabel.Size = new System.Drawing.Size(65, 13);
            deathStateLabel.TabIndex = 12;
            deathStateLabel.Text = "death State:";
            // 
            // deathStateTextBox
            // 
            this.deathStateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "deathState", true));
            this.deathStateTextBox.Location = new System.Drawing.Point(89, 158);
            this.deathStateTextBox.Name = "deathStateTextBox";
            this.deathStateTextBox.Size = new System.Drawing.Size(200, 20);
            this.deathStateTextBox.TabIndex = 13;
            // 
            // deathCityLabel
            // 
            deathCityLabel.AutoSize = true;
            deathCityLabel.Location = new System.Drawing.Point(7, 187);
            deathCityLabel.Name = "deathCityLabel";
            deathCityLabel.Size = new System.Drawing.Size(57, 13);
            deathCityLabel.TabIndex = 14;
            deathCityLabel.Text = "death City:";
            // 
            // deathCityTextBox
            // 
            this.deathCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "deathCity", true));
            this.deathCityTextBox.Location = new System.Drawing.Point(89, 184);
            this.deathCityTextBox.Name = "deathCityTextBox";
            this.deathCityTextBox.Size = new System.Drawing.Size(200, 20);
            this.deathCityTextBox.TabIndex = 15;
            // 
            // nameFirstLabel
            // 
            nameFirstLabel.AutoSize = true;
            nameFirstLabel.Location = new System.Drawing.Point(7, 213);
            nameFirstLabel.Name = "nameFirstLabel";
            nameFirstLabel.Size = new System.Drawing.Size(58, 13);
            nameFirstLabel.TabIndex = 16;
            nameFirstLabel.Text = "name First:";
            // 
            // nameFirstTextBox
            // 
            this.nameFirstTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "nameFirst", true));
            this.nameFirstTextBox.Location = new System.Drawing.Point(89, 210);
            this.nameFirstTextBox.Name = "nameFirstTextBox";
            this.nameFirstTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameFirstTextBox.TabIndex = 17;
            // 
            // nameLastLabel
            // 
            nameLastLabel.AutoSize = true;
            nameLastLabel.Location = new System.Drawing.Point(7, 239);
            nameLastLabel.Name = "nameLastLabel";
            nameLastLabel.Size = new System.Drawing.Size(59, 13);
            nameLastLabel.TabIndex = 18;
            nameLastLabel.Text = "name Last:";
            // 
            // nameLastTextBox
            // 
            this.nameLastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "nameLast", true));
            this.nameLastTextBox.Location = new System.Drawing.Point(89, 236);
            this.nameLastTextBox.Name = "nameLastTextBox";
            this.nameLastTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameLastTextBox.TabIndex = 19;
            // 
            // nameGivenLabel
            // 
            nameGivenLabel.AutoSize = true;
            nameGivenLabel.Location = new System.Drawing.Point(7, 265);
            nameGivenLabel.Name = "nameGivenLabel";
            nameGivenLabel.Size = new System.Drawing.Size(67, 13);
            nameGivenLabel.TabIndex = 20;
            nameGivenLabel.Text = "name Given:";
            // 
            // nameGivenTextBox
            // 
            this.nameGivenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "nameGiven", true));
            this.nameGivenTextBox.Location = new System.Drawing.Point(89, 262);
            this.nameGivenTextBox.Name = "nameGivenTextBox";
            this.nameGivenTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameGivenTextBox.TabIndex = 21;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(313, 265);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 22;
            this.btn1.Text = "Top";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Prev";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(499, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(590, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Last";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deathCountryTextBox
            // 
            this.deathCountryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "deathCountry", true));
            this.deathCountryTextBox.Location = new System.Drawing.Point(89, 132);
            this.deathCountryTextBox.Name = "deathCountryTextBox";
            this.deathCountryTextBox.Size = new System.Drawing.Size(200, 20);
            this.deathCountryTextBox.TabIndex = 11;
            // 
            // deathCountryLabel
            // 
            deathCountryLabel.AutoSize = true;
            deathCountryLabel.Location = new System.Drawing.Point(7, 135);
            deathCountryLabel.Name = "deathCountryLabel";
            deathCountryLabel.Size = new System.Drawing.Size(76, 13);
            deathCountryLabel.TabIndex = 10;
            deathCountryLabel.Text = "death Country:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Location = new System.Drawing.Point(332, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(0, 19);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(194, 20);
            this.txtFind.TabIndex = 0;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(playerIDpkLabel);
            this.Controls.Add(this.playerIDpkTextBox);
            this.Controls.Add(birthStateLabel);
            this.Controls.Add(this.birthStateTextBox);
            this.Controls.Add(birthCityLabel);
            this.Controls.Add(this.birthCityTextBox);
            this.Controls.Add(deathDateLabel);
            this.Controls.Add(this.deathDateDateTimePicker);
            this.Controls.Add(deathCountryLabel);
            this.Controls.Add(this.deathCountryTextBox);
            this.Controls.Add(deathStateLabel);
            this.Controls.Add(this.deathStateTextBox);
            this.Controls.Add(deathCityLabel);
            this.Controls.Add(this.deathCityTextBox);
            this.Controls.Add(nameFirstLabel);
            this.Controls.Add(this.nameFirstTextBox);
            this.Controls.Add(nameLastLabel);
            this.Controls.Add(this.nameLastTextBox);
            this.Controls.Add(nameGivenLabel);
            this.Controls.Add(this.nameGivenTextBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseball2015DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Baseball2015DataSet baseball2015DataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private Baseball2015DataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDpkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameLastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameFirstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGivenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathCityDataGridViewTextBoxColumn;
        private Baseball2015DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox playerIDpkTextBox;
        private System.Windows.Forms.TextBox birthStateTextBox;
        private System.Windows.Forms.TextBox birthCityTextBox;
        private System.Windows.Forms.DateTimePicker deathDateDateTimePicker;
        private System.Windows.Forms.TextBox deathStateTextBox;
        private System.Windows.Forms.TextBox deathCityTextBox;
        private System.Windows.Forms.TextBox nameFirstTextBox;
        private System.Windows.Forms.TextBox nameLastTextBox;
        private System.Windows.Forms.TextBox nameGivenTextBox;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox deathCountryTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFind;
    }
}

