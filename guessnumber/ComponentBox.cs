namespace guessnumber;
public class ComponentBox
    {
        public string String { get; private set; }
        public ConsoleColor Color{ get; private set; }
        
        public ComponentBox(string @string, ConsoleColor color=ConsoleColor.Green)
        {
            String = @string;
            Color = color;
        }
    }