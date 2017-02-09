using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace time_controller_console
{
    class Program
    {
        static int speed;
        static int hours;
        static int days;
        static int months;
        static int years;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.SetUp();
            program.SetUpTimer();
        }

        void SetUp()
        {
            speed = 5;
            hours = 12;
            days = 15;
            months = 8;
            years = 1945;
        }

        void SetUpTimer()
        {
            Timer secondsTimer = new Timer();
            secondsTimer.Elapsed += new ElapsedEventHandler(TickHours);
            secondsTimer.Interval = 
        }
    }
}
