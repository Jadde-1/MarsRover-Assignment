public class CommsLink
{
    public void TransmitToSpace(int option, int distance)
    {
        Console.WriteLine("  Earth Comms: Krypterer kommando...");
        DeepSpaceNetwork dsn = new DeepSpaceNetwork();

        
        dsn.RelaySignal(option,distance);

        Console.WriteLine("  Earth Comms: Forbindelse lukket pænt.");
    }

}