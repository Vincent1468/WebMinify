using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Yahoo.Yui.Compressor;

namespace WebMinify
{
    public class FileProcessor
    {
        public List<string> FileList { get; set; }
        public bool CreateBackup { get; set; }
        public bool SaveAsMin { get; set; }
        public bool IgnoreErrors { get; set; }

        public BackgroundWorker Worker { get; set; }
        public string BackupRootFolder { get; set; }

        // Loop trough file list
        // If css, minify css, if js minify js
        public void Process(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            for (int i = 0; i < FileList.Count; i++)
            {
                string file = FileList[i];

                if (file.EndsWith(".js"))
                {
                    ProcessJs(file);
                }

                if (file.EndsWith(".css"))
                {
                    ProcessCss(file);
                }

                Worker.ReportProgress(GetProgress(i));

            }
        }

        private void ProcessJs(string file)
        {
            string original;
            string error;

            string minified = Compressor<JavaScriptCompressor>.Minify(file, !SaveAsMin, out original, out error);

            if (!string.IsNullOrWhiteSpace(error))
            {
                if (!IgnoreErrors)
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrWhiteSpace(minified))
                return;

            if (CreateBackup)
                BackupFile(file, original);

            if (SaveAsMin)
            {
                file = file.Replace(".js", ".min.js");
                File.WriteAllText(file, minified);
            }

        }

        private void ProcessCss(string file)
        {
            string original;
            string error;

            string minified = Compressor<CssCompressor>.Minify(file, !SaveAsMin, out original, out error);

            if (!string.IsNullOrWhiteSpace(error))
            {
                if (!IgnoreErrors)
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrWhiteSpace(minified))
                return;

            if (CreateBackup)
                BackupFile(file, original);

            if (SaveAsMin)
            {
                file = file.Replace(".css", ".min.css");
                File.WriteAllText(file, minified);
            }
        }

        private void BackupFile(string file, string content)
        {
            string rootPath = Application.StartupPath + @"\Backups\";

            int i = file.IndexOf(BackupRootFolder);

            string backupPath = rootPath + file.Substring(i, file.Length - (i));

            if (!Directory.Exists(Path.GetDirectoryName(backupPath)))
                Directory.CreateDirectory(Path.GetDirectoryName(backupPath));

            File.WriteAllText(backupPath, content);

        }

        private int GetProgress(int currentIndex)
        {
            double p = 100 * currentIndex / FileList.Count;

            return (int)p;
        }

    }
}