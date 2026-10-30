public class CommsLink
{
    DeepSpaceNetwork dsn = new DeepSpaceNetwork();
    public void TransmitToSpace(int option, int distance)
    {
        Console.WriteLine("  Earth Comms: Krypterer kommando...");
        

        
        dsn.RelaySignal(option,distance);

        Console.WriteLine("  Earth Comms: Forbindelse lukket pænt.");
    }

}