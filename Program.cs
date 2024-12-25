class MainProgram
{
    public static int Main()
    {

        Menu.FileTypeMenu();
        (string? fileName, string? tempFile) = OptionChoose.FileChoice();

        Console.Clear();
        Menu.OperationMenu();
        OptionChoose.OperationOptionChoose(fileName, tempFile);

        return 0;

    }
}
