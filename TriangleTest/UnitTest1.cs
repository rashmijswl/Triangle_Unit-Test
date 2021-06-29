using NUnit.Framework;
using Triangle_Assignment2;

namespace TriangleTest
{
    [TestFixture]
    public class UnitTest1
    {
        //TriangleSolver obj = new TriangleSolver();

        [Test]
        public void TriangleTest_NotaTriangle1()
        {
            int a = 5, b = 5, c = 10; //arrange
            string result = TriangleSolver.Analyze(a, b, c); //act
            Assert.AreEqual(result, "Not a Triangle"); //assert
        }

        [Test]
        public void TriangleTest_NotaTriangle2()
        {
            int a = 3, b = 0, c = 1; //arrange
            string result = TriangleSolver.Analyze(a, b, c); //act
            Assert.AreEqual(result, "Not a Triangle"); //assert
        }

        [Test]
        public void TriangleTest_Scalene1()
        {
            int a = 5, b = 6, c = 10; //arrange
            string result = TriangleSolver.Analyze(a, b, c); //act
            Assert.AreEqual(result, "Scalene"); //assert
        }

        [Test]
        public void TriangleTest_Scalene2()
        {
            int a = 11, b = 5, c = 7; //arrange
            string result = TriangleSolver.Analyze(a, b, c); //act
            Assert.AreEqual(result, "Scalene"); //assert
        }

        [Test]
        public void TriangleTest_Equilateral1()
        {
            int a = 6, b = 6, c = 6; //arrange
            string result = TriangleSolver.Analyze(a, b, c); //act
            Assert.AreEqual(result, "Equilateral"); //assert
        }

        [Test]
        public void TriangleTest_Equilateral2()
        {
            int a = 11, b = 11, c = 11; //arrange
            string result = TriangleSolver.Analyze(a, b, c); //act
            Assert.AreEqual(result, "Equilateral"); //assert
        }

        [Test]
        public void TriangleTest_Isosceles1()
        {
            int a = 6, b = 6, c = 11; //arrange
            string result = TriangleSolver.Analyze(a, b, c); //act
            Assert.AreEqual(result, "Isosceles"); //assert
        }

        [Test]
        public void TriangleTest_Isosceles2()
        {
            int a = 13, b = 13, c = 21; //arrange
            string result = TriangleSolver.Analyze(a, b, c); //act
            Assert.AreEqual(result, "Isosceles"); //assert
        }
    }
}
