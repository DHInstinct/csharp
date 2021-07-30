using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_CIT265_A5
{
    public partial class homepage: Form
    {
        public Dictionary<string, string[]> BoxItems = new Dictionary<string, string[]>();
        public Dictionary<DateTime, string[]> BoxItemsDate = new Dictionary<DateTime, string[]>();

        public homepage()
        {
            InitializeComponent();
            Reader();
        }

        public ListBox GetEventBox()
        {
            return eventBox;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)// testbtn
        {
            EventWindow eventWindow = new EventWindow(this);
            eventWindow.BringToFront();
            eventWindow.ShowDialog();
        }

        private void quit_Click(object sender, EventArgs e) // Quit button
        {
            Writer();
            Application.Exit();
        }
        
        private void button2_Click(object sender, EventArgs e)// delete Event
        {
            // Worked with Asad Ranavaya on the delete function
            // It took us three hours to figure this out... we're not dumb, we just don't know how list boxes work hahah

            int selectedindex = eventBox.SelectedIndex;
            int compareindex = eventBox.SelectedIndex + 1;

            if (compareindex % 4 == 2)
            {
                selectedindex = eventBox.SelectedIndex - 1;
            }
            else if (compareindex % 4 == 3)
            {
                selectedindex = eventBox.SelectedIndex - 2;
            }
            else if(compareindex % 4 == 0)
            {
                selectedindex = eventBox.SelectedIndex - 3;
            }
            eventBox.Items.RemoveAt(selectedindex);
            eventBox.Items.RemoveAt(selectedindex);
            eventBox.Items.RemoveAt(selectedindex);
            eventBox.Items.RemoveAt(selectedindex);
        }


        //Worked with Asad Ranavaya for sorting by date
        private void sortbydate_Click(object sender, EventArgs e) // sort by date
        {
            BoxItemsDate.Clear();

            for (int i = 0; i < eventBox.Items.Count; i += 4)
            {
                string[] item = new string[4];
                for (int j = 0; j < 4; ++j)
                {
                    item[j] = eventBox.Items[i++].ToString();
                }
                i -= 4;
                BoxItemsDate.Add(DateTime.Parse(item[2].ToString()), item);
            }

            eventBox.Items.Clear();
            List<string[]> eventList = BoxItemsDate.OrderBy(kp => kp.Key)
                                      .Select(kp => kp.Value)
                                      .ToList();

            for (int i = 0; i < eventList.Count; ++i)
            {
                for (int j = 0; j < eventList[i].Length; ++j)
                {
                    eventBox.Items.Add(eventList[i][j]);
                }
            }
        }

        //Worked with Asad Ranavaya for sorting by name
        private void Sort_Click(object sender, EventArgs e) // sort by name
        {
            //clear dictionary
            BoxItems.Clear();

            //loop through the eventbox and place items into dictionary
            for (int i = 0; i < eventBox.Items.Count; i += 4)
            {
                //make dictionary bucket
                string[] item = new string[4];
                //loop through bucket
                for (int j = 0; j < 4; ++j)
                {
                    //place incremental eventbox item into bucket
                    item[j] = eventBox.Items[i++].ToString();
                }
                //subtracting 4 to account for incremental ^
                i -= 4;
                //add each array and each name
                BoxItems.Add(item[0].Substring(11), item);
            }

            //clear list box
            eventBox.Items.Clear();

            // use LINQ to sort items based on the key, which is the name
            List<string[]> eventList = BoxItems.OrderBy(kp => kp.Key)
                                      .Select(kp => kp.Value)
                                      .ToList();

            // looping through the array of string arrays
            for (int i = 0; i < eventList.Count; ++i)
            {
                for (int j = 0; j < eventList[i].Length; ++j)
                {
                    // adding each individual item of array[i]
                    eventBox.Items.Add(eventList[i][j]);
                }
            }
        
        }

        private void button2_Click_1(object sender, EventArgs e)// save txt file.
        {
            Writer();
        }

        private void button3_Click(object sender, EventArgs e)//load txt file.
        {
            Reader();
        }

        private void Reader()
        {
            const string sPath = @".\test.txt";

            using (StreamReader reader = new StreamReader(sPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    eventBox.Items.Add(line);
                }
            }
        }

        private void Writer()
        {
            const string sPath = @".\test.txt";

            TextWriter SaveFile = new StreamWriter(sPath);
            foreach (var item in eventBox.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.Close();

            MessageBox.Show("Program saved!");
        }
        
    }
}
