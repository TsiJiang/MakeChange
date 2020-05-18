using System;

namespace MakeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalAmt = GetUserInput("Total Cost: ");
            double paidAmt = GetUserInput("Tender Paid: ");
            if (paidAmt < totalAmt)
            {
                Console.WriteLine("The Customer has given you too little or you have input the incorrect value for the amount given.");
            }
            else if (paidAmt == totalAmt)
            {
                Console.WriteLine("No change due.");
            }
            else if (paidAmt != totalAmt && paidAmt > totalAmt)
            {
                double currency = 20.00;
                double changeDue = paidAmt - totalAmt;
                double changePaid = MakeChange(currency, changeDue);
                changeDue -= changePaid;
                currency = 10.00;
                changePaid = MakeChange(currency, changeDue);
                changeDue -= changePaid;
                currency = 5.00;
                changePaid = MakeChange(currency, changeDue);
                changeDue -= changePaid;
                currency = 1.00;
                changePaid = MakeChange(currency, changeDue);
                changeDue -= changePaid;
                currency = 0.25;
                changePaid = MakeChange(currency, changeDue);
                changeDue -= changePaid;
                currency = 0.10;
                changePaid = MakeChange(currency, changeDue);
                changeDue -= changePaid;
                currency = 0.05;
                changePaid = MakeChange(currency, changeDue);
                changeDue -= changePaid;
                if (changeDue > 0 && changeDue < 0.01) { changeDue = 0.01; } //catch statement for computational error (just extra because it annoyed me)
                currency = 0.01;
                MakeChange(currency, changeDue);
            }
            
        }
        static double GetUserInput(string strQuestion)
        {
            Console.Write(strQuestion);
            double userInput = double.Parse(Console.ReadLine());
            return userInput;
        }

        static double MakeChange(double currency, double changeDue) //single statement for calculating and printing different denominations (item 5)
        {
            int denomination = (int)(changeDue / currency);
            double changePaid = denomination * currency;
            if (denomination > 0)
            {
                Console.WriteLine($"{denomination} ${currency} currency due.");
            }
            return changePaid;
        }
    }
}
