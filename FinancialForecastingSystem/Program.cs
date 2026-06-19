using System;

namespace FinancialForecastingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            FinancialForecast forecaster = new FinancialForecast();

            // Setup our initial data based on past performance
            double initialInvestment = 10000.00; // Rs.10,000
            double pastGrowthRate = 0.08;        // 8% average past growth
            int yearsToForecast = 10;            // Predict 10 years into the future

            Console.WriteLine("--- Financial Forecasting Tool ---");
            Console.WriteLine($"Initial Value: Rs.{initialInvestment:N2}");
            Console.WriteLine($"Expected Growth Rate: {pastGrowthRate * 100}% per year");
            Console.WriteLine($"Forecasting Horizon: {yearsToForecast} years\n");

            // Execute the recursive algorithm
            double futureValue = forecaster.PredictFutureValue(initialInvestment, pastGrowthRate, yearsToForecast);

            Console.WriteLine($" Predicted Future Value: Rs.{futureValue:N2}");

            // Keep the console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}