using System;
using System.Collections.Generic;

namespace LoanCalculator.AdditionalFeatures
{
    public class HistoryManager
    {
        public class CalculationEntry
        {
            public decimal LoanAmount { get; set; }
            public int Years { get; set; }
            public int Months { get; set; }
            public decimal InterestRate { get; set; }
            public decimal AdditionalCosts { get; set; }
            public string PaymentType { get; set; }
            public DateTime Timestamp { get; set; }

            public override string ToString()
            {
                return $"{Timestamp:G} - {LoanAmount:C}, {Years} years, {Months} months, {InterestRate}% ({PaymentType})";
            }
        }

        private readonly List<CalculationEntry> _history = new List<CalculationEntry>();

        public void AddEntry(decimal loanAmount, int years, int months, decimal interestRate, string paymentType)
        {
            _history.Add(new CalculationEntry
            {
                LoanAmount = loanAmount,
                Years = years,
                Months = months,
                InterestRate = interestRate,
                PaymentType = paymentType,
                Timestamp = DateTime.Now
            });
        }
        public IReadOnlyList<CalculationEntry> GetHistory()
        {
            return _history.AsReadOnly();
        }
    }
}
