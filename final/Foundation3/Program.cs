class Program
{
    static void Main(string[] args)
    {
        // Create Address objects
        Address address1 = new Address("123 Olathe RD", "Olathe", "Kansas", "USA");
        Address address2 = new Address("456 Elm St", "Springfield", "Illinois", "USA");
        Address address3 = new Address("789 Maple Ave", "Chicago", "Illinois", "USA");

        // Create instances of Lecture, Reception, and OutdoorGathering with required parameters
        Lecture lecture = new Lecture("Tech Talk", "A talk about technology", "2024-12-20", "10:00 AM", address1, "Dr. Smith", 100);
        Reception reception = new Reception("Wedding Reception", "A celebration after the wedding", "2024-12-22", "5:00 PM", address2, "Yes");
        
        // Fix OutdoorGathering instantiation by providing both speaker and weather
        OutdoorGathering outdoor = new OutdoorGathering("Beach Party", "A fun beach gathering", "2024-12-21", "2:00 PM", address3, "John Doe", "Sunny");

        // Store all events in an array
        Event[] events = { lecture, reception, outdoor };

        // Loop through each event and print details
        foreach (Event ev in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("Full Details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("Short Details:");
            Console.WriteLine(ev.GetShortDetails());
            Console.WriteLine();  // Blank line between events
        }
    }
}
