namespace GUI
{
    partial class fMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.lb_title = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.lb_ipClass = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num_fourthOctet = new System.Windows.Forms.NumericUpDown();
            this.num_thirdOctet = new System.Windows.Forms.NumericUpDown();
            this.num_secondOctet = new System.Windows.Forms.NumericUpDown();
            this.num_firstOctet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.num_suffix = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaGroupBox3 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgv_branches = new Guna.UI.WinForms.GunaDataGridView();
            this.branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_resetIP = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGroupBox5 = new Guna.UI.WinForms.GunaGroupBox();
            this.btn_importFromFile = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_quickCalculate = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_resetBranch = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_about = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_fourthOctet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_thirdOctet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_secondOctet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_firstOctet)).BeginInit();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_suffix)).BeginInit();
            this.gunaGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_branches)).BeginInit();
            this.gunaGroupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(23, 15);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(337, 30);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Variable Length Subnet Masking";
            this.lb_title.Visible = false;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.lb_ipClass);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.num_fourthOctet);
            this.gunaGroupBox1.Controls.Add(this.num_thirdOctet);
            this.gunaGroupBox1.Controls.Add(this.num_secondOctet);
            this.gunaGroupBox1.Controls.Add(this.num_firstOctet);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.DodgerBlue;
            this.gunaGroupBox1.Location = new System.Drawing.Point(23, 114);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(397, 98);
            this.gunaGroupBox1.TabIndex = 1;
            this.gunaGroupBox1.Text = "IP address";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 5);
            // 
            // lb_ipClass
            // 
            this.lb_ipClass.AutoSize = true;
            this.lb_ipClass.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ipClass.Location = new System.Drawing.Point(366, 5);
            this.lb_ipClass.Name = "lb_ipClass";
            this.lb_ipClass.Size = new System.Drawing.Size(15, 19);
            this.lb_ipClass.TabIndex = 6;
            this.lb_ipClass.Text = "?";
            this.lb_ipClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Class";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_fourthOctet
            // 
            this.num_fourthOctet.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_fourthOctet.Location = new System.Drawing.Point(313, 50);
            this.num_fourthOctet.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_fourthOctet.Name = "num_fourthOctet";
            this.num_fourthOctet.Size = new System.Drawing.Size(66, 27);
            this.num_fourthOctet.TabIndex = 3;
            this.num_fourthOctet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num_thirdOctet
            // 
            this.num_thirdOctet.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_thirdOctet.Location = new System.Drawing.Point(216, 50);
            this.num_thirdOctet.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_thirdOctet.Name = "num_thirdOctet";
            this.num_thirdOctet.Size = new System.Drawing.Size(66, 27);
            this.num_thirdOctet.TabIndex = 2;
            this.num_thirdOctet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num_secondOctet
            // 
            this.num_secondOctet.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_secondOctet.Location = new System.Drawing.Point(119, 50);
            this.num_secondOctet.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_secondOctet.Name = "num_secondOctet";
            this.num_secondOctet.Size = new System.Drawing.Size(66, 27);
            this.num_secondOctet.TabIndex = 1;
            this.num_secondOctet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num_firstOctet
            // 
            this.num_firstOctet.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_firstOctet.Location = new System.Drawing.Point(22, 50);
            this.num_firstOctet.Maximum = new decimal(new int[] {
            223,
            0,
            0,
            0});
            this.num_firstOctet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_firstOctet.Name = "num_firstOctet";
            this.num_firstOctet.Size = new System.Drawing.Size(66, 27);
            this.num_firstOctet.TabIndex = 0;
            this.num_firstOctet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_firstOctet.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_firstOctet.ValueChanged += new System.EventHandler(this.num_firstOctet_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(287, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(190, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(93, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = ".";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gunaGroupBox2.BorderSize = 1;
            this.gunaGroupBox2.Controls.Add(this.num_suffix);
            this.gunaGroupBox2.Controls.Add(this.label4);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.DodgerBlue;
            this.gunaGroupBox2.Location = new System.Drawing.Point(426, 114);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(122, 98);
            this.gunaGroupBox2.TabIndex = 2;
            this.gunaGroupBox2.Text = "Suffix";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 5);
            // 
            // num_suffix
            // 
            this.num_suffix.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_suffix.Location = new System.Drawing.Point(37, 50);
            this.num_suffix.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_suffix.Name = "num_suffix";
            this.num_suffix.Size = new System.Drawing.Size(66, 27);
            this.num_suffix.TabIndex = 0;
            this.num_suffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "/";
            // 
            // gunaGroupBox3
            // 
            this.gunaGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox3.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gunaGroupBox3.BorderSize = 1;
            this.gunaGroupBox3.Controls.Add(this.dgv_branches);
            this.gunaGroupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox3.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox3.LineColor = System.Drawing.Color.DodgerBlue;
            this.gunaGroupBox3.Location = new System.Drawing.Point(23, 243);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Size = new System.Drawing.Size(525, 280);
            this.gunaGroupBox3.TabIndex = 3;
            this.gunaGroupBox3.Text = "Branches";
            this.gunaGroupBox3.TextLocation = new System.Drawing.Point(10, 5);
            // 
            // dgv_branches
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_branches.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_branches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_branches.BackgroundColor = System.Drawing.Color.White;
            this.dgv_branches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_branches.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_branches.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(94)))), ((int)(((byte)(3)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_branches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_branches.ColumnHeadersHeight = 21;
            this.dgv_branches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.branch,
            this.host});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_branches.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_branches.EnableHeadersVisualStyles = false;
            this.dgv_branches.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_branches.Location = new System.Drawing.Point(2, 31);
            this.dgv_branches.Name = "dgv_branches";
            this.dgv_branches.RowHeadersVisible = false;
            this.dgv_branches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_branches.Size = new System.Drawing.Size(521, 247);
            this.dgv_branches.TabIndex = 0;
            this.dgv_branches.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_branches.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_branches.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_branches.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_branches.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_branches.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_branches.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_branches.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_branches.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(94)))), ((int)(((byte)(3)))));
            this.dgv_branches.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_branches.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_branches.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_branches.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_branches.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_branches.ThemeStyle.ReadOnly = false;
            this.dgv_branches.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_branches.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_branches.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_branches.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_branches.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_branches.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_branches.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // branch
            // 
            this.branch.HeaderText = "Branch name";
            this.branch.Name = "branch";
            // 
            // host
            // 
            dataGridViewCellStyle3.Format = "N0";
            this.host.DefaultCellStyle = dataGridViewCellStyle3;
            this.host.HeaderText = "Hosts amount";
            this.host.Name = "host";
            // 
            // btn_resetIP
            // 
            this.btn_resetIP.AnimationHoverSpeed = 0.07F;
            this.btn_resetIP.AnimationSpeed = 0.03F;
            this.btn_resetIP.BaseColor1 = System.Drawing.Color.OrangeRed;
            this.btn_resetIP.BaseColor2 = System.Drawing.Color.DarkOrange;
            this.btn_resetIP.BorderColor = System.Drawing.Color.Black;
            this.btn_resetIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_resetIP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_resetIP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_resetIP.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btn_resetIP.ForeColor = System.Drawing.Color.White;
            this.btn_resetIP.Image = null;
            this.btn_resetIP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_resetIP.Location = new System.Drawing.Point(18, 132);
            this.btn_resetIP.Name = "btn_resetIP";
            this.btn_resetIP.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_resetIP.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_resetIP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_resetIP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_resetIP.OnHoverImage = null;
            this.btn_resetIP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_resetIP.Size = new System.Drawing.Size(165, 57);
            this.btn_resetIP.TabIndex = 0;
            this.btn_resetIP.Text = "Reset IP";
            this.btn_resetIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_resetIP.Click += new System.EventHandler(this.btn_resetIP_Click);
            // 
            // gunaGroupBox5
            // 
            this.gunaGroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox5.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox5.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gunaGroupBox5.BorderSize = 1;
            this.gunaGroupBox5.Controls.Add(this.btn_importFromFile);
            this.gunaGroupBox5.Controls.Add(this.btn_resetIP);
            this.gunaGroupBox5.Controls.Add(this.btn_quickCalculate);
            this.gunaGroupBox5.Controls.Add(this.btn_resetBranch);
            this.gunaGroupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox5.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox5.LineColor = System.Drawing.Color.DodgerBlue;
            this.gunaGroupBox5.Location = new System.Drawing.Point(591, 114);
            this.gunaGroupBox5.Name = "gunaGroupBox5";
            this.gunaGroupBox5.Size = new System.Drawing.Size(200, 409);
            this.gunaGroupBox5.TabIndex = 4;
            this.gunaGroupBox5.Text = "Options";
            this.gunaGroupBox5.TextLocation = new System.Drawing.Point(10, 5);
            // 
            // btn_importFromFile
            // 
            this.btn_importFromFile.AnimationHoverSpeed = 0.07F;
            this.btn_importFromFile.AnimationSpeed = 0.03F;
            this.btn_importFromFile.BaseColor1 = System.Drawing.Color.Green;
            this.btn_importFromFile.BaseColor2 = System.Drawing.Color.LimeGreen;
            this.btn_importFromFile.BorderColor = System.Drawing.Color.Black;
            this.btn_importFromFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_importFromFile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_importFromFile.FocusedColor = System.Drawing.Color.Empty;
            this.btn_importFromFile.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btn_importFromFile.ForeColor = System.Drawing.Color.White;
            this.btn_importFromFile.Image = null;
            this.btn_importFromFile.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_importFromFile.Location = new System.Drawing.Point(18, 44);
            this.btn_importFromFile.Name = "btn_importFromFile";
            this.btn_importFromFile.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_importFromFile.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_importFromFile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_importFromFile.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_importFromFile.OnHoverImage = null;
            this.btn_importFromFile.OnPressedColor = System.Drawing.Color.Black;
            this.btn_importFromFile.Size = new System.Drawing.Size(165, 57);
            this.btn_importFromFile.TabIndex = 1;
            this.btn_importFromFile.Text = "Import from file ...";
            this.btn_importFromFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_importFromFile.Click += new System.EventHandler(this.btn_importFromFile_Click);
            // 
            // btn_quickCalculate
            // 
            this.btn_quickCalculate.AnimationHoverSpeed = 0.07F;
            this.btn_quickCalculate.AnimationSpeed = 0.03F;
            this.btn_quickCalculate.BaseColor1 = System.Drawing.Color.LimeGreen;
            this.btn_quickCalculate.BaseColor2 = System.Drawing.Color.ForestGreen;
            this.btn_quickCalculate.BorderColor = System.Drawing.Color.Black;
            this.btn_quickCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quickCalculate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_quickCalculate.FocusedColor = System.Drawing.Color.Empty;
            this.btn_quickCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btn_quickCalculate.ForeColor = System.Drawing.Color.White;
            this.btn_quickCalculate.Image = null;
            this.btn_quickCalculate.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_quickCalculate.Location = new System.Drawing.Point(18, 336);
            this.btn_quickCalculate.Name = "btn_quickCalculate";
            this.btn_quickCalculate.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_quickCalculate.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_quickCalculate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_quickCalculate.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_quickCalculate.OnHoverImage = null;
            this.btn_quickCalculate.OnPressedColor = System.Drawing.Color.Black;
            this.btn_quickCalculate.Size = new System.Drawing.Size(165, 57);
            this.btn_quickCalculate.TabIndex = 0;
            this.btn_quickCalculate.Text = "Calculate";
            this.btn_quickCalculate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_quickCalculate.Click += new System.EventHandler(this.btn_quickCalculate_Click);
            // 
            // btn_resetBranch
            // 
            this.btn_resetBranch.AnimationHoverSpeed = 0.07F;
            this.btn_resetBranch.AnimationSpeed = 0.03F;
            this.btn_resetBranch.BaseColor1 = System.Drawing.Color.OrangeRed;
            this.btn_resetBranch.BaseColor2 = System.Drawing.Color.DarkOrange;
            this.btn_resetBranch.BorderColor = System.Drawing.Color.Black;
            this.btn_resetBranch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_resetBranch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_resetBranch.FocusedColor = System.Drawing.Color.Empty;
            this.btn_resetBranch.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btn_resetBranch.ForeColor = System.Drawing.Color.White;
            this.btn_resetBranch.Image = null;
            this.btn_resetBranch.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_resetBranch.Location = new System.Drawing.Point(18, 234);
            this.btn_resetBranch.Name = "btn_resetBranch";
            this.btn_resetBranch.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_resetBranch.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_resetBranch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_resetBranch.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_resetBranch.OnHoverImage = null;
            this.btn_resetBranch.OnPressedColor = System.Drawing.Color.Black;
            this.btn_resetBranch.Size = new System.Drawing.Size(165, 57);
            this.btn_resetBranch.TabIndex = 0;
            this.btn_resetBranch.Text = "Reset branches";
            this.btn_resetBranch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_resetBranch.Click += new System.EventHandler(this.btn_resetBranch_Click);
            // 
            // btn_about
            // 
            this.btn_about.AnimationHoverSpeed = 0.07F;
            this.btn_about.AnimationSpeed = 0.03F;
            this.btn_about.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_about.BorderColor = System.Drawing.Color.Black;
            this.btn_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_about.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_about.FocusedColor = System.Drawing.Color.Empty;
            this.btn_about.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_about.ForeColor = System.Drawing.Color.White;
            this.btn_about.Image = null;
            this.btn_about.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_about.Location = new System.Drawing.Point(518, 15);
            this.btn_about.Name = "btn_about";
            this.btn_about.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_about.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_about.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_about.OnHoverImage = null;
            this.btn_about.OnPressedColor = System.Drawing.Color.Black;
            this.btn_about.Size = new System.Drawing.Size(30, 30);
            this.btn_about.TabIndex = 5;
            this.btn_about.Text = "?";
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // fMain
            // 
            this.AcceptButton = this.btn_quickCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 546);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.gunaGroupBox5);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox3);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.lb_title);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Variable Length Subnet Masking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_fourthOctet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_thirdOctet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_secondOctet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_firstOctet)).EndInit();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_suffix)).EndInit();
            this.gunaGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_branches)).EndInit();
            this.gunaGroupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox5;
        private Guna.UI.WinForms.GunaDataGridView dgv_branches;
        private Guna.UI.WinForms.GunaGradientButton btn_resetIP;
        private Guna.UI.WinForms.GunaGradientButton btn_resetBranch;
        private Guna.UI.WinForms.GunaGradientButton btn_quickCalculate;
        private System.Windows.Forms.NumericUpDown num_firstOctet;
        private System.Windows.Forms.NumericUpDown num_fourthOctet;
        private System.Windows.Forms.NumericUpDown num_thirdOctet;
        private System.Windows.Forms.NumericUpDown num_secondOctet;
        private System.Windows.Forms.NumericUpDown num_suffix;
        private System.Windows.Forms.Label lb_ipClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn host;
        private Guna.UI.WinForms.GunaGradientButton btn_importFromFile;
        private Guna.UI.WinForms.GunaCircleButton btn_about;
    }
}

