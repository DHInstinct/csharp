using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_CIT265_A5
{
    public partial class EventWindow : Form
    {
        //Must have a reference to the homepage to access fields
        homepage refHome = new homepage();

        public EventWindow(homepage homepage)
        {
            InitializeComponent();
            refHome = homepage;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eventName_TextChanged(object sender, EventArgs e)
        {

        }
       
        //function that creates an event
        private void CreateEvent(string EventName, string EventDes, DateTime EventDate)
        {
            refHome.GetEventBox().Items.Add($"Name of Event: {EventName}");
            refHome.GetEventBox().Items.Add($"Description: {EventDes}");
            refHome.GetEventBox().Items.Add($"{EventDate}");
            refHome.GetEventBox().Items.Add("");
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //checking if the eventName and eventdes field is not empty
            if (eventName.Text != "" && eventdes.Text != "")
            {
                CreateEvent(eventName.Text, eventdes.Text, eventDate.Value);
                eventName.Clear();
                eventdes.Clear();
                eventDate.Value = DateTime.Now;
            }
        }
    }
}
