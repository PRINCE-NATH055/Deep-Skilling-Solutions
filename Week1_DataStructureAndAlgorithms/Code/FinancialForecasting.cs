using System;
class FinancialForecasting
{
    static double ForecastRecursive(double currentValue, double rate, int periods)
    {
        if (periods == 0)
            return currentValue;

        return ForecastRecursive(currentValue * (1 + rate), rate, periods - 1);
    }

    static void Main()
    {
        double initialValue = 1000;
        double rate = 0.05;
        int periods = 5;
        
        double recursiveResult = ForecastRecursive(initialValue, rate, periods);
        Console.WriteLine($"Recursive: {recursiveResult:F2} (O(n))");        
    }
}
