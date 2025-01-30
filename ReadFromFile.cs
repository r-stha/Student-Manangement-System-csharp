class ReadFromFile
{
    public static void Read(string fileName, string tempFile)
    {
        StreamReader reader = new(fileName);

        try
        {
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            string? read = reader.ReadLine();

            if (read == null)
            {
                Console.WriteLine("File  doesnot contain any data of the student!!\n");

            }
            else
            {
                while (read != null)
                {
                    Console.WriteLine(read);
                    read = reader.ReadLine();
                }
            }
            reader.Close();
            OptionChoose.PerformOperationAgain(fileName, tempFile);
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
}