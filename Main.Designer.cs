namespace HLVR_SDK_Assistant
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusMapSelectLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusMapsLoadedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.sdkMapPathText = new System.Windows.Forms.TextBox();
            this.sdkMapBrowseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gameMapPathText = new System.Windows.Forms.TextBox();
            this.gameMapBrowseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sdkScriptText = new System.Windows.Forms.TextBox();
            this.sdkScriptBrowseButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gameScriptText = new System.Windows.Forms.TextBox();
            this.gameScriptBrowseButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.mapListBox = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.mapCopyButton = new System.Windows.Forms.Button();
            this.refreshMapButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fIleToolStripMenuItem.Text = "File";
            this.fIleToolStripMenuItem.Click += new System.EventHandler(this.fIleToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusMapSelectLabel,
            this.toolStripStatusMapsLoadedLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1049, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(712, 19);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // toolStripStatusMapSelectLabel
            // 
            this.toolStripStatusMapSelectLabel.AutoSize = false;
            this.toolStripStatusMapSelectLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusMapSelectLabel.Name = "toolStripStatusMapSelectLabel";
            this.toolStripStatusMapSelectLabel.Size = new System.Drawing.Size(160, 19);
            this.toolStripStatusMapSelectLabel.Text = "toolStripStatusLabel1";
            this.toolStripStatusMapSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusMapsLoadedLabel
            // 
            this.toolStripStatusMapsLoadedLabel.AutoSize = false;
            this.toolStripStatusMapsLoadedLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusMapsLoadedLabel.Name = "toolStripStatusMapsLoadedLabel";
            this.toolStripStatusMapsLoadedLabel.Size = new System.Drawing.Size(160, 19);
            this.toolStripStatusMapsLoadedLabel.Text = "toolStripStatusLabel2";
            this.toolStripStatusMapsLoadedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "SDK Map Path:";
            // 
            // sdkMapPathText
            // 
            this.sdkMapPathText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sdkMapPathText.Enabled = false;
            this.sdkMapPathText.Location = new System.Drawing.Point(138, 6);
            this.sdkMapPathText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sdkMapPathText.Name = "sdkMapPathText";
            this.sdkMapPathText.Size = new System.Drawing.Size(445, 23);
            this.sdkMapPathText.TabIndex = 3;
            this.sdkMapPathText.TextChanged += new System.EventHandler(this.sdkMapPathMapCheck);
            // 
            // sdkMapBrowseButton
            // 
            this.sdkMapBrowseButton.Location = new System.Drawing.Point(591, 3);
            this.sdkMapBrowseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sdkMapBrowseButton.Name = "sdkMapBrowseButton";
            this.sdkMapBrowseButton.Size = new System.Drawing.Size(80, 25);
            this.sdkMapBrowseButton.TabIndex = 4;
            this.sdkMapBrowseButton.Text = "Browse";
            this.sdkMapBrowseButton.UseVisualStyleBackColor = true;
            this.sdkMapBrowseButton.Click += new System.EventHandler(this.sdkMapBrowseButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Game Map Path:";
            // 
            // gameMapPathText
            // 
            this.gameMapPathText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gameMapPathText.Enabled = false;
            this.gameMapPathText.Location = new System.Drawing.Point(138, 41);
            this.gameMapPathText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gameMapPathText.Name = "gameMapPathText";
            this.gameMapPathText.Size = new System.Drawing.Size(445, 23);
            this.gameMapPathText.TabIndex = 6;
            // 
            // gameMapBrowseButton
            // 
            this.gameMapBrowseButton.Location = new System.Drawing.Point(591, 38);
            this.gameMapBrowseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gameMapBrowseButton.Name = "gameMapBrowseButton";
            this.gameMapBrowseButton.Size = new System.Drawing.Size(80, 25);
            this.gameMapBrowseButton.TabIndex = 7;
            this.gameMapBrowseButton.Text = "Browse";
            this.gameMapBrowseButton.UseVisualStyleBackColor = true;
            this.gameMapBrowseButton.Click += new System.EventHandler(this.gameMapBrowseButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "SDK Launch Script:";
            // 
            // sdkScriptText
            // 
            this.sdkScriptText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sdkScriptText.Enabled = false;
            this.sdkScriptText.Location = new System.Drawing.Point(138, 76);
            this.sdkScriptText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sdkScriptText.Name = "sdkScriptText";
            this.sdkScriptText.Size = new System.Drawing.Size(445, 23);
            this.sdkScriptText.TabIndex = 9;
            // 
            // sdkScriptBrowseButton
            // 
            this.sdkScriptBrowseButton.Location = new System.Drawing.Point(591, 73);
            this.sdkScriptBrowseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sdkScriptBrowseButton.Name = "sdkScriptBrowseButton";
            this.sdkScriptBrowseButton.Size = new System.Drawing.Size(80, 25);
            this.sdkScriptBrowseButton.TabIndex = 10;
            this.sdkScriptBrowseButton.Text = "Browse";
            this.sdkScriptBrowseButton.UseVisualStyleBackColor = true;
            this.sdkScriptBrowseButton.Click += new System.EventHandler(this.sdkScriptBrowseButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Game Launch Script:";
            // 
            // gameScriptText
            // 
            this.gameScriptText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameScriptText.Enabled = false;
            this.gameScriptText.Location = new System.Drawing.Point(138, 108);
            this.gameScriptText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gameScriptText.Name = "gameScriptText";
            this.gameScriptText.Size = new System.Drawing.Size(445, 23);
            this.gameScriptText.TabIndex = 12;
            // 
            // gameScriptBrowseButton
            // 
            this.gameScriptBrowseButton.Location = new System.Drawing.Point(591, 108);
            this.gameScriptBrowseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gameScriptBrowseButton.Name = "gameScriptBrowseButton";
            this.gameScriptBrowseButton.Size = new System.Drawing.Size(80, 27);
            this.gameScriptBrowseButton.TabIndex = 13;
            this.gameScriptBrowseButton.Text = "Browse";
            this.gameScriptBrowseButton.UseVisualStyleBackColor = true;
            this.gameScriptBrowseButton.Click += new System.EventHandler(this.gameScriptBrowseButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameScriptBrowseButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.sdkMapPathText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sdkMapBrowseButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sdkScriptBrowseButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameMapPathText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sdkScriptText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameMapBrowseButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameScriptText, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(675, 138);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.9221F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0779F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 31);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1021, 436);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button6, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 399);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(675, 34);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(4, 4);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(329, 25);
            this.button5.TabIndex = 0;
            this.button5.Text = "Launch SDK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(341, 4);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(330, 25);
            this.button6.TabIndex = 1;
            this.button6.Text = "Launch Game";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel5.Controls.Add(this.mapListBox, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(687, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 390F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(330, 390);
            this.tableLayoutPanel5.TabIndex = 20;
            // 
            // mapListBox
            // 
            this.mapListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapListBox.FormattingEnabled = true;
            this.mapListBox.Location = new System.Drawing.Point(4, 3);
            this.mapListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mapListBox.Name = "mapListBox";
            this.mapListBox.Size = new System.Drawing.Size(322, 382);
            this.mapListBox.TabIndex = 18;
            this.mapListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.updateSelection);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.mapCopyButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.refreshMapButton, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(687, 399);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(330, 32);
            this.tableLayoutPanel4.TabIndex = 19;
            // 
            // mapCopyButton
            // 
            this.mapCopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mapCopyButton.Enabled = false;
            this.mapCopyButton.Location = new System.Drawing.Point(4, 3);
            this.mapCopyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mapCopyButton.Name = "mapCopyButton";
            this.mapCopyButton.Size = new System.Drawing.Size(157, 25);
            this.mapCopyButton.TabIndex = 15;
            this.mapCopyButton.Text = "Copy Selected Maps";
            this.mapCopyButton.UseVisualStyleBackColor = true;
            this.mapCopyButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // refreshMapButton
            // 
            this.refreshMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshMapButton.Enabled = false;
            this.refreshMapButton.Location = new System.Drawing.Point(169, 3);
            this.refreshMapButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refreshMapButton.Name = "refreshMapButton";
            this.refreshMapButton.Size = new System.Drawing.Size(157, 25);
            this.refreshMapButton.TabIndex = 16;
            this.refreshMapButton.Text = "Refresh Map List";
            this.refreshMapButton.UseVisualStyleBackColor = true;
            this.refreshMapButton.Click += new System.EventHandler(this.refreshMapList);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1049, 499);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(500, 320);
            this.Name = "Main";
            this.Text = "HLVR SDK Assistant";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMapSelectLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMapsLoadedLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sdkMapPathText;
        private System.Windows.Forms.Button sdkMapBrowseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gameMapPathText;
        private System.Windows.Forms.Button gameMapBrowseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sdkScriptText;
        private System.Windows.Forms.Button sdkScriptBrowseButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gameScriptText;
        private System.Windows.Forms.Button gameScriptBrowseButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button mapCopyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckedListBox mapListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button refreshMapButton;
    }
}

