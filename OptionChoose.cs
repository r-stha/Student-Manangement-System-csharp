class OptionChoose
{
    public static void FileChoice(out string fileName, out string tempFile)
    {

        switch (Console.ReadLine())
        {
            case "1":
                fileName = @"C:\Users\97798\Documents\std\Students_Record\Student.txt";
                tempFile = "temp.txt";
                break;

            case "2":
                fileName = @"C:\Users\97798\Documents\std\Students_Record\Student.json";
                tempFile = "temp.json";
                break;

            case "3":
                fileName = @"C:\Users\97798\Documents\std\Students_Record\Student.XML";
                tempFile = "temp.XML";
                break;

            default:
                Console.WriteLine("INVALID OPTIon");
                fileName = "";
                tempFile = "";
                break;

        }

    }

    public static void OperationOptionChoose(string fileName, string tempFile)
    {
        string? choice = Console.ReadLine();
        Console.Clear();

        switch (choice)
        {
            case "1":
                InsertToFile.InserOperation(fileName, tempFile);
                break;

            case "2":
                ReadFromFile.Read(fileName, tempFile);
                break;

            case "3":
                Menu.DeleteMenu();
                DeleteOperation(fileName, tempFile);
                Environment.Exit(0);
                break;

            case "4":
                Console.WriteLine("Exiting....");
                Environment.Exit(0);
                break;

            case "5":
                Delete.DeleteAll(fileName, tempFile);
                break;

            default:
                Console.WriteLine("INVALID OPTION!!!");
                break;

        }
    }


    public static void PerformOperationAgain(string fileName, string tempFile)
    {

        bool wantToStop = false;
        while (!wantToStop)
        {
            Console.WriteLine("Do you want to Insert or Read or Delete from the file (y/n)");
            string? stopChoice = Console.ReadLine();

            if (stopChoice == "y" || stopChoice == "Y")
            {
                Console.Clear();

                wantToStop = false;
                Menu.OperationMenu();
                OperationOptionChoose(fileName, tempFile);
            }
            else
            {
                wantToStop = true;
                Console.WriteLine("Exiting......");
            }
        }

    }

    public static void DeleteOperation(string fileName, string tempFile)
    {
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("Enter the id of the student to delete the record: ");
                int id = Input.GetValidInput();
                Delete.DeleteFromFile(fileName, tempFile, id);
                break;

            case "2":
                Console.WriteLine("Are you Sure you want to delete All data Of Student (y/n):");
                Conformation(Console.ReadLine(), fileName, tempFile);

                break;

            default:
                Console.WriteLine("Invalid Option.");
                break;

        }

    }

    public static void Conformation(string? choice, string fileName, string tempFile)
    {
        if (choice == "y" || choice == "Y")
        {
            Delete.DeleteAll(fileName, tempFile);
        }
        else
        {
            Console.WriteLine("Deletion Cancalled!!");
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
            Console.Clear();
            
            PerformOperationAgain(fileName, tempFile);
        }
    }

}