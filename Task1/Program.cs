using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Operators op = new Operators();

            Console.WriteLine("Choose operation: 1-Add 2-Subtract 3-Multiply 4-Divide 5-OddEvenFinder");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    op.Add(12, 15);
                    break;
                case 2:
                    op.Subtract(19, 5);
                    break;
                case 3:
                    op.Multiply(16, 10);
                    break;
                case 4:
                    op.Divide(49, 7);
                    break;
                case 5:
                    op.OddEvenFinder(13);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
