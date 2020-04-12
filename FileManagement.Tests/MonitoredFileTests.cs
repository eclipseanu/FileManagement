using FluentAssertions;
using NUnit.Framework;

namespace FileManagement.Tests
{
    [TestFixture]
    public class MonitoredFileTests
    {
        public string EXISTING_RELATIVE_FILE_PATH = @"C:\Users\Jason Storey\Desktop\GITHUB\FileManagement\ExampleDirectory\ExampleFile.txt";

        private MonitoredFile _file;
        [SetUp]
        public void Setup() => _file = new MonitoredFile();

        [Test]
        public void Checking_Unassigned_File_Should_Not_Exist()
        {
            _file.Check();
            _file.Exists.Should().BeFalse();
            
        }

        [Test]
        public void Checking_Existing_File_Should_Exist()
        {
            _file.Path = EXISTING_RELATIVE_FILE_PATH;
            _file.Check();
            
            _file.Path.Should().Be(EXISTING_RELATIVE_FILE_PATH);
            _file.Exists.Should().BeTrue();
        }
        
    }
}