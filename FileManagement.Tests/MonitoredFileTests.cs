using FluentAssertions;
using NUnit.Framework;

namespace FileManagement.Tests
{
    [TestFixture]
    public class MonitoredFileTests
    {
        public string EXISTING_FILE_PATH = @"C:\Users\jason\Documents\Github\FileManagement\ExampleDirectory";
        [Test]
        public void Check_Non_Existent_File_Does_Not_Throw()
        {
            var file = new MonitoredFile();
            file.Check();
        }

        [Test]
        public void Set_Path()
        {
            var file = new MonitoredFile();
            file.Path = EXISTING_FILE_PATH;
            file.Path.Should().Be(EXISTING_FILE_PATH);
        }
        
    }
}