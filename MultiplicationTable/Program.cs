using System;


namespace MultiplicationTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number;
            Mulitiplication multi = new Mulitiplication();
            Console.WriteLine("Display Prime Multiplication Table : ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("\n\n");

            Console.WriteLine("Number? ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            multi.MultiplicationTable(number);
            Console.ReadLine();
        }     
    }
}
