class MainProgram
{
    public static void Main()
    {

        Menu.FileTypeMenu();
        OptionChoose.FileChoice(out string? fileName, out string? tempFile);

        Console.Clear();
        Menu.OperationMenu();
        OptionChoose.OperationOptionChoose(fileName, tempFile);

    }
}
