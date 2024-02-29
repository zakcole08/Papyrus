namespace Papyrus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.saveBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontSelect = new System.Windows.Forms.ToolStripComboBox();
            this.fontSizeSelect = new System.Windows.Forms.ToolStripComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMain = new System.Windows.Forms.RichTextBox();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.txtLineNums = new System.Windows.Forms.RichTextBox();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(188)))));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton1,
            this.saveBar,
            this.toolStripSeparator1,
            this.fontSelect,
            this.fontSizeSelect});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(978, 36);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 33);
            this.toolStripButton2.Text = "btnOpen";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 33);
            this.toolStripButton1.Text = "btnSave";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // saveBar
            // 
            this.saveBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.saveBar.Name = "saveBar";
            this.saveBar.Size = new System.Drawing.Size(100, 33);
            this.saveBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // fontSelect
            // 
            this.fontSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.fontSelect.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSelect.Items.AddRange(new object[] {
            "AGA Arabesque Desktop",
            "Agency FB",
            "Akhbar MT",
            "ALGERIAN",
            "Arial",
            "Arial Rounded MT",
            "Art",
            "Bahnschrift",
            "Baskerville Old Face",
            "Bell MT",
            "Berlin Sans FB",
            "Bernard MT",
            "Blackadder ITC",
            "Bodoni MT",
            "Bodoni MT Poster",
            "Book Antiqua",
            "Bookman Old Style",
            "Bookshelf Symbol 7",
            "Bouhout 95",
            "Bradley Hand ITC",
            "Britannic",
            "Broadway",
            "Brush Script MT",
            "Calibri",
            "Californian FB",
            "Calisto MT",
            "Cambria",
            "Cambria Math",
            "Candara",
            "Cascadia Code",
            "Cascadia Mono",
            "Castellar",
            "Centaur",
            "Century",
            "Century Gothic",
            "Century Schoolbook",
            "Chiller",
            "Colonna MT",
            "Comic Sans MS",
            "Consolas",
            "Constantia"});
            this.fontSelect.Name = "fontSelect";
            this.fontSelect.Size = new System.Drawing.Size(121, 36);
            this.fontSelect.Sorted = true;
            this.fontSelect.Text = "Consolas";
            this.fontSelect.SelectedIndexChanged += new System.EventHandler(this.fontSelect_SelectedIndexChanged);
            this.fontSelect.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // fontSizeSelect
            // 
            this.fontSizeSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.fontSizeSelect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fontSizeSelect.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.fontSizeSelect.Name = "fontSizeSelect";
            this.fontSizeSelect.Size = new System.Drawing.Size(75, 36);
            this.fontSizeSelect.Text = "10";
            this.fontSizeSelect.SelectedIndexChanged += new System.EventHandler(this.fontSizeSelect_IndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 644);
            this.panel1.TabIndex = 1;
            // 
            // txtMain
            // 
            this.txtMain.AcceptsTab = true;
            this.txtMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMain.AutoWordSelection = true;
            this.txtMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(243)))));
            this.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMain.BulletIndent = 1;
            this.txtMain.EnableAutoDragDrop = true;
            this.txtMain.Location = new System.Drawing.Point(142, 38);
            this.txtMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMain.Name = "txtMain";
            this.txtMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMain.Size = new System.Drawing.Size(836, 568);
            this.txtMain.TabIndex = 2;
            this.txtMain.Text = "";
            this.txtMain.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // toolPanel
            // 
            this.toolPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toolPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(205)))));
            this.toolPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolPanel.Location = new System.Drawing.Point(0, 38);
            this.toolPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(134, 576);
            this.toolPanel.TabIndex = 3;
            this.toolPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtLineNums
            // 
            this.txtLineNums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLineNums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(233)))), ((int)(((byte)(195)))));
            this.txtLineNums.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLineNums.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLineNums.Location = new System.Drawing.Point(84, 38);
            this.txtLineNums.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLineNums.Name = "txtLineNums";
            this.txtLineNums.ReadOnly = true;
            this.txtLineNums.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLineNums.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtLineNums.Size = new System.Drawing.Size(50, 576);
            this.txtLineNums.TabIndex = 0;
            this.txtLineNums.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.txtLineNums);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Papyrus";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtMain;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.RichTextBox txtLineNums;
        private System.Windows.Forms.ToolStripComboBox fontSelect;
        private System.Windows.Forms.ToolStripProgressBar saveBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox fontSizeSelect;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

