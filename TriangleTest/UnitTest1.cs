using NUnit.Framework;
using Triangle_Assignment2;

namespace TriangleTest
{
    [TestFixture]
    public class UnitTest1
    {
        TriangleSolver obj = new TriangleSolver();
        [Test]
        public void TriangleTest_NotaTriangle()
        {
            int a = 5, b = 5, c = 10; //arrange
            string result = obj.Analyze(a, b, c); //act
            Assert.AreEqual(result, "Not a Triangle"); //assert
        }

        [Test]
        public void TriangleTest_Scalene()
        {
            int a = 5, b = 6, c = 10; //arrange
            string result = obj.Analyze(a, b, c); //act
            Assert.AreEqual(result, "Scalene"); //assert
        }

        [Test]
        public void TriangleTest_Equilateral()
        {
            int a = 6, b = 6, c = 6; //arrange
            string result = obj.Analyze(a, b, c); //act
            Assert.AreEqual(result, "Equilateral"); //assert
        }

        [Test]
        public void TriangleTest_Isosceles()
        {
            int a = 6, b = 6, c = 11; //arrange
            string result = obj.Analyze(a, b, c); //act
            Assert.AreEqual(result, "Isosceles"); //assert
        }
    }
}
