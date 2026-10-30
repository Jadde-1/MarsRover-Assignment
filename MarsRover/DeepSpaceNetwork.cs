public class DeepSpaceNetwork
{
    MarsRover ares = new MarsRover();
    public void RelaySignal(int option, int distance)
    {
        Console.WriteLine("    DSN Satellite: Modtager signal... videresender til Mars.");
        

        ares.ProcessCommand(option,distance);

        
        Console.WriteLine("    DSN Satellite: Bekræftelse modtaget fra Mars.");
    }
}