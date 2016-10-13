using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace WebMinify
{
    internal class FileSearcher
    {
        public string RootFolder { get; set; }
        public bool IncludeJs { get; set; }            
        public bool IncludeCss { get; set; }

        public BackgroundWorker bw { get; set; }
        public List<string> Result { get; set; } 

        public void Search(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            var files = new List<string>();
            
            if (IncludeJs)
                files.AddRange(
                    Directory.GetFiles(RootFolder, "*.js", SearchOption.AllDirectories));

            bw.ReportProgress(50);

            if (IncludeCss)
                files.AddRange(
                    Directory.GetFiles(RootFolder, "*.css", SearchOption.AllDirectories));

            bw.ReportProgress(100);

            Result = files;
        }
    }
}