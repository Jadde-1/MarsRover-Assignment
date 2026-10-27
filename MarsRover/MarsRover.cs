public class MarsRover
{
    private MobilitySystem mobility = new MobilitySystem();

    public void ProcessCommand(int option, int distance)
    {
        if (option < 0 || option > 1)
        {
            throw new ArgumentOutOfRangeException("This rover only have 0/1 as an option");
        }
        switch (option)
        {
            case 0:
                Drive(distance);
                break;
            case 1:
                DrillForSampels(distance); 
                break;
        }
        
    }

    public void Drive(int distance) 
    {
        Console.WriteLine("      Rover CPU: Kommando modtaget. Vækker motorer...");
        //try
        //{
            ScanWether();
            mobility.Drive(distance);
            Console.WriteLine("      Rover CPU: Kørsel bekræftet. Går i standby.");
        //}
        //catch (SandstormException ex)
        //{
        //    PrintError(ex);
        //}
        //catch (InvalidOperationException ex)
        //{
        //    PrintError(ex);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Unknown error accured");
        //}
    }

    public void DrillForSampels(int depth)
    {
        //try
        //{
            ScanWether();
            mobility.Drill(depth);
        //} catch (SandstormException ex)
        //{
        //    PrintError(ex);
        //}
        //catch (ArgumentOutOfRangeException ex)
        //{
        //    PrintError(ex);
        //}
        //catch (InvalidOperationException ex)
        //{
        //    PrintError(ex);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Unknown error accured");
        //}
        
    }

    private void ScanWether()
    {
        Random wether = new Random();
        if (wether.Next(1, 6) == 1)
        {
            throw new SandstormException("Rover is on lockdown cause: Sandstorm");
        }

    }

    
    private void PrintError(Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}