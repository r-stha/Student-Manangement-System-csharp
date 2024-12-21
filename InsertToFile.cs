class InsertToFile
{

    public static int GetValidInput()
    {
        while (true)
        {
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Enter a valid number:");
            }

        }
    }

    public static void WriteToFile(string FileName, int i)
    {

        try
        {

            (int id, string name, int grade) = Input.TakeStudentData(i);

            using StreamWriter streamWriter = new(FileName, true);
            streamWriter.WriteLine($"Student: {1}:");
            streamWriter.WriteLine($"id: {id}");
            streamWriter.WriteLine($"Name: {name}");
            streamWriter.WriteLine($"Section: {grade}  \n");
        }
        catch (FileNotFoundException error)
        {
            Console.WriteLine(error.Message);
        }
        catch (DirectoryNotFoundException error)
        {
            Console.WriteLine(error.Message);
        }



    }

    public static void WriteAgain(int i, string FileName)
    {
        bool continueWriting = true;

        while (continueWriting)
        {
            Console.WriteLine("Do you want to Enter the data of the student again (y/n):");
            string? writingChoice = Console.ReadLine();

            if (writingChoice == "y" || writingChoice == "Y")
            {
                continueWriting = true;

                WriteToFile(FileName, i);

                i++;

            }
            else
            {
                continueWriting = false;
            }
        }
    }

    public static void InserOperation(string FileName)
    {
        Console.WriteLine("Enter the number of data of Students to Enter:");
        int NumberOfData = GetValidInput();
        int i;

        for (i = 1; i <= NumberOfData; i++)
        {

            WriteToFile(FileName, i);

        }
        WriteAgain(i, FileName);



        Console.Clear();
        Console.WriteLine("Contents Written Successfully");
        Console.WriteLine("Press any key to continue.....");
        Console.ReadKey();
        
    }

}