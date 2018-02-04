using System;
using ProvincialParks.CampingApp.Infrastructure;

namespace ProvincialParks.CampingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFileReader fileReader = new TextFileReader();
            CampingTripExpenseCalculator expenseCalculator = new CampingTripExpenseCalculator(fileReader);

            Console.WriteLine("Enter Filename");
            var lineRead = Console.ReadLine();
            if (!string.IsNullOrEmpty(lineRead))
            {
                expenseCalculator.CalculateExpenses(lineRead);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Filename Entered");
            }
        }
    }
}
