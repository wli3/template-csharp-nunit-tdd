using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace ClassLibrary1Tests
{

    [TestFixture]
    public class Class1Test
    {
        [Test]
        public void Function1_should_return_1()
        {
            // Arrange
            var sut = new Class1();
            // Act
            var result = sut.Function1();
            // Assert
            Assert.AreEqual(1, result);
        }
    }
}
