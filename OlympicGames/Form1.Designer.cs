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
            SuspendLayout();
            // 
            // lbOlympics
            // 
            lbOlympics.FormattingEnabled = true;
            lbOlympics.Location = new Point(59, 74);
            lbOlympics.Name = "lbOlympics";
            lbOlympics.Size = new Size(199, 324);
            lbOlympics.TabIndex = 0;
            lbOlympics.SelectedIndexChanged += lbOlympics_SelectedIndexChanged;
            // 
            // lbCountriesParticipants
            // 
            lbCountriesParticipants.FormattingEnabled = true;
            lbCountriesParticipants.Location = new Point(389, 74);
            lbCountriesParticipants.Name = "lbCountriesParticipants";
            lbCountriesParticipants.Size = new Size(195, 324);
            lbCountriesParticipants.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(59, 15);
            label1.Name = "label1";
            label1.Size = new Size(199, 31);
            label1.TabIndex = 3;
            label1.Text = "Олімпійські ігри";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(389, 15);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 523);
            Controls.Add(btnDelOlympic);
            Controls.Add(btnEditOlympic);
            Controls.Add(btnAddOlympic);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbCountriesParticipants);
            Controls.Add(lbOlympics);
            Name = "Form1";
            Text = "Form1";
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
    }
}
