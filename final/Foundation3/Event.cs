public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {_eventTitle} Description: {_description} Date: {_date} Time: {_time} Address: {_address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDetails()
    {
        return $"{GetType().Name}: {_eventTitle} on {_date}";
    }
}