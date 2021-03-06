﻿namespace Mulholland.QSet.Application.DockForms
{
    partial class QueueSetMonitorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueueSetMonitorForm));
            this.qSetMonitor = new Mulholland.QSet.Application.Controls.QSetMonitor();
            this.SuspendLayout();
            // 
            // qSetMonitor
            // 
            this.qSetMonitor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.qSetMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qSetMonitor.ImageList = null;
            this.qSetMonitor.Location = new System.Drawing.Point(0, 0);
            this.qSetMonitor.Name = "qSetMonitor";
            this.qSetMonitor.QSet = null;
            this.qSetMonitor.Size = new System.Drawing.Size(345, 338);
            this.qSetMonitor.TabIndex = 0;
            // 
            // QueueSetMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 338);
            this.Controls.Add(this.qSetMonitor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QueueSetMonitorForm";
            this.Text = "Queue Set Monitor";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.QSetMonitor qSetMonitor;
    }
}