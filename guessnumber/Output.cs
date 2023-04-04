namespace guessnumber;

public class Output
{
    public delegate void PrintDelegate(ComponentBox componentBox);

    public event PrintDelegate PrintEvent;

    public void Print(ComponentBox componentBox)
    {
        if (PrintEvent != null)
        {
            PrintEvent(componentBox);
        }
    }
    
    public delegate void ClearScreenDelegate();

    public event ClearScreenDelegate ClearScreenEvent;

    public void ClearScreen()
    {
        if (ClearScreenEvent != null)
        {
            ClearScreenEvent();
        }
    }
}
