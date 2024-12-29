class Delete
{
    public static bool WriteInNewFile(string originalFile, string tempFile, int id)
    {
        bool isSkipped = false;
        bool skipData = false;


        StreamReader reader = new StreamReader(originalFile);
        StreamWriter writer = new StreamWriter(tempFile);

        string? data;
        while ((data = reader.ReadLine()) != null)
        {

            if (data.Contains($"id: {id}"))
            {
                isSkipped = true;
                skipData = true;

            }

            if (skipData)
            {
                if (data == "" || data == "\n")
                {
                    skipData = false;
                }
                continue;

            }
            writer.WriteLine(data);

        }


        writer.Close();
        reader.Close();

        return isSkipped;

    }

    public static void DeleteFromFile(string fileName, string tempFile, int id)
    {

        bool isFound = WriteInNewFile(fileName, tempFile, id);


        if (isFound)
        {
            Console.WriteLine($"Student with Id: {id} Deleted Sucessfully");
            File.Delete(fileName);
            File.Move(tempFile, fileName);

            OptionChoose.PerformOperationAgain(fileName, tempFile);
        }
        else
        {
            Console.WriteLine($"ERROR: Student with Id: {id} not found in the file");
            File.Delete(tempFile);

            OptionChoose.PerformOperationAgain(fileName, tempFile);

        }


    }

    public static void DeleteAll(string fileName, string tempFile)
    {
        StreamReader reader = new StreamReader(fileName);
        StreamWriter writer = new StreamWriter(tempFile);

        while (reader.ReadLine() != null)
        {
            reader.ReadLine();

        }
        writer.WriteLine();

        reader.Close();
        writer.Close();

        File.Delete(fileName);
        File.Move(tempFile, fileName);

        Console.WriteLine("All data of Students deleted Successfully.");
        OptionChoose.PerformOperationAgain(fileName, tempFile);

    }
}

