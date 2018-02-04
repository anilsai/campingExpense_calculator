namespace ProvincialParks.CampingApp.Infrastructure
{
    
    public class Expense // sigle expense
    {
        public int PersonID {get; private set;}
        public decimal Amount { get; private set; }

        public Expense (int personID, decimal amount)
        {
            PersonID = personID;
            Amount = amount;
        }
    }
}
