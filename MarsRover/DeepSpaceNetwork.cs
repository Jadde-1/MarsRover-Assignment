public class DeepSpaceNetwork
{
    public void RelaySignal(int distance)
    {
        Console.WriteLine("    DSN Satellite: Modtager signal... videresender til Mars.");
        MarsRover ares = new MarsRover();

        ares.ProcessCommand(distance);

        Console.WriteLine("    DSN Satellite: Bekræftelse modtaget fra Mars.");
    }
}