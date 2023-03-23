namespace CSharpProgramming
{
    internal class LogicalOperators
    {
        public LogicalOperators() 
        {
            int x = 3, y = 9;
            float p = 1.2f, q = 6.3f;

            bool logicalAND = x > y && p < q;
            Console.WriteLine(logicalAND);

            bool logicalOR = x < y || p > q;
            Console.WriteLine(logicalOR);

            bool logicalNot = !(x < y);
            Console.WriteLine(logicalNot);
        }
    }
}
