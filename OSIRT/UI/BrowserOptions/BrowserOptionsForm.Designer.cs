﻿namespace OSIRT.UI.BrowserOptions
{
    partial class BrowserOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserOptionsForm));
            this.uiBrowserOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.uiConnectToTorCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiUserAgentListLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.uiUserAgentTextBox = new System.Windows.Forms.TextBox();
            this.uiOKButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.uiBrowserOptionsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiBrowserOptionsGroupBox
            // 
            this.uiBrowserOptionsGroupBox.Controls.Add(this.uiConnectToTorCheckBox);
            this.uiBrowserOptionsGroupBox.Location = new System.Drawing.Point(8, 35);
            this.uiBrowserOptionsGroupBox.Name = "uiBrowserOptionsGroupBox";
            this.uiBrowserOptionsGroupBox.Size = new System.Drawing.Size(489, 43);
            this.uiBrowserOptionsGroupBox.TabIndex = 0;
            this.uiBrowserOptionsGroupBox.TabStop = false;
            this.uiBrowserOptionsGroupBox.Text = "Tor Network";
            // 
            // uiConnectToTorCheckBox
            // 
            this.uiConnectToTorCheckBox.AutoSize = true;
            this.uiConnectToTorCheckBox.Location = new System.Drawing.Point(6, 19);
            this.uiConnectToTorCheckBox.Name = "uiConnectToTorCheckBox";
            this.uiConnectToTorCheckBox.Size = new System.Drawing.Size(161, 17);
            this.uiConnectToTorCheckBox.TabIndex = 0;
            this.uiConnectToTorCheckBox.Text = "Connect via the Tor network";
            this.uiConnectToTorCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "These options are for advanced users who have received relevant training.\r\n ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.uiUserAgentListLinkLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.uiUserAgentTextBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spoof User Agent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Leave blank to use the browser\'s default user agent.";
            // 
            // uiUserAgentListLinkLabel
            // 
            this.uiUserAgentListLinkLabel.AutoSize = true;
            this.uiUserAgentListLinkLabel.Location = new System.Drawing.Point(352, 42);
            this.uiUserAgentListLinkLabel.Name = "uiUserAgentListLinkLabel";
            this.uiUserAgentListLinkLabel.Size = new System.Drawing.Size(135, 13);
            this.uiUserAgentListLinkLabel.TabIndex = 2;
            this.uiUserAgentListLinkLabel.TabStop = true;
            this.uiUserAgentListLinkLabel.Text = "clicking here (no affiliation).";
            this.uiUserAgentListLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uiUserAgentListLinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter a user agent in the box above. You can find a list of user agents by ";
            // 
            // uiUserAgentTextBox
            // 
            this.uiUserAgentTextBox.Location = new System.Drawing.Point(4, 19);
            this.uiUserAgentTextBox.Name = "uiUserAgentTextBox";
            this.uiUserAgentTextBox.Size = new System.Drawing.Size(479, 20);
            this.uiUserAgentTextBox.TabIndex = 0;
            // 
            // uiOKButton
            // 
            this.uiOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uiOKButton.Location = new System.Drawing.Point(422, 179);
            this.uiOKButton.Name = "uiOKButton";
            this.uiOKButton.Size = new System.Drawing.Size(75, 23);
            this.uiOKButton.TabIndex = 2;
            this.uiOKButton.Text = "OK";
            this.uiOKButton.UseVisualStyleBackColor = true;
            this.uiOKButton.Click += new System.EventHandler(this.uiOKButton_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(341, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BrowserOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 208);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uiOKButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiBrowserOptionsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowserOptionsForm";
            this.Text = "Advanced Browser Options";
            this.Load += new System.EventHandler(this.BrowserOptionsForm_Load);
            this.uiBrowserOptionsGroupBox.ResumeLayout(false);
            this.uiBrowserOptionsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox uiBrowserOptionsGroupBox;
        private System.Windows.Forms.CheckBox uiConnectToTorCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel uiUserAgentListLinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiUserAgentTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uiOKButton;
        private System.Windows.Forms.Button button2;
    }
}