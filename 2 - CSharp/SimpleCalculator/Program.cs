namespace SimpleCalculator;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Simple Calculator App";
        Console.Write("Hello!\r\nInput the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What do you want to do with those numbers?\r\n[A]dd\r\n[S]ubtract\r\n[M]ultiply");
        var choice = Console.ReadKey();
        switch (choice.KeyChar)
        {
            case 'a' or 'A':
                Console.WriteLine($"\n{num1} + {num2} = {num1 + num2}");
                break;
            case 's' or 'S':
                Console.WriteLine($"\n{num1} - {num2} = {num1 - num2}");
                break;
            case 'm' or 'M':
                Console.WriteLine($"\n{num1} * {num2} = {num1 * num2}");
                break;
            default:
                Console.WriteLine("\nInvalid option");
                break;
        }
        Console.WriteLine("Press any key to close");
        Console.ReadKey();
    }
}