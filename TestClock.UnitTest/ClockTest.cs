namespace TestClock.UnitTest;

public class ClockTest
{
    private Clock.Clock clock;
    
    [SetUp]
    public void SetUp()
    {
        clock = new Clock.Clock(0, 0);
    }

    [TearDown]
    public void TearDown()
    {
        clock = null;
    }

    //Hours:

    [Test]
    public void setGetHour_LowerBound()
    {
        clock.SetHour(1);
        Assert.AreEqual(1, clock.GetHour());
    }

    [Test]
    public void setGetHour_UpperBound()
    {
        clock.SetHour(12);
        Assert.AreEqual(12, clock.GetHour());
    }

    [Test]
    public void setGetHour_Middle()
    {
        clock.SetHour(6);
        Assert.AreEqual(6, clock.GetHour());
    }

    //Minutes:

    [Test]
    public void setGetMinutes_LowerBound()
    {
        clock.SetMinutes(0);
        Assert.AreEqual(0, clock.GetMinutes());
    }

    [Test]
    public void setGetMinutes_UpperBound()
    {
        clock.SetMinutes(60);
        Assert.AreEqual(60, clock.GetMinutes());
    }

    [Test]
    public void setGetMinutes_Middle()
    {
        clock.SetMinutes(30);
        Assert.AreEqual(30, clock.GetMinutes());
    }
    
}