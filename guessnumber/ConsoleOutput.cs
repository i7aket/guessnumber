namespace guessnumber;

public class ConsoleOutput : IOutPut
{
    public void Print(ComponentBox outputBox)
    {
        Console.ForegroundColor = outputBox.Color;
        Console.WriteLine(outputBox.String);
        
    }

    public void ClearScreen()
    {
        Console.Clear();
    }
}
