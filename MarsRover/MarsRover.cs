public class MarsRover
{
    private MobilitySystem mobility = new MobilitySystem();

    public void ProcessCommand(int distance)
    {
        Console.WriteLine("      Rover CPU: Kommando modtaget. Vækker motorer...");

        mobility.Drive(distance);

        Console.WriteLine("      Rover CPU: Kørsel bekræftet. Går i standby.");
    }
}