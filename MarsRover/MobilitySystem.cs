public class MobilitySystem
{
    public int BatteryLevel { get; set; } = 20;

    public void Drive(int distance)
    {
        Console.WriteLine("        Mobility: Forsøger at køre " + distance + " meter.");

        if (distance > BatteryLevel)
        {
            throw new InvalidOperationException("Kritisk motorfejl: Ikke nok strøm til turen!");
        }

        // Som standard har den for lidt strøm
        BatteryLevel -= distance;
        Console.WriteLine("        Mobility: Kørsel succesfuld. Strøm tilbage: " + BatteryLevel);
    }
}