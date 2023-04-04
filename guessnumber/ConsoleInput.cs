namespace guessnumber;

public class ConsoleInput : IInput
{
    public string? Input()
    {
        string? input = Console.ReadLine();
        if (input.Length == 4 && input != String.Empty)
        {
            bool result = int.TryParse(input, out int number);
            if (result)
            {
                return input;
            }
            else
            {
                throw new Exception("It should be a 4 digit number.");
            }
        }
        else
        {
            throw new Exception("It should be a 4 digit number.");
        }
    }
}