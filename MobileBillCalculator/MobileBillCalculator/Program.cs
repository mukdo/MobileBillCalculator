using System;

namespace MobileBillCalculator
{
    public class Program
    {
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        public float Bill { get; set; }
        public void InputDateTime()
        {
            Console.WriteLine("Start Time:");
            StartingTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("End Time:");
            EndingTime = DateTime.Parse(Console.ReadLine());
        }

        public void Calculation()
        {
            Bill = 0;
            int peakHourRate = 30;
            int offPeakHourRate = 20;

            while (StartingTime <= EndingTime)
            {
                if((StartingTime.Hour >= 9 && StartingTime.Minute>=0 && StartingTime.Second >=0)&& ( EndingTime.Hour<=22 && EndingTime.Minute<=59 && EndingTime.Second<=59) )
                {
                    Bill = Bill + peakHourRate;
                    StartingTime = StartingTime.AddSeconds(20);
                }

                else if ((StartingTime.Hour >= 12 && StartingTime.Minute >= 0 && StartingTime.Second >= 0) && (EndingTime.Hour <= 8 && EndingTime.Minute <= 59 && EndingTime.Second <= 59))
                {
                    Bill = Bill + offPeakHourRate;
                    StartingTime = StartingTime.AddSeconds(20);
                }

                else if ((StartingTime.Hour >= 11 && StartingTime.Minute >= 0 && StartingTime.Second >= 0) && (EndingTime.Hour <= 23 && EndingTime.Minute <= 59 && EndingTime.Second <= 59))
                {
                    Bill = Bill + offPeakHourRate; ;
                    StartingTime = StartingTime.AddSeconds(20);
                }

            }


        }

        public void TotalBill()
        {
            Bill = Bill / 100;
        }
       

        static void Main(string[] args)
        {
            var obj = new Program();
            obj.InputDateTime();
            obj.Calculation();
            obj.TotalBill();
            Console.WriteLine("Total bill" + obj.Bill + "Taka" );
        }
    }
}
