using NUnit.Framework;
using ConditionStatements2;

namespace ConditionStatementTests
{
    public class Tests
    {
        [TestCase(5, 6,11)]
        [TestCase(2, 2, 0)]
        [TestCase(-3, -8, -11)]
        [TestCase(-7,-7, 0)]
        public void Task1_ContainsCorrectNumbers(int a, int b, int expected)
        { 
           var (i1, i2) = Tasks.Task1(a, b);

            Assert.AreEqual(expected, i1, "Variable A contains incorrect value.");
            Assert.AreEqual(expected, i2, "Variable B contains incorrect value.");
        }
        
        [TestCase(5, 6, -2, -2)]
        [TestCase(2, 3,8, 2)]
        [TestCase(-8, -1, 0, -8)]
        [TestCase(-5,-9, -2, -9)]
        public void Task2_ReturnsCorrectNumber(int a, int b, int c, int expected)
        {
            var actual = Tasks.Task2(a, b, c);

            Assert.AreEqual(expected, actual, "Task2 returns incorrect value.");
        }
        
        [TestCase(5, 6, 4, 11)]
        [TestCase(-1, 0, 12, 12)]
        [TestCase(20,-10, 7, 27)]
        [TestCase(-5,-7, -11, -12)]
        public void Task3_ReturnsCorrectNumber(int a, int b, int c, int expected)
        {
            var actual = Tasks.Task3(a, b, c);

            Assert.AreEqual(expected, actual, "Task3 returns incorrect value.");
        }
}
}