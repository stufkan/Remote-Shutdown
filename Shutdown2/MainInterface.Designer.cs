﻿namespace Shutdown
{
    partial class MainInterface
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Time = new System.Windows.Forms.RadioButton();
            this.Countdown = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Shutdown = new System.Windows.Forms.RadioButton();
            this.Sleep = new System.Windows.Forms.RadioButton();
            this.Reboot = new System.Windows.Forms.RadioButton();
            this.TimeFormat = new System.Windows.Forms.TextBox();
            this.AddTen = new System.Windows.Forms.Button();
            this.Execute = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "No shutdown started";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Time);
            this.panel2.Controls.Add(this.Countdown);
            this.panel2.Location = new System.Drawing.Point(11, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 54);
            this.panel2.TabIndex = 16;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(0, 30);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(48, 17);
            this.Time.TabIndex = 6;
            this.Time.Text = "Time";
            this.Time.UseVisualStyleBackColor = true;
            this.Time.CheckedChanged += new System.EventHandler(this.radioButton2_Checked_1);
            // 
            // Countdown
            // 
            this.Countdown.AutoSize = true;
            this.Countdown.Checked = true;
            this.Countdown.Location = new System.Drawing.Point(0, 7);
            this.Countdown.Name = "Countdown";
            this.Countdown.Size = new System.Drawing.Size(79, 17);
            this.Countdown.TabIndex = 7;
            this.Countdown.TabStop = true;
            this.Countdown.Text = "Countdown";
            this.Countdown.UseVisualStyleBackColor = true;
            this.Countdown.CheckedChanged += new System.EventHandler(this.Countdown_Checked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Shutdown);
            this.panel1.Controls.Add(this.Sleep);
            this.panel1.Controls.Add(this.Reboot);
            this.panel1.Location = new System.Drawing.Point(135, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 76);
            this.panel1.TabIndex = 15;
            // 
            // Shutdown
            // 
            this.Shutdown.AutoSize = true;
            this.Shutdown.Checked = true;
            this.Shutdown.Location = new System.Drawing.Point(3, 5);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(73, 17);
            this.Shutdown.TabIndex = 2;
            this.Shutdown.TabStop = true;
            this.Shutdown.Text = "Shutdown";
            this.Shutdown.UseVisualStyleBackColor = true;
            this.Shutdown.CheckedChanged += new System.EventHandler(this.Shutdown_CheckedChanged);
            // 
            // Sleep
            // 
            this.Sleep.AutoSize = true;
            this.Sleep.Location = new System.Drawing.Point(3, 51);
            this.Sleep.Name = "Sleep";
            this.Sleep.Size = new System.Drawing.Size(71, 17);
            this.Sleep.TabIndex = 2;
            this.Sleep.Text = "Hibernate";
            this.Sleep.UseVisualStyleBackColor = true;
            this.Sleep.CheckedChanged += new System.EventHandler(this.Sleep_CheckedChanged);
            // 
            // Reboot
            // 
            this.Reboot.AutoSize = true;
            this.Reboot.Location = new System.Drawing.Point(3, 28);
            this.Reboot.Name = "Reboot";
            this.Reboot.Size = new System.Drawing.Size(60, 17);
            this.Reboot.TabIndex = 2;
            this.Reboot.Text = "Reboot";
            this.Reboot.UseVisualStyleBackColor = true;
            this.Reboot.CheckedChanged += new System.EventHandler(this.Reboot_CheckedChanged);
            // 
            // TimeFormat
            // 
            this.TimeFormat.Location = new System.Drawing.Point(11, 5);
            this.TimeFormat.Name = "TimeFormat";
            this.TimeFormat.Size = new System.Drawing.Size(100, 20);
            this.TimeFormat.TabIndex = 13;
            this.TimeFormat.Text = "0";
            // 
            // AddTen
            // 
            this.AddTen.Location = new System.Drawing.Point(11, 88);
            this.AddTen.Name = "AddTen";
            this.AddTen.Size = new System.Drawing.Size(75, 23);
            this.AddTen.TabIndex = 17;
            this.AddTen.Text = "+10";
            this.AddTen.UseCompatibleTextRendering = true;
            this.AddTen.UseVisualStyleBackColor = true;
            this.AddTen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddTen_MouseClick);
            this.AddTen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddTen_MouseUp);
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(135, 88);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(75, 23);
            this.Execute.TabIndex = 14;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TimeFormat);
            this.Controls.Add(this.AddTen);
            this.Controls.Add(this.Execute);
            this.Name = "MainInterface";
            this.Size = new System.Drawing.Size(226, 137);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Time;
        private System.Windows.Forms.RadioButton Countdown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Shutdown;
        private System.Windows.Forms.RadioButton Sleep;
        private System.Windows.Forms.RadioButton Reboot;
        public System.Windows.Forms.TextBox TimeFormat;
        public System.Windows.Forms.Button AddTen;
        public System.Windows.Forms.Button Execute;
        private System.Windows.Forms.NotifyIcon notifyIcon1;

        
    }
}
