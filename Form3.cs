using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITEC_MANAGEMENT.BL;

namespace ITEC_MANAGEMENT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure that the clicked cell corresponds to the Add button column
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                try
                {
                    // Get data from the DataGridView cells in the selected row
                    int eventId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["EventID"].Value.ToString());
                    string eventName = dataGridView1.Rows[e.RowIndex].Cells["EventName"].Value.ToString();
                    TimeSpan eventTime = TimeSpan.Parse(dataGridView1.Rows[e.RowIndex].Cells["EventTime"].Value.ToString());
                    DateTime eventDate = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["EventDate"].Value.ToString());
                    int venueId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["VenueID"].Value.ToString());
                    string venueName = dataGridView1.Rows[e.RowIndex].Cells["VenueName"].Value.ToString();

                    // Create an Event object
                    Event newEvent = new Event
                    {
                        EventID = eventId,
                        EventName = eventName,
                        EventTime = eventTime,
                        EventDate = eventDate,
                        VenueID = venueId,
                        VenueName = venueName
                    };

                    // Call the Business Logic Layer to add the event
                    EventManager eventManager = new EventManager();
                    eventManager.AddEvent(newEvent);

                    // Show success message
                    MessageBox.Show("Event added successfully.");
                }
                catch (Exception ex)
                {
                    // Show error message if something goes wrong
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
 