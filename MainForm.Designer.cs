﻿
namespace ClipboardHistory
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TextListBox = new System.Windows.Forms.ListBox();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // TextListBox
            // 
            this.TextListBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.TextListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextListBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextListBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.TextListBox.FormattingEnabled = true;
            this.TextListBox.ItemHeight = 21;
            this.TextListBox.Location = new System.Drawing.Point(12, 15);
            this.TextListBox.Name = "TextListBox";
            this.TextListBox.Size = new System.Drawing.Size(326, 420);
            this.TextListBox.TabIndex = 0;
            this.TextListBox.TabStop = false;
            this.TextListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextListBox_MouseClick);
            this.TextListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextListBox_MouseDoubleClick);
            // 
            // TrayIcon
            // 
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Clipboard History";
            this.TrayIcon.Visible = true;
            this.TrayIcon.Click += new System.EventHandler(this.TrayIcon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.TextListBox);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.Text = "Clipboard";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox TextListBox;
        private System.Windows.Forms.NotifyIcon TrayIcon;
    }
}

