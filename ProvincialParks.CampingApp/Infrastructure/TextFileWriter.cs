using System;
using System.Collections.Generic;
using System.IO;

namespace ProvincialParks.CampingApp.Infrastructure
{
    
    public class TextFileWriter //writes expenses to an output file
    {
        private string FileName { get; set; }

        public TextFileWriter(string fileName)
        {
            FileName = fileName;
        }

        public void WriteFile(List<CampingTrip> trips)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), @"InputOutput\" + FileName + ".out");
            using (TextWriter tw = new StreamWriter(path))
            {
                foreach (CampingTrip trip in trips)
                {
                    WritePesonExpense(trip, tw);
                    tw.WriteLine("");
                }
            }
        }

        private void WritePesonExpense(CampingTrip trip, TextWriter tw)
        {
            for (var person = 1; person <= trip.NumberOfPeople; person++)
            {
                tw.WriteLine(trip.GetAmountOwedPerPerson(person) > 0 ? "$" + trip.GetAmountOwedPerPerson(person).ToString() : string.Format("(${0})", Math.Abs(trip.GetAmountOwedPerPerson(person)).ToString()));
                Console.WriteLine(trip.GetAmountOwedPerPerson(person) > 0 ? "$" + trip.GetAmountOwedPerPerson(person).ToString() : string.Format("(${0})", Math.Abs(trip.GetAmountOwedPerPerson(person)).ToString()));
            }
        }
    }
}
