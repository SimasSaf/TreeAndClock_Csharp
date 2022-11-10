namespace Clock;

public class Clock
{
    int minutes, hour;

    public Clock(){}

    public Clock(int hour, int minutes)
    {
        this.hour = hour;
        this.minutes = minutes;
    }

    public int GetMinutes() {
        return minutes;
    }

    public void SetMinutes(int minutes)
    {
        if (minutes > 60 || minutes < 0)
        {
            throw new Exception("Minutes must be between 0 and 60");
        }
        this.minutes = minutes;
    }

    public int GetHour() { return hour; }

    public void SetHour(int hour)
    {
        if (hour > 12 || hour < 1)
        {
            throw new Exception("Hour must be between 1 and 12");
        }
        this.hour = hour;
    }
}