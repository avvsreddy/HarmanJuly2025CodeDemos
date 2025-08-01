namespace SuperCalculator.Business
{
    public class Calculator : ICalculator // BLL SRP
    {
        public int FindSum(int fno, int sno) // BL Code SRP
        {
            // BL Code
            return fno + sno;
        }
    }
} // BLL