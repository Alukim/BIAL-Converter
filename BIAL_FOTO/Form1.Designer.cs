namespace BIAL_FOTO
{
    partial class BIAL_PHOTO
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.JedenPlik = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectFile = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.fileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.selectedFilePath = new System.Windows.Forms.Label();
            this.selectedFolderPath = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.TextBox();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.convertFile = new System.Windows.Forms.Button();
            this.convertFolder = new System.Windows.Forms.Button();
            this.fileProgress = new System.Windows.Forms.ProgressBar();
            this.folderProgress = new System.Windows.Forms.ProgressBar();
            this.Tab.SuspendLayout();
            this.JedenPlik.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.JedenPlik);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.MinimumSize = new System.Drawing.Size(560, 440);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(678, 544);
            this.Tab.TabIndex = 0;
            // 
            // JedenPlik
            // 
            this.JedenPlik.Controls.Add(this.groupBox2);
            this.JedenPlik.Controls.Add(this.groupBox1);
            this.JedenPlik.Location = new System.Drawing.Point(4, 29);
            this.JedenPlik.Name = "JedenPlik";
            this.JedenPlik.Padding = new System.Windows.Forms.Padding(3);
            this.JedenPlik.Size = new System.Drawing.Size(670, 511);
            this.JedenPlik.TabIndex = 0;
            this.JedenPlik.Text = "Wgrywanie";
            this.JedenPlik.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.folderProgress);
            this.groupBox2.Controls.Add(this.convertFolder);
            this.groupBox2.Controls.Add(this.folderPath);
            this.groupBox2.Controls.Add(this.selectedFolderPath);
            this.groupBox2.Controls.Add(this.selectFolder);
            this.groupBox2.Location = new System.Drawing.Point(339, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 497);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CałyFolder";
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(7, 26);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(310, 48);
            this.selectFolder.TabIndex = 1;
            this.selectFolder.Text = "Wybierz folder";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fileProgress);
            this.groupBox1.Controls.Add(this.convertFile);
            this.groupBox1.Controls.Add(this.filePath);
            this.groupBox1.Controls.Add(this.selectedFilePath);
            this.groupBox1.Controls.Add(this.selectFile);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 497);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JedenPlik";
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(7, 26);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(310, 48);
            this.selectFile.TabIndex = 0;
            this.selectFile.Text = "Wybierz plik";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // fileBrowser
            // 
            this.fileBrowser.FileName = "fileBrowser";
            this.fileBrowser.Filter = "Image files (*.jpg,) | *.jpg;";
            this.fileBrowser.FileOk += new System.ComponentModel.CancelEventHandler(this.selectFile_Selected);
            // 
            // selectedFilePath
            // 
            this.selectedFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedFilePath.AutoSize = true;
            this.selectedFilePath.Location = new System.Drawing.Point(133, 123);
            this.selectedFilePath.Name = "selectedFilePath";
            this.selectedFilePath.Size = new System.Drawing.Size(69, 20);
            this.selectedFilePath.TabIndex = 1;
            this.selectedFilePath.Text = "Ścieżka ";
            // 
            // selectedFolderPath
            // 
            this.selectedFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedFolderPath.AutoSize = true;
            this.selectedFolderPath.Location = new System.Drawing.Point(132, 123);
            this.selectedFolderPath.Name = "selectedFolderPath";
            this.selectedFolderPath.Size = new System.Drawing.Size(65, 20);
            this.selectedFolderPath.TabIndex = 2;
            this.selectedFolderPath.Text = "Ścieżka";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(7, 165);
            this.filePath.Multiline = true;
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(310, 142);
            this.filePath.TabIndex = 2;
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(7, 165);
            this.folderPath.Multiline = true;
            this.folderPath.Name = "folderPath";
            this.folderPath.ReadOnly = true;
            this.folderPath.Size = new System.Drawing.Size(310, 142);
            this.folderPath.TabIndex = 3;
            // 
            // convertFile
            // 
            this.convertFile.Enabled = false;
            this.convertFile.Location = new System.Drawing.Point(7, 373);
            this.convertFile.Name = "convertFile";
            this.convertFile.Size = new System.Drawing.Size(310, 48);
            this.convertFile.TabIndex = 3;
            this.convertFile.Text = "Konwertuj plik";
            this.convertFile.UseVisualStyleBackColor = true;
            this.convertFile.Click += new System.EventHandler(this.convertFile_Click);
            // 
            // convertFolder
            // 
            this.convertFolder.Enabled = false;
            this.convertFolder.Location = new System.Drawing.Point(6, 373);
            this.convertFolder.Name = "convertFolder";
            this.convertFolder.Size = new System.Drawing.Size(310, 48);
            this.convertFolder.TabIndex = 4;
            this.convertFolder.Text = "Konwertuj folder";
            this.convertFolder.UseVisualStyleBackColor = true;
            this.convertFolder.Click += new System.EventHandler(this.convertFolder_Click);
            // 
            // fileProgress
            // 
            this.fileProgress.Location = new System.Drawing.Point(7, 443);
            this.fileProgress.Maximum = 1000;
            this.fileProgress.Name = "fileProgress";
            this.fileProgress.Size = new System.Drawing.Size(310, 39);
            this.fileProgress.TabIndex = 4;
            // 
            // folderProgress
            // 
            this.folderProgress.Location = new System.Drawing.Point(6, 443);
            this.folderProgress.Maximum = 1000;
            this.folderProgress.Name = "folderProgress";
            this.folderProgress.Size = new System.Drawing.Size(310, 39);
            this.folderProgress.TabIndex = 5;
            // 
            // BIAL_PHOTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 544);
            this.Controls.Add(this.Tab);
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "BIAL_PHOTO";
            this.Text = "BIAL_PHOTO";
            this.Tab.ResumeLayout(false);
            this.JedenPlik.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage JedenPlik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.OpenFileDialog fileBrowser;
        private System.Windows.Forms.Label selectedFolderPath;
        private System.Windows.Forms.Label selectedFilePath;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.ProgressBar folderProgress;
        private System.Windows.Forms.Button convertFolder;
        private System.Windows.Forms.ProgressBar fileProgress;
        private System.Windows.Forms.Button convertFile;
    }
}

