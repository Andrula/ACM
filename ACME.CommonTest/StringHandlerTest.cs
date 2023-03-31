using ACME.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACME.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InputAlreadyHasSpaces()
        {
            //Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    } 
}
