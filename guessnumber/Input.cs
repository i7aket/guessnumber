namespace guessnumber;

public class Input
{
    public delegate string InputDelegate();

    public event InputDelegate InputEvent;

    public string RizeInput()
    {
        if (InputEvent != null)
        {
            return InputEvent();
        }
        else
        {
            throw new InvalidOperationException("there is no registered Event ");
        }
    }
}