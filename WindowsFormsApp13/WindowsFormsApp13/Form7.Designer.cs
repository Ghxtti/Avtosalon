namespace WindowsFormsApp13
{
    partial class Form7
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
            System.Windows.Forms.Label zavod_proizvoditelyaLabel;
            System.Windows.Forms.Label strana_proizvoditelyaLabel;
            System.Windows.Forms.Label name_BrandLabel;
            System.Windows.Forms.Label iD_BrandLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this._1DataSet = new WindowsFormsApp13._1DataSet();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalTableAdapter = new WindowsFormsApp13._1DataSetTableAdapters.PersonalTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp13._1DataSetTableAdapters.TableAdapterManager();
            this.personalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.personalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_PersonalTextBox = new System.Windows.Forms.TextBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.experienceTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            zavod_proizvoditelyaLabel = new System.Windows.Forms.Label();
            strana_proizvoditelyaLabel = new System.Windows.Forms.Label();
            name_BrandLabel = new System.Windows.Forms.Label();
            iD_BrandLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingNavigator)).BeginInit();
            this.personalBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // zavod_proizvoditelyaLabel
            // 
            zavod_proizvoditelyaLabel.AutoSize = true;
            zavod_proizvoditelyaLabel.BackColor = System.Drawing.Color.Transparent;
            zavod_proizvoditelyaLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            zavod_proizvoditelyaLabel.ForeColor = System.Drawing.Color.AliceBlue;
            zavod_proizvoditelyaLabel.Location = new System.Drawing.Point(197, 282);
            zavod_proizvoditelyaLabel.Name = "zavod_proizvoditelyaLabel";
            zavod_proizvoditelyaLabel.Size = new System.Drawing.Size(160, 22);
            zavod_proizvoditelyaLabel.TabIndex = 24;
            zavod_proizvoditelyaLabel.Text = "Заробтная плата:";
            // 
            // strana_proizvoditelyaLabel
            // 
            strana_proizvoditelyaLabel.AutoSize = true;
            strana_proizvoditelyaLabel.BackColor = System.Drawing.Color.Transparent;
            strana_proizvoditelyaLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            strana_proizvoditelyaLabel.ForeColor = System.Drawing.Color.AliceBlue;
            strana_proizvoditelyaLabel.Location = new System.Drawing.Point(300, 231);
            strana_proizvoditelyaLabel.Name = "strana_proizvoditelyaLabel";
            strana_proizvoditelyaLabel.Size = new System.Drawing.Size(64, 22);
            strana_proizvoditelyaLabel.TabIndex = 22;
            strana_proizvoditelyaLabel.Text = "Опыт:";
            // 
            // name_BrandLabel
            // 
            name_BrandLabel.AutoSize = true;
            name_BrandLabel.BackColor = System.Drawing.Color.Transparent;
            name_BrandLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_BrandLabel.ForeColor = System.Drawing.Color.AliceBlue;
            name_BrandLabel.Location = new System.Drawing.Point(306, 181);
            name_BrandLabel.Name = "name_BrandLabel";
            name_BrandLabel.Size = new System.Drawing.Size(58, 22);
            name_BrandLabel.TabIndex = 20;
            name_BrandLabel.Text = "ФИО:";
            // 
            // iD_BrandLabel
            // 
            iD_BrandLabel.AutoSize = true;
            iD_BrandLabel.BackColor = System.Drawing.Color.Transparent;
            iD_BrandLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_BrandLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            iD_BrandLabel.Location = new System.Drawing.Point(241, 142);
            iD_BrandLabel.Name = "iD_BrandLabel";
            iD_BrandLabel.Size = new System.Drawing.Size(119, 22);
            iD_BrandLabel.TabIndex = 18;
            iD_BrandLabel.Text = "ID Персонал:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(316, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Персонал\r\n";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(245, 461);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(301, 40);
            this.button7.TabIndex = 34;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.OrangeRed;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(397, 396);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 40);
            this.button6.TabIndex = 33;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(245, 396);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 40);
            this.button5.TabIndex = 32;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(552, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 40);
            this.button4.TabIndex = 31;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(397, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 40);
            this.button3.TabIndex = 30;
            this.button3.Text = "Следующий";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(245, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 40);
            this.button2.TabIndex = 29;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(93, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 41);
            this.button1.TabIndex = 28;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _1DataSet
            // 
            this._1DataSet.DataSetName = "_1DataSet";
            this._1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this._1DataSet;
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
            // personalBindingNavigator
            // 
            this.personalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personalBindingNavigator.BindingSource = this.personalBindingSource;
            this.personalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.personalBindingNavigatorSaveItem});
            this.personalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personalBindingNavigator.Name = "personalBindingNavigator";
            this.personalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personalBindingNavigator.Size = new System.Drawing.Size(770, 25);
            this.personalBindingNavigator.TabIndex = 35;
            this.personalBindingNavigator.Text = "bindingNavigator1";
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
            // personalBindingNavigatorSaveItem
            // 
            this.personalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personalBindingNavigatorSaveItem.Image")));
            this.personalBindingNavigatorSaveItem.Name = "personalBindingNavigatorSaveItem";
            this.personalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personalBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.personalBindingNavigatorSaveItem.Click += new System.EventHandler(this.personalBindingNavigatorSaveItem_Click);
            // 
            // iD_PersonalTextBox
            // 
            this.iD_PersonalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "ID_Personal", true));
            this.iD_PersonalTextBox.Location = new System.Drawing.Point(371, 146);
            this.iD_PersonalTextBox.Name = "iD_PersonalTextBox";
            this.iD_PersonalTextBox.Size = new System.Drawing.Size(138, 20);
            this.iD_PersonalTextBox.TabIndex = 36;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(371, 185);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(138, 20);
            this.fIOTextBox.TabIndex = 37;
            // 
            // experienceTextBox
            // 
            this.experienceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "experience", true));
            this.experienceTextBox.Location = new System.Drawing.Point(371, 235);
            this.experienceTextBox.Name = "experienceTextBox";
            this.experienceTextBox.Size = new System.Drawing.Size(138, 20);
            this.experienceTextBox.TabIndex = 38;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(371, 282);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(138, 20);
            this.salaryTextBox.TabIndex = 39;
            this.salaryTextBox.TextChanged += new System.EventHandler(this.salaryTextBox_TextChanged);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 558);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.experienceTextBox);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(this.iD_PersonalTextBox);
            this.Controls.Add(this.personalBindingNavigator);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(zavod_proizvoditelyaLabel);
            this.Controls.Add(strana_proizvoditelyaLabel);
            this.Controls.Add(name_BrandLabel);
            this.Controls.Add(iD_BrandLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this._1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingNavigator)).EndInit();
            this.personalBindingNavigator.ResumeLayout(false);
            this.personalBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private _1DataSet _1DataSet;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private _1DataSetTableAdapters.PersonalTableAdapter personalTableAdapter;
        private _1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personalBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton personalBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_PersonalTextBox;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.TextBox experienceTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
    }
}