using System;
using System.IO;
using Yahoo.Yui.Compressor;

namespace WebMinify
{
    internal class Compressor<T> where T : ICompressor, new()
    {
        public static string Minify(string file, bool saveToFile, out string oldcontents, out string error)
        {
            var fileContents = File.ReadAllText(file);

            oldcontents = fileContents;
            error = "";

            if (string.IsNullOrWhiteSpace(fileContents))
                return "";

            var compressor = new T();

            string minified = "";

            try
            {
                minified = compressor.Compress(fileContents);
            }
            catch (Exception ex)
            {
                error = $"Error while processing file {file}\n\nError: {ex.Message}";
                return "";
            }

            if (saveToFile)
                File.WriteAllText(file, minified);

            return minified;
        }
    }
}