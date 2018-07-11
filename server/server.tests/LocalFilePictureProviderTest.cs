using NUnit.Framework;
using server.Pictures;
using System.IO;
using System.Linq;

namespace server.tests
{
    [TestFixture]
    public class LocalFilePictureProviderTest
    {

        [Test]
        public void GetAll_ReturnsValidList()
        {
            var provider = new LocalFilePictureProvider();

            var list = provider.GetAll();
            Assert.NotNull(list);
            Assert.AreEqual(7, list.Count());

            for (var i = 0; i < 7; i++)
            {
                var item = list[i];
                Assert.AreEqual(i + 1, item.Id);
                Assert.AreEqual($"/img/picture{i + 1}.jpg", item.Url);
            }
        }

        [Test]
        public void FilesExists()
        {
            var dir = Directory.GetCurrentDirectory();
            dir = Path.Combine(dir, "static", "img");

            for (var i = 0; i < 7; i++)
            {
                var filename = Path.Combine(dir, $"picture{i + 1}.jpg");
                Assert.True(File.Exists(filename));
            }
        }
    }
}
