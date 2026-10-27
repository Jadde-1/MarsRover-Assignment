public class MissionControl
{
    public void ExecuteMission()
    {
        Console.WriteLine("Mission Control: Starter dags-sekvens.");
        CommsLink earthComms = new CommsLink();

        earthComms.TransmitToSpace(50); // Vi beder roveren køre 50 meter

        Console.WriteLine("Mission Control: Sekvens fuldført uden fejl.");
    }
}