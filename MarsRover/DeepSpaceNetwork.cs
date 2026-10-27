public class DeepSpaceNetwork
{
    public void RelaySignal(int option, int distance)
    {
        Console.WriteLine("    DSN Satellite: Modtager signal... videresender til Mars.");
        MarsRover ares = new MarsRover();

        ares.ProcessCommand(option,distance);

        
        Console.WriteLine("    DSN Satellite: Bekræftelse modtaget fra Mars.");
    }
}