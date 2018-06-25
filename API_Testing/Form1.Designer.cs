namespace API_Testing
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
            this.smnrNameSttc = new System.Windows.Forms.Label();
            this.smnrNameLbl = new System.Windows.Forms.Label();
            this.smnrIdSttc = new System.Windows.Forms.Label();
            this.smnrNameInput = new System.Windows.Forms.TextBox();
            this.fetchBtn = new System.Windows.Forms.Button();
            this.smnrLvlSttc = new System.Windows.Forms.Label();
            this.smnrLvlLbl = new System.Windows.Forms.Label();
            this.smnrIcon = new System.Windows.Forms.PictureBox();
            this.smnrIdBox = new System.Windows.Forms.TextBox();
            this.smnrRankSttc = new System.Windows.Forms.Label();
            this.smnrRankLbl = new System.Windows.Forms.Label();
            this.rgnBox = new System.Windows.Forms.ComboBox();
            this.rgnLblSttc = new System.Windows.Forms.Label();
            this.accIdLblSttc = new System.Windows.Forms.Label();
            this.accIdBox = new System.Windows.Forms.TextBox();
            this.quitBtn = new System.Windows.Forms.Button();
            this.crntMtchBtn = new System.Windows.Forms.Button();
            this.seriesInfoLbl = new System.Windows.Forms.Label();
            this.seriesInfoSttc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.smnrIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // smnrNameSttc
            // 
            this.smnrNameSttc.AutoSize = true;
            this.smnrNameSttc.Location = new System.Drawing.Point(12, 26);
            this.smnrNameSttc.Name = "smnrNameSttc";
            this.smnrNameSttc.Size = new System.Drawing.Size(91, 13);
            this.smnrNameSttc.TabIndex = 0;
            this.smnrNameSttc.Text = "Summoner Name:";
            // 
            // smnrNameLbl
            // 
            this.smnrNameLbl.AutoSize = true;
            this.smnrNameLbl.Location = new System.Drawing.Point(99, 26);
            this.smnrNameLbl.Name = "smnrNameLbl";
            this.smnrNameLbl.Size = new System.Drawing.Size(0, 13);
            this.smnrNameLbl.TabIndex = 1;
            // 
            // smnrIdSttc
            // 
            this.smnrIdSttc.AutoSize = true;
            this.smnrIdSttc.Location = new System.Drawing.Point(12, 57);
            this.smnrIdSttc.Name = "smnrIdSttc";
            this.smnrIdSttc.Size = new System.Drawing.Size(78, 13);
            this.smnrIdSttc.TabIndex = 0;
            this.smnrIdSttc.Text = "Summoner ID: ";
            // 
            // smnrNameInput
            // 
            this.smnrNameInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smnrNameInput.Location = new System.Drawing.Point(292, 295);
            this.smnrNameInput.Name = "smnrNameInput";
            this.smnrNameInput.Size = new System.Drawing.Size(125, 23);
            this.smnrNameInput.TabIndex = 2;
            this.smnrNameInput.Text = "Type Name Here..";
            this.smnrNameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.smnrNameInput_KeyDown);
            // 
            // fetchBtn
            // 
            this.fetchBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchBtn.Location = new System.Drawing.Point(292, 324);
            this.fetchBtn.Name = "fetchBtn";
            this.fetchBtn.Size = new System.Drawing.Size(125, 33);
            this.fetchBtn.TabIndex = 3;
            this.fetchBtn.Text = "Fetch";
            this.fetchBtn.UseVisualStyleBackColor = true;
            this.fetchBtn.Click += new System.EventHandler(this.fetchBtn_Click);
            // 
            // smnrLvlSttc
            // 
            this.smnrLvlSttc.AutoSize = true;
            this.smnrLvlSttc.Location = new System.Drawing.Point(12, 87);
            this.smnrLvlSttc.Name = "smnrLvlSttc";
            this.smnrLvlSttc.Size = new System.Drawing.Size(89, 13);
            this.smnrLvlSttc.TabIndex = 0;
            this.smnrLvlSttc.Text = "Summoner Level:";
            // 
            // smnrLvlLbl
            // 
            this.smnrLvlLbl.AutoSize = true;
            this.smnrLvlLbl.Location = new System.Drawing.Point(98, 87);
            this.smnrLvlLbl.Name = "smnrLvlLbl";
            this.smnrLvlLbl.Size = new System.Drawing.Size(0, 13);
            this.smnrLvlLbl.TabIndex = 1;
            // 
            // smnrIcon
            // 
            this.smnrIcon.Location = new System.Drawing.Point(292, 20);
            this.smnrIcon.Name = "smnrIcon";
            this.smnrIcon.Size = new System.Drawing.Size(99, 80);
            this.smnrIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.smnrIcon.TabIndex = 4;
            this.smnrIcon.TabStop = false;
            // 
            // smnrIdBox
            // 
            this.smnrIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smnrIdBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smnrIdBox.Location = new System.Drawing.Point(88, 56);
            this.smnrIdBox.Name = "smnrIdBox";
            this.smnrIdBox.ReadOnly = true;
            this.smnrIdBox.Size = new System.Drawing.Size(125, 14);
            this.smnrIdBox.TabIndex = 2;
            this.smnrIdBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.smnrNameInput_KeyDown);
            this.smnrIdBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.smnrIdBox_MouseDown);
            // 
            // smnrRankSttc
            // 
            this.smnrRankSttc.AutoSize = true;
            this.smnrRankSttc.Location = new System.Drawing.Point(12, 120);
            this.smnrRankSttc.Name = "smnrRankSttc";
            this.smnrRankSttc.Size = new System.Drawing.Size(88, 13);
            this.smnrRankSttc.TabIndex = 5;
            this.smnrRankSttc.Text = "Summoner Rank:";
            // 
            // smnrRankLbl
            // 
            this.smnrRankLbl.AutoSize = true;
            this.smnrRankLbl.Location = new System.Drawing.Point(98, 120);
            this.smnrRankLbl.Name = "smnrRankLbl";
            this.smnrRankLbl.Size = new System.Drawing.Size(0, 13);
            this.smnrRankLbl.TabIndex = 1;
            // 
            // rgnBox
            // 
            this.rgnBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rgnBox.FormattingEnabled = true;
            this.rgnBox.Items.AddRange(new object[] {
            "EUNE",
            "EUW",
            "NA"});
            this.rgnBox.Location = new System.Drawing.Point(292, 186);
            this.rgnBox.Name = "rgnBox";
            this.rgnBox.Size = new System.Drawing.Size(121, 21);
            this.rgnBox.TabIndex = 6;
            this.rgnBox.SelectedIndexChanged += new System.EventHandler(this.rgnBox_SelectedIndexChanged);
            // 
            // rgnLblSttc
            // 
            this.rgnLblSttc.AutoSize = true;
            this.rgnLblSttc.Location = new System.Drawing.Point(289, 170);
            this.rgnLblSttc.Name = "rgnLblSttc";
            this.rgnLblSttc.Size = new System.Drawing.Size(44, 13);
            this.rgnLblSttc.TabIndex = 0;
            this.rgnLblSttc.Text = "Region:";
            // 
            // accIdLblSttc
            // 
            this.accIdLblSttc.AutoSize = true;
            this.accIdLblSttc.Location = new System.Drawing.Point(12, 177);
            this.accIdLblSttc.Name = "accIdLblSttc";
            this.accIdLblSttc.Size = new System.Drawing.Size(64, 13);
            this.accIdLblSttc.TabIndex = 0;
            this.accIdLblSttc.Text = "Account ID:";
            // 
            // accIdBox
            // 
            this.accIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accIdBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.accIdBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accIdBox.Location = new System.Drawing.Point(75, 177);
            this.accIdBox.Name = "accIdBox";
            this.accIdBox.ReadOnly = true;
            this.accIdBox.Size = new System.Drawing.Size(125, 14);
            this.accIdBox.TabIndex = 2;
            this.accIdBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.smnrNameInput_KeyDown);
            this.accIdBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.accIdBox_MouseDown);
            // 
            // quitBtn
            // 
            this.quitBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(12, 324);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(64, 33);
            this.quitBtn.TabIndex = 3;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // crntMtchBtn
            // 
            this.crntMtchBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crntMtchBtn.Location = new System.Drawing.Point(113, 324);
            this.crntMtchBtn.Name = "crntMtchBtn";
            this.crntMtchBtn.Size = new System.Drawing.Size(125, 33);
            this.crntMtchBtn.TabIndex = 3;
            this.crntMtchBtn.Text = "Current Match";
            this.crntMtchBtn.UseVisualStyleBackColor = true;
            this.crntMtchBtn.Click += new System.EventHandler(this.crntMtchBtn_Click);
            // 
            // seriesInfoLbl
            // 
            this.seriesInfoLbl.AutoSize = true;
            this.seriesInfoLbl.Location = new System.Drawing.Point(80, 150);
            this.seriesInfoLbl.Name = "seriesInfoLbl";
            this.seriesInfoLbl.Size = new System.Drawing.Size(0, 13);
            this.seriesInfoLbl.TabIndex = 1;
            // 
            // seriesInfoSttc
            // 
            this.seriesInfoSttc.AutoSize = true;
            this.seriesInfoSttc.Location = new System.Drawing.Point(11, 150);
            this.seriesInfoSttc.Name = "seriesInfoSttc";
            this.seriesInfoSttc.Size = new System.Drawing.Size(63, 13);
            this.seriesInfoSttc.TabIndex = 5;
            this.seriesInfoSttc.Text = "Series Info:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 369);
            this.ControlBox = false;
            this.Controls.Add(this.rgnBox);
            this.Controls.Add(this.seriesInfoSttc);
            this.Controls.Add(this.smnrRankSttc);
            this.Controls.Add(this.smnrIcon);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.crntMtchBtn);
            this.Controls.Add(this.fetchBtn);
            this.Controls.Add(this.accIdBox);
            this.Controls.Add(this.smnrIdBox);
            this.Controls.Add(this.seriesInfoLbl);
            this.Controls.Add(this.smnrNameInput);
            this.Controls.Add(this.smnrRankLbl);
            this.Controls.Add(this.smnrLvlLbl);
            this.Controls.Add(this.smnrNameLbl);
            this.Controls.Add(this.smnrLvlSttc);
            this.Controls.Add(this.rgnLblSttc);
            this.Controls.Add(this.accIdLblSttc);
            this.Controls.Add(this.smnrIdSttc);
            this.Controls.Add(this.smnrNameSttc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Riot API Test";
            ((System.ComponentModel.ISupportInitialize)(this.smnrIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label smnrNameSttc;
        private System.Windows.Forms.Label smnrNameLbl;
        private System.Windows.Forms.Label smnrIdSttc;
        private System.Windows.Forms.TextBox smnrNameInput;
        private System.Windows.Forms.Button fetchBtn;
        private System.Windows.Forms.Label smnrLvlSttc;
        private System.Windows.Forms.Label smnrLvlLbl;
        private System.Windows.Forms.PictureBox smnrIcon;
        private System.Windows.Forms.TextBox smnrIdBox;
        private System.Windows.Forms.Label smnrRankSttc;
        private System.Windows.Forms.Label smnrRankLbl;
        private System.Windows.Forms.ComboBox rgnBox;
        private System.Windows.Forms.Label rgnLblSttc;
        private System.Windows.Forms.Label accIdLblSttc;
        private System.Windows.Forms.TextBox accIdBox;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button crntMtchBtn;
        private System.Windows.Forms.Label seriesInfoLbl;
        private System.Windows.Forms.Label seriesInfoSttc;
    }
}

