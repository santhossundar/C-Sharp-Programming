namespace CSharpProgramming
{
    internal class UserInputs
    {
        public UserInputs() 
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName + " " + lastName + "!");

            Console.Write("Enter the number: ");
            string number = Console.ReadLine();

            int stringToInt = Int32.Parse(number);
            Console.WriteLine(stringToInt);

            int x = Console.Read();
            Console.WriteLine(x);
        }
    }
}
