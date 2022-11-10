namespace Clock;

public class Calculations : ICalculations
{
    //These values are global just in case the clock parameters
    //for whatever reason would be changed
    int totalCircleDegrees = 360;
    int totalMinutes = 60;
    int totalHours = 12;


    public int DegreesBetweenHourAndMinute(int hour, int minute)
    {
        int degreeDifference = HourDegree(hour) - MinuteDegree(minute);

        if (degreeDifference > totalCircleDegrees/2)
        {
            degreeDifference -= 360;
        }

        if (degreeDifference < 0) {degreeDifference *= -1;}

        return degreeDifference;
    }

    private int HourDegree ( int hour)
    {
        return hour * TotalDegreesInAClockByHour();
    }

    private int MinuteDegree ( int minute)
    {
        return minute * TotalDegreesInAClockByMinute();
    }

    private int TotalDegreesInAClockByMinute ()
    {
        return totalCircleDegrees / totalMinutes;
    }

    private int TotalDegreesInAClockByHour ()
    {
        return totalCircleDegrees / totalHours;
    }
}