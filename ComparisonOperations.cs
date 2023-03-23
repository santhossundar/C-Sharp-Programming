namespace CSharpProgramming
{
    internal class ComparisonOperations
    {
        public ComparisonOperations() 
        {
            int x = 5, y = 10;

            bool greaterThan = x > y;
            Console.WriteLine(greaterThan);

            bool greaterThanOrEqual = x >= y;
            Console.WriteLine(greaterThanOrEqual);

            bool lessThan = x < y;
            Console.WriteLine(lessThan);

            bool lessThanOrEqual = x <= y;
            Console.WriteLine(lessThanOrEqual);

            bool equalTo = x == y;
            Console.WriteLine(equalTo);

            bool notEqual = x != y;
            Console.WriteLine(notEqual);

        }
    }
}
