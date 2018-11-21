using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace TicketForm
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            //TimerMethod();
            SetTimer();
            
            
        }
        private static System.Timers.Timer aTimer;
        private DateTime startTime = DateTime.Now;
       // private DateTime endTime = startTime.AddMinutes(5);

        private  void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += this.OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.SynchronizingObject = this;
            aTimer.Enabled = true;
        }

        string currentTime;
        public void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            
            DateTime gTime = e.SignalTime;
            string nTime = string.Format("{0:T}", gTime);
            DateTime endTime = gTime.AddMinutes(5);

            while (true)
            {

            }
            //lblNextTime.Text = nTime;
            
            this.Text = nTime;
            
         
        }

        public void GetTime()
        {
            //ClockClass.GetTime();
            DateTime time = DateTime.Now;
            currentTime = time.ToString("h:mm");
            Console.WriteLine(currentTime);
            lblNextTime.Text = currentTime;
            
        }





        //public DateTime TimerMethod()
        //{
        //    // Create a timer and set a two second interval.
        //    Timer aTimer = new System.Timers.Timer();
        //    aTimer.Interval = 2000;

        //    // Hook up the Elapsed event for the timer. 
        //    aTimer.Elapsed += OnTimedEvent;

        //    // Have the timer fire repeated events (true is the default)
        //    aTimer.AutoReset = true;

        //    // Start the timer
        //    aTimer.Enabled = true;

        //    //Console.WriteLine("Press the Enter key to exit the program at any time... ");
        //    //Console.ReadLine();

        //    //DateTime currentTime = DateTime.Now;

        //}

        //    private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        //    {
        //        Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
        //    }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    //lblNextTime.Text = DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss tt");
        //    string currentTimeString = DateTime.Now.ToString("h:mm");

        //    lblNextTime.Text = currentTimeString;
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            //creates a pop up form for options
            Form options = new frmOptions();
            DialogResult selectedButton = options.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                //Gathers the information into a string to display in the lstbox
                lstMain.Items.Add((string)options.Tag);
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {

        }

        private void lblNextTime_Click(object sender, EventArgs e)
        {

        }
    }
}
