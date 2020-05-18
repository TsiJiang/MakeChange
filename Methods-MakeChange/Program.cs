using System;

namespace MakeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            //double totalAmt = GetTotal(); //calling statement for getting single user input "totalAmt" (Item 1)
            //double paidAmt = GetAmountPaid(); //calling statement for getting single user input "paidAmt" (Item 2)
            double totalAmt = GetUserInput("Total Cost: "); //calling single method for both user inputs (Item 4)
            double paidAmt = GetUserInput("Tender Paid: "); //calling single method for both user inputs (Item 4)
            //GetChange(totalAmt, paidAmt); //call statement for item 3
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
        static double GetTotal() //method for getting total cost (item 1)
        {
            Console.Write("Total Cost: ");
            double totalAmt = double.Parse(Console.ReadLine());
            return totalAmt;
        }
        static double GetAmountPaid() // method for getting amount paid (item 2)
        {
            Console.Write("Tender Paid: ");
            double paidAmt = double.Parse(Console.ReadLine());
            return paidAmt;
        }
        static void GetChange(double totalAmt, double paidAmt) //method for calculating change and printing all change (item 3)
        {
            double changeDue = paidAmt - totalAmt;
            Console.WriteLine($"Tender Due: ${changeDue}");
            changeDue += 0.00001;
            int twentyDollar = (int)(changeDue / 20);
            changeDue %= 20;
            Console.WriteLine($"{twentyDollar} twenty dollar bill(s) due.");
            int tenDollar = (int)(changeDue / 10);
            changeDue %= 10;
            Console.WriteLine($"{tenDollar} ten dollar bill(s) due.");
            int fiveDollar = (int)(changeDue / 5);
            changeDue %= 5;
            Console.WriteLine($"{fiveDollar} five dollar bill(s) due.");
            int oneDollar = (int)(changeDue / 1);
            changeDue %= 1;
            Console.WriteLine($"{oneDollar} one dollar bill(s) due.");
            int quarterCoin = (int)(changeDue / 0.25);
            changeDue %= 0.25;
            Console.WriteLine($"{quarterCoin} quarter(s) due.");
            int dimeCoin = (int)(changeDue / 0.10);
            changeDue %= 0.10;
            Console.WriteLine($"{dimeCoin} dime(s) due.");
            int nickleCoin = (int)(changeDue / 0.05);
            changeDue %= 0.05;
            Console.WriteLine($"{nickleCoin} nickle(s) due.");
            int pennyCoin = (int)(changeDue / 0.01);
            Console.WriteLine($"{pennyCoin} penn(y/ies) due.");
        }
        static double GetUserInput(string strQuestion) //single method for asking for both user inputs (item 4)
        {
            Console.Write(strQuestion);
            double userInput = double.Parse(Console.ReadLine());
            return userInput;
        }
        static double MakeChange(double currency, double changeDue) //single statement for calculating and printing different denominations (item 5)
        {
            double changePaid = 0.0;
            int denomination = (int)(changeDue / currency);
            changePaid = denomination * currency;
            Console.WriteLine($"{denomination} ${currency} currency due.");
            return changePaid;
        }
    }
}
