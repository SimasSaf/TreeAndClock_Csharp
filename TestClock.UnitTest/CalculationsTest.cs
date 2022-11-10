using Clock;

namespace TestClock.UnitTest;

public class CalculationsTest
{
    private Calculations calc = new Calculations();
    
    [Test]
    public void degreesBetweenArrows_Zero()
    {
        Assert.AreEqual(0, calc.DegreesBetweenHourAndMinute(12, 0));
        Assert.AreEqual(0, calc.DegreesBetweenHourAndMinute(12, 60));
    }

    [Test]
    public void degreesBetweenArrows_HalfCircles()
    {
        Assert.AreEqual(180, calc.DegreesBetweenHourAndMinute(12, 30));
        Assert.AreEqual(180, calc.DegreesBetweenHourAndMinute(3, 45));
        Assert.AreEqual(180, calc.DegreesBetweenHourAndMinute(6, 0));
        Assert.AreEqual(180, calc.DegreesBetweenHourAndMinute(9, 15));
    }

    [Test]
    public void degreesBetweenArrows_90()
    {
        Assert.AreEqual(90, calc.DegreesBetweenHourAndMinute(12, 15));
        Assert.AreEqual(90, calc.DegreesBetweenHourAndMinute(12, 45));
    }
}