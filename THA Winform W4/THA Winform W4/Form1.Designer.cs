namespace THA_Winform_W4
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelChooseCountry = new System.Windows.Forms.Label();
            this.labelChooseTeam = new System.Windows.Forms.Label();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelTeamCountry = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.textBoxTeamCountry = new System.Windows.Forms.TextBox();
            this.labelTeamCity = new System.Windows.Forms.Label();
            this.textBoxTeamCity = new System.Windows.Forms.TextBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd1 = new System.Windows.Forms.Button();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelPlayerNumber = new System.Windows.Forms.Label();
            this.labelPlayerPosition = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.textBoxPlayerNumber = new System.Windows.Forms.TextBox();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soccer team List";
            // 
            // labelChooseCountry
            // 
            this.labelChooseCountry.AutoSize = true;
            this.labelChooseCountry.Location = new System.Drawing.Point(48, 138);
            this.labelChooseCountry.Name = "labelChooseCountry";
            this.labelChooseCountry.Size = new System.Drawing.Size(173, 25);
            this.labelChooseCountry.TabIndex = 1;
            this.labelChooseCountry.Text = "Choose Country:";
            // 
            // labelChooseTeam
            // 
            this.labelChooseTeam.AutoSize = true;
            this.labelChooseTeam.Location = new System.Drawing.Point(48, 203);
            this.labelChooseTeam.Name = "labelChooseTeam";
            this.labelChooseTeam.Size = new System.Drawing.Size(152, 25);
            this.labelChooseTeam.TabIndex = 2;
            this.labelChooseTeam.Text = "Choose Team:";
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(504, 135);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(134, 25);
            this.labelTeamName.TabIndex = 3;
            this.labelTeamName.Text = "Team Name:";
            // 
            // labelTeamCountry
            // 
            this.labelTeamCountry.AutoSize = true;
            this.labelTeamCountry.Location = new System.Drawing.Point(504, 200);
            this.labelTeamCountry.Name = "labelTeamCountry";
            this.labelTeamCountry.Size = new System.Drawing.Size(153, 25);
            this.labelTeamCountry.TabIndex = 4;
            this.labelTeamCountry.Text = "Team Country:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adding Team";
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(677, 129);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(196, 31);
            this.textBoxTeamName.TabIndex = 6;
            this.textBoxTeamName.TextChanged += new System.EventHandler(this.textBoxTeamName_TextChanged);
            // 
            // textBoxTeamCountry
            // 
            this.textBoxTeamCountry.Location = new System.Drawing.Point(677, 194);
            this.textBoxTeamCountry.Name = "textBoxTeamCountry";
            this.textBoxTeamCountry.Size = new System.Drawing.Size(196, 31);
            this.textBoxTeamCountry.TabIndex = 7;
            this.textBoxTeamCountry.TextChanged += new System.EventHandler(this.textBoxTeamCountry_TextChanged);
            // 
            // labelTeamCity
            // 
            this.labelTeamCity.AutoSize = true;
            this.labelTeamCity.Location = new System.Drawing.Point(504, 264);
            this.labelTeamCity.Name = "labelTeamCity";
            this.labelTeamCity.Size = new System.Drawing.Size(115, 25);
            this.labelTeamCity.TabIndex = 8;
            this.labelTeamCity.Text = "Team City:";
            // 
            // textBoxTeamCity
            // 
            this.textBoxTeamCity.Location = new System.Drawing.Point(677, 258);
            this.textBoxTeamCity.Name = "textBoxTeamCity";
            this.textBoxTeamCity.Size = new System.Drawing.Size(196, 31);
            this.textBoxTeamCity.TabIndex = 9;
            this.textBoxTeamCity.TextChanged += new System.EventHandler(this.textBoxTeamCity_TextChanged);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(239, 130);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(218, 33);
            this.comboBoxCountry.TabIndex = 10;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(239, 195);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(218, 33);
            this.comboBoxTeam.TabIndex = 11;
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeam_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(53, 307);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(406, 204);
            this.listBox1.TabIndex = 12;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(52, 537);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(124, 39);
            this.buttonRemove.TabIndex = 13;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.Location = new System.Drawing.Point(677, 317);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(99, 32);
            this.buttonAdd1.TabIndex = 14;
            this.buttonAdd1.Text = "Add";
            this.buttonAdd1.UseVisualStyleBackColor = true;
            this.buttonAdd1.Click += new System.EventHandler(this.buttonAdd1_Click);
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(927, 135);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(141, 25);
            this.labelPlayerName.TabIndex = 15;
            this.labelPlayerName.Text = "Player Name:";
            // 
            // labelPlayerNumber
            // 
            this.labelPlayerNumber.AutoSize = true;
            this.labelPlayerNumber.Location = new System.Drawing.Point(927, 200);
            this.labelPlayerNumber.Name = "labelPlayerNumber";
            this.labelPlayerNumber.Size = new System.Drawing.Size(160, 25);
            this.labelPlayerNumber.TabIndex = 16;
            this.labelPlayerNumber.Text = "Player Number:";
            // 
            // labelPlayerPosition
            // 
            this.labelPlayerPosition.AutoSize = true;
            this.labelPlayerPosition.Location = new System.Drawing.Point(927, 264);
            this.labelPlayerPosition.Name = "labelPlayerPosition";
            this.labelPlayerPosition.Size = new System.Drawing.Size(162, 25);
            this.labelPlayerPosition.TabIndex = 17;
            this.labelPlayerPosition.Text = "Player Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1117, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Adding Players";
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(1122, 129);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(198, 31);
            this.textBoxPlayerName.TabIndex = 19;
            // 
            // textBoxPlayerNumber
            // 
            this.textBoxPlayerNumber.Location = new System.Drawing.Point(1122, 200);
            this.textBoxPlayerNumber.Name = "textBoxPlayerNumber";
            this.textBoxPlayerNumber.Size = new System.Drawing.Size(198, 31);
            this.textBoxPlayerNumber.TabIndex = 20;
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.Location = new System.Drawing.Point(1122, 317);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(99, 32);
            this.buttonAdd2.TabIndex = 22;
            this.buttonAdd2.Text = "Add";
            this.buttonAdd2.UseVisualStyleBackColor = true;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.comboBoxPosition.Location = new System.Drawing.Point(1122, 261);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(198, 33);
            this.comboBoxPosition.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 683);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.buttonAdd2);
            this.Controls.Add(this.textBoxPlayerNumber);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPlayerPosition);
            this.Controls.Add(this.labelPlayerNumber);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.buttonAdd1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.textBoxTeamCity);
            this.Controls.Add(this.labelTeamCity);
            this.Controls.Add(this.textBoxTeamCountry);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTeamCountry);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.labelChooseTeam);
            this.Controls.Add(this.labelChooseCountry);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChooseCountry;
        private System.Windows.Forms.Label labelChooseTeam;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelTeamCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.TextBox textBoxTeamCountry;
        private System.Windows.Forms.Label labelTeamCity;
        private System.Windows.Forms.TextBox textBoxTeamCity;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd1;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelPlayerNumber;
        private System.Windows.Forms.Label labelPlayerPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.TextBox textBoxPlayerNumber;
        private System.Windows.Forms.Button buttonAdd2;
        private System.Windows.Forms.ComboBox comboBoxPosition;
    }
}

