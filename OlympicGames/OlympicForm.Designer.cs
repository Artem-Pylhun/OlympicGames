namespace OlympicGames
{
    partial class OlympicForm
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
            label1 = new Label();
            tabPage2 = new TabPage();
            button1 = new Button();
            lbCities = new ListBox();
            lbAthletes1 = new ListBox();
            lbParticipants = new ListBox();
            nudWins = new NumericUpDown();
            nudLosses = new NumericUpDown();
            btnEditCity = new Button();
            btnEditParticipant = new Button();
            btnDelCity = new Button();
            btnAddCity = new Button();
            btnDelParticipant = new Button();
            btnAddParticipant = new Button();
            label9 = new Label();
            label8 = new Label();
            label16 = new Label();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label7 = new Label();
            label11 = new Label();
            label6 = new Label();
            nudPopulation = new NumericUpDown();
            tbLocation = new TextBox();
            tbParticipantTitle = new TextBox();
            tbCityTitle = new TextBox();
            tabPage1 = new TabPage();
            label18 = new Label();
            btnRemoveParticipantFromList = new Button();
            btnAddParticipantToList = new Button();
            nudYear = new NumericUpDown();
            btnBack = new Button();
            btnCreateOlympic = new Button();
            btnSaveOlympicChanges = new Button();
            cbEventType = new ComboBox();
            cbCityHost = new ComboBox();
            label2 = new Label();
            lbCountryParticipants = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            cbCountryParticipants = new ComboBox();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            button2 = new Button();
            label17 = new Label();
            btnEditAthlete = new Button();
            btnDelAthlete = new Button();
            btnAddAthlete = new Button();
            label15 = new Label();
            label14 = new Label();
            cbIsMale = new CheckBox();
            nudAge = new NumericUpDown();
            tbFullName = new TextBox();
            lbAthletes = new ListBox();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudWins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLosses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPopulation).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 65);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(lbCities);
            tabPage2.Controls.Add(lbAthletes1);
            tabPage2.Controls.Add(lbParticipants);
            tabPage2.Controls.Add(nudWins);
            tabPage2.Controls.Add(nudLosses);
            tabPage2.Controls.Add(btnEditCity);
            tabPage2.Controls.Add(btnEditParticipant);
            tabPage2.Controls.Add(btnDelCity);
            tabPage2.Controls.Add(btnAddCity);
            tabPage2.Controls.Add(btnDelParticipant);
            tabPage2.Controls.Add(btnAddParticipant);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(nudPopulation);
            tabPage2.Controls.Add(tbLocation);
            tabPage2.Controls.Add(tbParticipantTitle);
            tabPage2.Controls.Add(tbCityTitle);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(718, 413);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "City | Participants";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(8, 363);
            button1.Name = "button1";
            button1.Size = new Size(59, 42);
            button1.TabIndex = 11;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnBack_Click;
            // 
            // lbCities
            // 
            lbCities.FormattingEnabled = true;
            lbCities.HorizontalScrollbar = true;
            lbCities.Location = new Point(195, 76);
            lbCities.Name = "lbCities";
            lbCities.Size = new Size(150, 204);
            lbCities.TabIndex = 10;
            lbCities.SelectedIndexChanged += lbCities_SelectedIndexChanged;
            // 
            // lbAthletes1
            // 
            lbAthletes1.FormattingEnabled = true;
            lbAthletes1.HorizontalScrollbar = true;
            lbAthletes1.Location = new Point(360, 245);
            lbAthletes1.Name = "lbAthletes1";
            lbAthletes1.Size = new Size(148, 164);
            lbAthletes1.TabIndex = 9;
            // 
            // lbParticipants
            // 
            lbParticipants.FormattingEnabled = true;
            lbParticipants.HorizontalScrollbar = true;
            lbParticipants.Location = new Point(514, 53);
            lbParticipants.Name = "lbParticipants";
            lbParticipants.Size = new Size(196, 284);
            lbParticipants.TabIndex = 8;
            lbParticipants.SelectedIndexChanged += lbParticipants_SelectedIndexChanged;
            // 
            // nudWins
            // 
            nudWins.Location = new Point(358, 129);
            nudWins.Name = "nudWins";
            nudWins.Size = new Size(150, 27);
            nudWins.TabIndex = 6;
            // 
            // nudLosses
            // 
            nudLosses.Location = new Point(358, 185);
            nudLosses.Name = "nudLosses";
            nudLosses.Size = new Size(150, 27);
            nudLosses.TabIndex = 6;
            // 
            // btnEditCity
            // 
            btnEditCity.AllowDrop = true;
            btnEditCity.Location = new Point(186, 303);
            btnEditCity.Name = "btnEditCity";
            btnEditCity.Size = new Size(75, 50);
            btnEditCity.TabIndex = 3;
            btnEditCity.Tag = "edit";
            btnEditCity.Text = "Edit";
            btnEditCity.UseVisualStyleBackColor = true;
            btnEditCity.Click += btnCity;
            // 
            // btnEditParticipant
            // 
            btnEditParticipant.AllowDrop = true;
            btnEditParticipant.Location = new Point(658, 359);
            btnEditParticipant.Name = "btnEditParticipant";
            btnEditParticipant.Size = new Size(52, 50);
            btnEditParticipant.TabIndex = 3;
            btnEditParticipant.Tag = "edit";
            btnEditParticipant.Text = "Edit";
            btnEditParticipant.UseVisualStyleBackColor = true;
            btnEditParticipant.Click += btnParticipant;
            // 
            // btnDelCity
            // 
            btnDelCity.Location = new Point(105, 303);
            btnDelCity.Name = "btnDelCity";
            btnDelCity.Size = new Size(75, 50);
            btnDelCity.TabIndex = 4;
            btnDelCity.Tag = "del";
            btnDelCity.Text = "Delete";
            btnDelCity.UseVisualStyleBackColor = true;
            btnDelCity.Click += btnCity;
            // 
            // btnAddCity
            // 
            btnAddCity.Location = new Point(30, 303);
            btnAddCity.Name = "btnAddCity";
            btnAddCity.Size = new Size(75, 50);
            btnAddCity.TabIndex = 5;
            btnAddCity.Tag = "add";
            btnAddCity.Text = "Add";
            btnAddCity.UseVisualStyleBackColor = true;
            btnAddCity.Click += btnCity;
            // 
            // btnDelParticipant
            // 
            btnDelParticipant.Location = new Point(585, 359);
            btnDelParticipant.Name = "btnDelParticipant";
            btnDelParticipant.Size = new Size(67, 50);
            btnDelParticipant.TabIndex = 4;
            btnDelParticipant.Tag = "del";
            btnDelParticipant.Text = "Delete";
            btnDelParticipant.UseVisualStyleBackColor = true;
            btnDelParticipant.Click += btnParticipant;
            // 
            // btnAddParticipant
            // 
            btnAddParticipant.Location = new Point(514, 359);
            btnAddParticipant.Name = "btnAddParticipant";
            btnAddParticipant.Size = new Size(65, 50);
            btnAddParticipant.TabIndex = 5;
            btnAddParticipant.Tag = "add";
            btnAddParticipant.Text = "Add";
            btnAddParticipant.UseVisualStyleBackColor = true;
            btnAddParticipant.Click += btnParticipant;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(59, 193);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 2;
            label9.Text = "Population";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(73, 121);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 2;
            label8.Text = "Location";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(397, 222);
            label16.Name = "label16";
            label16.Size = new Size(63, 20);
            label16.TabIndex = 2;
            label16.Text = "Athletes";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(409, 162);
            label13.Name = "label13";
            label13.Size = new Size(51, 20);
            label13.TabIndex = 2;
            label13.Text = "Losses";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(406, 106);
            label12.Name = "label12";
            label12.Size = new Size(41, 20);
            label12.TabIndex = 2;
            label12.Text = "Wins";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(409, 53);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 2;
            label10.Text = "Title";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 53);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 2;
            label7.Text = "Title";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(437, 13);
            label11.Name = "label11";
            label11.Size = new Size(142, 31);
            label11.TabIndex = 2;
            label11.Text = "Participants";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(155, 13);
            label6.Name = "label6";
            label6.Size = new Size(56, 31);
            label6.TabIndex = 2;
            label6.Text = "City";
            // 
            // nudPopulation
            // 
            nudPopulation.Location = new Point(30, 216);
            nudPopulation.Maximum = new decimal(new int[] { 5000000, 0, 0, 0 });
            nudPopulation.Minimum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPopulation.Name = "nudPopulation";
            nudPopulation.Size = new Size(150, 27);
            nudPopulation.TabIndex = 1;
            nudPopulation.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // tbLocation
            // 
            tbLocation.Location = new Point(30, 144);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(150, 27);
            tbLocation.TabIndex = 0;
            // 
            // tbParticipantTitle
            // 
            tbParticipantTitle.Location = new Point(358, 76);
            tbParticipantTitle.Name = "tbParticipantTitle";
            tbParticipantTitle.Size = new Size(150, 27);
            tbParticipantTitle.TabIndex = 0;
            // 
            // tbCityTitle
            // 
            tbCityTitle.Location = new Point(30, 76);
            tbCityTitle.Name = "tbCityTitle";
            tbCityTitle.Size = new Size(150, 27);
            tbCityTitle.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(btnRemoveParticipantFromList);
            tabPage1.Controls.Add(btnAddParticipantToList);
            tabPage1.Controls.Add(nudYear);
            tabPage1.Controls.Add(btnBack);
            tabPage1.Controls.Add(btnCreateOlympic);
            tabPage1.Controls.Add(btnSaveOlympicChanges);
            tabPage1.Controls.Add(cbEventType);
            tabPage1.Controls.Add(cbCityHost);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(lbCountryParticipants);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cbCountryParticipants);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(718, 413);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Olympic";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label18.Location = new Point(321, 3);
            label18.Name = "label18";
            label18.Size = new Size(103, 31);
            label18.TabIndex = 8;
            label18.Text = "Olympic";
            // 
            // btnRemoveParticipantFromList
            // 
            btnRemoveParticipantFromList.Location = new Point(324, 140);
            btnRemoveParticipantFromList.Name = "btnRemoveParticipantFromList";
            btnRemoveParticipantFromList.Size = new Size(85, 57);
            btnRemoveParticipantFromList.TabIndex = 7;
            btnRemoveParticipantFromList.Text = "Remove from list";
            btnRemoveParticipantFromList.UseVisualStyleBackColor = true;
            btnRemoveParticipantFromList.Click += btnRemoveParticipantFromList_Click;
            // 
            // btnAddParticipantToList
            // 
            btnAddParticipantToList.Location = new Point(235, 139);
            btnAddParticipantToList.Name = "btnAddParticipantToList";
            btnAddParticipantToList.Size = new Size(76, 59);
            btnAddParticipantToList.TabIndex = 6;
            btnAddParticipantToList.Text = "Add to list";
            btnAddParticipantToList.UseVisualStyleBackColor = true;
            btnAddParticipantToList.Click += btnAddParticipantToList_Click;
            // 
            // nudYear
            // 
            nudYear.Location = new Point(24, 81);
            nudYear.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(150, 27);
            nudYear.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(18, 367);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(59, 42);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCreateOlympic
            // 
            btnCreateOlympic.Location = new Point(190, 336);
            btnCreateOlympic.Name = "btnCreateOlympic";
            btnCreateOlympic.Size = new Size(171, 69);
            btnCreateOlympic.TabIndex = 5;
            btnCreateOlympic.Text = "Create Olympic";
            btnCreateOlympic.UseVisualStyleBackColor = true;
            btnCreateOlympic.Click += btnCreateOlympic_Click;
            // 
            // btnSaveOlympicChanges
            // 
            btnSaveOlympicChanges.Location = new Point(379, 336);
            btnSaveOlympicChanges.Name = "btnSaveOlympicChanges";
            btnSaveOlympicChanges.Size = new Size(171, 69);
            btnSaveOlympicChanges.TabIndex = 5;
            btnSaveOlympicChanges.Text = "Save Changes";
            btnSaveOlympicChanges.UseVisualStyleBackColor = true;
            btnSaveOlympicChanges.Click += btnSave_Click;
            // 
            // cbEventType
            // 
            cbEventType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEventType.FormattingEnabled = true;
            cbEventType.Location = new Point(24, 213);
            cbEventType.Name = "cbEventType";
            cbEventType.Size = new Size(151, 28);
            cbEventType.TabIndex = 0;
            // 
            // cbCityHost
            // 
            cbCityHost.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCityHost.FormattingEnabled = true;
            cbCityHost.Location = new Point(24, 148);
            cbCityHost.Name = "cbCityHost";
            cbCityHost.Size = new Size(151, 28);
            cbCityHost.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 125);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "City Host";
            // 
            // lbCountryParticipants
            // 
            lbCountryParticipants.FormattingEnabled = true;
            lbCountryParticipants.HorizontalScrollbar = true;
            lbCountryParticipants.Location = new Point(430, 58);
            lbCountryParticipants.Name = "lbCountryParticipants";
            lbCountryParticipants.Size = new Size(269, 244);
            lbCountryParticipants.TabIndex = 3;
            lbCountryParticipants.SelectedIndexChanged += lbCountryParticipants_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 190);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 1;
            label4.Text = "Event type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 58);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 1;
            label5.Text = "Year when will be held";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 58);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 1;
            label3.Text = "Country participants";
            // 
            // cbCountryParticipants
            // 
            cbCountryParticipants.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCountryParticipants.FormattingEnabled = true;
            cbCountryParticipants.Location = new Point(235, 91);
            cbCountryParticipants.Name = "cbCountryParticipants";
            cbCountryParticipants.Size = new Size(174, 28);
            cbCountryParticipants.TabIndex = 0;
            cbCountryParticipants.SelectedIndexChanged += cbCountryParticipants_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(726, 446);
            tabControl1.TabIndex = 6;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(btnEditAthlete);
            tabPage3.Controls.Add(btnDelAthlete);
            tabPage3.Controls.Add(btnAddAthlete);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(cbIsMale);
            tabPage3.Controls.Add(nudAge);
            tabPage3.Controls.Add(tbFullName);
            tabPage3.Controls.Add(lbAthletes);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(718, 413);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Athletes";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(19, 363);
            button2.Name = "button2";
            button2.Size = new Size(59, 42);
            button2.TabIndex = 17;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnBack_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label17.Location = new Point(353, 8);
            label17.Name = "label17";
            label17.Size = new Size(103, 31);
            label17.TabIndex = 16;
            label17.Text = "Athletes";
            // 
            // btnEditAthlete
            // 
            btnEditAthlete.AllowDrop = true;
            btnEditAthlete.Location = new Point(346, 335);
            btnEditAthlete.Name = "btnEditAthlete";
            btnEditAthlete.Size = new Size(62, 50);
            btnEditAthlete.TabIndex = 13;
            btnEditAthlete.Tag = "edit";
            btnEditAthlete.Text = "Edit";
            btnEditAthlete.UseVisualStyleBackColor = true;
            btnEditAthlete.Click += btnAthlete;
            // 
            // btnDelAthlete
            // 
            btnDelAthlete.Location = new Point(273, 335);
            btnDelAthlete.Name = "btnDelAthlete";
            btnDelAthlete.Size = new Size(67, 50);
            btnDelAthlete.TabIndex = 14;
            btnDelAthlete.Tag = "del";
            btnDelAthlete.Text = "Delete";
            btnDelAthlete.UseVisualStyleBackColor = true;
            btnDelAthlete.Click += btnAthlete;
            // 
            // btnAddAthlete
            // 
            btnAddAthlete.Location = new Point(202, 335);
            btnAddAthlete.Name = "btnAddAthlete";
            btnAddAthlete.Size = new Size(65, 50);
            btnAddAthlete.TabIndex = 15;
            btnAddAthlete.Tag = "add";
            btnAddAthlete.Text = "Add";
            btnAddAthlete.UseVisualStyleBackColor = true;
            btnAddAthlete.Click += btnAthlete;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(500, 176);
            label15.Name = "label15";
            label15.Size = new Size(36, 20);
            label15.TabIndex = 12;
            label15.Text = "Age";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(490, 100);
            label14.Name = "label14";
            label14.Size = new Size(76, 20);
            label14.TabIndex = 12;
            label14.Text = "Full Name";
            // 
            // cbIsMale
            // 
            cbIsMale.AutoSize = true;
            cbIsMale.Location = new Point(480, 271);
            cbIsMale.Name = "cbIsMale";
            cbIsMale.Size = new Size(85, 24);
            cbIsMale.TabIndex = 11;
            cbIsMale.Text = "Is male?";
            cbIsMale.TextAlign = ContentAlignment.MiddleRight;
            cbIsMale.UseVisualStyleBackColor = true;
            // 
            // nudAge
            // 
            nudAge.Location = new Point(490, 210);
            nudAge.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudAge.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(75, 27);
            nudAge.TabIndex = 10;
            nudAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(467, 136);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(125, 27);
            tbFullName.TabIndex = 9;
            // 
            // lbAthletes
            // 
            lbAthletes.FormattingEnabled = true;
            lbAthletes.HorizontalScrollbar = true;
            lbAthletes.Location = new Point(200, 67);
            lbAthletes.Name = "lbAthletes";
            lbAthletes.Size = new Size(208, 244);
            lbAthletes.TabIndex = 8;
            lbAthletes.SelectedIndexChanged += lbAthletes_SelectedIndexChanged;
            // 
            // OlympicForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 446);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "OlympicForm";
            Text = "OlympicForm";
            FormClosed += OlympicForm_FormClosed;
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudWins).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLosses).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPopulation).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TabPage tabPage2;
        private Button btnEditParticipant;
        private Button btnDelParticipant;
        private Button btnAddParticipant;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label7;
        private Label label6;
        private NumericUpDown nudPopulation;
        private TextBox tbLocation;
        private TextBox tbCityTitle;
        private TabPage tabPage1;
        private NumericUpDown nudYear;
        private Button btnBack;
        private Button btnSaveOlympicChanges;
        private Button btnAddOlympic;
        private Button btnCreateOlympic;
        private ComboBox cbEventType;
        private ComboBox cbCityHost;
        private Label label2;
        private ListBox lbCountryParticipants;
        private Label label4;
        private Label label5;
        private Label label3;
        private ComboBox cbCountryParticipants;
        private TabControl tabControl1;
        private NumericUpDown nudWins;
        private NumericUpDown nudLosses;
        private Label label11;
        private TabPage tabPage3;
        private ListBox lbParticipants;
        private TextBox tbParticipantTitle;
        private Label label13;
        private Label label12;
        private ListBox lbAthletes;
        private ListBox lbAthletes1;
        private CheckBox cbIsMale;
        private NumericUpDown nudAge;
        private TextBox tbFullName;
        private Label label15;
        private Label label14;
        private ListBox lbCities;
        private Button btnEditCity;
        private Button btnDelCity;
        private Button btnAddCity;
        private Label label16;
        private Button btnRemoveParticipantFromList;
        private Button btnAddParticipantToList;
        private Button btnEditAthlete;
        private Button btnDelAthlete;
        private Button btnAddAthlete;
        private Label label17;
        private Label label18;
        private Button button1;
        private Button button2;
    }
}