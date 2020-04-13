using FluentAssertions;
using NUnit.Framework;

namespace FileManagement.Tests
{
    [TestFixture]
    public class FilePathTests
    {
        private const string THIS_COMPUTER_PROJECT_RUNNING_LOCATION = @"C:\Users\Jason Storey\Desktop\GITHUB\FileManagement\FileManagement.Tests\bin\Debug";
        private const string THIS_COMPUTER_PROJECT_MAIN_DIRECTORY = @"C:\Users\Jason Storey\Desktop\GITHUB\FileManagement";
        private const string THIS_COMPUTER_RUNNING_DRIVE = @"C:";

        [Test]
        public void This_Computer_Running_Directory()
        {
            var here = FilePath.ApplicationRunningDirectory;
            here.Should().Be(THIS_COMPUTER_PROJECT_RUNNING_LOCATION);
        }

        [Test]
        public void Back_X_Directories()
        {
            var projectMainFolder = FilePath.BackXDirectories(3, FilePath.ApplicationRunningDirectory);
            projectMainFolder.Should().Be(THIS_COMPUTER_PROJECT_MAIN_DIRECTORY);
        }

        [Test]
        public void Back_Negative_Directories()
        {
            var newDir = FilePath.BackXDirectories(-50, THIS_COMPUTER_PROJECT_MAIN_DIRECTORY);
            newDir.Should().Be(THIS_COMPUTER_PROJECT_MAIN_DIRECTORY);
        }

        [Test]
        public void Back_Too_Many_Directories_Returns_Root()
        {
            var newDir = FilePath.BackXDirectories(100, THIS_COMPUTER_PROJECT_MAIN_DIRECTORY);
            newDir.Should().Be(THIS_COMPUTER_RUNNING_DRIVE);
        }








    }
}