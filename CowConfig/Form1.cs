using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using CowConfig.Util.Proxy;
using System.Diagnostics;
using System.IO;
using CowConfig.Util;

namespace CowConfig
{
    public partial class cowFrom : Form
    {
        public cowFrom()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // 还原窗体显示    
                WindowState = FormWindowState.Normal;
                // 激活窗体并给予它焦点
                this.Activate();
                // 任务栏区显示图标
                this.ShowInTaskbar = true;
                // 托盘区图标隐藏
                notifyIcon1.Visible = false;
            }
        }

        private void cowFrom_SizeChanged(object sender, EventArgs e)
        {
            // 判断是否选择的是最小化按钮
            if (WindowState == FormWindowState.Minimized)
            {
                // 隐藏任务栏区图标
                this.ShowInTaskbar = false;
                // 图标显示在托盘区
                notifyIcon1.Visible = true;
            }
        }

        private void cowFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            e.Cancel = true;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SetAutoProxy(false);
            //Process[] ps = Process.GetProcesses();
            //foreach (Process item in ps)
            //{
            //    if (item.ProcessName.Equals("cow"))
            //        item.Kill();
            //}
            this.Dispose();
            this.Close();
        }

        public static bool SetAutoProxy(bool enabled)
        {
            if (enabled)
            {
                string pacUrl = null;
                StreamReader sr = new StreamReader("rc.txt", Encoding.Default);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != null && line.Trim().Contains("listen") && line.Trim()[0] != '#')
                    {
                        pacUrl = line.Split('=')[1].Trim() + "/pac";
                    }
                }
                if (string.IsNullOrEmpty(pacUrl))
                {
                    MessageBox.Show("未找到listen地址！");
                    return false;
                }

                WinINet.SetIEProxy(true, false, "", pacUrl);
            }
            else
            {
                WinINet.SetIEProxy(false, false, "", "");
            }
            return true;
        }

        public static RegistryKey OpenRegKey(string name, bool writable, RegistryHive hive = RegistryHive.CurrentUser)
        {
            // we are building x86 binary for both x86 and x64, which will
            // cause problem when opening registry key
            // detect operating system instead of CPU
            if (string.IsNullOrEmpty(name)) throw new ArgumentException(nameof(name));
            try
            {
                RegistryKey userKey = RegistryKey.OpenBaseKey(hive,
                        Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32)
                    .OpenSubKey(name, writable);
                return userKey;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show("OpenRegKey: " + ae.ToString());
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static bool SetBoot(bool enabled)
        {
            string Key = "CowConfig";
            RegistryKey runKey = null;
            try
            {
                string path = Application.ExecutablePath;
                runKey = OpenRegKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (runKey == null)
                {

                    return false;
                }
                if (enabled)
                {
                    runKey.SetValue(Key, path);
                }
                else
                {
                    runKey.DeleteValue(Key);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                if (runKey != null)
                {
                    try
                    {
                        runKey.Close();
                        runKey.Dispose();
                    }
                    catch (Exception)
                    { }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //开机启动
            if (BootCheckBox.Checked)
                SetBoot(true);
            else
                SetBoot(false);
            //代理配置
            if (AutoProxyCheckBox.Checked)
                SetAutoProxy(true);
            else
                SetAutoProxy(false);

            AutoProxyToolStripMenuItem.Checked = AutoProxyCheckBox.Checked;
            BootToolStripMenuItem.Checked = BootCheckBox.Checked;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AutoProxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AutoProxyToolStripMenuItem.Checked)
            {
                AutoProxyToolStripMenuItem.Checked = false;
                SetAutoProxy(false);
            }
            else
            {
                AutoProxyToolStripMenuItem.Checked = true;
                SetAutoProxy(true);
            }
        }

        private void BootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BootToolStripMenuItem.Checked)
            {
                BootToolStripMenuItem.Checked = false;
                SetBoot(false);
            }
            else
            {
                BootToolStripMenuItem.Checked = true;
                SetBoot(true);
            }
        }

        public void StartCow()
        {
            Process[] ps = Process.GetProcesses();
            foreach (Process item in ps)
            {
                if (item.ProcessName.Equals("cow"))
                    item.Kill();
            }
            
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = @"cow.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.UseShellExecute = true;
            Process.Start(psi);
        }

        private void cowFrom_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            StartCow();
            //初始化参数
            RegistryKey run_Check = OpenRegKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            if (run_Check != null && run_Check.GetValue("CowConfig") != null)
            {
                BootCheckBox.Checked = true;
                BootToolStripMenuItem.Checked = true;
            }

            run_Check = OpenRegKey(@"Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            if (run_Check.GetValue("AutoConfigURL") != null)
            {
                AutoProxyCheckBox.Checked = true;
                AutoProxyToolStripMenuItem.Checked = true;
            }
        }

        private void ReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartCow();
            if(AutoProxyToolStripMenuItem.Checked && AutoProxyCheckBox.Checked)
                SetAutoProxy(true);
        }

        private void ShowHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App app = new App(Process.GetProcessesByName("cow")[0]);
            app.Show();
            app.Hide();
        }
    }
}
