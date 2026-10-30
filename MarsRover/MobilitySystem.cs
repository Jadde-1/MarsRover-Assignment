public class MobilitySystem
{
    public int BatteryLevel { get; set; } = 5;

    public void Drive(int distance)
    {
        Console.Clear();
        Console.WriteLine("        Mobility: Forsøger at køre " + distance + " meter.");

        if (distance > BatteryLevel)
        {
            throw new InvalidOperationException("Critical mother error: Not enought power for the ride!");
        }

        // Som standard har den for lidt strøm
        BatteryLevel -= distance;
        Console.WriteLine("        Mobility: Kørsel succesfuld. Strøm tilbage: " + BatteryLevel);
    }

    public void Drill(int depth)
    {
        Console.Clear();
        Random sampleChance = new Random();
        if (depth < 0)
        {
            throw new ArgumentOutOfRangeException("You cant drill less than 0 meters");
        }
        else if (depth+5 > BatteryLevel)
        {
            throw new InvalidOperationException("Critical motor error: Not enought power for the drilling!");
        } else if (sampleChance.Next(0,5) == 0)
        {
            BatteryLevel -= depth;
            throw new NoSampelFoundException("Drilling succefull but no sample found. Strøm tilbage: " + BatteryLevel);
        }
        string sample = "";
        int rock = sampleChance.Next(0,100);

        if (rock <= 35) //30%
        {
            sample = "ultra common rock";
        }
        else if (rock <= 55) //20%
        {
            sample = "common rock";
        }
        else if (rock <= 75) //15%
        {
            sample = "good rock";
        }
        else if (rock <= 90) //15%
        {
            sample = "legendary rock";
        }
        else
        {
            sample = "mythic rock";
        }





    Console.WriteLine("Found sample to analysing....");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("("+(i+1)+"/3)Analyzing...");
            Thread.Sleep(1000);
        }
        if (sample == "mythic rock")
        {
            Console.Write("Sample found to be ");
            foreach (char i in sample)
            {
                Random color = new Random();
                int colorChoice = color.Next(0,3);
                if (colorChoice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                } else if (colorChoice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write(i);
                Console.ForegroundColor = ConsoleColor.White;
            }
        } else
        {
            Console.WriteLine("Sample found to be " + sample);
        }
        
        Console.WriteLine("");
        BatteryLevel -= depth+5;
        Console.WriteLine("        Mobility: Boring succesfuld. Strøm tilbage: " + BatteryLevel);
    }

    public void Recharge()
    {
        Console.Clear();
        Random rand = new Random();
        while (BatteryLevel < 100)
        {
            if (rand.Next(0, 20) == 0)
            { 
                throw new SunsetException("Advarsel fra Mars: Advarsel fra Mars: Charing failed sun went down Battery:" + BatteryLevel);
            }
            System.Threading.Thread.Sleep(1000);
            BatteryLevel += 10;
            if (BatteryLevel > 100)
            {
                BatteryLevel = 100;
            }
            Console.WriteLine("Recharging - Current power level:" + BatteryLevel);
        }

        Console.WriteLine("Rover fully Charged");

    }



}
