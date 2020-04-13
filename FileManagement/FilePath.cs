using System;
using System.IO;
using System.Linq;

namespace FileManagement
{
    public class FilePath
    {
        public static string ApplicationRunningDirectory => AppDomain.CurrentDomain.BaseDirectory;

        public static string BackXDirectories(int amount, string path)
        {
            if (amount <= 0) return path;
            var backup = string.Concat(Enumerable.Repeat(@"..\",amount));
            return Path.GetFullPath(Path.Combine(path, backup)).TrimEnd('\\');
        }
    }
}