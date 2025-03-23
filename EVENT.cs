using System;

namespace ITEC_MANAGEMENT.UI
{
    public class EventUI
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public TimeSpan EventTime { get; set; }
        public DateTime EventDate { get; set; }
        public int VenueID { get; set; }
        public string VenueName { get; set; }

        // Method to create and store event information
        public void CreateEvent()
        {
            // Collect event information from the user
            Console.WriteLine("Enter Event ID:");
            EventID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Event Name:");
            EventName = Console.ReadLine();

            Console.WriteLine("Enter Event Time (HH:mm:ss):");
            EventTime = TimeSpan.Parse(Console.ReadLine());

            Console.WriteLine("Enter Event Date (YYYY-MM-DD):");
            EventDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Venue ID:");
            VenueID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Venue Name:");
            VenueName = Console.ReadLine();

            // After collecting data, confirm the event creation
            Console.WriteLine("Event successfully created:");
            Console.WriteLine($"ID: {EventID}, Name: {EventName}, Time: {EventTime}, Date: {EventDate.ToShortDateString()}, Venue: {VenueID} - {VenueName}");
        }

        // Optionally, we can have a method to store or process the event
        public void AddEvent()
        {
            Console.WriteLine($"Event '{EventName}' added to the system.");
        }
        public void UpdateEvent() {

            Console.WriteLine($"Event '{EventName}' Updated to the system.");
        }
    
    }

}

