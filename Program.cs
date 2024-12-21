class MainProgram
{
    public static int Main()
    {

        Menu.FileTypeMenu();
        string? fileName = OptionChoose.FileChoice();

        Console.Clear();
        Menu.OperationMenu();
        OptionChoose.OperationOptionChoose(fileName);

        return 0;

    }
}
