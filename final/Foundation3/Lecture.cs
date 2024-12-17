public class Lecture : Event
{
    string _speaker;
    int _capacity;

    public Lecture(string eventTitle, string description, string date, string time, Address address, string speaker, int capacity)
        : base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails}: Speaker: {_speaker} Capactiy: {_capacity}";
    }

}