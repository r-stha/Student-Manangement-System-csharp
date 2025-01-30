class Menu
{
    public static void FileTypeMenu()
    {
        Console.WriteLine("Enter the file type to write the data:");
        Console.WriteLine("1. Text file");
        Console.WriteLine("2. Json file");
        Console.WriteLine("3. XML file");
    }

    public static void OperationMenu()
    {
        Console.WriteLine("1. Insert");
        Console.WriteLine("2. Read");
        Console.WriteLine("3. Delete");
        Console.WriteLine("4. Exit");
    }

    public static void DeleteMenu()
    {
        Console.WriteLine("1. Delete by ID");
        Console.WriteLine("2. Delete All");
    }


}