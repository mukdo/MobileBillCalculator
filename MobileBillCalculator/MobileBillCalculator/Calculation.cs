using System;
using System.Collections.Generic;
using System.Text;

namespace MobileBillCalculator
{
    public class Calculation
    {
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        private DateTime GetDate { get; set; }
        private DateTime Overlap { get; set; }
        public float Bill { get; set; }
        readonly int peakHourRate;
        readonly int offPeakHourRate;

        public Calculation()
        {
            peakHourRate = 30;
            offPeakHourRate = 20;
        }

        public void InputDateTime()
        {
            Console.WriteLine("Start Time:");
            StartingTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("End Time:");
            EndingTime = DateTime.Parse(Console.ReadLine());
        }

        public void BillCalculation()
        {
            Bill = 0;   
            GetDate = StartingTime.Date;
            Overlap = GetDate.AddHours(9);

            while (StartingTime <= EndingTime)
            {
                if ((StartingTime.Hour >= 9 && StartingTime.Minute >= 0 && StartingTime.Second >= 0) && (StartingTime.Hour <= 22 && StartingTime.Minute <= 59 && StartingTime.Second <= 59))
                {
                    Bill = Bill + peakHourRate;
                    StartingTime = StartingTime.AddSeconds(20);
                }

                else if ((StartingTime.Hour >= 0 && StartingTime.Minute >= 0 && StartingTime.Second >= 0) && (StartingTime.Hour <= 8 && StartingTime.Minute <= 59 && StartingTime.Second <= 59))
                {
                    if (StartingTime.AddSeconds(20) >= Overlap)
                    {
                        Bill = Bill + peakHourRate;

                    }
                    else
                    {
                        Bill = Bill + offPeakHourRate;

                    }

                    StartingTime = StartingTime.AddSeconds(20);
                }

                else if ((StartingTime.Hour >= 23 && StartingTime.Minute >= 0 && StartingTime.Second >= 0) && (StartingTime.Hour <= 23 && StartingTime.Minute <= 59 && StartingTime.Second <= 59))
                {
                    Bill = Bill + offPeakHourRate; ;
                    StartingTime = StartingTime.AddSeconds(20);
                }

                else
                {
                    Console.WriteLine("Sorry Formate not ok ");

                }
            }

        }

        public float TotalBill()
        {
            Bill = Bill / 100;
            return Bill;
        }
    }
}
