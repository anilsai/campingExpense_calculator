using System;
using System.Collections.Generic;
using System.Linq;

namespace ProvincialParks.CampingApp.Infrastructure
{
    public class CampingTrip  //returns expense deatils
    {
        public int NumberOfPeople { get; private set; }
        public IList<Expense> Expenses { get; set; }
        public decimal TotalExpenses
        {
            get
            {
                return GetTotalExpenses();
            }
        }

        public CampingTrip (int numberOfPeople)
        {
            NumberOfPeople = numberOfPeople;
            Expenses = new List<Expense>();
        }

        private decimal GetTotalExpenses()
        {
            return Expenses.Sum(x => x.Amount);       
        }

        private decimal GetAverageExpenses()
        {
            return GetTotalExpenses() / NumberOfPeople;
        }

        private decimal GetExpensesPaidPerPerson(int personID)
        {
            return Expenses.Where(x => x.PersonID == personID).Sum(s => s.Amount);
        }

        public decimal GetAmountOwedPerPerson(int personID)
        {
            return decimal.Round(GetAverageExpenses()-GetExpensesPaidPerPerson(personID), 2, MidpointRounding.AwayFromZero);
        }
    }
}
