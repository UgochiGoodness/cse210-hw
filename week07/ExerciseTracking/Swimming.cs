public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    // Convert laps → meters → kilometers → miles
    public override double GetDistance()
    {
        double meters = _laps * 50;
        double miles = meters / 1000 * 0.62;
        return miles;
    }

    public override double GetSpeed() => (GetDistance() / Minutes) * 60;

    public override double GetPace() => Minutes / GetDistance();
}
