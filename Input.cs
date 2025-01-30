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

    public static void TakeStudentData(int i, out int id, out string? name, out int grade)
    {
        Console.Clear();

        Console.WriteLine($"Enter the id of the {i} Student:");
        id = GetValidInput();

        Console.WriteLine($"Enter the name of the {i} Student:");
        name = Console.ReadLine();

        Console.WriteLine($"Enter the Grade of the {i} Student:");
        grade = GetValidInput();

    }
}