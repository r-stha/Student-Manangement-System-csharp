class Input
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

    public static (int, string, int) TakeStudentData(int i)
    {
        Console.WriteLine($"Enter the id of the {i} Student:");
        int id = GetValidInput();

        Console.WriteLine($"Enter the name of the {i} Student:");
        string? name = Console.ReadLine();

        Console.WriteLine($"Enter the Grade of the {i} Student:");
        int grade = GetValidInput();

        if (name is not null)
            return (id, name, grade);

        return (0, "", 0);



    }
}