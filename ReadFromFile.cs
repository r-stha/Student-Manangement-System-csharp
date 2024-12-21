class ReadFromFile
{
    public static void Read(string FileName)
    {
        StreamReader reader = new(FileName);

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