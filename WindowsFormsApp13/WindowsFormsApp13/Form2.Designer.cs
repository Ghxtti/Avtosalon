namespace WindowsFormsApp13
{
    partial class Users
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
            System.Windows.Forms.Label iD_BrandLabel;
            System.Windows.Forms.Label name_BrandLabel;
            System.Windows.Forms.Label strana_proizvoditelyaLabel;
            System.Windows.Forms.Label zavod_proizvoditelyaLabel;
            System.Windows.Forms.Label addressLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.label1 = new System.Windows.Forms.Label();
            this._1DataSet = new WindowsFormsApp13._1DataSet();
            this.brand_carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brand_carTableAdapter = new WindowsFormsApp13._1DataSetTableAdapters.Brand_carTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp13._1DataSetTableAdapters.TableAdapterManager();
            this.brand_carBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.brand_carBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_BrandTextBox = new System.Windows.Forms.TextBox();
            this.name_BrandTextBox = new System.Windows.Forms.TextBox();
            this.strana_proizvoditelyaTextBox = new System.Windows.Forms.TextBox();
            this.zavod_proizvoditelyaTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            iD_BrandLabel = new System.Windows.Forms.Label();
            name_BrandLabel = new System.Windows.Forms.Label();
            strana_proizvoditelyaLabel = new System.Windows.Forms.Label();
            zavod_proizvoditelyaLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand_carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand_carBindingNavigator)).BeginInit();
            this.brand_carBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_BrandLabel
            // 
            iD_BrandLabel.AutoSize = true;
            iD_BrandLabel.BackColor = System.Drawing.Color.Transparent;
            iD_BrandLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_BrandLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            iD_BrandLabel.Location = new System.Drawing.Point(229, 136);
            iD_BrandLabel.Name = "iD_BrandLabel";
            iD_BrandLabel.Size = new System.Drawing.Size(97, 22);
            iD_BrandLabel.TabIndex = 7;
            iD_BrandLabel.Text = "ID Марки:";
            iD_BrandLabel.Click += new System.EventHandler(this.iD_BrandLabel_Click);
            // 
            // name_BrandLabel
            // 
            name_BrandLabel.AutoSize = true;
            name_BrandLabel.BackColor = System.Drawing.Color.Transparent;
            name_BrandLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_BrandLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            name_BrandLabel.Location = new System.Drawing.Point(159, 179);
            name_BrandLabel.Name = "name_BrandLabel";
            name_BrandLabel.Size = new System.Drawing.Size(151, 22);
            name_BrandLabel.TabIndex = 9;
            name_BrandLabel.Text = "Название Марки:";
            name_BrandLabel.Click += new System.EventHandler(this.name_BrandLabel_Click);
            // 
            // strana_proizvoditelyaLabel
            // 
            strana_proizvoditelyaLabel.AutoSize = true;
            strana_proizvoditelyaLabel.BackColor = System.Drawing.Color.Transparent;
            strana_proizvoditelyaLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            strana_proizvoditelyaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            strana_proizvoditelyaLabel.Location = new System.Drawing.Point(106, 229);
            strana_proizvoditelyaLabel.Name = "strana_proizvoditelyaLabel";
            strana_proizvoditelyaLabel.Size = new System.Drawing.Size(204, 22);
            strana_proizvoditelyaLabel.TabIndex = 11;
            strana_proizvoditelyaLabel.Text = "Страна производителя:";
            strana_proizvoditelyaLabel.Click += new System.EventHandler(this.strana_proizvoditelyaLabel_Click);
            // 
            // zavod_proizvoditelyaLabel
            // 
            zavod_proizvoditelyaLabel.AutoSize = true;
            zavod_proizvoditelyaLabel.BackColor = System.Drawing.Color.Transparent;
            zavod_proizvoditelyaLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            zavod_proizvoditelyaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            zavod_proizvoditelyaLabel.Location = new System.Drawing.Point(134, 276);
            zavod_proizvoditelyaLabel.Name = "zavod_proizvoditelyaLabel";
            zavod_proizvoditelyaLabel.Size = new System.Drawing.Size(189, 22);
            zavod_proizvoditelyaLabel.TabIndex = 13;
            zavod_proizvoditelyaLabel.Text = "Завод производителя:";
            zavod_proizvoditelyaLabel.Click += new System.EventHandler(this.zavod_proizvoditelyaLabel_Click_1);
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Transparent;
            addressLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            addressLabel.Location = new System.Drawing.Point(260, 327);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(63, 22);
            addressLabel.TabIndex = 15;
            addressLabel.Text = "Адрес:";
            addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(297, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Марка Машины";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _1DataSet
            // 
            this._1DataSet.DataSetName = "_1DataSet";
            this._1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brand_carBindingSource
            // 
            this.brand_carBindingSource.DataMember = "Brand car";
            this.brand_carBindingSource.DataSource = this._1DataSet;
            // 
            // brand_carTableAdapter
            // 
            this.brand_carTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Brand_carTableAdapter = this.brand_carTableAdapter;
            this.tableAdapterManager.BuyersTableAdapter = null;
            this.tableAdapterManager.Car_saleTableAdapter = null;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp13._1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // brand_carBindingNavigator
            // 
            this.brand_carBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.brand_carBindingNavigator.BindingSource = this.brand_carBindingSource;
            this.brand_carBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.brand_carBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.brand_carBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.brand_carBindingNavigatorSaveItem});
            this.brand_carBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.brand_carBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.brand_carBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.brand_carBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.brand_carBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.brand_carBindingNavigator.Name = "brand_carBindingNavigator";
            this.brand_carBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.brand_carBindingNavigator.Size = new System.Drawing.Size(780, 25);
            this.brand_carBindingNavigator.TabIndex = 6;
            this.brand_carBindingNavigator.Text = "bindingNavigator1";
            this.brand_carBindingNavigator.RefreshItems += new System.EventHandler(this.brand_carBindingNavigator_RefreshItems);
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
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
            // brand_carBindingNavigatorSaveItem
            // 
            this.brand_carBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brand_carBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("brand_carBindingNavigatorSaveItem.Image")));
            this.brand_carBindingNavigatorSaveItem.Name = "brand_carBindingNavigatorSaveItem";
            this.brand_carBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.brand_carBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.brand_carBindingNavigatorSaveItem.Click += new System.EventHandler(this.brand_carBindingNavigatorSaveItem_Click);
            // 
            // iD_BrandTextBox
            // 
            this.iD_BrandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brand_carBindingSource, "ID_Brand", true));
            this.iD_BrandTextBox.Location = new System.Drawing.Point(337, 131);
            this.iD_BrandTextBox.Name = "iD_BrandTextBox";
            this.iD_BrandTextBox.Size = new System.Drawing.Size(155, 29);
            this.iD_BrandTextBox.TabIndex = 8;
            this.iD_BrandTextBox.TextChanged += new System.EventHandler(this.iD_BrandTextBox_TextChanged);
            // 
            // name_BrandTextBox
            // 
            this.name_BrandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brand_carBindingSource, "Name Brand", true));
            this.name_BrandTextBox.Location = new System.Drawing.Point(337, 176);
            this.name_BrandTextBox.Name = "name_BrandTextBox";
            this.name_BrandTextBox.Size = new System.Drawing.Size(155, 29);
            this.name_BrandTextBox.TabIndex = 10;
            this.name_BrandTextBox.TextChanged += new System.EventHandler(this.name_BrandTextBox_TextChanged);
            // 
            // strana_proizvoditelyaTextBox
            // 
            this.strana_proizvoditelyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brand_carBindingSource, "Strana proizvoditelya", true));
            this.strana_proizvoditelyaTextBox.Location = new System.Drawing.Point(337, 226);
            this.strana_proizvoditelyaTextBox.Name = "strana_proizvoditelyaTextBox";
            this.strana_proizvoditelyaTextBox.Size = new System.Drawing.Size(155, 29);
            this.strana_proizvoditelyaTextBox.TabIndex = 12;
            this.strana_proizvoditelyaTextBox.TextChanged += new System.EventHandler(this.strana_proizvoditelyaTextBox_TextChanged);
            // 
            // zavod_proizvoditelyaTextBox
            // 
            this.zavod_proizvoditelyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brand_carBindingSource, "Zavod proizvoditelya", true));
            this.zavod_proizvoditelyaTextBox.Location = new System.Drawing.Point(337, 271);
            this.zavod_proizvoditelyaTextBox.Name = "zavod_proizvoditelyaTextBox";
            this.zavod_proizvoditelyaTextBox.Size = new System.Drawing.Size(155, 29);
            this.zavod_proizvoditelyaTextBox.TabIndex = 14;
            this.zavod_proizvoditelyaTextBox.TextChanged += new System.EventHandler(this.zavod_proizvoditelyaTextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brand_carBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(337, 322);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(155, 29);
            this.addressTextBox.TabIndex = 16;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(262, 501);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(301, 40);
            this.button7.TabIndex = 27;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.OrangeRed;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(414, 439);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 40);
            this.button6.TabIndex = 26;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Location = new System.Drawing.Point(262, 439);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 40);
            this.button5.TabIndex = 25;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(569, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 40);
            this.button4.TabIndex = 24;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(414, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 40);
            this.button3.TabIndex = 23;
            this.button3.Text = "Следующий";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(262, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(110, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(780, 632);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(zavod_proizvoditelyaLabel);
            this.Controls.Add(this.zavod_proizvoditelyaTextBox);
            this.Controls.Add(strana_proizvoditelyaLabel);
            this.Controls.Add(this.strana_proizvoditelyaTextBox);
            this.Controls.Add(name_BrandLabel);
            this.Controls.Add(this.name_BrandTextBox);
            this.Controls.Add(iD_BrandLabel);
            this.Controls.Add(this.iD_BrandTextBox);
            this.Controls.Add(this.brand_carBindingNavigator);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this._1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand_carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand_carBindingNavigator)).EndInit();
            this.brand_carBindingNavigator.ResumeLayout(false);
            this.brand_carBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private _1DataSet _1DataSet;
        private System.Windows.Forms.BindingSource brand_carBindingSource;
        private _1DataSetTableAdapters.Brand_carTableAdapter brand_carTableAdapter;
        private _1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator brand_carBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton brand_carBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_BrandTextBox;
        private System.Windows.Forms.TextBox name_BrandTextBox;
        private System.Windows.Forms.TextBox strana_proizvoditelyaTextBox;
        private System.Windows.Forms.TextBox zavod_proizvoditelyaTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}