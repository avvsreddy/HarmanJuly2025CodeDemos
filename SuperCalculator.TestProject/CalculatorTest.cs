using SuperCalculator.Business;

namespace SuperCalculator.TestProject
{
    [TestClass]
    public sealed class CalculatorTest
    {
        [TestMethod]
        public void SumTest_WithValidInput_ShouldReturnValidResult() // +ve Test case
        {
            // no conditional stmts
            // no looping stmts
            // no exception blocks

            // AAA 
            // A - Arrage
            Calculator target = new Calculator();
            int fno = 10;
            int sno = 20;
            int actual = 0;
            int expected = 30;
            // A - Act
            actual = target.FindSum(fno, sno);
            // A - Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(NegetiveInputException))]
        public void SumTest_WithNegativeInput_ShouldThrowsExp() // -ve Test case
        {
            // no conditional stmts
            // no looping stmts
            // no exception blocks

            // AAA 
            // A - Arrage
            Calculator target = new Calculator();
            //int fno = 10;
            //int sno = 20;
            //int actual = 0;
            //int expected = 30;
            // A - Act
            int actual = target.FindSum(-1, -1);
            // A - Assert
            // Assert.AreEqual(-1 + -1, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(ZeroInputException))]
        public void SumTest_WithZeroInput_ShouldThrowExp()
        {
            Calculator target = new Calculator();
            int actual = target.FindSum(0, 0);
        }
    }
}
