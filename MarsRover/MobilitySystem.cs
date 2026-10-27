public class MobilitySystem
{
    public int BatteryLevel { get; set; } = 5;

    public void Drive(int distance)
    {
        Console.WriteLine("        Mobility: Forsøger at køre " + distance + " meter.");

        if (distance > BatteryLevel)
        {
            throw new InvalidOperationException("Critical mother error: Not enought power for the ride!");
        }

        // Som standard har den for lidt strøm
        BatteryLevel -= distance;
        Console.WriteLine("        Mobility: Kørsel succesfuld. Strøm tilbage: " + BatteryLevel);
    }

    public void Drill(int depth)
    {
        if (depth < 0)
        {
            throw new ArgumentOutOfRangeException("You cant drill less than 0 meters");
        }
        else if (depth > BatteryLevel)
        {
            throw new InvalidOperationException("Critical mother error: Not enought power for the drilling!");
        }

        BatteryLevel -= depth;
        Console.WriteLine("        Mobility: Boring succesfuld. Strøm tilbage: " + BatteryLevel);
    }

    public void Recharge()
    {
        Random rand = new Random();
        while (BatteryLevel < 100)
        {
            if (rand.Next(0, 20) == 0)
            { 
                throw new SunsetException("Advarsel fra Mars: Advarsel fra Mars: Charing failed sun went down Battery:" + BatteryLevel);
            }
            System.Threading.Thread.Sleep(1000);
            BatteryLevel += 10;
            if (BatteryLevel > 100)
            {
                BatteryLevel = 100;
            }
            Console.WriteLine("Recharging - Current power level:" + BatteryLevel);
        }

        Console.WriteLine("Rover fully Charged");

    }



}
