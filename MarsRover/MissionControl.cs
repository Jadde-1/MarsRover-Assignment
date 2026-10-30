public class MissionControl
{
   
    int distance = 20;
    int option = 0;
    CommsLink earthComms = new CommsLink();
    public void ExecuteMission()
    {
        Console.WriteLine("Mission Control: Starter dags-sekvens.");
        
        Console.WriteLine("0(Drive),1(Drill),2(Recharge)");
        try
        {
            option = int.Parse(Console.ReadLine());
            earthComms.TransmitToSpace(option, distance);
            Console.WriteLine("Mission Control: Sekvens fuldført uden fejl.");
        }
        catch (SandstormException ex) // tjek
        {
            PrintError(ex);
        } catch (SunsetException ex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        catch (ArgumentOutOfRangeException ex) // tjek
        {
            PrintError(ex);
        }
        catch (InvalidOperationException ex) // tjek
        {
            PrintError(ex);
        }
        catch (Exception ex)
        {
            PrintError(ex);
        } finally // Tjek
        {
            Console.WriteLine("Afbryder radioforbindelse til Ares-1 for i dag.");
            ExecuteMission();
        }

       
    }

    private void PrintError(Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}