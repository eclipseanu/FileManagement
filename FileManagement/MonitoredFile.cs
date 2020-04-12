using System.IO;

namespace FileManagement
{
    public class MonitoredFile
    {
    
        public void Check()
        {
            Exists = File.Exists(Path);
        }

        public string Path { get; set; }
        public bool Exists { get; set; }
    }
}