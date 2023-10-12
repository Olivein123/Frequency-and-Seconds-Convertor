using TimeAndFrequencyConversion;

FrequencyConverter frequencyConverter = new FrequencyConverter();
TimeConverter timeConverter = new TimeConverter();


Console.WriteLine("Enter type of unit to convert to: \n 1. Seconds \n 2. Hz");
string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        double seconds = 0;

        try
        {
            Console.Write("Please enter a number in seconds: ");
            string input = Console.ReadLine();
            double.TryParse(input, out seconds);

        }
        catch (InvalidDataException e)
        {
            Console.WriteLine(e.Message);
        }

        string unitSeconds = "";

        double periodInHertz = timeConverter.SecondsToHertz(seconds);

        //count zeroes
        int zeroCount = 0;
        
        string periodInString = periodInHertz.ToString();
        foreach(char digit in periodInString)
        {
            if (digit == '0')
            {
                zeroCount++;
            }
        }

        if(zeroCount == 3)
        {
            unitSeconds = "kilohertz";
        }else if(zeroCount == 6)
        {
            unitSeconds = "megahertz";
        }else if (zeroCount == 9 || zeroCount == 8) 
        {
            unitSeconds = "gigahertz";
        }
        else 
        {
            unitSeconds = "terahertz";
        }

        Console.WriteLine($"Frequency: {periodInHertz} {unitSeconds}");


        break;
    case "2":
        double frequencyInHertz = 0;

        try
        {
            Console.Write("Please enter a number in hz: ");
            string input = Console.ReadLine();
            double.TryParse(input, out frequencyInHertz);

        }
        catch (InvalidDataException e)
        {
            Console.WriteLine(e.Message);
        }

        double periodInSeconds = frequencyConverter.HertzToSeconds(frequencyInHertz);


        string period = periodInSeconds.ToString();
        string lastLetter = period.Substring(period.Length - 1)[0].ToString();
        string unit = "";


        // the only time na ma 1 ni an last letter kay if millisecond

        switch (lastLetter)
        {
            case "1":
                if (period.Length >= 2)
                {
                    unit = "Milliseconds";
                }
                else
                {
                    throw new InvalidOperationException("Invalid choice. Please select a valid option.");
                }
                break;

            case "6":
                unit = "Microseconds";
                break;
            case "9":
                unit = "Nanoseconds";
                break;
            case "12":
                unit = "Picoseconds";
                break;
            default:
                throw new InvalidOperationException("Invalid choice. Please select a valid option.");

        }

        Console.WriteLine($"Frequency: {frequencyInHertz} Hz");
        Console.WriteLine($"Period: {periodInSeconds}  {unit}");
        break;
}


