class OptionChoose
{
    public static string FileChoice()
    {
        string? fileName = "";
        switch (Console.ReadLine())
        {
            case "1":
                fileName = @"C:\Users\97798\Documents\std\Students Record\Student.txt";
                break;

            case "2":
                fileName = @"C:\Users\97798\Documents\std\Students Record\Student.json";
                break;

            case "3":
                fileName = @"C:\Users\97798\Documents\std\Students Record\Student.XML";
                break;

            default:
                Console.WriteLine("INVALID OPTIon");
                break;

        }

        try
        {
            return fileName;
        }
        catch (NullReferenceException error)
        {
            Console.WriteLine(error.Message);
            return "";
        }

    }

    public static void OperationOptionChoose(string fileName)
    {
        switch (Console.ReadLine())
        {
            case "1":
                InsertToFile.InserOperation(fileName);
    
                break;

            case "2":
                ReadFromFile.Read(fileName);
                break;

            case "3":
                Console.WriteLine("Exiting....");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("INVALID OPTION!!!");
                break;

        }
    }


    public static void PerformOperationAgain(string fileName)
    {

        bool wantToStop = false;
        while (!wantToStop)
        {

            Console.WriteLine("Do you want to Insert or Read from the file (y/n)");
            string? stopChoice = Console.ReadLine();

            if (stopChoice == "y" || stopChoice == "Y")
            {
                wantToStop = false;
                Menu.OperationMenu();
                OperationOptionChoose(fileName);
            }
            else
            {
                wantToStop = true;
                Console.WriteLine("Exiting...");
            }
        }

    }

}