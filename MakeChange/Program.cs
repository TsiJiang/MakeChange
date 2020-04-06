﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalAmt = GetTotal();
            double paidAmt = GetAmountPaid();
            GetChange(totalAmt, paidAmt);


        }
        static double GetTotal()
        {
            Console.Write("Total Cost: ");
            double totalAmt = double.Parse(Console.ReadLine());
            return totalAmt;
        }
        static double GetAmountPaid()
        {
            Console.Write("Tender Paid: ");
            double paidAmt = double.Parse(Console.ReadLine());
            return paidAmt;
        }
        static void GetChange(double paidAmt, double totalAmt)
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
            changeDue %= 0.01;
            Console.WriteLine($"{pennyCoin} penn(y/ies) due.");
        }
    }
}
