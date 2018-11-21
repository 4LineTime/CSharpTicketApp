using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketForm
{
    public class ClockClass
    {
        private string currentTime;
        private DateTime time;

        public string GetTime()
        {
            this.time = DateTime.Now;
            this.currentTime = time.ToString("h:mm");
            Console.WriteLine(currentTime);
            return currentTime;

        }

        public string CurrentTime
        {
            get
            {
                return currentTime;
            }
        }
    }
}
