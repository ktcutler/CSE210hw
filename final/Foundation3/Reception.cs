public class Reception : Event
{
    string _rsvp;

    public Reception(string eventTitle, string description, string date, string time, Address address, string rsvp)
        : base(eventTitle, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails} RSVP: {_rsvp}";
    }
}