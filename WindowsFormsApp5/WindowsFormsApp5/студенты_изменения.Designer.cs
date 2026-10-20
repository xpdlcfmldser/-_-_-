namespace WindowsFormsApp5
{
    partial class студенты_изменения
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label midle_NameLabel;
            System.Windows.Forms.Label telefon_NumberLabel;
            System.Windows.Forms.Label nomer_KomnatyLabel;
            System.Windows.Forms.Label name_GruppaLabel;
            System.Windows.Forms.Label name_InventarLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(студенты_изменения));
            System.Windows.Forms.Label iD_KomnataLabel;
            System.Windows.Forms.Label iD_GruppaLabel;
            System.Windows.Forms.Label iD_InventarLabel;
            this.obshaga_30_1_08DataSet = new WindowsFormsApp5.Obshaga_30_1_08DataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new WindowsFormsApp5.Obshaga_30_1_08DataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp5.Obshaga_30_1_08DataSetTableAdapters.TableAdapterManager();
            this.studentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.midle_NameTextBox = new System.Windows.Forms.TextBox();
            this.telefon_NumberTextBox = new System.Windows.Forms.TextBox();
            this.komnatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komnatsTableAdapter = new WindowsFormsApp5.Obshaga_30_1_08DataSetTableAdapters.KomnatsTableAdapter();
            this.nomer_KomnatyComboBox = new System.Windows.Forms.ComboBox();
            this.gruppsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruppsTableAdapter = new WindowsFormsApp5.Obshaga_30_1_08DataSetTableAdapters.GruppsTableAdapter();
            this.name_GruppaComboBox = new System.Windows.Forms.ComboBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new WindowsFormsApp5.Obshaga_30_1_08DataSetTableAdapters.InventoryTableAdapter();
            this.name_InventarComboBox = new System.Windows.Forms.ComboBox();
            this.fKStudentsKomnatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.iD_KomnataTextBox = new System.Windows.Forms.TextBox();
            this.iD_GruppaTextBox = new System.Windows.Forms.TextBox();
            this.iD_InventarTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            midle_NameLabel = new System.Windows.Forms.Label();
            telefon_NumberLabel = new System.Windows.Forms.Label();
            nomer_KomnatyLabel = new System.Windows.Forms.Label();
            name_GruppaLabel = new System.Windows.Forms.Label();
            name_InventarLabel = new System.Windows.Forms.Label();
            iD_KomnataLabel = new System.Windows.Forms.Label();
            iD_GruppaLabel = new System.Windows.Forms.Label();
            iD_InventarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.obshaga_30_1_08DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).BeginInit();
            this.studentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.komnatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStudentsKomnatsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(66, 77);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(70, 121);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 3;
            surnameLabel.Text = "Surname:";
            // 
            // midle_NameLabel
            // 
            midle_NameLabel.AutoSize = true;
            midle_NameLabel.Location = new System.Drawing.Point(71, 165);
            midle_NameLabel.Name = "midle_NameLabel";
            midle_NameLabel.Size = new System.Drawing.Size(66, 13);
            midle_NameLabel.TabIndex = 5;
            midle_NameLabel.Text = "Midle Name:";
            // 
            // telefon_NumberLabel
            // 
            telefon_NumberLabel.AutoSize = true;
            telefon_NumberLabel.Location = new System.Drawing.Point(72, 209);
            telefon_NumberLabel.Name = "telefon_NumberLabel";
            telefon_NumberLabel.Size = new System.Drawing.Size(86, 13);
            telefon_NumberLabel.TabIndex = 7;
            telefon_NumberLabel.Text = "Telefon Number:";
            // 
            // nomer_KomnatyLabel
            // 
            nomer_KomnatyLabel.AutoSize = true;
            nomer_KomnatyLabel.Location = new System.Drawing.Point(71, 254);
            nomer_KomnatyLabel.Name = "nomer_KomnatyLabel";
            nomer_KomnatyLabel.Size = new System.Drawing.Size(85, 13);
            nomer_KomnatyLabel.TabIndex = 9;
            nomer_KomnatyLabel.Text = "Nomer Komnaty:";
            // 
            // name_GruppaLabel
            // 
            name_GruppaLabel.AutoSize = true;
            name_GruppaLabel.Location = new System.Drawing.Point(75, 300);
            name_GruppaLabel.Name = "name_GruppaLabel";
            name_GruppaLabel.Size = new System.Drawing.Size(76, 13);
            name_GruppaLabel.TabIndex = 11;
            name_GruppaLabel.Text = "Name Gruppa:";
            // 
            // name_InventarLabel
            // 
            name_InventarLabel.AutoSize = true;
            name_InventarLabel.Location = new System.Drawing.Point(84, 347);
            name_InventarLabel.Name = "name_InventarLabel";
            name_InventarLabel.Size = new System.Drawing.Size(80, 13);
            name_InventarLabel.TabIndex = 13;
            name_InventarLabel.Text = "Name Inventar:";
            // 
            // obshaga_30_1_08DataSet
            // 
            this.obshaga_30_1_08DataSet.DataSetName = "Obshaga_30_1_08DataSet";
            this.obshaga_30_1_08DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.obshaga_30_1_08DataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GruppsTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.KomnatsTableAdapter = null;
            this.tableAdapterManager.LoginsTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp5.Obshaga_30_1_08DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentsBindingNavigator
            // 
            this.studentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentsBindingNavigator.BindingSource = this.studentsBindingSource;
            this.studentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentsBindingNavigatorSaveItem});
            this.studentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentsBindingNavigator.Name = "studentsBindingNavigator";
            this.studentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentsBindingNavigator.Size = new System.Drawing.Size(697, 25);
            this.studentsBindingNavigator.TabIndex = 0;
            this.studentsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // studentsBindingNavigatorSaveItem
            // 
            this.studentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsBindingNavigatorSaveItem.Image")));
            this.studentsBindingNavigatorSaveItem.Name = "studentsBindingNavigatorSaveItem";
            this.studentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.studentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentsBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(110, 74);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(128, 118);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 4;
            // 
            // midle_NameTextBox
            // 
            this.midle_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Midle_Name", true));
            this.midle_NameTextBox.Location = new System.Drawing.Point(143, 162);
            this.midle_NameTextBox.Name = "midle_NameTextBox";
            this.midle_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.midle_NameTextBox.TabIndex = 6;
            // 
            // telefon_NumberTextBox
            // 
            this.telefon_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Telefon_Number", true));
            this.telefon_NumberTextBox.Location = new System.Drawing.Point(164, 206);
            this.telefon_NumberTextBox.Name = "telefon_NumberTextBox";
            this.telefon_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefon_NumberTextBox.TabIndex = 8;
            // 
            // komnatsBindingSource
            // 
            this.komnatsBindingSource.DataMember = "Komnats";
            this.komnatsBindingSource.DataSource = this.obshaga_30_1_08DataSet;
            // 
            // komnatsTableAdapter
            // 
            this.komnatsTableAdapter.ClearBeforeFill = true;
            // 
            // nomer_KomnatyComboBox
            // 
            this.nomer_KomnatyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komnatsBindingSource, "Nomer_Komnaty", true));
            this.nomer_KomnatyComboBox.DataSource = this.komnatsBindingSource;
            this.nomer_KomnatyComboBox.DisplayMember = "Nomer_Komnaty";
            this.nomer_KomnatyComboBox.FormattingEnabled = true;
            this.nomer_KomnatyComboBox.Location = new System.Drawing.Point(162, 251);
            this.nomer_KomnatyComboBox.Name = "nomer_KomnatyComboBox";
            this.nomer_KomnatyComboBox.Size = new System.Drawing.Size(121, 21);
            this.nomer_KomnatyComboBox.TabIndex = 10;
            this.nomer_KomnatyComboBox.ValueMember = "ID_Komnata";
            // 
            // gruppsBindingSource
            // 
            this.gruppsBindingSource.DataMember = "Grupps";
            this.gruppsBindingSource.DataSource = this.obshaga_30_1_08DataSet;
            // 
            // gruppsTableAdapter
            // 
            this.gruppsTableAdapter.ClearBeforeFill = true;
            // 
            // name_GruppaComboBox
            // 
            this.name_GruppaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruppsBindingSource, "Name_Gruppa", true));
            this.name_GruppaComboBox.DataSource = this.gruppsBindingSource;
            this.name_GruppaComboBox.DisplayMember = "Name_Gruppa";
            this.name_GruppaComboBox.FormattingEnabled = true;
            this.name_GruppaComboBox.Location = new System.Drawing.Point(157, 297);
            this.name_GruppaComboBox.Name = "name_GruppaComboBox";
            this.name_GruppaComboBox.Size = new System.Drawing.Size(121, 21);
            this.name_GruppaComboBox.TabIndex = 12;
            this.name_GruppaComboBox.ValueMember = "ID_Gruppa";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.obshaga_30_1_08DataSet;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // name_InventarComboBox
            // 
            this.name_InventarComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Name_Inventar", true));
            this.name_InventarComboBox.DataSource = this.inventoryBindingSource;
            this.name_InventarComboBox.DisplayMember = "Name_Inventar";
            this.name_InventarComboBox.FormattingEnabled = true;
            this.name_InventarComboBox.Location = new System.Drawing.Point(170, 344);
            this.name_InventarComboBox.Name = "name_InventarComboBox";
            this.name_InventarComboBox.Size = new System.Drawing.Size(121, 21);
            this.name_InventarComboBox.TabIndex = 14;
            this.name_InventarComboBox.ValueMember = "ID_Inventar";
            // 
            // fKStudentsKomnatsBindingSource
            // 
            this.fKStudentsKomnatsBindingSource.DataMember = "FK_Students_Komnats";
            this.fKStudentsKomnatsBindingSource.DataSource = this.komnatsBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(497, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "Отчистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iD_KomnataLabel
            // 
            iD_KomnataLabel.AutoSize = true;
            iD_KomnataLabel.Location = new System.Drawing.Point(289, 254);
            iD_KomnataLabel.Name = "iD_KomnataLabel";
            iD_KomnataLabel.Size = new System.Drawing.Size(66, 13);
            iD_KomnataLabel.TabIndex = 17;
            iD_KomnataLabel.Text = "ID Komnata:";
            iD_KomnataLabel.Visible = false;
            // 
            // iD_KomnataTextBox
            // 
            this.iD_KomnataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komnatsBindingSource, "ID_Komnata", true));
            this.iD_KomnataTextBox.Location = new System.Drawing.Point(361, 251);
            this.iD_KomnataTextBox.Name = "iD_KomnataTextBox";
            this.iD_KomnataTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_KomnataTextBox.TabIndex = 18;
            this.iD_KomnataTextBox.Visible = false;
            // 
            // iD_GruppaLabel
            // 
            iD_GruppaLabel.AutoSize = true;
            iD_GruppaLabel.Location = new System.Drawing.Point(296, 305);
            iD_GruppaLabel.Name = "iD_GruppaLabel";
            iD_GruppaLabel.Size = new System.Drawing.Size(59, 13);
            iD_GruppaLabel.TabIndex = 19;
            iD_GruppaLabel.Text = "ID Gruppa:";
            iD_GruppaLabel.Visible = false;
            // 
            // iD_GruppaTextBox
            // 
            this.iD_GruppaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruppsBindingSource, "ID_Gruppa", true));
            this.iD_GruppaTextBox.Location = new System.Drawing.Point(361, 302);
            this.iD_GruppaTextBox.Name = "iD_GruppaTextBox";
            this.iD_GruppaTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_GruppaTextBox.TabIndex = 20;
            this.iD_GruppaTextBox.Visible = false;
            // 
            // iD_InventarLabel
            // 
            iD_InventarLabel.AutoSize = true;
            iD_InventarLabel.Location = new System.Drawing.Point(309, 347);
            iD_InventarLabel.Name = "iD_InventarLabel";
            iD_InventarLabel.Size = new System.Drawing.Size(63, 13);
            iD_InventarLabel.TabIndex = 21;
            iD_InventarLabel.Text = "ID Inventar:";
            iD_InventarLabel.Visible = false;
            // 
            // iD_InventarTextBox
            // 
            this.iD_InventarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "ID_Inventar", true));
            this.iD_InventarTextBox.Location = new System.Drawing.Point(378, 344);
            this.iD_InventarTextBox.Name = "iD_InventarTextBox";
            this.iD_InventarTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_InventarTextBox.TabIndex = 22;
            this.iD_InventarTextBox.Visible = false;
            // 
            // студенты_изменения
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 453);
            this.Controls.Add(iD_InventarLabel);
            this.Controls.Add(this.iD_InventarTextBox);
            this.Controls.Add(iD_GruppaLabel);
            this.Controls.Add(this.iD_GruppaTextBox);
            this.Controls.Add(iD_KomnataLabel);
            this.Controls.Add(this.iD_KomnataTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(name_InventarLabel);
            this.Controls.Add(this.name_InventarComboBox);
            this.Controls.Add(name_GruppaLabel);
            this.Controls.Add(this.name_GruppaComboBox);
            this.Controls.Add(nomer_KomnatyLabel);
            this.Controls.Add(this.nomer_KomnatyComboBox);
            this.Controls.Add(telefon_NumberLabel);
            this.Controls.Add(this.telefon_NumberTextBox);
            this.Controls.Add(midle_NameLabel);
            this.Controls.Add(this.midle_NameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.studentsBindingNavigator);
            this.Name = "студенты_изменения";
            this.Text = "студенты_изменения";
            this.Load += new System.EventHandler(this.студенты_изменения_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obshaga_30_1_08DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).EndInit();
            this.studentsBindingNavigator.ResumeLayout(false);
            this.studentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.komnatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStudentsKomnatsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Obshaga_30_1_08DataSet obshaga_30_1_08DataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private Obshaga_30_1_08DataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private Obshaga_30_1_08DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentsBindingNavigatorSaveItem;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox surnameTextBox;
        public System.Windows.Forms.TextBox midle_NameTextBox;
        public System.Windows.Forms.TextBox telefon_NumberTextBox;
        private System.Windows.Forms.BindingSource komnatsBindingSource;
        private Obshaga_30_1_08DataSetTableAdapters.KomnatsTableAdapter komnatsTableAdapter;
        private System.Windows.Forms.ComboBox nomer_KomnatyComboBox;
        private System.Windows.Forms.BindingSource gruppsBindingSource;
        private Obshaga_30_1_08DataSetTableAdapters.GruppsTableAdapter gruppsTableAdapter;
        private System.Windows.Forms.ComboBox name_GruppaComboBox;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private Obshaga_30_1_08DataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.ComboBox name_InventarComboBox;
        private System.Windows.Forms.BindingSource fKStudentsKomnatsBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox iD_KomnataTextBox;
        private System.Windows.Forms.TextBox iD_GruppaTextBox;
        private System.Windows.Forms.TextBox iD_InventarTextBox;
    }
}