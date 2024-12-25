class Delete
{

    public static bool WriteInNewFile(string originalFile, string tempFile, int id)
    {
        bool isSkipped = false;

        using (StreamReader reader = new(originalFile))
        using (StreamWriter writer = new(tempFile))
        {
            string? data;
            while ((data = reader.ReadLine()) != null)
            {

                if (data.Contains($"id: {id}"))
                {
                    isSkipped = true;
                    reader.ReadLine();
                    reader.ReadLine();
                    reader.ReadLine();

                   continue;
                }
                writer.WriteLine(data);

            }

        }
        return isSkipped;

    }

    public static void DeleteFromFile(string fileName, string tempFile,int id)
    {


        bool isFound = WriteInNewFile(fileName, tempFile, id);


        if (isFound)
        {
            Console.WriteLine($"Student with Id: {id} Deleted Sucessfully");
            File.Delete(fileName);
            File.Move(tempFile, fileName);
        }
        else
        {
            Console.WriteLine($"ERROR: Student with Id: {id} not found in the file");
            File.Delete(tempFile);
        }


    }
}