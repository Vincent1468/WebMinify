namespace WebMinify
{
    partial class MainForm
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
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.grpFiles = new System.Windows.Forms.GroupBox();
            this.lsFiles = new System.Windows.Forms.ListBox();
            this.chkJs = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkCss = new System.Windows.Forms.CheckBox();
            this.grpMinify = new System.Windows.Forms.GroupBox();
            this.chkMin = new System.Windows.Forms.CheckBox();
            this.chkBackup = new System.Windows.Forms.CheckBox();
            this.btnMinify = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.chkIgnoreErrors = new System.Windows.Forms.CheckBox();
            this.grpFiles.SuspendLayout();
            this.grpMinify.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(199, 11);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // grpFiles
            // 
            this.grpFiles.Controls.Add(this.lsFiles);
            this.grpFiles.Controls.Add(this.chkJs);
            this.grpFiles.Controls.Add(this.btnSelectFolder);
            this.grpFiles.Controls.Add(this.label1);
            this.grpFiles.Controls.Add(this.chkCss);
            this.grpFiles.Location = new System.Drawing.Point(12, 12);
            this.grpFiles.Name = "grpFiles";
            this.grpFiles.Size = new System.Drawing.Size(285, 210);
            this.grpFiles.TabIndex = 1;
            this.grpFiles.TabStop = false;
            this.grpFiles.Text = "Files";
            // 
            // lsFiles
            // 
            this.lsFiles.FormattingEnabled = true;
            this.lsFiles.Location = new System.Drawing.Point(7, 38);
            this.lsFiles.Name = "lsFiles";
            this.lsFiles.Size = new System.Drawing.Size(267, 160);
            this.lsFiles.TabIndex = 4;
            // 
            // chkJs
            // 
            this.chkJs.AutoSize = true;
            this.chkJs.Checked = true;
            this.chkJs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJs.Location = new System.Drawing.Point(131, 15);
            this.chkJs.Name = "chkJs";
            this.chkJs.Size = new System.Drawing.Size(62, 17);
            this.chkJs.TabIndex = 3;
            this.chkJs.Text = "JS Files";
            this.chkJs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Include";
            // 
            // chkCss
            // 
            this.chkCss.AutoSize = true;
            this.chkCss.Checked = true;
            this.chkCss.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCss.Location = new System.Drawing.Point(52, 15);
            this.chkCss.Name = "chkCss";
            this.chkCss.Size = new System.Drawing.Size(71, 17);
            this.chkCss.TabIndex = 1;
            this.chkCss.Text = "CSS Files";
            this.chkCss.UseVisualStyleBackColor = true;
            // 
            // grpMinify
            // 
            this.grpMinify.Controls.Add(this.chkIgnoreErrors);
            this.grpMinify.Controls.Add(this.chkMin);
            this.grpMinify.Controls.Add(this.chkBackup);
            this.grpMinify.Controls.Add(this.btnMinify);
            this.grpMinify.Location = new System.Drawing.Point(12, 228);
            this.grpMinify.Name = "grpMinify";
            this.grpMinify.Size = new System.Drawing.Size(285, 70);
            this.grpMinify.TabIndex = 2;
            this.grpMinify.TabStop = false;
            this.grpMinify.Text = "Minify";
            // 
            // chkMin
            // 
            this.chkMin.AutoSize = true;
            this.chkMin.Location = new System.Drawing.Point(6, 41);
            this.chkMin.Name = "chkMin";
            this.chkMin.Size = new System.Drawing.Size(146, 17);
            this.chkMin.TabIndex = 2;
            this.chkMin.Text = "Save as .min.js / .min.css";
            this.chkMin.UseVisualStyleBackColor = true;
            // 
            // chkBackup
            // 
            this.chkBackup.AutoSize = true;
            this.chkBackup.Location = new System.Drawing.Point(6, 19);
            this.chkBackup.Name = "chkBackup";
            this.chkBackup.Size = new System.Drawing.Size(96, 17);
            this.chkBackup.TabIndex = 1;
            this.chkBackup.Text = "Create backup";
            this.chkBackup.UseVisualStyleBackColor = true;
            // 
            // btnMinify
            // 
            this.btnMinify.Location = new System.Drawing.Point(199, 42);
            this.btnMinify.Name = "btnMinify";
            this.btnMinify.Size = new System.Drawing.Size(80, 23);
            this.btnMinify.TabIndex = 0;
            this.btnMinify.Text = "Minify";
            this.btnMinify.UseVisualStyleBackColor = true;
            this.btnMinify.Click += new System.EventHandler(this.btnMinify_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 304);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(285, 23);
            this.progressBar.TabIndex = 3;
            // 
            // chkIgnoreErrors
            // 
            this.chkIgnoreErrors.AutoSize = true;
            this.chkIgnoreErrors.Location = new System.Drawing.Point(199, 19);
            this.chkIgnoreErrors.Name = "chkIgnoreErrors";
            this.chkIgnoreErrors.Size = new System.Drawing.Size(85, 17);
            this.chkIgnoreErrors.TabIndex = 3;
            this.chkIgnoreErrors.Text = "Ignore errors";
            this.chkIgnoreErrors.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 335);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.grpMinify);
            this.Controls.Add(this.grpFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Web Minifier";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpFiles.ResumeLayout(false);
            this.grpFiles.PerformLayout();
            this.grpMinify.ResumeLayout(false);
            this.grpMinify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.GroupBox grpFiles;
        private System.Windows.Forms.CheckBox chkJs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCss;
        private System.Windows.Forms.ListBox lsFiles;
        private System.Windows.Forms.GroupBox grpMinify;
        private System.Windows.Forms.Button btnMinify;
        private System.Windows.Forms.CheckBox chkBackup;
        private System.Windows.Forms.CheckBox chkMin;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox chkIgnoreErrors;
    }
}

