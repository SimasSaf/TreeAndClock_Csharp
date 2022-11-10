namespace Clock;

public class RunClock
{
    //initialize
    static Clock clock = new Clock(0, 0);
    static ICalculations calc = new Calculations();
    static String? _userInput;
    static int _hour, minutes;

    public static void StartClock()
    {
        while(true)
        {
            Console.WriteLine("Please provide the hour: ");
            TakeAndValidateHour();

            Console.WriteLine("Please provide the minute: ");
            TakeAndValidateMinutes();

            Console.WriteLine("Degrees between the two arrows: " + calc.DegreesBetweenHourAndMinute(clock.GetHour(), clock.GetMinutes()));

        }

    }

    private static void TakeAndValidateHour()
    {
        while(true)
        {
            _userInput = Console.ReadLine();


            if (!int.TryParse(_userInput, out _hour))
            {
                Console.WriteLine("-Input has to be a number-");
            }
            else
            {
                if (_hour <= 12 && _hour >= 1)
                {
                    clock.SetHour(_hour);
                    break;
                }
                else
                {
                    Console.WriteLine("-Please enter a value between 1 and 12-");
                }
            }
        }
    }

    private static void TakeAndValidateMinutes()
    {
        while(true)
        {
            _userInput = Console.ReadLine();

            if (!int.TryParse(_userInput, out minutes))
            {
                Console.WriteLine("-Input has to be a number-");
            }
            else
            {
                if (minutes <= 60 && minutes >= 0)
                {
                    clock.SetMinutes(minutes);
                    break;
                }
                else
                {
                    Console.WriteLine("-Please enter a value between 0 and 60-");
                }
            }
        }
    }
}