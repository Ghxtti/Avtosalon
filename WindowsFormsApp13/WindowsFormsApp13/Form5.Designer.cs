namespace WindowsFormsApp13
{
    partial class Form5
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
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this._1DataSet = new WindowsFormsApp13._1DataSet();
            this.car_saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_saleTableAdapter = new WindowsFormsApp13._1DataSetTableAdapters.Car_saleTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp13._1DataSetTableAdapters.TableAdapterManager();
            this.car_saleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.car_saleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_CarsTextBox = new System.Windows.Forms.TextBox();
            this.iD_SaleTextBox = new System.Windows.Forms.TextBox();
            this.iD_PersonalTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.carTextBox = new System.Windows.Forms.TextBox();
            this.personalTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            addressLabel = new System.Windows.Forms.Label();
            zavod_proizvoditelyaLabel = new System.Windows.Forms.Label();
            strana_proizvoditelyaLabel = new System.Windows.Forms.Label();
            name_BrandLabel = new System.Windows.Forms.Label();
            iD_BrandLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_saleBindingNavigator)).BeginInit();
            this.car_saleBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Transparent;
            addressLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.Location = new System.Drawing.Point(267, 272);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(88, 22);
            addressLabel.TabIndex = 25;
            addressLabel.Text = "Машины:";
            addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // zavod_proizvoditelyaLabel
            // 
            zavod_proizvoditelyaLabel.AutoSize = true;
            zavod_proizvoditelyaLabel.BackColor = System.Drawing.Color.Transparent;
            zavod_proizvoditelyaLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            zavod_proizvoditelyaLabel.Location = new System.Drawing.Point(293, 225);
            zavod_proizvoditelyaLabel.Name = "zavod_proizvoditelyaLabel";
            zavod_proizvoditelyaLabel.Size = new System.Drawing.Size(61, 22);
            zavod_proizvoditelyaLabel.TabIndex = 23;
            zavod_proizvoditelyaLabel.Text = "Дата:";
            zavod_proizvoditelyaLabel.Click += new System.EventHandler(this.zavod_proizvoditelyaLabel_Click);
            // 
            // strana_proizvoditelyaLabel
            // 
            strana_proizvoditelyaLabel.AutoSize = true;
            strana_proizvoditelyaLabel.BackColor = System.Drawing.Color.Transparent;
            strana_proizvoditelyaLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            strana_proizvoditelyaLabel.Location = new System.Drawing.Point(233, 180);
            strana_proizvoditelyaLabel.Name = "strana_proizvoditelyaLabel";
            strana_proizvoditelyaLabel.Size = new System.Drawing.Size(113, 22);
            strana_proizvoditelyaLabel.TabIndex = 21;
            strana_proizvoditelyaLabel.Text = "ID Персонал";
            strana_proizvoditelyaLabel.Click += new System.EventHandler(this.strana_proizvoditelyaLabel_Click);
            // 
            // name_BrandLabel
            // 
            name_BrandLabel.AutoSize = true;
            name_BrandLabel.BackColor = System.Drawing.Color.Transparent;
            name_BrandLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_BrandLabel.Location = new System.Drawing.Point(239, 130);
            name_BrandLabel.Name = "name_BrandLabel";
            name_BrandLabel.Size = new System.Drawing.Size(115, 22);
            name_BrandLabel.TabIndex = 19;
            name_BrandLabel.Text = "ID Продажа:";
            name_BrandLabel.Click += new System.EventHandler(this.name_BrandLabel_Click);
            // 
            // iD_BrandLabel
            // 
            iD_BrandLabel.AutoSize = true;
            iD_BrandLabel.BackColor = System.Drawing.Color.Transparent;
            iD_BrandLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_BrandLabel.Location = new System.Drawing.Point(240, 86);
            iD_BrandLabel.Name = "iD_BrandLabel";
            iD_BrandLabel.Size = new System.Drawing.Size(115, 22);
            iD_BrandLabel.TabIndex = 17;
            iD_BrandLabel.Text = "ID Машины:";
            iD_BrandLabel.Click += new System.EventHandler(this.iD_BrandLabel_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(247, 368);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 22);
            label1.TabIndex = 31;
            label1.Text = "Стоимость:";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(250, 324);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 22);
            label3.TabIndex = 29;
            label3.Text = " Персонал:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(321, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 33);
            this.label2.TabIndex = 34;
            this.label2.Text = "Продажа";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(256, 513);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(301, 40);
            this.button7.TabIndex = 41;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Tomato;
            this.button6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(408, 467);
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
            this.button5.Location = new System.Drawing.Point(256, 467);
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
            this.button4.Location = new System.Drawing.Point(563, 412);
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
            this.button3.Location = new System.Drawing.Point(408, 412);
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
            this.button2.Location = new System.Drawing.Point(256, 412);
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
            this.button1.Location = new System.Drawing.Point(104, 411);
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
            // car_saleBindingSource
            // 
            this.car_saleBindingSource.DataMember = "Car sale";
            this.car_saleBindingSource.DataSource = this._1DataSet;
            // 
            // car_saleTableAdapter
            // 
            this.car_saleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Brand_carTableAdapter = null;
            this.tableAdapterManager.BuyersTableAdapter = null;
            this.tableAdapterManager.Car_saleTableAdapter = this.car_saleTableAdapter;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp13._1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // car_saleBindingNavigator
            // 
            this.car_saleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.car_saleBindingNavigator.BindingSource = this.car_saleBindingSource;
            this.car_saleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.car_saleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.car_saleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.car_saleBindingNavigatorSaveItem});
            this.car_saleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.car_saleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.car_saleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.car_saleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.car_saleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.car_saleBindingNavigator.Name = "car_saleBindingNavigator";
            this.car_saleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.car_saleBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.car_saleBindingNavigator.TabIndex = 42;
            this.car_saleBindingNavigator.Text = "bindingNavigator1";
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
            // car_saleBindingNavigatorSaveItem
            // 
            this.car_saleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.car_saleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("car_saleBindingNavigatorSaveItem.Image")));
            this.car_saleBindingNavigatorSaveItem.Name = "car_saleBindingNavigatorSaveItem";
            this.car_saleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.car_saleBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.car_saleBindingNavigatorSaveItem.Click += new System.EventHandler(this.car_saleBindingNavigatorSaveItem_Click);
            // 
            // iD_CarsTextBox
            // 
            this.iD_CarsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_saleBindingSource, "ID_Cars", true));
            this.iD_CarsTextBox.Location = new System.Drawing.Point(368, 86);
            this.iD_CarsTextBox.Name = "iD_CarsTextBox";
            this.iD_CarsTextBox.Size = new System.Drawing.Size(147, 20);
            this.iD_CarsTextBox.TabIndex = 43;
            // 
            // iD_SaleTextBox
            // 
            this.iD_SaleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_saleBindingSource, "ID_Sale", true));
            this.iD_SaleTextBox.Location = new System.Drawing.Point(368, 135);
            this.iD_SaleTextBox.Name = "iD_SaleTextBox";
            this.iD_SaleTextBox.Size = new System.Drawing.Size(147, 20);
            this.iD_SaleTextBox.TabIndex = 44;
            // 
            // iD_PersonalTextBox
            // 
            this.iD_PersonalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_saleBindingSource, "ID_Personal", true));
            this.iD_PersonalTextBox.Location = new System.Drawing.Point(368, 185);
            this.iD_PersonalTextBox.Name = "iD_PersonalTextBox";
            this.iD_PersonalTextBox.Size = new System.Drawing.Size(147, 20);
            this.iD_PersonalTextBox.TabIndex = 45;
            // 
            // dateTextBox
            // 
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_saleBindingSource, "Date", true));
            this.dateTextBox.Location = new System.Drawing.Point(368, 230);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(147, 20);
            this.dateTextBox.TabIndex = 46;
            // 
            // carTextBox
            // 
            this.carTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_saleBindingSource, "Car", true));
            this.carTextBox.Location = new System.Drawing.Point(368, 277);
            this.carTextBox.Name = "carTextBox";
            this.carTextBox.Size = new System.Drawing.Size(147, 20);
            this.carTextBox.TabIndex = 47;
            // 
            // personalTextBox
            // 
            this.personalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_saleBindingSource, "Personal", true));
            this.personalTextBox.Location = new System.Drawing.Point(368, 329);
            this.personalTextBox.Name = "personalTextBox";
            this.personalTextBox.Size = new System.Drawing.Size(147, 20);
            this.personalTextBox.TabIndex = 48;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_saleBindingSource, "Salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(368, 373);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(147, 20);
            this.salaryTextBox.TabIndex = 49;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(256, 582);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(301, 44);
            this.button8.TabIndex = 50;
            this.button8.Text = "Табличный вид";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 647);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.personalTextBox);
            this.Controls.Add(this.carTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.iD_PersonalTextBox);
            this.Controls.Add(this.iD_SaleTextBox);
            this.Controls.Add(this.iD_CarsTextBox);
            this.Controls.Add(this.car_saleBindingNavigator);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(label3);
            this.Controls.Add(addressLabel);
            this.Controls.Add(zavod_proizvoditelyaLabel);
            this.Controls.Add(strana_proizvoditelyaLabel);
            this.Controls.Add(name_BrandLabel);
            this.Controls.Add(iD_BrandLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this._1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_saleBindingNavigator)).EndInit();
            this.car_saleBindingNavigator.ResumeLayout(false);
            this.car_saleBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private _1DataSet _1DataSet;
        private System.Windows.Forms.BindingSource car_saleBindingSource;
        private _1DataSetTableAdapters.Car_saleTableAdapter car_saleTableAdapter;
        private _1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator car_saleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton car_saleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_CarsTextBox;
        private System.Windows.Forms.TextBox iD_SaleTextBox;
        private System.Windows.Forms.TextBox iD_PersonalTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox carTextBox;
        private System.Windows.Forms.TextBox personalTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Button button8;
    }
}