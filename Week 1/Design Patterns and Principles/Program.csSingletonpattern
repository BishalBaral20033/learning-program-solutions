using System;

class Logger
{
    private static Logger? _instance;

    private static readonly object _lock = new object();

    // Private constructor to prevent external instantiation
    private Logger()
    {
        Console.WriteLine("Logger initialized.");
    }

    // Public method to get the single instance
    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock) // Thread safety
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
            }
        }
        return _instance;
    }

    // Method to log messages
    public void Log(string message)
    {
        Console.WriteLine($"[Log]: {message}");
    }
}

class Program
{
    static void Main()
    {
        // Get the singleton instance
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        // Use the logger
        logger1.Log("First message");
        logger2.Log("Second message");

        // Check if both instances are the same
        if (ReferenceEquals(logger1, logger2))
        {
            Console.WriteLine("Logger is a singleton. Only one instance exists.");
        }
        else
        {
            Console.WriteLine("Logger is NOT a singleton.");
        }
    }
}
