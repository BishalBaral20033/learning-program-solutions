using System;

class FinancialForecast
{
    // Recursive method to calculate future value
    static double PredictFutureValueRecursive(double initialValue, double growthRate, int years)
    {
        if (years == 0)
            return initialValue;

        return PredictFutureValueRecursive(initialValue, growthRate, years - 1) * (1 + growthRate);
    }

    // Iterative method to calculate future value
    static double PredictFutureValueIterative(double initialValue, double growthRate, int years)
    {
        double value = initialValue;
        for (int i = 0; i < years; i++)
        {
            value *= (1 + growthRate);
        }
        return value;
    }

    static void Main()
    {
        Console.Write("Enter initial investment amount: ");
        double initialValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual growth rate (in percent, e.g., 10 for 10%): ");
        double growthPercent = Convert.ToDouble(Console.ReadLine());
        double growthRate = growthPercent / 100.0;

        Console.Write("Enter number of years to forecast: ");
        int years = Convert.ToInt32(Console.ReadLine());

        double futureRecursive = PredictFutureValueRecursive(initialValue, growthRate, years);
        double futureIterative = PredictFutureValueIterative(initialValue, growthRate, years);

        Console.WriteLine($"\nForecasting result after {years} years:");
        Console.WriteLine($"Recursive prediction: {futureRecursive:F2}");
        Console.WriteLine($"Iterative prediction: {futureIterative:F2}");
    }
}
