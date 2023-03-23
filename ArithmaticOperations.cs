namespace CSharpProgramming
{
    internal class ArithmaticOperations
    {
        public ArithmaticOperations()
        {
            // Addition
            int payment = 1000;
            int tax = 50;
            int total = payment * tax;
            Console.WriteLine(total);

            // Substraction
            int discount = 100;
            int balance = total - discount;
            Console.WriteLine(balance);

            // Multiplication
            int lenght = 30;
            int height = 60;
            int square = lenght * height;
            Console.WriteLine(square);

            // Divition
            int noOfItems = 5;
            int priceForEachItem = total / noOfItems;
            Console.WriteLine(priceForEachItem);
        }
    }
}
