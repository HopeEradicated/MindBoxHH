using System;
using hh.shapeLib;

namespace hh.test {
    [TestClass]
    public class UnitTest {
        [TestMethod]
        public void CircleClassTest() {
            Circle circle = new Circle(6);

            double expected = 113.1;
            double actual = circle.Square();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleClassTest() {
            Triangle triangle = new Triangle(3, 4, 5);

            double expected = 6;
            double actual = triangle.Square();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isRectangleTest() {
            Triangle triangle = new Triangle(3, 4, 5);

            bool actual = triangle.IsRight();

            Assert.IsTrue(actual);
        }
    }
}
