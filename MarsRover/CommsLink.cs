public class CommsLink
{
    public void TransmitToSpace(int distance)
    {
        Console.WriteLine("  Earth Comms: Krypterer kommando...");
        DeepSpaceNetwork dsn = new DeepSpaceNetwork();

        dsn.RelaySignal(distance);

        Console.WriteLine("  Earth Comms: Forbindelse lukket pænt.");
    }
}