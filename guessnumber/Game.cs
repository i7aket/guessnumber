namespace guessnumber;

public class Game
{
    public GameStatus GameStatus;
    private Random _rnd = new Random();
    private string _rndNumber;
    private const int NumberLength = 4;

    public delegate string InputDelegate();
    public event InputDelegate InputEvent;
    
    public Game()
    {
        NewGame();
    }
    

    public void NewGame()
    {
        _rndNumber = CreateRndNumber();
        GameStatus = GameStatus.InProgress;
        
        //_rndNumber = "0099"; //debug
    }
    
    private string CreateRndNumber()
    {
        string randomNumber = String.Empty;
        for (int i = 0; i < NumberLength; i++)
        {
            randomNumber += _rnd.Next(0, 9).ToString();
        }
        return randomNumber;
    }  
    
    
    public string RizeInput()
    {
        if (InputEvent != null)
        {
            return InputEvent();
        }
        else
        {
            throw new InvalidOperationException("There is no registered Event ");
        }
    }
    
    public string CheckNumner()
    {
        string inputNumber = RizeInput(); 
        if (inputNumber == _rndNumber)
        {
            GameStatus = GameStatus.EndGame;
            return inputNumber + " XXXX";
        }
        else
        {
            string result = String.Empty;
            char[] charInputNumber = inputNumber.ToCharArray();
            char[] charRndNumber = _rndNumber.ToCharArray();
            
            // Checking for X 
            for (int i = 0; i < NumberLength; i++)
            {
                if (charInputNumber[i] == charRndNumber[i])
                {
                    result += "X";
                    charRndNumber[i] = 'Z';  
                }
            }
            
            // Checking for Y
            for (int i = 0; i < NumberLength; i++)
            {
                for (int n = 0; n < NumberLength; n++)
                {
                    if (charInputNumber[i] == charRndNumber[n])
                    {
                        result += "Y";
                        charRndNumber[n] = 'Z';
                    }
                } 
            } 
            return inputNumber + " " +result;
        }
    }
}