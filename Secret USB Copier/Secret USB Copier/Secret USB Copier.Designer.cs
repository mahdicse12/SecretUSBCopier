namespace Secret_USB_Copier
{
    partial class Form_SecretUSBCopier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SecretUSBCopier));
            this.tabControl_SUC = new System.Windows.Forms.TabControl();
            this.tabPage_Start = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.dataGridView_Devices = new System.Windows.Forms.DataGridView();
            this.Column_Drive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_CurrentStatus = new System.Windows.Forms.Label();
            this.button_Deactivate = new System.Windows.Forms.Button();
            this.button_Activate = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.tabPage_Setting = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_Opendirectory = new System.Windows.Forms.Button();
            this.button_Changedirectory = new System.Windows.Forms.Button();
            this.textBox_Directory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_StartWithWindowsAndMinimize = new System.Windows.Forms.CheckBox();
            this.tabPage_About = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showSettingtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivatetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abouttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_SUC.SuspendLayout();
            this.tabPage_Start.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Devices)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage_Setting.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage_About.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_SUC
            // 
            this.tabControl_SUC.Controls.Add(this.tabPage_Start);
            this.tabControl_SUC.Controls.Add(this.tabPage_Setting);
            this.tabControl_SUC.Controls.Add(this.tabPage_About);
            this.tabControl_SUC.Location = new System.Drawing.Point(1, 0);
            this.tabControl_SUC.Name = "tabControl_SUC";
            this.tabControl_SUC.SelectedIndex = 0;
            this.tabControl_SUC.Size = new System.Drawing.Size(333, 311);
            this.tabControl_SUC.TabIndex = 0;
            // 
            // tabPage_Start
            // 
            this.tabPage_Start.Controls.Add(this.groupBox2);
            this.tabPage_Start.Controls.Add(this.groupBox1);
            this.tabPage_Start.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Start.Name = "tabPage_Start";
            this.tabPage_Start.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Start.Size = new System.Drawing.Size(325, 285);
            this.tabPage_Start.TabIndex = 0;
            this.tabPage_Start.Text = "Start";
            this.tabPage_Start.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Refresh);
            this.groupBox2.Controls.Add(this.dataGridView_Devices);
            this.groupBox2.Location = new System.Drawing.Point(7, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Devices";
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(174, 130);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(132, 23);
            this.button_Refresh.TabIndex = 2;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // dataGridView_Devices
            // 
            this.dataGridView_Devices.AllowUserToAddRows = false;
            this.dataGridView_Devices.AllowUserToDeleteRows = false;
            this.dataGridView_Devices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Devices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Drive,
            this.Column_Title,
            this.Column_Type,
            this.Column_Size});
            this.dataGridView_Devices.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Devices.Name = "dataGridView_Devices";
            this.dataGridView_Devices.ReadOnly = true;
            this.dataGridView_Devices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Devices.Size = new System.Drawing.Size(300, 105);
            this.dataGridView_Devices.TabIndex = 0;
            // 
            // Column_Drive
            // 
            this.Column_Drive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Drive.HeaderText = "Drive";
            this.Column_Drive.Name = "Column_Drive";
            this.Column_Drive.ReadOnly = true;
            // 
            // Column_Title
            // 
            this.Column_Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Title.HeaderText = "Title";
            this.Column_Title.Name = "Column_Title";
            this.Column_Title.ReadOnly = true;
            // 
            // Column_Type
            // 
            this.Column_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Type.HeaderText = "Type";
            this.Column_Type.Name = "Column_Type";
            this.Column_Type.ReadOnly = true;
            // 
            // Column_Size
            // 
            this.Column_Size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Size.HeaderText = "Size";
            this.Column_Size.Name = "Column_Size";
            this.Column_Size.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_CurrentStatus);
            this.groupBox1.Controls.Add(this.button_Deactivate);
            this.groupBox1.Controls.Add(this.button_Activate);
            this.groupBox1.Controls.Add(this.label_Status);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // label_CurrentStatus
            // 
            this.label_CurrentStatus.Location = new System.Drawing.Point(6, 16);
            this.label_CurrentStatus.Name = "label_CurrentStatus";
            this.label_CurrentStatus.Size = new System.Drawing.Size(86, 23);
            this.label_CurrentStatus.TabIndex = 3;
            this.label_CurrentStatus.Text = "Current Status :";
            // 
            // button_Deactivate
            // 
            this.button_Deactivate.Location = new System.Drawing.Point(174, 42);
            this.button_Deactivate.Name = "button_Deactivate";
            this.button_Deactivate.Size = new System.Drawing.Size(132, 23);
            this.button_Deactivate.TabIndex = 2;
            this.button_Deactivate.Text = "Deactivate";
            this.button_Deactivate.UseVisualStyleBackColor = true;
            this.button_Deactivate.Click += new System.EventHandler(this.button_Deactivate_Click);
            // 
            // button_Activate
            // 
            this.button_Activate.Location = new System.Drawing.Point(9, 42);
            this.button_Activate.Name = "button_Activate";
            this.button_Activate.Size = new System.Drawing.Size(132, 23);
            this.button_Activate.TabIndex = 1;
            this.button_Activate.Text = "Activate";
            this.button_Activate.UseVisualStyleBackColor = true;
            this.button_Activate.Click += new System.EventHandler(this.button_Activate_Click);
            // 
            // label_Status
            // 
            this.label_Status.Location = new System.Drawing.Point(98, 16);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(86, 23);
            this.label_Status.TabIndex = 0;
            // 
            // tabPage_Setting
            // 
            this.tabPage_Setting.Controls.Add(this.groupBox4);
            this.tabPage_Setting.Controls.Add(this.groupBox3);
            this.tabPage_Setting.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Setting.Name = "tabPage_Setting";
            this.tabPage_Setting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Setting.Size = new System.Drawing.Size(325, 285);
            this.tabPage_Setting.TabIndex = 1;
            this.tabPage_Setting.Text = "Setting";
            this.tabPage_Setting.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_Opendirectory);
            this.groupBox4.Controls.Add(this.button_Changedirectory);
            this.groupBox4.Controls.Add(this.textBox_Directory);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(7, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 154);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Target directory";
            // 
            // button_Opendirectory
            // 
            this.button_Opendirectory.Location = new System.Drawing.Point(172, 98);
            this.button_Opendirectory.Name = "button_Opendirectory";
            this.button_Opendirectory.Size = new System.Drawing.Size(132, 23);
            this.button_Opendirectory.TabIndex = 4;
            this.button_Opendirectory.Text = "Open directory";
            this.button_Opendirectory.UseVisualStyleBackColor = true;
            this.button_Opendirectory.Click += new System.EventHandler(this.button_Opendirectory_Click);
            // 
            // button_Changedirectory
            // 
            this.button_Changedirectory.Location = new System.Drawing.Point(9, 98);
            this.button_Changedirectory.Name = "button_Changedirectory";
            this.button_Changedirectory.Size = new System.Drawing.Size(132, 23);
            this.button_Changedirectory.TabIndex = 3;
            this.button_Changedirectory.Text = "Change directory";
            this.button_Changedirectory.UseVisualStyleBackColor = true;
            this.button_Changedirectory.Click += new System.EventHandler(this.button_Changedirectory_Click);
            // 
            // textBox_Directory
            // 
            this.textBox_Directory.Location = new System.Drawing.Point(9, 72);
            this.textBox_Directory.Name = "textBox_Directory";
            this.textBox_Directory.Size = new System.Drawing.Size(295, 20);
            this.textBox_Directory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copied files will be saved to :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_StartWithWindowsAndMinimize);
            this.groupBox3.Location = new System.Drawing.Point(7, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 111);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Startup";
            // 
            // checkBox_StartWithWindowsAndMinimize
            // 
            this.checkBox_StartWithWindowsAndMinimize.AutoSize = true;
            this.checkBox_StartWithWindowsAndMinimize.Location = new System.Drawing.Point(9, 41);
            this.checkBox_StartWithWindowsAndMinimize.Name = "checkBox_StartWithWindowsAndMinimize";
            this.checkBox_StartWithWindowsAndMinimize.Size = new System.Drawing.Size(178, 17);
            this.checkBox_StartWithWindowsAndMinimize.TabIndex = 0;
            this.checkBox_StartWithWindowsAndMinimize.Text = "Start with windows and Minimize";
            this.checkBox_StartWithWindowsAndMinimize.UseVisualStyleBackColor = true;
            this.checkBox_StartWithWindowsAndMinimize.CheckedChanged += new System.EventHandler(this.checkBox_StartWithWindows_CheckedChanged);
            // 
            // tabPage_About
            // 
            this.tabPage_About.Controls.Add(this.groupBox6);
            this.tabPage_About.Location = new System.Drawing.Point(4, 22);
            this.tabPage_About.Name = "tabPage_About";
            this.tabPage_About.Size = new System.Drawing.Size(325, 285);
            this.tabPage_About.TabIndex = 2;
            this.tabPage_About.Text = "About";
            this.tabPage_About.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(319, 115);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Details";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Developer :         Mahdi and Milon";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tool :                  Secret USB Copier";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Secret USB Copier";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ni_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSettingtoolStripMenuItem,
            this.activetoolStripMenuItem,
            this.deactivatetoolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.abouttoolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip.ShowItemToolTips = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 158);
            // 
            // showSettingtoolStripMenuItem
            // 
            this.showSettingtoolStripMenuItem.Image = global::Secret_USB_Copier.Properties.Resources.ShowSetting;
            this.showSettingtoolStripMenuItem.Name = "showSettingtoolStripMenuItem";
            this.showSettingtoolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showSettingtoolStripMenuItem.Text = "Show Setting";
            this.showSettingtoolStripMenuItem.Click += new System.EventHandler(this.showSettingtoolStripMenuItem_Click);
            // 
            // activetoolStripMenuItem
            // 
            this.activetoolStripMenuItem.Image = global::Secret_USB_Copier.Properties.Resources.Active;
            this.activetoolStripMenuItem.Name = "activetoolStripMenuItem";
            this.activetoolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.activetoolStripMenuItem.Text = "Activate";
            this.activetoolStripMenuItem.Click += new System.EventHandler(this.activetoolStripMenuItem_Click);
            // 
            // deactivatetoolStripMenuItem
            // 
            this.deactivatetoolStripMenuItem.Image = global::Secret_USB_Copier.Properties.Resources.Inactive;
            this.deactivatetoolStripMenuItem.Name = "deactivatetoolStripMenuItem";
            this.deactivatetoolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deactivatetoolStripMenuItem.Text = "Deactivate";
            this.deactivatetoolStripMenuItem.Click += new System.EventHandler(this.deactivatetoolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Image = global::Secret_USB_Copier.Properties.Resources.Restore;
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // abouttoolStripMenuItem
            // 
            this.abouttoolStripMenuItem.Image = global::Secret_USB_Copier.Properties.Resources.SUC;
            this.abouttoolStripMenuItem.Name = "abouttoolStripMenuItem";
            this.abouttoolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abouttoolStripMenuItem.Text = "About";
            this.abouttoolStripMenuItem.Click += new System.EventHandler(this.abouttoolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Secret_USB_Copier.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form_SecretUSBCopier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.tabControl_SUC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_SecretUSBCopier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret USB Copier";
            this.tabControl_SUC.ResumeLayout(false);
            this.tabPage_Start.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Devices)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabPage_Setting.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage_About.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_SUC;
        private System.Windows.Forms.TabPage tabPage_Start;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Deactivate;
        private System.Windows.Forms.Button button_Activate;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.TabPage tabPage_Setting;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabPage tabPage_About;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Devices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Drive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Size;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label_CurrentStatus;
        private System.Windows.Forms.ToolStripMenuItem showSettingtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abouttoolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_Opendirectory;
        private System.Windows.Forms.Button button_Changedirectory;
        private System.Windows.Forms.TextBox textBox_Directory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_StartWithWindowsAndMinimize;
        private System.Windows.Forms.ToolStripMenuItem activetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactivatetoolStripMenuItem;
    }
}

