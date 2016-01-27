namespace BypassServerMonitor
{
    partial class ServerMonitor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerMonitor));
            this.label1 = new System.Windows.Forms.Label();
            this.requestTimeTB = new System.Windows.Forms.TextBox();
            this.setRefreshRateBtn = new System.Windows.Forms.Button();
            this.refreshRateLabel = new System.Windows.Forms.Label();
            this.manualRefreshBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.connectedLabel = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.messagesTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.semaphorePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Refresh rate:";
            // 
            // requestTimeTB
            // 
            this.requestTimeTB.Location = new System.Drawing.Point(12, 33);
            this.requestTimeTB.Name = "requestTimeTB";
            this.requestTimeTB.Size = new System.Drawing.Size(100, 20);
            this.requestTimeTB.TabIndex = 1;
            // 
            // setRefreshRateBtn
            // 
            this.setRefreshRateBtn.Location = new System.Drawing.Point(118, 33);
            this.setRefreshRateBtn.Name = "setRefreshRateBtn";
            this.setRefreshRateBtn.Size = new System.Drawing.Size(75, 23);
            this.setRefreshRateBtn.TabIndex = 3;
            this.setRefreshRateBtn.Text = "Set";
            this.setRefreshRateBtn.UseVisualStyleBackColor = true;
            this.setRefreshRateBtn.Click += new System.EventHandler(this.setRefreshRateBtn_Click);
            // 
            // refreshRateLabel
            // 
            this.refreshRateLabel.AutoSize = true;
            this.refreshRateLabel.Location = new System.Drawing.Point(115, 13);
            this.refreshRateLabel.Name = "refreshRateLabel";
            this.refreshRateLabel.Size = new System.Drawing.Size(62, 13);
            this.refreshRateLabel.TabIndex = 4;
            this.refreshRateLabel.Text = "45 seconds";
            // 
            // manualRefreshBtn
            // 
            this.manualRefreshBtn.Location = new System.Drawing.Point(216, 33);
            this.manualRefreshBtn.Name = "manualRefreshBtn";
            this.manualRefreshBtn.Size = new System.Drawing.Size(111, 23);
            this.manualRefreshBtn.TabIndex = 5;
            this.manualRefreshBtn.Text = "Manual Refresh";
            this.manualRefreshBtn.UseVisualStyleBackColor = true;
            this.manualRefreshBtn.Click += new System.EventHandler(this.manualRefreshBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // connectedLabel
            // 
            this.connectedLabel.AutoSize = true;
            this.connectedLabel.ForeColor = System.Drawing.Color.Red;
            this.connectedLabel.Location = new System.Drawing.Point(220, 13);
            this.connectedLabel.Name = "connectedLabel";
            this.connectedLabel.Size = new System.Drawing.Size(103, 13);
            this.connectedLabel.TabIndex = 8;
            this.connectedLabel.Text = "Connected to server";
            this.connectedLabel.HandleCreated += new System.EventHandler(this.connectedLabel_HandleCreated);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Location = new System.Drawing.Point(12, 59);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1081, 447);
            this.tabs.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.messagesTb);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1073, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Estado";
            // 
            // messagesTb
            // 
            this.messagesTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesTb.Location = new System.Drawing.Point(482, -2);
            this.messagesTb.Multiline = true;
            this.messagesTb.Name = "messagesTb";
            this.messagesTb.ReadOnly = true;
            this.messagesTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messagesTb.Size = new System.Drawing.Size(586, 425);
            this.messagesTb.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.grid);
            this.panel1.Location = new System.Drawing.Point(5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 425);
            this.panel1.TabIndex = 10;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(444, 425);
            this.grid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.semaphorePanel);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1073, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conectados";
            // 
            // semaphorePanel
            // 
            this.semaphorePanel.AutoScroll = true;
            this.semaphorePanel.Location = new System.Drawing.Point(24, 37);
            this.semaphorePanel.Name = "semaphorePanel";
            this.semaphorePanel.Size = new System.Drawing.Size(1024, 378);
            this.semaphorePanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clientes";
            // 
            // ServerMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 515);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.connectedLabel);
            this.Controls.Add(this.manualRefreshBtn);
            this.Controls.Add(this.refreshRateLabel);
            this.Controls.Add(this.setRefreshRateBtn);
            this.Controls.Add(this.requestTimeTB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerMonitor";
            this.Text = "ServerMonitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerMonitor_FormClosing);
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox requestTimeTB;
        private System.Windows.Forms.Button setRefreshRateBtn;
        private System.Windows.Forms.Label refreshRateLabel;
        private System.Windows.Forms.Button manualRefreshBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label connectedLabel;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox messagesTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel semaphorePanel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}