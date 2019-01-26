namespace MagoBox
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderTileModifiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderObjectPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderSpecialItemPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderItemPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderBossPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderEnemyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.objTab = new System.Windows.Forms.TabPage();
            this.cloneObj = new System.Windows.Forms.Button();
            this.editObj = new System.Windows.Forms.Button();
            this.delObj = new System.Windows.Forms.Button();
            this.addObj = new System.Windows.Forms.Button();
            this.objList = new System.Windows.Forms.ListBox();
            this.specItemTab = new System.Windows.Forms.TabPage();
            this.cloneSpecItem = new System.Windows.Forms.Button();
            this.editSpecItem = new System.Windows.Forms.Button();
            this.delSpecItem = new System.Windows.Forms.Button();
            this.addSpecItem = new System.Windows.Forms.Button();
            this.specItemList = new System.Windows.Forms.ListBox();
            this.itemTab = new System.Windows.Forms.TabPage();
            this.cloneItem = new System.Windows.Forms.Button();
            this.editItem = new System.Windows.Forms.Button();
            this.delItem = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.itemList = new System.Windows.Forms.ListBox();
            this.bossTab = new System.Windows.Forms.TabPage();
            this.cloneBoss = new System.Windows.Forms.Button();
            this.editBoss = new System.Windows.Forms.Button();
            this.delBoss = new System.Windows.Forms.Button();
            this.addBoss = new System.Windows.Forms.Button();
            this.bossList = new System.Windows.Forms.ListBox();
            this.enemyTab = new System.Windows.Forms.TabPage();
            this.cloneEnemy = new System.Windows.Forms.Button();
            this.editEnemy = new System.Windows.Forms.Button();
            this.delEnemy = new System.Windows.Forms.Button();
            this.addEnemy = new System.Windows.Forms.Button();
            this.enemyList = new System.Windows.Forms.ListBox();
            this.glControl = new OpenTK.GLControl();
            this.resetCamera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xCoord = new System.Windows.Forms.NumericUpDown();
            this.xOffset = new System.Windows.Forms.NumericUpDown();
            this.yOffset = new System.Windows.Forms.NumericUpDown();
            this.yCoord = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.editDeco = new System.Windows.Forms.CheckBox();
            this.editBlock = new System.Windows.Forms.CheckBox();
            this.editCol = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.d3_4 = new System.Windows.Forms.NumericUpDown();
            this.d1_1 = new System.Windows.Forms.NumericUpDown();
            this.d3_3 = new System.Windows.Forms.NumericUpDown();
            this.d1_2 = new System.Windows.Forms.NumericUpDown();
            this.d3_2 = new System.Windows.Forms.NumericUpDown();
            this.d1_3 = new System.Windows.Forms.NumericUpDown();
            this.d3_1 = new System.Windows.Forms.NumericUpDown();
            this.d1_4 = new System.Windows.Forms.NumericUpDown();
            this.d2_4 = new System.Windows.Forms.NumericUpDown();
            this.d2_1 = new System.Windows.Forms.NumericUpDown();
            this.d2_3 = new System.Windows.Forms.NumericUpDown();
            this.d2_2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.vblock = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vshape = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vmat = new System.Windows.Forms.NumericUpDown();
            this.vautomove = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.pick = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeH = new System.Windows.Forms.NumericUpDown();
            this.sizeW = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.blockImg = new System.Windows.Forms.PictureBox();
            this.colImg = new System.Windows.Forms.PictureBox();
            this.ice = new System.Windows.Forms.CheckBox();
            this.spike = new System.Windows.Forms.CheckBox();
            this.boundary = new System.Windows.Forms.CheckBox();
            this.ladder = new System.Windows.Forms.CheckBox();
            this.water = new System.Windows.Forms.CheckBox();
            this.lava = new System.Windows.Forms.CheckBox();
            this.draw = new System.Windows.Forms.Button();
            this.move = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.objTab.SuspendLayout();
            this.specItemTab.SuspendLayout();
            this.itemTab.SuspendLayout();
            this.bossTab.SuspendLayout();
            this.enemyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xCoord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoord)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d3_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vblock)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vshape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vautomove)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colImg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.stageSettingsToolStripMenuItem,
            this.renderSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // stageSettingsToolStripMenuItem
            // 
            this.stageSettingsToolStripMenuItem.Name = "stageSettingsToolStripMenuItem";
            this.stageSettingsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.stageSettingsToolStripMenuItem.Text = "Stage Settings";
            this.stageSettingsToolStripMenuItem.Click += new System.EventHandler(this.stageSettingsToolStripMenuItem_Click);
            // 
            // renderSettingsToolStripMenuItem
            // 
            this.renderSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renderTileModifiersToolStripMenuItem,
            this.renderBlocksToolStripMenuItem,
            this.renderObjectPointsToolStripMenuItem,
            this.renderSpecialItemPointsToolStripMenuItem,
            this.renderItemPointsToolStripMenuItem,
            this.renderBossPointsToolStripMenuItem,
            this.renderEnemyPointsToolStripMenuItem});
            this.renderSettingsToolStripMenuItem.Name = "renderSettingsToolStripMenuItem";
            this.renderSettingsToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.renderSettingsToolStripMenuItem.Text = "Render Settings";
            // 
            // renderTileModifiersToolStripMenuItem
            // 
            this.renderTileModifiersToolStripMenuItem.Checked = true;
            this.renderTileModifiersToolStripMenuItem.CheckOnClick = true;
            this.renderTileModifiersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renderTileModifiersToolStripMenuItem.Name = "renderTileModifiersToolStripMenuItem";
            this.renderTileModifiersToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.renderTileModifiersToolStripMenuItem.Text = "Render Tile Modifiers";
            // 
            // renderBlocksToolStripMenuItem
            // 
            this.renderBlocksToolStripMenuItem.Checked = true;
            this.renderBlocksToolStripMenuItem.CheckOnClick = true;
            this.renderBlocksToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renderBlocksToolStripMenuItem.Name = "renderBlocksToolStripMenuItem";
            this.renderBlocksToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.renderBlocksToolStripMenuItem.Text = "Render Blocks";
            // 
            // renderObjectPointsToolStripMenuItem
            // 
            this.renderObjectPointsToolStripMenuItem.Checked = true;
            this.renderObjectPointsToolStripMenuItem.CheckOnClick = true;
            this.renderObjectPointsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renderObjectPointsToolStripMenuItem.Name = "renderObjectPointsToolStripMenuItem";
            this.renderObjectPointsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.renderObjectPointsToolStripMenuItem.Text = "Render Object Points";
            // 
            // renderSpecialItemPointsToolStripMenuItem
            // 
            this.renderSpecialItemPointsToolStripMenuItem.Checked = true;
            this.renderSpecialItemPointsToolStripMenuItem.CheckOnClick = true;
            this.renderSpecialItemPointsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renderSpecialItemPointsToolStripMenuItem.Name = "renderSpecialItemPointsToolStripMenuItem";
            this.renderSpecialItemPointsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.renderSpecialItemPointsToolStripMenuItem.Text = "Render Special Item Points";
            // 
            // renderItemPointsToolStripMenuItem
            // 
            this.renderItemPointsToolStripMenuItem.Checked = true;
            this.renderItemPointsToolStripMenuItem.CheckOnClick = true;
            this.renderItemPointsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renderItemPointsToolStripMenuItem.Name = "renderItemPointsToolStripMenuItem";
            this.renderItemPointsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.renderItemPointsToolStripMenuItem.Text = "Render Item Points";
            // 
            // renderBossPointsToolStripMenuItem
            // 
            this.renderBossPointsToolStripMenuItem.Checked = true;
            this.renderBossPointsToolStripMenuItem.CheckOnClick = true;
            this.renderBossPointsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renderBossPointsToolStripMenuItem.Name = "renderBossPointsToolStripMenuItem";
            this.renderBossPointsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.renderBossPointsToolStripMenuItem.Text = "Render Boss Points";
            // 
            // renderEnemyPointsToolStripMenuItem
            // 
            this.renderEnemyPointsToolStripMenuItem.Checked = true;
            this.renderEnemyPointsToolStripMenuItem.CheckOnClick = true;
            this.renderEnemyPointsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renderEnemyPointsToolStripMenuItem.Name = "renderEnemyPointsToolStripMenuItem";
            this.renderEnemyPointsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.renderEnemyPointsToolStripMenuItem.Text = "Render Enemy Points";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 464);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object Lists";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.objTab);
            this.tabControl1.Controls.Add(this.specItemTab);
            this.tabControl1.Controls.Add(this.itemTab);
            this.tabControl1.Controls.Add(this.bossTab);
            this.tabControl1.Controls.Add(this.enemyTab);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(266, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // objTab
            // 
            this.objTab.Controls.Add(this.cloneObj);
            this.objTab.Controls.Add(this.editObj);
            this.objTab.Controls.Add(this.delObj);
            this.objTab.Controls.Add(this.addObj);
            this.objTab.Controls.Add(this.objList);
            this.objTab.Location = new System.Drawing.Point(4, 22);
            this.objTab.Name = "objTab";
            this.objTab.Padding = new System.Windows.Forms.Padding(3);
            this.objTab.Size = new System.Drawing.Size(258, 412);
            this.objTab.TabIndex = 0;
            this.objTab.Text = "Objects";
            this.objTab.UseVisualStyleBackColor = true;
            // 
            // cloneObj
            // 
            this.cloneObj.Location = new System.Drawing.Point(187, 385);
            this.cloneObj.Name = "cloneObj";
            this.cloneObj.Size = new System.Drawing.Size(60, 23);
            this.cloneObj.TabIndex = 4;
            this.cloneObj.Text = "Duplicate";
            this.cloneObj.UseVisualStyleBackColor = true;
            this.cloneObj.Click += new System.EventHandler(this.cloneObj_Click);
            // 
            // editObj
            // 
            this.editObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editObj.Location = new System.Drawing.Point(121, 385);
            this.editObj.Name = "editObj";
            this.editObj.Size = new System.Drawing.Size(60, 23);
            this.editObj.TabIndex = 3;
            this.editObj.Text = "Edit";
            this.editObj.UseVisualStyleBackColor = true;
            this.editObj.Click += new System.EventHandler(this.editObj_Click);
            // 
            // delObj
            // 
            this.delObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delObj.Location = new System.Drawing.Point(69, 385);
            this.delObj.Name = "delObj";
            this.delObj.Size = new System.Drawing.Size(46, 23);
            this.delObj.TabIndex = 2;
            this.delObj.Text = "-";
            this.delObj.UseVisualStyleBackColor = true;
            this.delObj.Click += new System.EventHandler(this.delObj_Click);
            // 
            // addObj
            // 
            this.addObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addObj.Location = new System.Drawing.Point(17, 385);
            this.addObj.Name = "addObj";
            this.addObj.Size = new System.Drawing.Size(46, 23);
            this.addObj.TabIndex = 1;
            this.addObj.Text = "+";
            this.addObj.UseVisualStyleBackColor = true;
            this.addObj.Click += new System.EventHandler(this.addObj_Click);
            // 
            // objList
            // 
            this.objList.FormattingEnabled = true;
            this.objList.Location = new System.Drawing.Point(5, 5);
            this.objList.Name = "objList";
            this.objList.Size = new System.Drawing.Size(248, 368);
            this.objList.TabIndex = 0;
            this.objList.SelectedIndexChanged += new System.EventHandler(this.objList_SelectedIndexChanged);
            this.objList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.objList_MouseDoubleClick);
            // 
            // specItemTab
            // 
            this.specItemTab.Controls.Add(this.cloneSpecItem);
            this.specItemTab.Controls.Add(this.editSpecItem);
            this.specItemTab.Controls.Add(this.delSpecItem);
            this.specItemTab.Controls.Add(this.addSpecItem);
            this.specItemTab.Controls.Add(this.specItemList);
            this.specItemTab.Location = new System.Drawing.Point(4, 22);
            this.specItemTab.Name = "specItemTab";
            this.specItemTab.Padding = new System.Windows.Forms.Padding(3);
            this.specItemTab.Size = new System.Drawing.Size(258, 412);
            this.specItemTab.TabIndex = 1;
            this.specItemTab.Text = "Special Items";
            this.specItemTab.UseVisualStyleBackColor = true;
            // 
            // cloneSpecItem
            // 
            this.cloneSpecItem.Location = new System.Drawing.Point(187, 385);
            this.cloneSpecItem.Name = "cloneSpecItem";
            this.cloneSpecItem.Size = new System.Drawing.Size(60, 23);
            this.cloneSpecItem.TabIndex = 8;
            this.cloneSpecItem.Text = "Duplicate";
            this.cloneSpecItem.UseVisualStyleBackColor = true;
            this.cloneSpecItem.Click += new System.EventHandler(this.cloneSpecItem_Click);
            // 
            // editSpecItem
            // 
            this.editSpecItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSpecItem.Location = new System.Drawing.Point(121, 385);
            this.editSpecItem.Name = "editSpecItem";
            this.editSpecItem.Size = new System.Drawing.Size(60, 23);
            this.editSpecItem.TabIndex = 7;
            this.editSpecItem.Text = "Edit";
            this.editSpecItem.UseVisualStyleBackColor = true;
            this.editSpecItem.Click += new System.EventHandler(this.editSpecItem_Click);
            // 
            // delSpecItem
            // 
            this.delSpecItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delSpecItem.Location = new System.Drawing.Point(69, 385);
            this.delSpecItem.Name = "delSpecItem";
            this.delSpecItem.Size = new System.Drawing.Size(46, 23);
            this.delSpecItem.TabIndex = 6;
            this.delSpecItem.Text = "-";
            this.delSpecItem.UseVisualStyleBackColor = true;
            this.delSpecItem.Click += new System.EventHandler(this.delSpecItem_Click);
            // 
            // addSpecItem
            // 
            this.addSpecItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSpecItem.Location = new System.Drawing.Point(17, 385);
            this.addSpecItem.Name = "addSpecItem";
            this.addSpecItem.Size = new System.Drawing.Size(46, 23);
            this.addSpecItem.TabIndex = 5;
            this.addSpecItem.Text = "+";
            this.addSpecItem.UseVisualStyleBackColor = true;
            this.addSpecItem.Click += new System.EventHandler(this.addSpecItem_Click);
            // 
            // specItemList
            // 
            this.specItemList.FormattingEnabled = true;
            this.specItemList.Location = new System.Drawing.Point(5, 5);
            this.specItemList.Name = "specItemList";
            this.specItemList.Size = new System.Drawing.Size(248, 368);
            this.specItemList.TabIndex = 4;
            this.specItemList.SelectedIndexChanged += new System.EventHandler(this.specItemList_SelectedIndexChanged);
            this.specItemList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.specItemList_MouseDoubleClick);
            // 
            // itemTab
            // 
            this.itemTab.Controls.Add(this.cloneItem);
            this.itemTab.Controls.Add(this.editItem);
            this.itemTab.Controls.Add(this.delItem);
            this.itemTab.Controls.Add(this.addItem);
            this.itemTab.Controls.Add(this.itemList);
            this.itemTab.Location = new System.Drawing.Point(4, 22);
            this.itemTab.Name = "itemTab";
            this.itemTab.Size = new System.Drawing.Size(258, 412);
            this.itemTab.TabIndex = 2;
            this.itemTab.Text = "Items";
            this.itemTab.UseVisualStyleBackColor = true;
            // 
            // cloneItem
            // 
            this.cloneItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloneItem.Location = new System.Drawing.Point(187, 385);
            this.cloneItem.Name = "cloneItem";
            this.cloneItem.Size = new System.Drawing.Size(60, 23);
            this.cloneItem.TabIndex = 8;
            this.cloneItem.Text = "Duplicate";
            this.cloneItem.UseVisualStyleBackColor = true;
            this.cloneItem.Click += new System.EventHandler(this.cloneItem_Click);
            // 
            // editItem
            // 
            this.editItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editItem.Location = new System.Drawing.Point(121, 385);
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(60, 23);
            this.editItem.TabIndex = 7;
            this.editItem.Text = "Edit";
            this.editItem.UseVisualStyleBackColor = true;
            this.editItem.Click += new System.EventHandler(this.editItem_Click);
            // 
            // delItem
            // 
            this.delItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delItem.Location = new System.Drawing.Point(69, 385);
            this.delItem.Name = "delItem";
            this.delItem.Size = new System.Drawing.Size(46, 23);
            this.delItem.TabIndex = 6;
            this.delItem.Text = "-";
            this.delItem.UseVisualStyleBackColor = true;
            this.delItem.Click += new System.EventHandler(this.delItem_Click);
            // 
            // addItem
            // 
            this.addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem.Location = new System.Drawing.Point(17, 385);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(46, 23);
            this.addItem.TabIndex = 5;
            this.addItem.Text = "+";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(5, 5);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(248, 368);
            this.itemList.TabIndex = 4;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
            this.itemList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.itemList_MouseDoubleClick);
            // 
            // bossTab
            // 
            this.bossTab.Controls.Add(this.cloneBoss);
            this.bossTab.Controls.Add(this.editBoss);
            this.bossTab.Controls.Add(this.delBoss);
            this.bossTab.Controls.Add(this.addBoss);
            this.bossTab.Controls.Add(this.bossList);
            this.bossTab.Location = new System.Drawing.Point(4, 22);
            this.bossTab.Name = "bossTab";
            this.bossTab.Size = new System.Drawing.Size(258, 412);
            this.bossTab.TabIndex = 3;
            this.bossTab.Text = "Bosses";
            this.bossTab.UseVisualStyleBackColor = true;
            // 
            // cloneBoss
            // 
            this.cloneBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloneBoss.Location = new System.Drawing.Point(187, 385);
            this.cloneBoss.Name = "cloneBoss";
            this.cloneBoss.Size = new System.Drawing.Size(60, 23);
            this.cloneBoss.TabIndex = 8;
            this.cloneBoss.Text = "Duplicate";
            this.cloneBoss.UseVisualStyleBackColor = true;
            this.cloneBoss.Click += new System.EventHandler(this.cloneBoss_Click);
            // 
            // editBoss
            // 
            this.editBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBoss.Location = new System.Drawing.Point(121, 385);
            this.editBoss.Name = "editBoss";
            this.editBoss.Size = new System.Drawing.Size(60, 23);
            this.editBoss.TabIndex = 7;
            this.editBoss.Text = "Edit";
            this.editBoss.UseVisualStyleBackColor = true;
            this.editBoss.Click += new System.EventHandler(this.editBoss_Click);
            // 
            // delBoss
            // 
            this.delBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBoss.Location = new System.Drawing.Point(69, 385);
            this.delBoss.Name = "delBoss";
            this.delBoss.Size = new System.Drawing.Size(46, 23);
            this.delBoss.TabIndex = 6;
            this.delBoss.Text = "-";
            this.delBoss.UseVisualStyleBackColor = true;
            this.delBoss.Click += new System.EventHandler(this.delBoss_Click);
            // 
            // addBoss
            // 
            this.addBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBoss.Location = new System.Drawing.Point(17, 385);
            this.addBoss.Name = "addBoss";
            this.addBoss.Size = new System.Drawing.Size(46, 23);
            this.addBoss.TabIndex = 5;
            this.addBoss.Text = "+";
            this.addBoss.UseVisualStyleBackColor = true;
            this.addBoss.Click += new System.EventHandler(this.addBoss_Click);
            // 
            // bossList
            // 
            this.bossList.FormattingEnabled = true;
            this.bossList.Location = new System.Drawing.Point(5, 5);
            this.bossList.Name = "bossList";
            this.bossList.Size = new System.Drawing.Size(248, 368);
            this.bossList.TabIndex = 4;
            this.bossList.SelectedIndexChanged += new System.EventHandler(this.bossList_SelectedIndexChanged);
            this.bossList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.bossList_MouseDoubleClick);
            // 
            // enemyTab
            // 
            this.enemyTab.Controls.Add(this.cloneEnemy);
            this.enemyTab.Controls.Add(this.editEnemy);
            this.enemyTab.Controls.Add(this.delEnemy);
            this.enemyTab.Controls.Add(this.addEnemy);
            this.enemyTab.Controls.Add(this.enemyList);
            this.enemyTab.Location = new System.Drawing.Point(4, 22);
            this.enemyTab.Name = "enemyTab";
            this.enemyTab.Size = new System.Drawing.Size(258, 412);
            this.enemyTab.TabIndex = 4;
            this.enemyTab.Text = "Enemies";
            this.enemyTab.UseVisualStyleBackColor = true;
            // 
            // cloneEnemy
            // 
            this.cloneEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloneEnemy.Location = new System.Drawing.Point(187, 385);
            this.cloneEnemy.Name = "cloneEnemy";
            this.cloneEnemy.Size = new System.Drawing.Size(60, 23);
            this.cloneEnemy.TabIndex = 8;
            this.cloneEnemy.Text = "Duplicate";
            this.cloneEnemy.UseVisualStyleBackColor = true;
            this.cloneEnemy.Click += new System.EventHandler(this.cloneEnemy_Click);
            // 
            // editEnemy
            // 
            this.editEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEnemy.Location = new System.Drawing.Point(121, 385);
            this.editEnemy.Name = "editEnemy";
            this.editEnemy.Size = new System.Drawing.Size(60, 23);
            this.editEnemy.TabIndex = 7;
            this.editEnemy.Text = "Edit";
            this.editEnemy.UseVisualStyleBackColor = true;
            this.editEnemy.Click += new System.EventHandler(this.editEnemy_Click);
            // 
            // delEnemy
            // 
            this.delEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delEnemy.Location = new System.Drawing.Point(69, 385);
            this.delEnemy.Name = "delEnemy";
            this.delEnemy.Size = new System.Drawing.Size(46, 23);
            this.delEnemy.TabIndex = 6;
            this.delEnemy.Text = "-";
            this.delEnemy.UseVisualStyleBackColor = true;
            this.delEnemy.Click += new System.EventHandler(this.delEnemy_Click);
            // 
            // addEnemy
            // 
            this.addEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEnemy.Location = new System.Drawing.Point(17, 385);
            this.addEnemy.Name = "addEnemy";
            this.addEnemy.Size = new System.Drawing.Size(46, 23);
            this.addEnemy.TabIndex = 5;
            this.addEnemy.Text = "+";
            this.addEnemy.UseVisualStyleBackColor = true;
            this.addEnemy.Click += new System.EventHandler(this.addEnemy_Click);
            // 
            // enemyList
            // 
            this.enemyList.FormattingEnabled = true;
            this.enemyList.Location = new System.Drawing.Point(5, 5);
            this.enemyList.Name = "enemyList";
            this.enemyList.Size = new System.Drawing.Size(248, 368);
            this.enemyList.TabIndex = 4;
            this.enemyList.SelectedIndexChanged += new System.EventHandler(this.enemyList_SelectedIndexChanged);
            this.enemyList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.enemyList_MouseDoubleClick);
            // 
            // glControl
            // 
            this.glControl.BackColor = System.Drawing.Color.Black;
            this.glControl.Location = new System.Drawing.Point(298, 68);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(552, 365);
            this.glControl.TabIndex = 2;
            this.glControl.VSync = false;
            this.glControl.Load += new System.EventHandler(this.glControl_Load);
            this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
            this.glControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseDown);
            this.glControl.MouseLeave += new System.EventHandler(this.glControl_MouseLeave);
            this.glControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseMove);
            this.glControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseUp);
            this.glControl.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseWheel);
            // 
            // resetCamera
            // 
            this.resetCamera.Location = new System.Drawing.Point(446, 31);
            this.resetCamera.Name = "resetCamera";
            this.resetCamera.Size = new System.Drawing.Size(82, 31);
            this.resetCamera.TabIndex = 6;
            this.resetCamera.Text = "Reset Camera";
            this.resetCamera.UseVisualStyleBackColor = true;
            this.resetCamera.Click += new System.EventHandler(this.resetCamera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Coordinate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Y";
            // 
            // xCoord
            // 
            this.xCoord.Location = new System.Drawing.Point(379, 443);
            this.xCoord.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.xCoord.Name = "xCoord";
            this.xCoord.Size = new System.Drawing.Size(120, 20);
            this.xCoord.TabIndex = 23;
            this.xCoord.ValueChanged += new System.EventHandler(this.xCoord_ValueChanged);
            // 
            // xOffset
            // 
            this.xOffset.Location = new System.Drawing.Point(547, 443);
            this.xOffset.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.xOffset.Name = "xOffset";
            this.xOffset.Size = new System.Drawing.Size(41, 20);
            this.xOffset.TabIndex = 24;
            this.xOffset.ValueChanged += new System.EventHandler(this.xOffset_ValueChanged);
            // 
            // yOffset
            // 
            this.yOffset.Location = new System.Drawing.Point(547, 471);
            this.yOffset.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.yOffset.Name = "yOffset";
            this.yOffset.Size = new System.Drawing.Size(41, 20);
            this.yOffset.TabIndex = 26;
            this.yOffset.ValueChanged += new System.EventHandler(this.yOffset_ValueChanged);
            // 
            // yCoord
            // 
            this.yCoord.Location = new System.Drawing.Point(379, 471);
            this.yCoord.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.yCoord.Name = "yCoord";
            this.yCoord.Size = new System.Drawing.Size(120, 20);
            this.yCoord.TabIndex = 25;
            this.yCoord.ValueChanged += new System.EventHandler(this.yCoord_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Collision",
            "Decoration"});
            this.comboBox1.Location = new System.Drawing.Point(534, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.editDeco);
            this.groupBox2.Controls.Add(this.editBlock);
            this.groupBox2.Controls.Add(this.editCol);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(856, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 414);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tile Data Editor";
            // 
            // editDeco
            // 
            this.editDeco.AutoSize = true;
            this.editDeco.Location = new System.Drawing.Point(7, 392);
            this.editDeco.Name = "editDeco";
            this.editDeco.Size = new System.Drawing.Size(104, 17);
            this.editDeco.TabIndex = 96;
            this.editDeco.Text = "Edit Decorations";
            this.editDeco.UseVisualStyleBackColor = true;
            // 
            // editBlock
            // 
            this.editBlock.AutoSize = true;
            this.editBlock.Location = new System.Drawing.Point(7, 369);
            this.editBlock.Name = "editBlock";
            this.editBlock.Size = new System.Drawing.Size(79, 17);
            this.editBlock.TabIndex = 95;
            this.editBlock.Text = "Edit Blocks";
            this.editBlock.UseVisualStyleBackColor = true;
            // 
            // editCol
            // 
            this.editCol.AutoSize = true;
            this.editCol.Location = new System.Drawing.Point(7, 346);
            this.editCol.Name = "editCol";
            this.editCol.Size = new System.Drawing.Size(90, 17);
            this.editCol.TabIndex = 94;
            this.editCol.Text = "Edit Collisions";
            this.editCol.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.d3_4);
            this.groupBox5.Controls.Add(this.d1_1);
            this.groupBox5.Controls.Add(this.d3_3);
            this.groupBox5.Controls.Add(this.d1_2);
            this.groupBox5.Controls.Add(this.d3_2);
            this.groupBox5.Controls.Add(this.d1_3);
            this.groupBox5.Controls.Add(this.d3_1);
            this.groupBox5.Controls.Add(this.d1_4);
            this.groupBox5.Controls.Add(this.d2_4);
            this.groupBox5.Controls.Add(this.d2_1);
            this.groupBox5.Controls.Add(this.d2_3);
            this.groupBox5.Controls.Add(this.d2_2);
            this.groupBox5.Location = new System.Drawing.Point(7, 248);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 95);
            this.groupBox5.TabIndex = 93;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Decoration Data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "BLand";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "MLand";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 72;
            this.label13.Text = "FLand";
            // 
            // d3_4
            // 
            this.d3_4.Location = new System.Drawing.Point(187, 66);
            this.d3_4.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.d3_4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.d3_4.Name = "d3_4";
            this.d3_4.Size = new System.Drawing.Size(39, 20);
            this.d3_4.TabIndex = 84;
            // 
            // d1_1
            // 
            this.d1_1.Location = new System.Drawing.Point(52, 14);
            this.d1_1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d1_1.Name = "d1_1";
            this.d1_1.Size = new System.Drawing.Size(39, 20);
            this.d1_1.TabIndex = 73;
            // 
            // d3_3
            // 
            this.d3_3.Location = new System.Drawing.Point(142, 66);
            this.d3_3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d3_3.Name = "d3_3";
            this.d3_3.Size = new System.Drawing.Size(39, 20);
            this.d3_3.TabIndex = 83;
            // 
            // d1_2
            // 
            this.d1_2.Location = new System.Drawing.Point(97, 14);
            this.d1_2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d1_2.Name = "d1_2";
            this.d1_2.Size = new System.Drawing.Size(39, 20);
            this.d1_2.TabIndex = 74;
            // 
            // d3_2
            // 
            this.d3_2.Location = new System.Drawing.Point(97, 66);
            this.d3_2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d3_2.Name = "d3_2";
            this.d3_2.Size = new System.Drawing.Size(39, 20);
            this.d3_2.TabIndex = 82;
            // 
            // d1_3
            // 
            this.d1_3.Location = new System.Drawing.Point(142, 14);
            this.d1_3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d1_3.Name = "d1_3";
            this.d1_3.Size = new System.Drawing.Size(39, 20);
            this.d1_3.TabIndex = 75;
            // 
            // d3_1
            // 
            this.d3_1.Location = new System.Drawing.Point(52, 66);
            this.d3_1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d3_1.Name = "d3_1";
            this.d3_1.Size = new System.Drawing.Size(39, 20);
            this.d3_1.TabIndex = 81;
            // 
            // d1_4
            // 
            this.d1_4.Location = new System.Drawing.Point(187, 14);
            this.d1_4.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.d1_4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.d1_4.Name = "d1_4";
            this.d1_4.Size = new System.Drawing.Size(39, 20);
            this.d1_4.TabIndex = 76;
            // 
            // d2_4
            // 
            this.d2_4.Location = new System.Drawing.Point(187, 40);
            this.d2_4.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.d2_4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.d2_4.Name = "d2_4";
            this.d2_4.Size = new System.Drawing.Size(39, 20);
            this.d2_4.TabIndex = 80;
            // 
            // d2_1
            // 
            this.d2_1.Location = new System.Drawing.Point(52, 40);
            this.d2_1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d2_1.Name = "d2_1";
            this.d2_1.Size = new System.Drawing.Size(39, 20);
            this.d2_1.TabIndex = 77;
            // 
            // d2_3
            // 
            this.d2_3.Location = new System.Drawing.Point(142, 40);
            this.d2_3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d2_3.Name = "d2_3";
            this.d2_3.Size = new System.Drawing.Size(39, 20);
            this.d2_3.TabIndex = 79;
            // 
            // d2_2
            // 
            this.d2_2.Location = new System.Drawing.Point(97, 40);
            this.d2_2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d2_2.Name = "d2_2";
            this.d2_2.Size = new System.Drawing.Size(39, 20);
            this.d2_2.TabIndex = 78;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.blockImg);
            this.groupBox4.Controls.Add(this.vblock);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(7, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 53);
            this.groupBox4.TabIndex = 92;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Block Data";
            // 
            // vblock
            // 
            this.vblock.Location = new System.Drawing.Point(6, 22);
            this.vblock.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.vblock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.vblock.Name = "vblock";
            this.vblock.Size = new System.Drawing.Size(51, 20);
            this.vblock.TabIndex = 85;
            this.vblock.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Block";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.colImg);
            this.groupBox3.Controls.Add(this.vshape);
            this.groupBox3.Controls.Add(this.ice);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.spike);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.boundary);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.vmat);
            this.groupBox3.Controls.Add(this.ladder);
            this.groupBox3.Controls.Add(this.vautomove);
            this.groupBox3.Controls.Add(this.water);
            this.groupBox3.Controls.Add(this.lava);
            this.groupBox3.Location = new System.Drawing.Point(7, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 173);
            this.groupBox3.TabIndex = 91;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Collision Data";
            // 
            // vshape
            // 
            this.vshape.Location = new System.Drawing.Point(6, 19);
            this.vshape.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.vshape.Name = "vshape";
            this.vshape.Size = new System.Drawing.Size(73, 20);
            this.vshape.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Collision Shape";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Collision Material";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Auto Move Speed";
            // 
            // vmat
            // 
            this.vmat.Location = new System.Drawing.Point(6, 115);
            this.vmat.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.vmat.Name = "vmat";
            this.vmat.Size = new System.Drawing.Size(73, 20);
            this.vmat.TabIndex = 87;
            // 
            // vautomove
            // 
            this.vautomove.Location = new System.Drawing.Point(6, 141);
            this.vautomove.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.vautomove.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.vautomove.Name = "vautomove";
            this.vautomove.Size = new System.Drawing.Size(73, 20);
            this.vautomove.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Offset";
            // 
            // pick
            // 
            this.pick.Location = new System.Drawing.Point(409, 31);
            this.pick.Name = "pick";
            this.pick.Size = new System.Drawing.Size(31, 31);
            this.pick.TabIndex = 30;
            this.pick.UseVisualStyleBackColor = true;
            this.pick.Click += new System.EventHandler(this.pick_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.sizeW);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.sizeH);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(856, 443);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(270, 49);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Level Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height";
            // 
            // sizeH
            // 
            this.sizeH.Location = new System.Drawing.Point(51, 21);
            this.sizeH.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.sizeH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeH.Name = "sizeH";
            this.sizeH.Size = new System.Drawing.Size(78, 20);
            this.sizeH.TabIndex = 1;
            this.sizeH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeH.ValueChanged += new System.EventHandler(this.UpdateLevelSize);
            // 
            // sizeW
            // 
            this.sizeW.Location = new System.Drawing.Point(179, 22);
            this.sizeW.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.sizeW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeW.Name = "sizeW";
            this.sizeW.Size = new System.Drawing.Size(78, 20);
            this.sizeW.TabIndex = 3;
            this.sizeW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeW.ValueChanged += new System.EventHandler(this.UpdateLevelSize);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Width";
            // 
            // blockImg
            // 
            this.blockImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.blockImg.Image = global::MagoBox.Properties.Resources._0;
            this.blockImg.Location = new System.Drawing.Point(100, 16);
            this.blockImg.Name = "blockImg";
            this.blockImg.Size = new System.Drawing.Size(30, 30);
            this.blockImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blockImg.TabIndex = 92;
            this.blockImg.TabStop = false;
            // 
            // colImg
            // 
            this.colImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.colImg.Image = global::MagoBox.Properties.Resources._0;
            this.colImg.Location = new System.Drawing.Point(164, 15);
            this.colImg.Name = "colImg";
            this.colImg.Size = new System.Drawing.Size(30, 30);
            this.colImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colImg.TabIndex = 91;
            this.colImg.TabStop = false;
            // 
            // ice
            // 
            this.ice.AutoSize = true;
            this.ice.Image = global::MagoBox.Properties.Resources.ice;
            this.ice.Location = new System.Drawing.Point(89, 92);
            this.ice.Name = "ice";
            this.ice.Size = new System.Drawing.Size(58, 17);
            this.ice.TabIndex = 90;
            this.ice.Text = "Ice";
            this.ice.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ice.UseVisualStyleBackColor = true;
            // 
            // spike
            // 
            this.spike.AutoSize = true;
            this.spike.Image = global::MagoBox.Properties.Resources.spike;
            this.spike.Location = new System.Drawing.Point(89, 69);
            this.spike.Name = "spike";
            this.spike.Size = new System.Drawing.Size(70, 17);
            this.spike.TabIndex = 89;
            this.spike.Text = "Spike";
            this.spike.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.spike.UseVisualStyleBackColor = true;
            // 
            // boundary
            // 
            this.boundary.AutoSize = true;
            this.boundary.Image = global::MagoBox.Properties.Resources.boundary;
            this.boundary.Location = new System.Drawing.Point(89, 46);
            this.boundary.Name = "boundary";
            this.boundary.Size = new System.Drawing.Size(88, 17);
            this.boundary.TabIndex = 88;
            this.boundary.Text = "Boundary";
            this.boundary.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.boundary.UseVisualStyleBackColor = true;
            // 
            // ladder
            // 
            this.ladder.AutoSize = true;
            this.ladder.Image = global::MagoBox.Properties.Resources.ladder;
            this.ladder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ladder.Location = new System.Drawing.Point(7, 46);
            this.ladder.Name = "ladder";
            this.ladder.Size = new System.Drawing.Size(76, 17);
            this.ladder.TabIndex = 62;
            this.ladder.Text = "Ladder";
            this.ladder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ladder.UseVisualStyleBackColor = true;
            // 
            // water
            // 
            this.water.AutoSize = true;
            this.water.Image = global::MagoBox.Properties.Resources.water;
            this.water.Location = new System.Drawing.Point(7, 69);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(72, 17);
            this.water.TabIndex = 63;
            this.water.Text = "Water";
            this.water.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.water.UseVisualStyleBackColor = true;
            // 
            // lava
            // 
            this.lava.AutoSize = true;
            this.lava.Image = global::MagoBox.Properties.Resources.lava;
            this.lava.Location = new System.Drawing.Point(7, 92);
            this.lava.Name = "lava";
            this.lava.Size = new System.Drawing.Size(67, 17);
            this.lava.TabIndex = 64;
            this.lava.Text = "Lava";
            this.lava.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.lava.UseVisualStyleBackColor = true;
            // 
            // draw
            // 
            this.draw.Image = global::MagoBox.Properties.Resources.draw;
            this.draw.Location = new System.Drawing.Point(372, 31);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(31, 31);
            this.draw.TabIndex = 5;
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // move
            // 
            this.move.BackgroundImage = global::MagoBox.Properties.Resources.move;
            this.move.Location = new System.Drawing.Point(335, 31);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(31, 31);
            this.move.TabIndex = 4;
            this.move.UseVisualStyleBackColor = true;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // select
            // 
            this.select.BackgroundImage = global::MagoBox.Properties.Resources.select;
            this.select.Location = new System.Drawing.Point(298, 31);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(31, 31);
            this.select.TabIndex = 3;
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 504);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.pick);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.yOffset);
            this.Controls.Add(this.yCoord);
            this.Controls.Add(this.xOffset);
            this.Controls.Add(this.xCoord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetCamera);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.move);
            this.Controls.Add(this.select);
            this.Controls.Add(this.glControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MagoBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.objTab.ResumeLayout(false);
            this.specItemTab.ResumeLayout(false);
            this.itemTab.ResumeLayout(false);
            this.bossTab.ResumeLayout(false);
            this.enemyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xCoord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoord)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d3_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vblock)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vshape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vautomove)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage objTab;
        private System.Windows.Forms.Button editObj;
        private System.Windows.Forms.Button delObj;
        private System.Windows.Forms.Button addObj;
        private System.Windows.Forms.ListBox objList;
        private System.Windows.Forms.TabPage specItemTab;
        private System.Windows.Forms.Button editSpecItem;
        private System.Windows.Forms.Button delSpecItem;
        private System.Windows.Forms.Button addSpecItem;
        private System.Windows.Forms.ListBox specItemList;
        private System.Windows.Forms.TabPage itemTab;
        private System.Windows.Forms.Button editItem;
        private System.Windows.Forms.Button delItem;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.TabPage bossTab;
        private System.Windows.Forms.Button editBoss;
        private System.Windows.Forms.Button delBoss;
        private System.Windows.Forms.Button addBoss;
        private System.Windows.Forms.ListBox bossList;
        private System.Windows.Forms.TabPage enemyTab;
        private System.Windows.Forms.Button editEnemy;
        private System.Windows.Forms.Button delEnemy;
        private System.Windows.Forms.Button addEnemy;
        private System.Windows.Forms.ListBox enemyList;
        private OpenTK.GLControl glControl;
        private System.Windows.Forms.ToolStripMenuItem stageSettingsToolStripMenuItem;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button move;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Button resetCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown xCoord;
        private System.Windows.Forms.NumericUpDown xOffset;
        private System.Windows.Forms.NumericUpDown yOffset;
        private System.Windows.Forms.NumericUpDown yCoord;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cloneObj;
        private System.Windows.Forms.Button cloneSpecItem;
        private System.Windows.Forms.Button cloneItem;
        private System.Windows.Forms.Button cloneBoss;
        private System.Windows.Forms.Button cloneEnemy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem renderSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderBlocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderTileModifiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderObjectPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderSpecialItemPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderItemPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderBossPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderEnemyPointsToolStripMenuItem;
        private System.Windows.Forms.CheckBox ice;
        private System.Windows.Forms.CheckBox spike;
        private System.Windows.Forms.CheckBox boundary;
        private System.Windows.Forms.NumericUpDown vmat;
        private System.Windows.Forms.NumericUpDown vautomove;
        private System.Windows.Forms.NumericUpDown vblock;
        private System.Windows.Forms.NumericUpDown d3_4;
        private System.Windows.Forms.NumericUpDown d3_3;
        private System.Windows.Forms.NumericUpDown d3_2;
        private System.Windows.Forms.NumericUpDown d3_1;
        private System.Windows.Forms.NumericUpDown d2_4;
        private System.Windows.Forms.NumericUpDown d2_3;
        private System.Windows.Forms.NumericUpDown d2_2;
        private System.Windows.Forms.NumericUpDown d2_1;
        private System.Windows.Forms.NumericUpDown d1_4;
        private System.Windows.Forms.NumericUpDown d1_3;
        private System.Windows.Forms.NumericUpDown d1_2;
        private System.Windows.Forms.NumericUpDown d1_1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox lava;
        private System.Windows.Forms.CheckBox water;
        private System.Windows.Forms.CheckBox ladder;
        private System.Windows.Forms.NumericUpDown vshape;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox editCol;
        private System.Windows.Forms.CheckBox editDeco;
        private System.Windows.Forms.CheckBox editBlock;
        private System.Windows.Forms.PictureBox colImg;
        private System.Windows.Forms.PictureBox blockImg;
        private System.Windows.Forms.Button pick;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown sizeW;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown sizeH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

