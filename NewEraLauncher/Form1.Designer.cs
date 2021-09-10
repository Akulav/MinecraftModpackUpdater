﻿
namespace NewEraLauncher
{
    partial class defaultWindow
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.downloadBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(12, 12);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(559, 76);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "Update To Latest";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(12, 120);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(306, 13);
            this.progressLabel.TabIndex = 1;
            this.progressLabel.Text = "*This will reset your config, mods, resourcepack, shader folders.";
            // 
            // downloadBar
            // 
            this.downloadBar.Location = new System.Drawing.Point(12, 94);
            this.downloadBar.Name = "downloadBar";
            this.downloadBar.Size = new System.Drawing.Size(555, 23);
            this.downloadBar.TabIndex = 2;
            // 
            // defaultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 159);
            this.Controls.Add(this.downloadBar);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.updateBtn);
            this.Name = "defaultWindow";
            this.Text = "New Era Updater 0.0.1";
            this.Load += new System.EventHandler(this.defaultWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.ProgressBar downloadBar;
    }
}

