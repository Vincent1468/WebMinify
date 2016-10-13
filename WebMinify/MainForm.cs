using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace WebMinify
{
    public partial class MainForm : Form
    {
        private FileProcessor _fileProcessor;
        private BackgroundWorker _fileSearcWorker;
        private BackgroundWorker _minifyWorker;
        private string RootFolderName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            _fileProcessor = new FileProcessor();
           
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if ( (_fileSearcWorker != null &&_fileSearcWorker.IsBusy) || (_minifyWorker != null && _minifyWorker.IsBusy))
                return;

            var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            
            if (!string.IsNullOrWhiteSpace(dialog.SelectedPath))
            {
                var searcher = new FileSearcher
                {
                    RootFolder = dialog.SelectedPath,
                    IncludeCss = chkCss.Checked,
                    IncludeJs = chkJs.Checked        
                };

                // Get the folder name of the root directory
                RootFolderName = dialog.SelectedPath.Replace(Path.GetDirectoryName(dialog.SelectedPath), "");

                while (RootFolderName.StartsWith(@"\"))
                    RootFolderName = RootFolderName.Substring(1, RootFolderName.Length - 1);

                if (_fileSearcWorker != null)
                {
                    _fileSearcWorker.RunWorkerAsync();
                    return;
                }
                
                _fileSearcWorker = new BackgroundWorker()
                {
                    WorkerReportsProgress = true
                };
                
                _fileSearcWorker.DoWork += searcher.Search;

                _fileSearcWorker.ProgressChanged += delegate(object s, ProgressChangedEventArgs status)
                {
                    progressBar.Value = status.ProgressPercentage;
                };

                _fileSearcWorker.RunWorkerCompleted += delegate(object s, RunWorkerCompletedEventArgs status)
                {
                    lsFiles.DataSource = searcher.Result;

                    progressBar.Value = 0;
                };

                searcher.bw = _fileSearcWorker;

                _fileSearcWorker.RunWorkerAsync();

            }

        }
        
        private void btnMinify_Click(object sender, EventArgs e)
        {
            if (lsFiles.Items.Count == 0 || (_fileSearcWorker != null && _fileSearcWorker.IsBusy) || (_minifyWorker != null && _minifyWorker.IsBusy))
                return;

            _fileProcessor.FileList = (List<string>) lsFiles.DataSource;
            _fileProcessor.CreateBackup = chkBackup.Checked;
            _fileProcessor.SaveAsMin = chkMin.Checked;
            _fileProcessor.IgnoreErrors = chkIgnoreErrors.Checked;
            _fileProcessor.BackupRootFolder = RootFolderName;

            if (_minifyWorker != null)
            {
                _minifyWorker.RunWorkerAsync();
                return;
            }

            _minifyWorker = new BackgroundWorker()
            {
                WorkerReportsProgress = true
            };

            _fileProcessor.Worker = _minifyWorker;

            _minifyWorker.DoWork += _fileProcessor.Process;

            _minifyWorker.ProgressChanged += delegate (object s, ProgressChangedEventArgs status)
            {
                progressBar.Value = status.ProgressPercentage;
            };

            _minifyWorker.RunWorkerCompleted += delegate (object s, RunWorkerCompletedEventArgs status)
            {
                MessageBox.Show("All files have been minified", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                progressBar.Value = 0;
            };

            _minifyWorker.RunWorkerAsync();
        }


    }
}