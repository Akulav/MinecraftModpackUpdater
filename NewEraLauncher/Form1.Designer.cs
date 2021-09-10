
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
            this.packDescriptor = new System.Windows.Forms.Label();
            this.packDescr = new System.Windows.Forms.Label();
            this.modpackList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(12, 48);
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
            this.progressLabel.Location = new System.Drawing.Point(12, 162);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(306, 13);
            this.progressLabel.TabIndex = 1;
            this.progressLabel.Text = "*This will reset your config, mods, resourcepack, shader folders.";
            // 
            // downloadBar
            // 
            this.downloadBar.Location = new System.Drawing.Point(12, 130);
            this.downloadBar.Name = "downloadBar";
            this.downloadBar.Size = new System.Drawing.Size(559, 23);
            this.downloadBar.TabIndex = 2;
            // 
            // packDescriptor
            // 
            this.packDescriptor.AutoSize = true;
            this.packDescriptor.Location = new System.Drawing.Point(308, 12);
            this.packDescriptor.Name = "packDescriptor";
            this.packDescriptor.Size = new System.Drawing.Size(0, 13);
            this.packDescriptor.TabIndex = 4;
            // 
            // packDescr
            // 
            this.packDescr.AutoSize = true;
            this.packDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packDescr.Location = new System.Drawing.Point(445, 12);
            this.packDescr.Name = "packDescr";
            this.packDescr.Size = new System.Drawing.Size(140, 20);
            this.packDescr.TabIndex = 5;
            this.packDescr.Text = "Select a modpack.";
            // 
            // modpackList
            // 
            this.modpackList.FormattingEnabled = true;
            this.modpackList.Location = new System.Drawing.Point(15, 12);
            this.modpackList.Name = "modpackList";
            this.modpackList.Size = new System.Drawing.Size(424, 34);
            this.modpackList.TabIndex = 6;
            // 
            // defaultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 184);
            this.Controls.Add(this.modpackList);
            this.Controls.Add(this.packDescr);
            this.Controls.Add(this.packDescriptor);
            this.Controls.Add(this.downloadBar);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.updateBtn);
            this.MaximizeBox = false;
            this.Name = "defaultWindow";
            this.ShowIcon = false;
            this.Text = "New Era Updater 1.0.0 - Made by Caty ";
            this.Load += new System.EventHandler(this.defaultWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.ProgressBar downloadBar;
        private System.Windows.Forms.Label packDescriptor;
        private System.Windows.Forms.Label packDescr;
        private System.Windows.Forms.CheckedListBox modpackList;
    }
}

