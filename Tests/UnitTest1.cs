using Microsoft.VisualStudio.TestTools.UnitTesting;
using DirectoryScanner.Core;
using DirectoryScanner.Core.Struct;
using System.Threading;
using System.Linq;

namespace DirectoryScanner.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var _token = new CancellationTokenSource();

            Scanner scanner = new Scanner(4, @"D:\THIS.PROJECT\WT2JAVA\LABA1", _token.Token);
            scanner.StartProcess();

            Assert.IsTrue(scanner.Root.Childs.Count() == 4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var _token = new CancellationTokenSource();

            Scanner scanner = new Scanner(10, @"D:\THIS.PROJECT", _token.Token);
            scanner.StartProcess();

            Assert.IsTrue(scanner.Root.Childs.Count() == 10 && scanner.Root.Childs.All(x => x is DirectoryNode));
        }


        [TestMethod]
        public void TestMethod3()
        {
            var _token = new CancellationTokenSource();

            Scanner scanner = new Scanner(10, @"D:\KONSPECTI", _token.Token);
            scanner.StartProcess();

            Assert.IsTrue(scanner.Root.Childs.All(x => x is FileNode));
        }
    }

}