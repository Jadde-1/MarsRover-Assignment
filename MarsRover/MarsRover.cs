public class MarsRover
{
    private MobilitySystem mobility = new MobilitySystem();

    public void ProcessCommand(int distance)
    {
        Console.WriteLine("      Rover CPU: Kommando modtaget. Vækker motorer...");
        try
        {
            mobility.Drive(distance);
            Console.WriteLine("      Rover CPU: Kørsel bekræftet. Går i standby.");
        } catch (InvalidOperationException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}