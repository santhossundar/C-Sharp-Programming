namespace CSharpProgramming
{
    internal class Conversions
    {
        public Conversions() 
        {
            // Implicit conversion
            int intNumber = 120;
            Console.WriteLine(intNumber.GetType());

            long intNumberToLongNumber = intNumber;
            Console.WriteLine(intNumberToLongNumber);
            Console.WriteLine(intNumberToLongNumber.GetType());

            // Explicit conversion
            float floatNumber = 3.145f;
            Console.WriteLine(floatNumber.GetType());

            int floatNumberToIntNumber = (int)floatNumber;
            Console.WriteLine(floatNumberToIntNumber); 
            Console.WriteLine(floatNumberToIntNumber.GetType());

            // Type conversion
            int num = 1100;
            string numToString = num.ToString();
            Console.WriteLine(numToString);
            Console.WriteLine(numToString.GetType());
        }
    }
}
