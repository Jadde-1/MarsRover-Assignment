public class MobilitySystem
{
    public int BatteryLevel { get; set; } = 20;

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



}
