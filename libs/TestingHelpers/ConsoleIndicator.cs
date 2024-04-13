namespace Quiz;

public class ConsoleIndicator : IDisposable {

    private ConsoleIndicator(ConsoleColor? foreground_color, ConsoleColor? background_color) {
        m_ForegroundColor = Console.ForegroundColor;
        m_BackgroundColor = Console.BackgroundColor;

        if (foreground_color != null) {
            Console.ForegroundColor = foreground_color.Value;
        }
        if (background_color != null) {
            Console.BackgroundColor = background_color.Value;
        }
    }
        
    private readonly ConsoleColor m_ForegroundColor;
        
    private readonly ConsoleColor m_BackgroundColor;

    public void Dispose() {
        Console.ForegroundColor = m_ForegroundColor;
        Console.BackgroundColor = m_BackgroundColor;
    }
        
    public static IDisposable Passed() => new ConsoleIndicator(ConsoleColor.Green, null);

    public static IDisposable Failed() => new ConsoleIndicator(ConsoleColor.White, ConsoleColor.Red);

    public static IDisposable Exception() => new ConsoleIndicator(ConsoleColor.White, ConsoleColor.Magenta);

    public static IDisposable Result() => new ConsoleIndicator(ConsoleColor.White, ConsoleColor.DarkBlue);

}