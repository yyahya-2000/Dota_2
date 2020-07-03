namespace HOME_WORK_CONTROL
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.your_name_lable = new System.Windows.Forms.Label();
            this.enemy_name_lable = new System.Windows.Forms.Label();
            this.Your_Level_health = new System.Windows.Forms.ProgressBar();
            this.playing_style_1 = new System.Windows.Forms.ComboBox();
            this.round_news = new System.Windows.Forms.Label();
            this.playing_style_2 = new System.Windows.Forms.ComboBox();
            this.enemy_Level_health = new System.Windows.Forms.ProgressBar();
            this.New_round_button = new System.Windows.Forms.Button();
            this.Choose_Random_button = new System.Windows.Forms.Button();
            this.Choose_Random_button_1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.round_number = new System.Windows.Forms.Label();
            this.Random_Always_checkBox1 = new System.Windows.Forms.CheckBox();
            this.Random_always_checkBox2 = new System.Windows.Forms.CheckBox();
            this.Percent_label1 = new System.Windows.Forms.Label();
            this.Percent_label2 = new System.Windows.Forms.Label();
            this.player1_label1 = new System.Windows.Forms.Label();
            this.player2label1 = new System.Windows.Forms.Label();
            this.data_player_2_label = new System.Windows.Forms.Label();
            this.data_player_1_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // your_name_lable
            // 
            this.your_name_lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.your_name_lable.AutoSize = true;
            this.your_name_lable.BackColor = System.Drawing.Color.Transparent;
            this.your_name_lable.Font = new System.Drawing.Font("CSNPWDT NFI", 20F);
            this.your_name_lable.ForeColor = System.Drawing.Color.White;
            this.your_name_lable.ImageKey = "(none)";
            this.your_name_lable.Location = new System.Drawing.Point(603, 225);
            this.your_name_lable.MinimumSize = new System.Drawing.Size(121, 33);
            this.your_name_lable.Name = "your_name_lable";
            this.your_name_lable.Size = new System.Drawing.Size(121, 33);
            this.your_name_lable.TabIndex = 17;
            this.your_name_lable.Text = "PLAYER 1:";
            this.your_name_lable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enemy_name_lable
            // 
            this.enemy_name_lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.enemy_name_lable.AutoSize = true;
            this.enemy_name_lable.BackColor = System.Drawing.Color.Transparent;
            this.enemy_name_lable.Font = new System.Drawing.Font("CSNPWDT NFI", 20F);
            this.enemy_name_lable.ForeColor = System.Drawing.Color.White;
            this.enemy_name_lable.ImageKey = "(none)";
            this.enemy_name_lable.Location = new System.Drawing.Point(12, 228);
            this.enemy_name_lable.Name = "enemy_name_lable";
            this.enemy_name_lable.Size = new System.Drawing.Size(129, 33);
            this.enemy_name_lable.TabIndex = 18;
            this.enemy_name_lable.Text = "PLAYER 2:";
            this.enemy_name_lable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Your_Level_health
            // 
            this.Your_Level_health.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Your_Level_health.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Your_Level_health.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Your_Level_health.Location = new System.Drawing.Point(591, 37);
            this.Your_Level_health.MaximumSize = new System.Drawing.Size(400, 23);
            this.Your_Level_health.Name = "Your_Level_health";
            this.Your_Level_health.Size = new System.Drawing.Size(186, 23);
            this.Your_Level_health.TabIndex = 22;
            // 
            // playing_style_1
            // 
            this.playing_style_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playing_style_1.BackColor = System.Drawing.SystemColors.Window;
            this.playing_style_1.Font = new System.Drawing.Font("Bodoni MT", 11F);
            this.playing_style_1.FormattingEnabled = true;
            this.playing_style_1.Items.AddRange(new object[] {
            "RUN AWAY",
            "PROTECT",
            "ATTACK"});
            this.playing_style_1.Location = new System.Drawing.Point(593, 66);
            this.playing_style_1.MaximumSize = new System.Drawing.Size(400, 0);
            this.playing_style_1.Name = "playing_style_1";
            this.playing_style_1.Size = new System.Drawing.Size(186, 26);
            this.playing_style_1.TabIndex = 24;
            this.playing_style_1.Text = "Choose Playing Style!";
            this.playing_style_1.SelectedIndexChanged += new System.EventHandler(this.playing_style_1_SelectedIndexChanged);
            // 
            // round_news
            // 
            this.round_news.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.round_news.AutoSize = true;
            this.round_news.Font = new System.Drawing.Font("CSNPWDT NFI", 14F);
            this.round_news.ForeColor = System.Drawing.Color.Green;
            this.round_news.Location = new System.Drawing.Point(397, 235);
            this.round_news.Name = "round_news";
            this.round_news.Size = new System.Drawing.Size(0, 23);
            this.round_news.TabIndex = 26;
            // 
            // playing_style_2
            // 
            this.playing_style_2.Font = new System.Drawing.Font("Bodoni MT", 11F);
            this.playing_style_2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.playing_style_2.FormattingEnabled = true;
            this.playing_style_2.Items.AddRange(new object[] {
            "RUN AWAY",
            "PROTECT",
            "ATTACK"});
            this.playing_style_2.Location = new System.Drawing.Point(2, 76);
            this.playing_style_2.Name = "playing_style_2";
            this.playing_style_2.Size = new System.Drawing.Size(184, 26);
            this.playing_style_2.TabIndex = 27;
            this.playing_style_2.Text = "Choose Playing Style!";
            // 
            // enemy_Level_health
            // 
            this.enemy_Level_health.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enemy_Level_health.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.enemy_Level_health.Location = new System.Drawing.Point(2, 37);
            this.enemy_Level_health.Name = "enemy_Level_health";
            this.enemy_Level_health.Size = new System.Drawing.Size(184, 23);
            this.enemy_Level_health.TabIndex = 28;
            // 
            // New_round_button
            // 
            this.New_round_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.New_round_button.BackColor = System.Drawing.Color.Transparent;
            this.New_round_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_round_button.Font = new System.Drawing.Font("CSNPWDT NFI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_round_button.ForeColor = System.Drawing.Color.MintCream;
            this.New_round_button.Location = new System.Drawing.Point(235, 408);
            this.New_round_button.Name = "New_round_button";
            this.New_round_button.Size = new System.Drawing.Size(290, 40);
            this.New_round_button.TabIndex = 30;
            this.New_round_button.Tag = "";
            this.New_round_button.Text = "NEW ROUND";
            this.New_round_button.UseCompatibleTextRendering = true;
            this.New_round_button.UseVisualStyleBackColor = false;
            this.New_round_button.Click += new System.EventHandler(this.New_round_button_Click);
            // 
            // Choose_Random_button
            // 
            this.Choose_Random_button.BackColor = System.Drawing.Color.Transparent;
            this.Choose_Random_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choose_Random_button.Font = new System.Drawing.Font("CSNPWDT NFI", 16F);
            this.Choose_Random_button.ForeColor = System.Drawing.Color.MintCream;
            this.Choose_Random_button.Location = new System.Drawing.Point(2, 117);
            this.Choose_Random_button.Name = "Choose_Random_button";
            this.Choose_Random_button.Size = new System.Drawing.Size(184, 40);
            this.Choose_Random_button.TabIndex = 31;
            this.Choose_Random_button.Tag = "";
            this.Choose_Random_button.Text = "Choose Random";
            this.Choose_Random_button.UseCompatibleTextRendering = true;
            this.Choose_Random_button.UseVisualStyleBackColor = false;
            this.Choose_Random_button.Click += new System.EventHandler(this.Choose_Random_button_Click);
            // 
            // Choose_Random_button_1
            // 
            this.Choose_Random_button_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Choose_Random_button_1.BackColor = System.Drawing.Color.Transparent;
            this.Choose_Random_button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choose_Random_button_1.Font = new System.Drawing.Font("CSNPWDT NFI", 16F);
            this.Choose_Random_button_1.ForeColor = System.Drawing.Color.MintCream;
            this.Choose_Random_button_1.Location = new System.Drawing.Point(591, 98);
            this.Choose_Random_button_1.Name = "Choose_Random_button_1";
            this.Choose_Random_button_1.Size = new System.Drawing.Size(186, 40);
            this.Choose_Random_button_1.TabIndex = 32;
            this.Choose_Random_button_1.Tag = "";
            this.Choose_Random_button_1.Text = "Choose Random";
            this.Choose_Random_button_1.UseCompatibleTextRendering = true;
            this.Choose_Random_button_1.UseVisualStyleBackColor = false;
            this.Choose_Random_button_1.Click += new System.EventHandler(this.Choose_Random_button_1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(779, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // round_number
            // 
            this.round_number.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.round_number.AutoSize = true;
            this.round_number.BackColor = System.Drawing.Color.Transparent;
            this.round_number.Font = new System.Drawing.Font("6809chargen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_number.ForeColor = System.Drawing.Color.White;
            this.round_number.ImageKey = "(none)";
            this.round_number.Location = new System.Drawing.Point(328, 388);
            this.round_number.Name = "round_number";
            this.round_number.Size = new System.Drawing.Size(112, 17);
            this.round_number.TabIndex = 35;
            this.round_number.Text = "ROUND : 0";
            this.round_number.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Random_Always_checkBox1
            // 
            this.Random_Always_checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Random_Always_checkBox1.AutoSize = true;
            this.Random_Always_checkBox1.Location = new System.Drawing.Point(675, 144);
            this.Random_Always_checkBox1.Name = "Random_Always_checkBox1";
            this.Random_Always_checkBox1.Size = new System.Drawing.Size(102, 17);
            this.Random_Always_checkBox1.TabIndex = 37;
            this.Random_Always_checkBox1.Text = "Random Always";
            this.Random_Always_checkBox1.UseVisualStyleBackColor = true;
            this.Random_Always_checkBox1.CheckedChanged += new System.EventHandler(this.Random_Always_checkBox1_CheckedChanged);
            // 
            // Random_always_checkBox2
            // 
            this.Random_always_checkBox2.AutoSize = true;
            this.Random_always_checkBox2.Location = new System.Drawing.Point(2, 164);
            this.Random_always_checkBox2.Name = "Random_always_checkBox2";
            this.Random_always_checkBox2.Size = new System.Drawing.Size(102, 17);
            this.Random_always_checkBox2.TabIndex = 38;
            this.Random_always_checkBox2.Text = "Random Always";
            this.Random_always_checkBox2.UseVisualStyleBackColor = true;
            this.Random_always_checkBox2.CheckedChanged += new System.EventHandler(this.Random_always_checkBox2_CheckedChanged);
            // 
            // Percent_label1
            // 
            this.Percent_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Percent_label1.AutoSize = true;
            this.Percent_label1.BackColor = System.Drawing.Color.Transparent;
            this.Percent_label1.Font = new System.Drawing.Font("CSNPWDT NFI", 15F);
            this.Percent_label1.ForeColor = System.Drawing.Color.White;
            this.Percent_label1.ImageKey = "(none)";
            this.Percent_label1.Location = new System.Drawing.Point(536, 37);
            this.Percent_label1.Name = "Percent_label1";
            this.Percent_label1.Size = new System.Drawing.Size(49, 24);
            this.Percent_label1.TabIndex = 39;
            this.Percent_label1.Text = "100%";
            this.Percent_label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Percent_label2
            // 
            this.Percent_label2.AutoSize = true;
            this.Percent_label2.BackColor = System.Drawing.Color.Transparent;
            this.Percent_label2.Font = new System.Drawing.Font("CSNPWDT NFI", 15F);
            this.Percent_label2.ForeColor = System.Drawing.Color.White;
            this.Percent_label2.ImageKey = "(none)";
            this.Percent_label2.Location = new System.Drawing.Point(192, 37);
            this.Percent_label2.Name = "Percent_label2";
            this.Percent_label2.Size = new System.Drawing.Size(49, 24);
            this.Percent_label2.TabIndex = 40;
            this.Percent_label2.Text = "100%";
            this.Percent_label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player1_label1
            // 
            this.player1_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.player1_label1.AutoSize = true;
            this.player1_label1.BackColor = System.Drawing.Color.Transparent;
            this.player1_label1.Font = new System.Drawing.Font("CSNPWDT NFI", 20F);
            this.player1_label1.ForeColor = System.Drawing.Color.White;
            this.player1_label1.ImageKey = "(none)";
            this.player1_label1.Location = new System.Drawing.Point(603, 1);
            this.player1_label1.MinimumSize = new System.Drawing.Size(121, 33);
            this.player1_label1.Name = "player1_label1";
            this.player1_label1.Size = new System.Drawing.Size(121, 33);
            this.player1_label1.TabIndex = 41;
            this.player1_label1.Text = "PLAYER 1:";
            this.player1_label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player2label1
            // 
            this.player2label1.AutoSize = true;
            this.player2label1.BackColor = System.Drawing.Color.Transparent;
            this.player2label1.Font = new System.Drawing.Font("CSNPWDT NFI", 20F);
            this.player2label1.ForeColor = System.Drawing.Color.White;
            this.player2label1.ImageKey = "(none)";
            this.player2label1.Location = new System.Drawing.Point(12, 1);
            this.player2label1.MinimumSize = new System.Drawing.Size(121, 33);
            this.player2label1.Name = "player2label1";
            this.player2label1.Size = new System.Drawing.Size(129, 33);
            this.player2label1.TabIndex = 42;
            this.player2label1.Text = "PLAYER 2:";
            this.player2label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // data_player_2_label
            // 
            this.data_player_2_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.data_player_2_label.AutoSize = true;
            this.data_player_2_label.BackColor = System.Drawing.Color.Transparent;
            this.data_player_2_label.Font = new System.Drawing.Font("CSNPWDT NFI", 10F);
            this.data_player_2_label.ForeColor = System.Drawing.Color.White;
            this.data_player_2_label.ImageKey = "(none)";
            this.data_player_2_label.Location = new System.Drawing.Point(-1, 272);
            this.data_player_2_label.MinimumSize = new System.Drawing.Size(121, 33);
            this.data_player_2_label.Name = "data_player_2_label";
            this.data_player_2_label.Size = new System.Drawing.Size(121, 33);
            this.data_player_2_label.TabIndex = 43;
            this.data_player_2_label.Text = "DATA PLAYER_1";
            this.data_player_2_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // data_player_1_label
            // 
            this.data_player_1_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.data_player_1_label.AutoSize = true;
            this.data_player_1_label.BackColor = System.Drawing.Color.Transparent;
            this.data_player_1_label.Font = new System.Drawing.Font("CSNPWDT NFI", 10F);
            this.data_player_1_label.ForeColor = System.Drawing.Color.White;
            this.data_player_1_label.ImageKey = "(none)";
            this.data_player_1_label.Location = new System.Drawing.Point(627, 272);
            this.data_player_1_label.MinimumSize = new System.Drawing.Size(121, 33);
            this.data_player_1_label.Name = "data_player_1_label";
            this.data_player_1_label.Size = new System.Drawing.Size(121, 33);
            this.data_player_1_label.TabIndex = 44;
            this.data_player_1_label.Text = "DATA PLAYER_1";
            this.data_player_1_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HOME_WORK_CONTROL.Properties.Resources.fire_36;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 460);
            this.Controls.Add(this.data_player_1_label);
            this.Controls.Add(this.data_player_2_label);
            this.Controls.Add(this.player2label1);
            this.Controls.Add(this.player1_label1);
            this.Controls.Add(this.Percent_label2);
            this.Controls.Add(this.Percent_label1);
            this.Controls.Add(this.Random_always_checkBox2);
            this.Controls.Add(this.Random_Always_checkBox1);
            this.Controls.Add(this.round_number);
            this.Controls.Add(this.Choose_Random_button_1);
            this.Controls.Add(this.Choose_Random_button);
            this.Controls.Add(this.New_round_button);
            this.Controls.Add(this.enemy_Level_health);
            this.Controls.Add(this.playing_style_2);
            this.Controls.Add(this.round_news);
            this.Controls.Add(this.playing_style_1);
            this.Controls.Add(this.Your_Level_health);
            this.Controls.Add(this.enemy_name_lable);
            this.Controls.Add(this.your_name_lable);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOTA 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label your_name_lable;
        private System.Windows.Forms.Label enemy_name_lable;
        private System.Windows.Forms.ProgressBar Your_Level_health;
        private System.Windows.Forms.ComboBox playing_style_1;
        private System.Windows.Forms.Label round_news;
        private System.Windows.Forms.ComboBox playing_style_2;
        private System.Windows.Forms.ProgressBar enemy_Level_health;
        private System.Windows.Forms.Button New_round_button;
        private System.Windows.Forms.Button Choose_Random_button;
        private System.Windows.Forms.Button Choose_Random_button_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label round_number;
        private System.Windows.Forms.CheckBox Random_Always_checkBox1;
        private System.Windows.Forms.CheckBox Random_always_checkBox2;
        private System.Windows.Forms.Label Percent_label1;
        private System.Windows.Forms.Label Percent_label2;
        private System.Windows.Forms.Label player1_label1;
        private System.Windows.Forms.Label player2label1;
        private System.Windows.Forms.Label data_player_2_label;
        private System.Windows.Forms.Label data_player_1_label;
    }
}