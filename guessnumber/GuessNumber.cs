namespace guessnumber;

public class GuessNumber
{
    private Output _output = new Output(); 
    private ConsoleOutput _consoleOut = new ConsoleOutput();
    private Game _game = new Game();
    
    private Input _input = new Input();
    private ConsoleInput _consoleInput = new ConsoleInput();


    public GuessNumber()
    {
        _output.PrintEvent += _consoleOut.Print;
        _output.ClearScreenEvent += _consoleOut.ClearScreen;
        _game.InputEvent += _consoleInput.Input;
        Begin();
    }

    public void Begin()
    {
        _output.ClearScreen();
        _output.Print(new ComponentBox("Input code from 0000 to 9999, X - Correct number and correct place of number, Y - Correct number wrong place of the number."));
        
        //_output.Print(new ComponentBox(_game._rndNumber));//debug
        do
        {
            _game.GameStatus = GameStatus.InProgress;
            CheckNumber();
        } while (_game.GameStatus == GameStatus.InProgress);
        _output.Print(new ComponentBox($"Congratulations you guessed number, press any key to start new game"));
        Console.ReadKey();
        _game.NewGame();
        Begin();
    }

    public void CheckNumber()
    {
        try
        {
            _output.Print(new ComponentBox(_game.CheckNumner()));
        }
        catch (Exception e)
        {
            _output.Print(new ComponentBox(e.Message.ToString()));
            CheckNumber();
        }
    }
}