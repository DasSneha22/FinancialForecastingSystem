using System;

namespace FinancialForecastingSystem
{
    public class FinancialForecast
    {
        /// <summary>
        /// Recursively predicts the future value based on a past growth rate.
        /// </summary>
        /// <param name="currentValue">The current financial value.</param>
        /// <param name="growthRate">The expected annual growth rate (e.g., 0.05 for 5%).</param>
        /// <param name="yearsRemaining">The number of years left to forecast.</param>
        /// <returns>The forecasted future value.</returns>
        public double PredictFutureValue(double currentValue, double growthRate, int yearsRemaining)
        {
            // 1. Base Case: If there are no years left to forecast, stop and return the value.
            if (yearsRemaining == 0)
            {
                return currentValue;
            }

            // 2. Recursive Case: Calculate the value for the next year.
            double nextYearValue = currentValue * (1 + growthRate);

            // Call the method again, passing the new value and decreasing the remaining years by 1.
            return PredictFutureValue(nextYearValue, growthRate, yearsRemaining - 1);
        }
    }
}