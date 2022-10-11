using System;

namespace s2k_Clock
{
    class Program
    {
        static void Main(string[] args)
        {   
            //DateTime.Now return's Date & Time in (dd-MM-yyyy HH:mm:ss) example: "10-10-2022 23:45:03"
            DateTime now = DateTime.Now;

            TimeSpan Time = now.TimeOfDay;

            string Clock = now.ToShortTimeString();
            Console.WriteLine(Clock);
            
            //Time.Hours return's hour in (HH) format example: "22:04 pm as 22" 24Hrs format.
            // Console.WriteLine(Time.Hours);
           
            if (Time.Hours >= 05 && Time.Hours <= 12 )
            {
                // 05:00 AM - 12:00 PM
                Console.WriteLine("Good morning.");
            }
            else if (Time.Hours >= 13 && Time.Hours <= 15 )
            {
                // 01:00 PM - 03:00 PM 
                Console.WriteLine("Good afternoon.");
            }
            else if (Time.Hours >= 16 && Time.Hours <= 19 )
            {
                 // 04:00 PM - 07:00 PM 
                Console.WriteLine("Good evening.");
            }
            else if (Time.Hours >= 20 && Time.Hours <= 24 )
            {
                // 07:00 PM - 12:00 AM 
                Console.WriteLine("Good night.");
            }else
            {
                Console.WriteLine("Take Rest!! Sleep.");
            }
            
        }
    }
}
