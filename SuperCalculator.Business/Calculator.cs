namespace SuperCalculator.Business
{
    public class Calculator : ICalculator // BLL SRP
    {
        public int FindSum(int fno, int sno) // BL Code SRP
        {
            // BL Code
            // Rules: find sum for only +ve, non Zero and Even numbers only otherwise throw exp

            if (fno < 0 && sno < 0)
            {
                throw new NegetiveInputException("Provide only +ve input");
            }

            if (fno == 0 || sno == 0)
            {
                throw new ZeroInputException("Provide only non zero input");
            }

            if (fno % 2 != 0 || sno % 2 != 0)
            {
                throw new NonEvenInputException("Provide only even number input");
            }

            return fno + sno;
        }
    }
} // BLL