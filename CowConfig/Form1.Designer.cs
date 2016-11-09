namespace CowConfig
{
    partial class cowFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cowFrom));
            this.AutoProxyCheckBox = new System.Windows.Forms.CheckBox();
            this.BootCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoProxyCheckBox
            // 
            this.AutoProxyCheckBox.AutoSize = true;
            this.AutoProxyCheckBox.Location = new System.Drawing.Point(87, 39);
            this.AutoProxyCheckBox.Name = "AutoProxyCheckBox";
            this.AutoProxyCheckBox.Size = new System.Drawing.Size(72, 16);
            this.AutoProxyCheckBox.TabIndex = 0;
            this.AutoProxyCheckBox.Text = "启用代理";
            this.AutoProxyCheckBox.UseVisualStyleBackColor = true;
            // 
            // BootCheckBox
            // 
            this.BootCheckBox.AutoSize = true;
            this.BootCheckBox.Location = new System.Drawing.Point(87, 82);
            this.BootCheckBox.Name = "BootCheckBox";
            this.BootCheckBox.Size = new System.Drawing.Size(72, 16);
            this.BootCheckBox.TabIndex = 1;
            this.BootCheckBox.Text = "开机启动";
            this.BootCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(40, 135);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "确定";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelButton1
            // 
            this.CancelButton1.Location = new System.Drawing.Point(153, 135);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(75, 23);
            this.CancelButton1.TabIndex = 3;
            this.CancelButton1.Text = "取消";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "cow";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReloadToolStripMenuItem,
            this.AutoProxyToolStripMenuItem,
            this.BootToolStripMenuItem,
            this.QuitToolStripMenuItem,
            this.ShowHideToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ReloadToolStripMenuItem
            // 
            this.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem";
            this.ReloadToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ReloadToolStripMenuItem.Text = "重新加载";
            this.ReloadToolStripMenuItem.Click += new System.EventHandler(this.ReloadToolStripMenuItem_Click);
            // 
            // AutoProxyToolStripMenuItem
            // 
            this.AutoProxyToolStripMenuItem.Name = "AutoProxyToolStripMenuItem";
            this.AutoProxyToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.AutoProxyToolStripMenuItem.Text = "启用代理";
            this.AutoProxyToolStripMenuItem.Click += new System.EventHandler(this.AutoProxyToolStripMenuItem_Click);
            // 
            // BootToolStripMenuItem
            // 
            this.BootToolStripMenuItem.Name = "BootToolStripMenuItem";
            this.BootToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.BootToolStripMenuItem.Text = "开机启动";
            this.BootToolStripMenuItem.Click += new System.EventHandler(this.BootToolStripMenuItem_Click);
            // 
            // QuitToolStripMenuItem
            // 
            this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            this.QuitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.QuitToolStripMenuItem.Text = "退出";
            this.QuitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // ShowHideToolStripMenuItem
            // 
            this.ShowHideToolStripMenuItem.Name = "ShowHideToolStripMenuItem";
            this.ShowHideToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ShowHideToolStripMenuItem.Text = "显示/隐藏";
            this.ShowHideToolStripMenuItem.Visible = false;
            this.ShowHideToolStripMenuItem.Click += new System.EventHandler(this.ShowHideToolStripMenuItem_Click);
            // 
            // cowFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 187);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.BootCheckBox);
            this.Controls.Add(this.AutoProxyCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cowFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cowFrom_FormClosing);
            this.Load += new System.EventHandler(this.cowFrom_Load);
            this.SizeChanged += new System.EventHandler(this.cowFrom_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AutoProxyCheckBox;
        private System.Windows.Forms.CheckBox BootCheckBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AutoProxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowHideToolStripMenuItem;
    }
}

