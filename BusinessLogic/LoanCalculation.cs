using System;

namespace LoanCalculator.BusinessLogic
{
    public class LoanCalculation
    {
        public decimal CalculateMonthlyPaymentAnnual(decimal loanAmount, decimal annualRate, int months)
        {
            decimal monthlyRate = annualRate / 12 / 100;
            decimal numerator = monthlyRate * (decimal)Math.Pow((double)(1 + monthlyRate), months);
            decimal denominator = (decimal)Math.Pow((double)(1 + monthlyRate), months) - 1;

            return loanAmount * numerator / denominator;
        }

        public decimal CalculateTotalPaymentDifferentiated(decimal loanAmount, decimal annualRate, int months)
        {
            decimal totalPayment = 0;
            decimal monthlyRate = annualRate / 12 / 100;

            for (int i = 0; i < months; i++)
            {
                decimal principalPart = loanAmount / months;
                decimal interestPart = (loanAmount - principalPart * i) * monthlyRate;
                totalPayment += principalPart + interestPart;
            }

            return totalPayment;
        }

        public decimal CalculateOverpayment(decimal loanAmount, decimal totalPayment)
        {
            return totalPayment - loanAmount;
        }

    }
}
