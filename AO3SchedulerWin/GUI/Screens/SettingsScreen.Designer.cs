﻿namespace AO3SchedulerWin.GUI.Screens
{
    partial class SettingsScreen
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            statusLabel = new Label();
            startServiceBtn = new Button();
            stopServiceBtn = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            serviceQueryTimer = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(145, 30);
            label1.TabIndex = 0;
            label1.Text = "Service Status:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            statusLabel.Location = new Point(157, 31);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(120, 30);
            statusLabel.TabIndex = 1;
            statusLabel.Text = "Unavailable";
            // 
            // startServiceBtn
            // 
            startServiceBtn.Location = new Point(6, 75);
            startServiceBtn.Name = "startServiceBtn";
            startServiceBtn.Size = new Size(119, 37);
            startServiceBtn.TabIndex = 2;
            startServiceBtn.Text = "Start";
            startServiceBtn.UseVisualStyleBackColor = true;
            startServiceBtn.Click += startServiceBtn_Click;
            // 
            // stopServiceBtn
            // 
            stopServiceBtn.Location = new Point(131, 75);
            stopServiceBtn.Name = "stopServiceBtn";
            stopServiceBtn.Size = new Size(119, 37);
            stopServiceBtn.TabIndex = 3;
            stopServiceBtn.Text = "Stop";
            stopServiceBtn.UseVisualStyleBackColor = true;
            stopServiceBtn.Click += stopServiceBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(stopServiceBtn);
            groupBox1.Controls.Add(statusLabel);
            groupBox1.Controls.Add(startServiceBtn);
            groupBox1.Location = new Point(12, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 157);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Local Upload Service";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(12, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 157);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Publish Mode";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Enabled = false;
            radioButton2.Location = new Point(6, 95);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(177, 19);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "Publish from a remote server";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(6, 70);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(152, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Publish from this device";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // serviceQueryTimer
            // 
            serviceQueryTimer.Enabled = true;
            serviceQueryTimer.Interval = 1000;
            serviceQueryTimer.Tick += serviceQueryTimer_Tick;
            // 
            // SettingsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SettingsScreen";
            Text = "SettingsScreen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label statusLabel;
        private Button startServiceBtn;
        private Button stopServiceBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private System.Windows.Forms.Timer serviceQueryTimer;
    }
}