using System;

namespace MakeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalAmt = 0.0000001;
            double paidAmt = 0;
            while (paidAmt < totalAmt)
            {
                totalAmt = GetUserInput("Total Cost: ");
                paidAmt = GetUserInput("Tender Paid: ");
                if (paidAmt < totalAmt)
                {
                    Console.WriteLine("The Customer has given you too little or you have input the incorrect value for the amount given.");
                }
            }
            if (paidAmt == totalAmt)
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
                if (changeDue > 0 && changeDue < 0.01) { changeDue = 0.01; }
                currency = 0.01;
                MakeChange(currency, changeDue);
            }
        }

        static double GetUserInput(string strQuestion)
        {
            double userInput = 0;
            while (userInput <= 0)
            {
                Console.Write(strQuestion);
                userInput = double.Parse(Console.ReadLine());
            }
            return userInput;
        }
        static double MakeChange(double currency, double changeDue)
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
