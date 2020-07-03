namespace HOME_WORK_CONTROL
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.choose_hero_button = new System.Windows.Forms.Button();
            this.save_changed_button = new System.Windows.Forms.Button();
            this.Download_Modified_button = new System.Windows.Forms.Button();
            this.Download_Oreginal_button = new System.Windows.Forms.Button();
            this.max_type_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.filter_lable = new System.Windows.Forms.Label();
            this.type_label1 = new System.Windows.Forms.Label();
            this.max_type_label = new System.Windows.Forms.Label();
            this.min_type_label = new System.Windows.Forms.Label();
            this.min_type_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.min_moveSpeed_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.min_moveSpped_label = new System.Windows.Forms.Label();
            this.max_moveSpeed_label = new System.Windows.Forms.Label();
            this.moveSpeed_label = new System.Windows.Forms.Label();
            this.max_moveSpped_numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.min_regeneration_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.min_regeneration_label = new System.Windows.Forms.Label();
            this.max_regeneration_label = new System.Windows.Forms.Label();
            this.Regeneration_label = new System.Windows.Forms.Label();
            this.max_regeneration_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.search_button = new System.Windows.Forms.Button();
            this.play_instructions = new System.Windows.Forms.RichTextBox();
            this.help_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_type_numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_type_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_moveSpeed_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_moveSpped_numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_regeneration_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_regeneration_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Balloon XBd BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(233, 1);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(624, 484);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // choose_hero_button
            // 
            this.choose_hero_button.BackColor = System.Drawing.Color.Transparent;
            this.choose_hero_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.choose_hero_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.choose_hero_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choose_hero_button.Font = new System.Drawing.Font("Shatter", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.choose_hero_button.ForeColor = System.Drawing.Color.White;
            this.choose_hero_button.Location = new System.Drawing.Point(1, 332);
            this.choose_hero_button.Name = "choose_hero_button";
            this.choose_hero_button.Size = new System.Drawing.Size(230, 36);
            this.choose_hero_button.TabIndex = 6;
            this.choose_hero_button.Tag = "";
            this.choose_hero_button.Text = "CHOOSE YOUR HERO";
            this.choose_hero_button.UseCompatibleTextRendering = true;
            this.choose_hero_button.UseVisualStyleBackColor = false;
            this.choose_hero_button.Click += new System.EventHandler(this.choose_hero_button_Click);
            // 
            // save_changed_button
            // 
            this.save_changed_button.BackColor = System.Drawing.Color.Transparent;
            this.save_changed_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.save_changed_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.save_changed_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_changed_button.Font = new System.Drawing.Font("Shatter", 18F);
            this.save_changed_button.ForeColor = System.Drawing.Color.LawnGreen;
            this.save_changed_button.Location = new System.Drawing.Point(1, 453);
            this.save_changed_button.Name = "save_changed_button";
            this.save_changed_button.Size = new System.Drawing.Size(230, 32);
            this.save_changed_button.TabIndex = 7;
            this.save_changed_button.Tag = "";
            this.save_changed_button.Text = "SAVE CHANGED";
            this.save_changed_button.UseCompatibleTextRendering = true;
            this.save_changed_button.UseVisualStyleBackColor = false;
            this.save_changed_button.Click += new System.EventHandler(this.save_changed_Click);
            // 
            // Download_Modified_button
            // 
            this.Download_Modified_button.BackColor = System.Drawing.Color.Transparent;
            this.Download_Modified_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.Download_Modified_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Download_Modified_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Download_Modified_button.Font = new System.Drawing.Font("Shatter", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Download_Modified_button.ForeColor = System.Drawing.Color.White;
            this.Download_Modified_button.Location = new System.Drawing.Point(1, 415);
            this.Download_Modified_button.Name = "Download_Modified_button";
            this.Download_Modified_button.Size = new System.Drawing.Size(230, 32);
            this.Download_Modified_button.TabIndex = 8;
            this.Download_Modified_button.Tag = "";
            this.Download_Modified_button.Text = "DOWNLOAD MODIFIED DATA";
            this.Download_Modified_button.UseCompatibleTextRendering = true;
            this.Download_Modified_button.UseVisualStyleBackColor = false;
            this.Download_Modified_button.Click += new System.EventHandler(this.Download_Modified_button_Click);
            // 
            // Download_Oreginal_button
            // 
            this.Download_Oreginal_button.BackColor = System.Drawing.Color.Transparent;
            this.Download_Oreginal_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.Download_Oreginal_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Download_Oreginal_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Download_Oreginal_button.Font = new System.Drawing.Font("Shatter", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Download_Oreginal_button.ForeColor = System.Drawing.Color.White;
            this.Download_Oreginal_button.Location = new System.Drawing.Point(1, 374);
            this.Download_Oreginal_button.Name = "Download_Oreginal_button";
            this.Download_Oreginal_button.Size = new System.Drawing.Size(230, 35);
            this.Download_Oreginal_button.TabIndex = 9;
            this.Download_Oreginal_button.Tag = "";
            this.Download_Oreginal_button.Text = "DOWNLOAD ORIGINAL DATA";
            this.Download_Oreginal_button.UseCompatibleTextRendering = true;
            this.Download_Oreginal_button.UseVisualStyleBackColor = false;
            this.Download_Oreginal_button.Click += new System.EventHandler(this.Download_Oreginal_button_Click);
            // 
            // max_type_numericUpDown1
            // 
            this.max_type_numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.max_type_numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.max_type_numericUpDown1.Location = new System.Drawing.Point(171, 89);
            this.max_type_numericUpDown1.Name = "max_type_numericUpDown1";
            this.max_type_numericUpDown1.Size = new System.Drawing.Size(56, 20);
            this.max_type_numericUpDown1.TabIndex = 10;
            // 
            // filter_lable
            // 
            this.filter_lable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filter_lable.AutoSize = true;
            this.filter_lable.BackColor = System.Drawing.Color.Transparent;
            this.filter_lable.Font = new System.Drawing.Font("Shatter", 22F);
            this.filter_lable.ForeColor = System.Drawing.Color.White;
            this.filter_lable.ImageKey = "(none)";
            this.filter_lable.Location = new System.Drawing.Point(50, 9);
            this.filter_lable.MinimumSize = new System.Drawing.Size(121, 33);
            this.filter_lable.Name = "filter_lable";
            this.filter_lable.Size = new System.Drawing.Size(121, 35);
            this.filter_lable.TabIndex = 18;
            this.filter_lable.Text = "FILTER";
            this.filter_lable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // type_label1
            // 
            this.type_label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.type_label1.AutoSize = true;
            this.type_label1.BackColor = System.Drawing.Color.Transparent;
            this.type_label1.Font = new System.Drawing.Font("Shatter", 18F);
            this.type_label1.ForeColor = System.Drawing.Color.White;
            this.type_label1.ImageKey = "(none)";
            this.type_label1.Location = new System.Drawing.Point(-4, 45);
            this.type_label1.Name = "type_label1";
            this.type_label1.Size = new System.Drawing.Size(74, 28);
            this.type_label1.TabIndex = 19;
            this.type_label1.Text = "TYPE:";
            this.type_label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // max_type_label
            // 
            this.max_type_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.max_type_label.AutoSize = true;
            this.max_type_label.BackColor = System.Drawing.Color.Transparent;
            this.max_type_label.Font = new System.Drawing.Font("CSNPWDT NFI", 12F);
            this.max_type_label.ForeColor = System.Drawing.Color.White;
            this.max_type_label.ImageKey = "(none)";
            this.max_type_label.Location = new System.Drawing.Point(128, 90);
            this.max_type_label.Name = "max_type_label";
            this.max_type_label.Size = new System.Drawing.Size(43, 19);
            this.max_type_label.TabIndex = 20;
            this.max_type_label.Text = "MAX:";
            this.max_type_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // min_type_label
            // 
            this.min_type_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.min_type_label.AutoSize = true;
            this.min_type_label.BackColor = System.Drawing.Color.Transparent;
            this.min_type_label.Font = new System.Drawing.Font("CSNPWDT NFI", 12F);
            this.min_type_label.ForeColor = System.Drawing.Color.White;
            this.min_type_label.ImageKey = "(none)";
            this.min_type_label.Location = new System.Drawing.Point(13, 90);
            this.min_type_label.Name = "min_type_label";
            this.min_type_label.Size = new System.Drawing.Size(37, 19);
            this.min_type_label.TabIndex = 21;
            this.min_type_label.Text = "MIN:";
            this.min_type_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // min_type_numericUpDown
            // 
            this.min_type_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.min_type_numericUpDown.BackColor = System.Drawing.Color.Red;
            this.min_type_numericUpDown.Location = new System.Drawing.Point(56, 89);
            this.min_type_numericUpDown.Name = "min_type_numericUpDown";
            this.min_type_numericUpDown.Size = new System.Drawing.Size(56, 20);
            this.min_type_numericUpDown.TabIndex = 22;
            // 
            // min_moveSpeed_numericUpDown
            // 
            this.min_moveSpeed_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.min_moveSpeed_numericUpDown.BackColor = System.Drawing.Color.Red;
            this.min_moveSpeed_numericUpDown.Location = new System.Drawing.Point(62, 164);
            this.min_moveSpeed_numericUpDown.Name = "min_moveSpeed_numericUpDown";
            this.min_moveSpeed_numericUpDown.Size = new System.Drawing.Size(56, 20);
            this.min_moveSpeed_numericUpDown.TabIndex = 27;
            // 
            // min_moveSpped_label
            // 
            this.min_moveSpped_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.min_moveSpped_label.AutoSize = true;
            this.min_moveSpped_label.BackColor = System.Drawing.Color.Transparent;
            this.min_moveSpped_label.Font = new System.Drawing.Font("CSNPWDT NFI", 12F);
            this.min_moveSpped_label.ForeColor = System.Drawing.Color.White;
            this.min_moveSpped_label.ImageKey = "(none)";
            this.min_moveSpped_label.Location = new System.Drawing.Point(19, 165);
            this.min_moveSpped_label.Name = "min_moveSpped_label";
            this.min_moveSpped_label.Size = new System.Drawing.Size(37, 19);
            this.min_moveSpped_label.TabIndex = 26;
            this.min_moveSpped_label.Text = "MIN:";
            this.min_moveSpped_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // max_moveSpeed_label
            // 
            this.max_moveSpeed_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.max_moveSpeed_label.AutoSize = true;
            this.max_moveSpeed_label.BackColor = System.Drawing.Color.Transparent;
            this.max_moveSpeed_label.Font = new System.Drawing.Font("CSNPWDT NFI", 12F);
            this.max_moveSpeed_label.ForeColor = System.Drawing.Color.White;
            this.max_moveSpeed_label.ImageKey = "(none)";
            this.max_moveSpeed_label.Location = new System.Drawing.Point(122, 163);
            this.max_moveSpeed_label.Name = "max_moveSpeed_label";
            this.max_moveSpeed_label.Size = new System.Drawing.Size(43, 19);
            this.max_moveSpeed_label.TabIndex = 25;
            this.max_moveSpeed_label.Text = "MAX:";
            this.max_moveSpeed_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // moveSpeed_label
            // 
            this.moveSpeed_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.moveSpeed_label.AutoSize = true;
            this.moveSpeed_label.BackColor = System.Drawing.Color.Transparent;
            this.moveSpeed_label.Font = new System.Drawing.Font("Shatter", 18F);
            this.moveSpeed_label.ForeColor = System.Drawing.Color.White;
            this.moveSpeed_label.ImageKey = "(none)";
            this.moveSpeed_label.Location = new System.Drawing.Point(-4, 121);
            this.moveSpeed_label.Name = "moveSpeed_label";
            this.moveSpeed_label.Size = new System.Drawing.Size(166, 28);
            this.moveSpeed_label.TabIndex = 24;
            this.moveSpeed_label.Text = "MOVE SPEED:";
            this.moveSpeed_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // max_moveSpped_numericUpDown4
            // 
            this.max_moveSpped_numericUpDown4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.max_moveSpped_numericUpDown4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.max_moveSpped_numericUpDown4.Location = new System.Drawing.Point(171, 164);
            this.max_moveSpped_numericUpDown4.Name = "max_moveSpped_numericUpDown4";
            this.max_moveSpped_numericUpDown4.Size = new System.Drawing.Size(56, 20);
            this.max_moveSpped_numericUpDown4.TabIndex = 23;
            // 
            // min_regeneration_numericUpDown
            // 
            this.min_regeneration_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.min_regeneration_numericUpDown.BackColor = System.Drawing.Color.Red;
            this.min_regeneration_numericUpDown.Location = new System.Drawing.Point(62, 243);
            this.min_regeneration_numericUpDown.Name = "min_regeneration_numericUpDown";
            this.min_regeneration_numericUpDown.Size = new System.Drawing.Size(56, 20);
            this.min_regeneration_numericUpDown.TabIndex = 32;
            // 
            // min_regeneration_label
            // 
            this.min_regeneration_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.min_regeneration_label.AutoSize = true;
            this.min_regeneration_label.BackColor = System.Drawing.Color.Transparent;
            this.min_regeneration_label.Font = new System.Drawing.Font("CSNPWDT NFI", 12F);
            this.min_regeneration_label.ForeColor = System.Drawing.Color.White;
            this.min_regeneration_label.ImageKey = "(none)";
            this.min_regeneration_label.Location = new System.Drawing.Point(19, 244);
            this.min_regeneration_label.Name = "min_regeneration_label";
            this.min_regeneration_label.Size = new System.Drawing.Size(37, 19);
            this.min_regeneration_label.TabIndex = 31;
            this.min_regeneration_label.Text = "MIN:";
            this.min_regeneration_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // max_regeneration_label
            // 
            this.max_regeneration_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.max_regeneration_label.AutoSize = true;
            this.max_regeneration_label.BackColor = System.Drawing.Color.Transparent;
            this.max_regeneration_label.Font = new System.Drawing.Font("CSNPWDT NFI", 12F);
            this.max_regeneration_label.ForeColor = System.Drawing.Color.White;
            this.max_regeneration_label.ImageKey = "(none)";
            this.max_regeneration_label.Location = new System.Drawing.Point(128, 246);
            this.max_regeneration_label.Name = "max_regeneration_label";
            this.max_regeneration_label.Size = new System.Drawing.Size(43, 19);
            this.max_regeneration_label.TabIndex = 30;
            this.max_regeneration_label.Text = "MAX:";
            this.max_regeneration_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Regeneration_label
            // 
            this.Regeneration_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Regeneration_label.AutoSize = true;
            this.Regeneration_label.BackColor = System.Drawing.Color.Transparent;
            this.Regeneration_label.Font = new System.Drawing.Font("Shatter", 18F);
            this.Regeneration_label.ForeColor = System.Drawing.Color.White;
            this.Regeneration_label.ImageKey = "(none)";
            this.Regeneration_label.Location = new System.Drawing.Point(-4, 201);
            this.Regeneration_label.Name = "Regeneration_label";
            this.Regeneration_label.Size = new System.Drawing.Size(196, 28);
            this.Regeneration_label.TabIndex = 29;
            this.Regeneration_label.Text = "REGENERATION:";
            this.Regeneration_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // max_regeneration_numericUpDown
            // 
            this.max_regeneration_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.max_regeneration_numericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.max_regeneration_numericUpDown.Location = new System.Drawing.Point(171, 243);
            this.max_regeneration_numericUpDown.Name = "max_regeneration_numericUpDown";
            this.max_regeneration_numericUpDown.Size = new System.Drawing.Size(56, 20);
            this.max_regeneration_numericUpDown.TabIndex = 28;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.Transparent;
            this.search_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.search_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Shatter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.Color.MintCream;
            this.search_button.Location = new System.Drawing.Point(1, 286);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(226, 24);
            this.search_button.TabIndex = 33;
            this.search_button.Tag = "";
            this.search_button.Text = "SEARCH";
            this.search_button.UseCompatibleTextRendering = true;
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // play_instructions
            // 
            this.play_instructions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.play_instructions.Enabled = false;
            this.play_instructions.Font = new System.Drawing.Font("Freehand471 BT", 12F);
            this.play_instructions.Location = new System.Drawing.Point(1, 1);
            this.play_instructions.Name = "play_instructions";
            this.play_instructions.Size = new System.Drawing.Size(780, 428);
            this.play_instructions.TabIndex = 34;
            this.play_instructions.Text = resources.GetString("play_instructions.Text");
            this.play_instructions.Visible = false;
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.Color.Transparent;
            this.help_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_button.Font = new System.Drawing.Font("Shatter", 10F);
            this.help_button.ForeColor = System.Drawing.Color.Red;
            this.help_button.Location = new System.Drawing.Point(1, 1);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(45, 24);
            this.help_button.TabIndex = 35;
            this.help_button.Tag = "";
            this.help_button.Text = "help";
            this.help_button.UseCompatibleTextRendering = true;
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::HOME_WORK_CONTROL.Properties.Resources._350227994;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 487);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.play_instructions);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.min_regeneration_numericUpDown);
            this.Controls.Add(this.min_regeneration_label);
            this.Controls.Add(this.max_regeneration_label);
            this.Controls.Add(this.Regeneration_label);
            this.Controls.Add(this.max_regeneration_numericUpDown);
            this.Controls.Add(this.min_moveSpeed_numericUpDown);
            this.Controls.Add(this.min_moveSpped_label);
            this.Controls.Add(this.max_moveSpeed_label);
            this.Controls.Add(this.moveSpeed_label);
            this.Controls.Add(this.max_moveSpped_numericUpDown4);
            this.Controls.Add(this.min_type_numericUpDown);
            this.Controls.Add(this.min_type_label);
            this.Controls.Add(this.max_type_label);
            this.Controls.Add(this.type_label1);
            this.Controls.Add(this.filter_lable);
            this.Controls.Add(this.max_type_numericUpDown1);
            this.Controls.Add(this.Download_Oreginal_button);
            this.Controls.Add(this.Download_Modified_button);
            this.Controls.Add(this.save_changed_button);
            this.Controls.Add(this.choose_hero_button);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(872, 526);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOTA 2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_type_numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_type_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_moveSpeed_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_moveSpped_numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_regeneration_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_regeneration_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button save_changed_button;
        private System.Windows.Forms.Button Download_Modified_button;
        private System.Windows.Forms.Button Download_Oreginal_button;
        private System.Windows.Forms.NumericUpDown max_type_numericUpDown1;
        private System.Windows.Forms.Label filter_lable;
        private System.Windows.Forms.Label type_label1;
        private System.Windows.Forms.Label max_type_label;
        private System.Windows.Forms.Label min_type_label;
        private System.Windows.Forms.NumericUpDown min_type_numericUpDown;
        private System.Windows.Forms.NumericUpDown min_moveSpeed_numericUpDown;
        private System.Windows.Forms.Label min_moveSpped_label;
        private System.Windows.Forms.Label max_moveSpeed_label;
        private System.Windows.Forms.Label moveSpeed_label;
        private System.Windows.Forms.NumericUpDown max_moveSpped_numericUpDown4;
        private System.Windows.Forms.NumericUpDown min_regeneration_numericUpDown;
        private System.Windows.Forms.Label min_regeneration_label;
        private System.Windows.Forms.Label max_regeneration_label;
        private System.Windows.Forms.Label Regeneration_label;
        private System.Windows.Forms.NumericUpDown max_regeneration_numericUpDown;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button choose_hero_button;
        private System.Windows.Forms.RichTextBox play_instructions;
        private System.Windows.Forms.Button help_button;
    }
}