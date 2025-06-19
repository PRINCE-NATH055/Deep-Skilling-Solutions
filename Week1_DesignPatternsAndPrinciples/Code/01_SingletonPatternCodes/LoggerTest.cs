class LoggerTest
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        logger1.Log("First log message.");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("Second log message.");

        if (logger1 == logger2)
        {
            System.Console.WriteLine("Both logger instances are the same.");
        }
        else
        {
            System.Console.WriteLine("Logger instances are different.");
        }
    }
}
