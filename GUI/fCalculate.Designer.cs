namespace GUI
{
    partial class fCalculate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCalculate));
            this.dgv_result = new Guna.UI.WinForms.GunaDataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broadCast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subnetMask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_IP = new System.Windows.Forms.Label();
            this.lb_subnet = new System.Windows.Forms.Label();
            this.lb_netAddress = new System.Windows.Forms.Label();
            this.lb_netClass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chb_showGuide = new Guna.UI.WinForms.GunaWinSwitch();
            this.txt_reasoningResult = new System.Windows.Forms.RichTextBox();
            this.pn_reasoningResult = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.pn_reasoningResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_result
            // 
            this.dgv_result.AllowUserToAddRows = false;
            this.dgv_result.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgv_result.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_result.BackgroundColor = System.Drawing.Color.White;
            this.dgv_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_result.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_result.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_result.ColumnHeadersHeight = 21;
            this.dgv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.branch,
            this.host,
            this.netAddress,
            this.firstIP,
            this.lastIP,
            this.broadCast,
            this.subnetMask});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_result.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_result.EnableHeadersVisualStyles = false;
            this.dgv_result.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_result.Location = new System.Drawing.Point(20, 235);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.ReadOnly = true;
            this.dgv_result.RowHeadersVisible = false;
            this.dgv_result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_result.Size = new System.Drawing.Size(909, 351);
            this.dgv_result.TabIndex = 0;
            this.dgv_result.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightBlue;
            this.dgv_result.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgv_result.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_result.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_result.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_result.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_result.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_result.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_result.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.dgv_result.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_result.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dgv_result.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_result.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_result.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_result.ThemeStyle.ReadOnly = true;
            this.dgv_result.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dgv_result.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_result.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_result.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_result.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_result.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gold;
            this.dgv_result.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // branch
            // 
            this.branch.HeaderText = "Branch";
            this.branch.Name = "branch";
            this.branch.ReadOnly = true;
            // 
            // host
            // 
            this.host.HeaderText = "Hosts";
            this.host.Name = "host";
            this.host.ReadOnly = true;
            // 
            // netAddress
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netAddress.DefaultCellStyle = dataGridViewCellStyle3;
            this.netAddress.HeaderText = "Net ID";
            this.netAddress.Name = "netAddress";
            this.netAddress.ReadOnly = true;
            // 
            // firstIP
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstIP.DefaultCellStyle = dataGridViewCellStyle4;
            this.firstIP.HeaderText = "First IP";
            this.firstIP.Name = "firstIP";
            this.firstIP.ReadOnly = true;
            // 
            // lastIP
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.lastIP.DefaultCellStyle = dataGridViewCellStyle5;
            this.lastIP.HeaderText = "Last IP";
            this.lastIP.Name = "lastIP";
            this.lastIP.ReadOnly = true;
            // 
            // broadCast
            // 
            this.broadCast.HeaderText = "BroadCast IP";
            this.broadCast.Name = "broadCast";
            this.broadCast.ReadOnly = true;
            // 
            // subnetMask
            // 
            this.subnetMask.HeaderText = "Subnet Mask";
            this.subnetMask.Name = "subnetMask";
            this.subnetMask.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subnet mask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Net address";
            // 
            // lb_IP
            // 
            this.lb_IP.AutoSize = true;
            this.lb_IP.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IP.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lb_IP.Location = new System.Drawing.Point(219, 92);
            this.lb_IP.Name = "lb_IP";
            this.lb_IP.Size = new System.Drawing.Size(20, 25);
            this.lb_IP.TabIndex = 1;
            this.lb_IP.Text = "?";
            // 
            // lb_subnet
            // 
            this.lb_subnet.AutoSize = true;
            this.lb_subnet.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subnet.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lb_subnet.Location = new System.Drawing.Point(219, 128);
            this.lb_subnet.Name = "lb_subnet";
            this.lb_subnet.Size = new System.Drawing.Size(20, 25);
            this.lb_subnet.TabIndex = 1;
            this.lb_subnet.Text = "?";
            // 
            // lb_netAddress
            // 
            this.lb_netAddress.AutoSize = true;
            this.lb_netAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_netAddress.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lb_netAddress.Location = new System.Drawing.Point(682, 92);
            this.lb_netAddress.Name = "lb_netAddress";
            this.lb_netAddress.Size = new System.Drawing.Size(20, 25);
            this.lb_netAddress.TabIndex = 1;
            this.lb_netAddress.Text = "?";
            // 
            // lb_netClass
            // 
            this.lb_netClass.AutoSize = true;
            this.lb_netClass.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_netClass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lb_netClass.Location = new System.Drawing.Point(682, 128);
            this.lb_netClass.Name = "lb_netClass";
            this.lb_netClass.Size = new System.Drawing.Size(20, 25);
            this.lb_netClass.TabIndex = 1;
            this.lb_netClass.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(545, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Network class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(545, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Show guidances";
            // 
            // chb_showGuide
            // 
            this.chb_showGuide.BaseColor = System.Drawing.SystemColors.Control;
            this.chb_showGuide.Checked = true;
            this.chb_showGuide.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.chb_showGuide.CheckedOnColor = System.Drawing.Color.LimeGreen;
            this.chb_showGuide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chb_showGuide.FillColor = System.Drawing.Color.White;
            this.chb_showGuide.Location = new System.Drawing.Point(700, 33);
            this.chb_showGuide.Name = "chb_showGuide";
            this.chb_showGuide.Size = new System.Drawing.Size(40, 22);
            this.chb_showGuide.TabIndex = 3;
            this.chb_showGuide.CheckedChanged += new System.EventHandler(this.chb_showGuide_CheckedChanged);
            // 
            // txt_reasoningResult
            // 
            this.txt_reasoningResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_reasoningResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_reasoningResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_reasoningResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reasoningResult.Location = new System.Drawing.Point(0, 0);
            this.txt_reasoningResult.Name = "txt_reasoningResult";
            this.txt_reasoningResult.ReadOnly = true;
            this.txt_reasoningResult.Size = new System.Drawing.Size(907, 349);
            this.txt_reasoningResult.TabIndex = 4;
            this.txt_reasoningResult.Text = "";
            // 
            // pn_reasoningResult
            // 
            this.pn_reasoningResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_reasoningResult.Controls.Add(this.txt_reasoningResult);
            this.pn_reasoningResult.Location = new System.Drawing.Point(20, 235);
            this.pn_reasoningResult.Name = "pn_reasoningResult";
            this.pn_reasoningResult.Size = new System.Drawing.Size(909, 351);
            this.pn_reasoningResult.TabIndex = 5;
            // 
            // fCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 606);
            this.Controls.Add(this.pn_reasoningResult);
            this.Controls.Add(this.chb_showGuide);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_netClass);
            this.Controls.Add(this.lb_netAddress);
            this.Controls.Add(this.lb_subnet);
            this.Controls.Add(this.lb_IP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_result);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fCalculate";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "VLSM RESULT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fQuickCalculate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.pn_reasoningResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgv_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_IP;
        private System.Windows.Forms.Label lb_subnet;
        private System.Windows.Forms.Label lb_netAddress;
        private System.Windows.Forms.Label lb_netClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn host;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn broadCast;
        private System.Windows.Forms.DataGridViewTextBoxColumn subnetMask;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaWinSwitch chb_showGuide;
        private System.Windows.Forms.RichTextBox txt_reasoningResult;
        private System.Windows.Forms.Panel pn_reasoningResult;
    }
}