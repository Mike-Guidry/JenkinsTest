using System;
using System.Collections.Generic;
using System.Text;
using JenkinsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsAppTests
{
    [TestClass]
    public class LittleClassTests
    {
        [TestMethod]
        public void LittleMethod_ReturnsLittle()
        {
            var sut = new LittleClass();

            string result = sut.LittleMethod();

            Assert.AreEqual("little", result);

        }

        [TestMethod]
        public void LittleMethod_ReturnsBig()
        {
            var sut = new LittleClass();

            string result = sut.LittleMethod();

            Assert.AreEqual("Big", result);

        }
    }
}
