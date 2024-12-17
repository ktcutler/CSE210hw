public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string eventTitle, string description, string date, string time, Address address, string speaker, string weather)
        : base(eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}: Weather: {_weather}";
    }
}
