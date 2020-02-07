using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Assignment01.Tests
{
    [TestFixture]
    public class RectangleTest
    {
        [SetUp]
        public void SetUp()
        {
            Rectangle rect = new Rectangle();
        }

        /* Test for the GetLength() funtion
         * giving 1 and expecting 1, otherwise fails
         */
        [Test]
        public void Get_Length1_Expect1()
        {
            Rectangle rect = new Rectangle();
            Assert.AreEqual(1, rect.GetLength(), 1);
        }

        /* Test for the GetWidth() funtion
         * giving 1 and expecting 1, otherwise fails
         */
        [Test]
        public void Get_Width1_Expect1()
        {
            Rectangle rect = new Rectangle();
            Assert.AreEqual(1, rect.GetWidth(), 1);
        }

        /* Test for the SetLength() funtion
         * giving 2 and expecting 2, otherwise fails
         */
        [Test]
        public void Set_Length2_Expect2()
        {
            Rectangle rect = new Rectangle();
            Assert.AreEqual(2, rect.SetLength(2), 0);
        }

        /* Test for the SetWidth() funtion
         * giving 2 and expecting 2, otherwise fails
         */
        [Test]
        public void Set_Width2_Expect2()
        {
            Rectangle rect = new Rectangle();
            Assert.AreEqual(2, rect.SetWidth(2), 0);
        }

        /* Test for the GetPerimeter() funtion
         * giving (2,2) and expecting 8, otherwise fails
         */
        [Test]
        public void Get_Perimeter8_Expect8()
        {
            Rectangle rect = new Rectangle(2, 2);
            Assert.AreEqual(8, rect.GetPerimeter(), 0);
        }

        /* Test for the GetArea() funtion
         * giving (2,2) and expecting 4, otherwise fails
         */
        [Test]
        public void Get_Area4_Expect4()
        {
            Rectangle rect = new Rectangle(2, 2);
            Assert.AreEqual(4, rect.GetArea(), 0);
        }
    }
}
