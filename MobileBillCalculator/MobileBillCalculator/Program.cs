using System;

namespace MobileBillCalculator
{
    public class Program
    {
      

        static void Main(string[] args)
        {
            var calculation = new Calculation();
            calculation.InputDateTime();
            calculation.BillCalculation();
            Console.WriteLine("Total bill " + calculation.TotalBill() + " Taka");

        }
    }
}
