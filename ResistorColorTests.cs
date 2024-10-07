using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace resistor_color.Tests
{
    [TestClass]
    public class ResistorColorTests
    {
        [TestMethod]
        public void TestColorCode_ValidColor()
        {
            Assert.AreEqual(0, ResistorColor.ColorCode("black"));
            Assert.AreEqual(1, ResistorColor.ColorCode("brown"));
            Assert.AreEqual(2, ResistorColor.ColorCode("red"));
            Assert.AreEqual(3, ResistorColor.ColorCode("orange"));
            Assert.AreEqual(4, ResistorColor.ColorCode("yellow"));
            Assert.AreEqual(5, ResistorColor.ColorCode("green"));
            Assert.AreEqual(6, ResistorColor.ColorCode("blue"));
            Assert.AreEqual(7, ResistorColor.ColorCode("violet"));
            Assert.AreEqual(8, ResistorColor.ColorCode("grey"));
            Assert.AreEqual(9, ResistorColor.ColorCode("white"));
        }

        [TestMethod]
        public void TestColorCode_InvalidColor()
        {
            Assert.AreEqual(-1, ResistorColor.ColorCode("pink"));
            Assert.AreEqual(-1, ResistorColor.ColorCode("cyan"));
            Assert.AreEqual(-1, ResistorColor.ColorCode("magenta"));
        }

        [TestMethod]
        public void TestColors()
        {
            CollectionAssert.AreEqual(new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" }, ResistorColor.Colors);
        }
    }
}
