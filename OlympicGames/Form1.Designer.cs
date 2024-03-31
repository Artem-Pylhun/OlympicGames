namespace OlympicGames
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbOlympics = new ListBox();
            lbCountriesParticipants = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnAddOlympic = new Button();
            btnEditOlympic = new Button();
            btnDelOlympic = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            cSVToolStripMenuItem = new ToolStripMenuItem();
            jSONToolStripMenuItem = new ToolStripMenuItem();
            tXTToolStripMenuItem = new ToolStripMenuItem();
            xLSXToolStripMenuItem = new ToolStripMenuItem();
            xMLToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            cSVToolStripMenuItem1 = new ToolStripMenuItem();
            jSONToolStripMenuItem1 = new ToolStripMenuItem();
            tXTToolStripMenuItem1 = new ToolStripMenuItem();
            xLSXToolStripMenuItem1 = new ToolStripMenuItem();
            xMLToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbOlympics
            // 
            lbOlympics.FormattingEnabled = true;
            lbOlympics.HorizontalScrollbar = true;
            lbOlympics.Location = new Point(59, 74);
            lbOlympics.Name = "lbOlympics";
            lbOlympics.Size = new Size(199, 324);
            lbOlympics.TabIndex = 0;
            lbOlympics.SelectedIndexChanged += lbOlympics_SelectedIndexChanged;
            // 
            // lbCountriesParticipants
            // 
            lbCountriesParticipants.FormattingEnabled = true;
            lbCountriesParticipants.HorizontalScrollbar = true;
            lbCountriesParticipants.Location = new Point(389, 74);
            lbCountriesParticipants.Name = "lbCountriesParticipants";
            lbCountriesParticipants.Size = new Size(195, 324);
            lbCountriesParticipants.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(59, 28);
            label1.Name = "label1";
            label1.Size = new Size(199, 31);
            label1.TabIndex = 3;
            label1.Text = "Олімпійські ігри";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(389, 28);
            label2.Name = "label2";
            label2.Size = new Size(203, 31);
            label2.TabIndex = 3;
            label2.Text = "Країни-учасники";
            // 
            // btnAddOlympic
            // 
            btnAddOlympic.Location = new Point(269, 115);
            btnAddOlympic.Name = "btnAddOlympic";
            btnAddOlympic.Size = new Size(109, 29);
            btnAddOlympic.TabIndex = 4;
            btnAddOlympic.Tag = "add";
            btnAddOlympic.Text = "Додати гру";
            btnAddOlympic.UseVisualStyleBackColor = true;
            btnAddOlympic.Click += btnOlympic_Click;
            // 
            // btnEditOlympic
            // 
            btnEditOlympic.Location = new Point(269, 160);
            btnEditOlympic.Name = "btnEditOlympic";
            btnEditOlympic.Size = new Size(109, 29);
            btnEditOlympic.TabIndex = 4;
            btnEditOlympic.Tag = "edit";
            btnEditOlympic.Text = "Змінити гру";
            btnEditOlympic.UseVisualStyleBackColor = true;
            btnEditOlympic.Click += btnOlympic_Click;
            // 
            // btnDelOlympic
            // 
            btnDelOlympic.Location = new Point(269, 202);
            btnDelOlympic.Name = "btnDelOlympic";
            btnDelOlympic.Size = new Size(109, 29);
            btnDelOlympic.TabIndex = 4;
            btnDelOlympic.Tag = "del";
            btnDelOlympic.Text = "Видалити гру";
            btnDelOlympic.UseVisualStyleBackColor = true;
            btnDelOlympic.Click += btnOlympic_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(695, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cSVToolStripMenuItem, jSONToolStripMenuItem, tXTToolStripMenuItem, xLSXToolStripMenuItem, xMLToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(141, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // cSVToolStripMenuItem
            // 
            cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            cSVToolStripMenuItem.Size = new Size(127, 26);
            cSVToolStripMenuItem.Tag = "csv";
            cSVToolStripMenuItem.Text = "CSV";
            cSVToolStripMenuItem.Click += OpenMenuOptionClick;
            // 
            // jSONToolStripMenuItem
            // 
            jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            jSONToolStripMenuItem.Size = new Size(127, 26);
            jSONToolStripMenuItem.Tag = "json";
            jSONToolStripMenuItem.Text = "JSON";
            jSONToolStripMenuItem.Click += OpenMenuOptionClick;
            // 
            // tXTToolStripMenuItem
            // 
            tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            tXTToolStripMenuItem.Size = new Size(127, 26);
            tXTToolStripMenuItem.Tag = "txt";
            tXTToolStripMenuItem.Text = "TXT";
            tXTToolStripMenuItem.Click += OpenMenuOptionClick;
            // 
            // xLSXToolStripMenuItem
            // 
            xLSXToolStripMenuItem.Name = "xLSXToolStripMenuItem";
            xLSXToolStripMenuItem.Size = new Size(127, 26);
            xLSXToolStripMenuItem.Tag = "xlsx";
            xLSXToolStripMenuItem.Text = "XLSX";
            xLSXToolStripMenuItem.Click += OpenMenuOptionClick;
            // 
            // xMLToolStripMenuItem
            // 
            xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            xMLToolStripMenuItem.Size = new Size(127, 26);
            xMLToolStripMenuItem.Tag = "xml";
            xMLToolStripMenuItem.Text = "XML";
            xMLToolStripMenuItem.Click += OpenMenuOptionClick;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(141, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveMenuOptionClick;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cSVToolStripMenuItem1, jSONToolStripMenuItem1, tXTToolStripMenuItem1, xLSXToolStripMenuItem1, xMLToolStripMenuItem1 });
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(141, 26);
            saveAsToolStripMenuItem.Text = "Save as";
            // 
            // cSVToolStripMenuItem1
            // 
            cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
            cSVToolStripMenuItem1.Size = new Size(127, 26);
            cSVToolStripMenuItem1.Tag = "csv";
            cSVToolStripMenuItem1.Text = "CSV";
            cSVToolStripMenuItem1.Click += SaveAsMenuOptionClick;
            // 
            // jSONToolStripMenuItem1
            // 
            jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            jSONToolStripMenuItem1.Size = new Size(127, 26);
            jSONToolStripMenuItem1.Tag = "json";
            jSONToolStripMenuItem1.Text = "JSON";
            jSONToolStripMenuItem1.Click += SaveAsMenuOptionClick;
            // 
            // tXTToolStripMenuItem1
            // 
            tXTToolStripMenuItem1.Name = "tXTToolStripMenuItem1";
            tXTToolStripMenuItem1.Size = new Size(127, 26);
            tXTToolStripMenuItem1.Tag = "txt";
            tXTToolStripMenuItem1.Text = "TXT";
            tXTToolStripMenuItem1.Click += SaveAsMenuOptionClick;
            // 
            // xLSXToolStripMenuItem1
            // 
            xLSXToolStripMenuItem1.Name = "xLSXToolStripMenuItem1";
            xLSXToolStripMenuItem1.Size = new Size(127, 26);
            xLSXToolStripMenuItem1.Tag = "xlsx";
            xLSXToolStripMenuItem1.Text = "XLSX";
            xLSXToolStripMenuItem1.Click += SaveAsMenuOptionClick;
            // 
            // xMLToolStripMenuItem1
            // 
            xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            xMLToolStripMenuItem1.Size = new Size(127, 26);
            xMLToolStripMenuItem1.Tag = "xml";
            xMLToolStripMenuItem1.Text = "XML";
            xMLToolStripMenuItem1.Click += SaveAsMenuOptionClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 523);
            Controls.Add(menuStrip1);
            Controls.Add(btnDelOlympic);
            Controls.Add(btnEditOlympic);
            Controls.Add(btnAddOlympic);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbCountriesParticipants);
            Controls.Add(lbOlympics);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbOlympics;
        private ListBox lbCountriesParticipants;
        private Label label1;
        private Label label2;
        private Button btnAddOlympic;
        private Button btnEditOlympic;
        private Button btnDelOlympic;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem cSVToolStripMenuItem;
        private ToolStripMenuItem jSONToolStripMenuItem;
        private ToolStripMenuItem tXTToolStripMenuItem;
        private ToolStripMenuItem xLSXToolStripMenuItem;
        private ToolStripMenuItem xMLToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem cSVToolStripMenuItem1;
        private ToolStripMenuItem jSONToolStripMenuItem1;
        private ToolStripMenuItem tXTToolStripMenuItem1;
        private ToolStripMenuItem xLSXToolStripMenuItem1;
        private ToolStripMenuItem xMLToolStripMenuItem1;
    }
}
