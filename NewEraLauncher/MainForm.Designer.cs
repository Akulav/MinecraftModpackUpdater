
namespace NewEraLauncher
{
    public partial class defaultWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(defaultWindow));
            this.updateBtn = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.downloadBar = new System.Windows.Forms.ProgressBar();
            this.packDescriptor = new System.Windows.Forms.Label();
            this.modpackList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(12, 67);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(364, 76);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "Update To Latest";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(9, 175);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(311, 13);
            this.progressLabel.TabIndex = 1;
            this.progressLabel.Text = "*This may reset your config, mods, resourcepack, shader folders.";
            // 
            // downloadBar
            // 
            this.downloadBar.Location = new System.Drawing.Point(12, 149);
            this.downloadBar.Name = "downloadBar";
            this.downloadBar.Size = new System.Drawing.Size(364, 23);
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
            // modpackList
            // 
            this.modpackList.FormattingEnabled = true;
            this.modpackList.Location = new System.Drawing.Point(12, 12);
            this.modpackList.Name = "modpackList";
            this.modpackList.Size = new System.Drawing.Size(364, 49);
            this.modpackList.TabIndex = 6;
            this.modpackList.SelectedIndexChanged += new System.EventHandler(this.modpackList_SelectedIndexChanged);
            // 
            // defaultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 198);
            this.Controls.Add(this.modpackList);
            this.Controls.Add(this.packDescriptor);
            this.Controls.Add(this.downloadBar);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.updateBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "defaultWindow";
            this.Text = "New Era Updater 1.4.0 - Made by Caty ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.defaultWindow_FormClosing);
            this.Load += new System.EventHandler(this.DefaultWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.ProgressBar downloadBar;
        public System.Windows.Forms.Label packDescriptor;
        public  System.Windows.Forms.CheckedListBox modpackList;
    }
}

