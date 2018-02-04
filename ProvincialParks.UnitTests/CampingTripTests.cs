using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProvincialParks.CampingApp.Infrastructure;

namespace ProvincialParks.UnitTests
{
    [TestClass]
    public class CampingTripTests
    {
        [TestMethod]
        public void TotalExpenses_ShouldReturnTotalPerTrip_WhenValuesInList()
        {
            //act
            var campingTrip = new CampingTrip(2);
            campingTrip.Expenses.Add(new Expense(1, 1.04m));
            campingTrip.Expenses.Add(new Expense(1, 5m));
            campingTrip.Expenses.Add(new Expense(2, 3m));
            campingTrip.Expenses.Add(new Expense(2, 132m));

            //assert
            Assert.AreEqual(campingTrip.NumberOfPeople, 2);
            Assert.AreEqual(campingTrip.TotalExpenses, 141.04m);
        }

        [TestMethod]
        public void GetAmountOwedPerPerson_ShouldReturnTotalOwedByPerson_WhenValuesInList()
        {
            //act
            var campingTrip = new CampingTrip(3);
            campingTrip.Expenses.Add(new Expense(1, 20m));
            campingTrip.Expenses.Add(new Expense(1, 20m));
            campingTrip.Expenses.Add(new Expense(2, 5m));
            campingTrip.Expenses.Add(new Expense(2, 18.81m));
            campingTrip.Expenses.Add(new Expense(2, 6m));
            campingTrip.Expenses.Add(new Expense(2, 2.61m));
            campingTrip.Expenses.Add(new Expense(3, 9m));
            campingTrip.Expenses.Add(new Expense(3, 7m));
            campingTrip.Expenses.Add(new Expense(3, 4.05m));

            //assert
            Assert.AreEqual(campingTrip.NumberOfPeople, 3);
            Assert.AreEqual(campingTrip.GetAmountOwedPerPerson(1), -9.18m);
            Assert.AreEqual(campingTrip.GetAmountOwedPerPerson(2), -1.6m);
            Assert.AreEqual(campingTrip.GetAmountOwedPerPerson(3), 10.77m);
        }
    }
}
