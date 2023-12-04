using WindowsFormsApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateVertex_Test()
        {
            var vert = new Vertex();
        }

        [TestMethod]
        public void ChangeColor_Test()
        {
            var vert = new Vertex();
            vert.changeColor("Red");
            string test = vert.Color;
            Assert.AreEqual("Red", test);
        }
    }
}
