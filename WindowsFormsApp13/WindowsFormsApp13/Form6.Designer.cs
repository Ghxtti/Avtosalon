namespace WindowsFormsApp13
{
    partial class Form6
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label zavod_proizvoditelyaLabel;
            System.Windows.Forms.Label strana_proizvoditelyaLabel;
            System.Windows.Forms.Label name_BrandLabel;
            System.Windows.Forms.Label iD_BrandLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this._1DataSet = new WindowsFormsApp13._1DataSet();
            this.personalTableAdapter = new WindowsFormsApp13._1DataSetTableAdapters.PersonalTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp13._1DataSetTableAdapters.TableAdapterManager();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new WindowsFormsApp13._1DataSetTableAdapters.CarsTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iD_CarTextBox = new System.Windows.Forms.TextBox();
            this.name_carTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.production_yearTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.iD_BrandTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            addressLabel = new System.Windows.Forms.Label();
            zavod_proizvoditelyaLabel = new System.Windows.Forms.Label();
            strana_proizvoditelyaLabel = new System.Windows.Forms.Label();
            name_BrandLabel = new System.Windows.Forms.Label();
            iD_BrandLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Transparent;
            addressLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.ForeColor = System.Drawing.Color.AliceBlue;
            addressLabel.Location = new System.Drawing.Point(248, 292);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(59, 22);
            addressLabel.TabIndex = 25;
            addressLabel.Text = "Цвет:";
            addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // zavod_proizvoditelyaLabel
            // 
            zavod_proizvoditelyaLabel.AutoSize = true;
            zavod_proizvoditelyaLabel.BackColor = System.Drawing.Color.Transparent;
            zavod_proizvoditelyaLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            zavod_proizvoditelyaLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            zavod_proizvoditelyaLabel.Location = new System.Drawing.Point(182, 251);
            zavod_proizvoditelyaLabel.Name = "zavod_proizvoditelyaLabel";
            zavod_proizvoditelyaLabel.Size = new System.Drawing.Size(120, 22);
            zavod_proizvoditelyaLabel.TabIndex = 23;
            zavod_proizvoditelyaLabel.Text = "Год Выпуска:";
            zavod_proizvoditelyaLabel.Click += new System.EventHandler(this.zavod_proizvoditelyaLabel_Click);
            // 
            // strana_proizvoditelyaLabel
            // 
            strana_proizvoditelyaLabel.AutoSize = true;
            strana_proizvoditelyaLabel.BackColor = System.Drawing.Color.Transparent;
            strana_proizvoditelyaLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            strana_proizvoditelyaLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            strana_proizvoditelyaLabel.Location = new System.Drawing.Point(242, 206);
            strana_proizvoditelyaLabel.Name = "strana_proizvoditelyaLabel";
            strana_proizvoditelyaLabel.Size = new System.Drawing.Size(69, 22);
            strana_proizvoditelyaLabel.TabIndex = 21;
            strana_proizvoditelyaLabel.Text = "Марка:";
            strana_proizvoditelyaLabel.Click += new System.EventHandler(this.strana_proizvoditelyaLabel_Click);
            // 
            // name_BrandLabel
            // 
            name_BrandLabel.AutoSize = true;
            name_BrandLabel.BackColor = System.Drawing.Color.Transparent;
            name_BrandLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_BrandLabel.ForeColor = System.Drawing.Color.AliceBlue;
            name_BrandLabel.Location = new System.Drawing.Point(131, 156);
            name_BrandLabel.Name = "name_BrandLabel";
            name_BrandLabel.Size = new System.Drawing.Size(169, 22);
            name_BrandLabel.TabIndex = 19;
            name_BrandLabel.Text = "Название Машины:";
            name_BrandLabel.Click += new System.EventHandler(this.name_BrandLabel_Click);
            // 
            // iD_BrandLabel
            // 
            iD_BrandLabel.AutoSize = true;
            iD_BrandLabel.BackColor = System.Drawing.Color.Transparent;
            iD_BrandLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_BrandLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            iD_BrandLabel.Location = new System.Drawing.Point(199, 111);
            iD_BrandLabel.Name = "iD_BrandLabel";
            iD_BrandLabel.Size = new System.Drawing.Size(116, 22);
            iD_BrandLabel.TabIndex = 17;
            iD_BrandLabel.Text = "ID Машина :";
            iD_BrandLabel.Click += new System.EventHandler(this.iD_BrandLabel_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.Color.AliceBlue;
            label1.Location = new System.Drawing.Point(213, 336);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 22);
            label1.TabIndex = 27;
            label1.Text = "Категория:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.Color.AliceBlue;
            label2.Location = new System.Drawing.Point(213, 372);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 22);
            label2.TabIndex = 28;
            label2.Text = "ID Марки:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.ForeColor = System.Drawing.SystemColors.ControlText;
            label3.Location = new System.Drawing.Point(251, 417);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 22);
            label3.TabIndex = 29;
            label3.Text = "Цена:";
            label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(284, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 33);
            this.label5.TabIndex = 34;
            this.label5.Text = "Машины";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(238, 585);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(301, 40);
            this.button7.TabIndex = 41;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.OrangeRed;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(390, 523);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 40);
            this.button6.TabIndex = 40;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(238, 523);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 40);
            this.button5.TabIndex = 39;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(545, 467);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 40);
            this.button4.TabIndex = 38;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(390, 468);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 40);
            this.button3.TabIndex = 37;
            this.button3.Text = "Следующий";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(238, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 40);
            this.button2.TabIndex = 36;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(86, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 41);
            this.button1.TabIndex = 35;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _1DataSet
            // 
            this._1DataSet.DataSetName = "_1DataSet";
            this._1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Brand_carTableAdapter = null;
            this.tableAdapterManager.BuyersTableAdapter = null;
            this.tableAdapterManager.Car_saleTableAdapter = null;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = this.personalTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp13._1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this._1DataSet;
            this.carsBindingSource.CurrentChanged += new System.EventHandler(this.carsBindingSource_CurrentChanged);
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(784, 25);
            this.bindingNavigator1.TabIndex = 42;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // iD_CarTextBox
            // 
            this.iD_CarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "ID_Car", true));
            this.iD_CarTextBox.Location = new System.Drawing.Point(319, 115);
            this.iD_CarTextBox.Name = "iD_CarTextBox";
            this.iD_CarTextBox.Size = new System.Drawing.Size(161, 20);
            this.iD_CarTextBox.TabIndex = 43;
            // 
            // name_carTextBox
            // 
            this.name_carTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Name car", true));
            this.name_carTextBox.Location = new System.Drawing.Point(319, 160);
            this.name_carTextBox.Name = "name_carTextBox";
            this.name_carTextBox.Size = new System.Drawing.Size(161, 20);
            this.name_carTextBox.TabIndex = 44;
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Brand", true));
            this.brandTextBox.Location = new System.Drawing.Point(319, 211);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(161, 20);
            this.brandTextBox.TabIndex = 45;
            // 
            // production_yearTextBox
            // 
            this.production_yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Production year", true));
            this.production_yearTextBox.Location = new System.Drawing.Point(319, 256);
            this.production_yearTextBox.Name = "production_yearTextBox";
            this.production_yearTextBox.Size = new System.Drawing.Size(161, 20);
            this.production_yearTextBox.TabIndex = 46;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(319, 297);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(161, 20);
            this.colorTextBox.TabIndex = 47;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(319, 338);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(161, 20);
            this.categoryTextBox.TabIndex = 48;
            // 
            // iD_BrandTextBox
            // 
            this.iD_BrandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "ID_Brand", true));
            this.iD_BrandTextBox.Location = new System.Drawing.Point(319, 377);
            this.iD_BrandTextBox.Name = "iD_BrandTextBox";
            this.iD_BrandTextBox.Size = new System.Drawing.Size(161, 20);
            this.iD_BrandTextBox.TabIndex = 49;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(319, 422);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(161, 20);
            this.priceTextBox.TabIndex = 50;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 645);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.iD_BrandTextBox);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.production_yearTextBox);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.name_carTextBox);
            this.Controls.Add(this.iD_CarTextBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(addressLabel);
            this.Controls.Add(zavod_proizvoditelyaLabel);
            this.Controls.Add(strana_proizvoditelyaLabel);
            this.Controls.Add(name_BrandLabel);
            this.Controls.Add(iD_BrandLabel);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this._1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private _1DataSet _1DataSet;
        private _1DataSetTableAdapters.PersonalTableAdapter personalTableAdapter;
        private _1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private _1DataSetTableAdapters.CarsTableAdapter carsTableAdapter;
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
        private System.Windows.Forms.TextBox iD_CarTextBox;
        private System.Windows.Forms.TextBox name_carTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox production_yearTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox iD_BrandTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}