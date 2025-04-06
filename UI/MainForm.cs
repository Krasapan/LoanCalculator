using LoanCalculator.AdditionalFeatures;
using LoanCalculator.BusinessLogic;
using LoanCalculator.UI.DarkMode;
using System;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class MainForm : Form
    {
        private readonly LoanCalculation _loanCalculation;
        private readonly HistoryManager _historyManager;
        private readonly DarkModeCS _darkMode;


        public MainForm(LoanCalculation loanCalculation, HistoryManager historyManager)
        {
            InitializeComponent();
            _loanCalculation = loanCalculation;
            _historyManager = historyManager;
            _darkMode = new DarkModeCS(this);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ClearTextBoxes();
            RefreshHistoryMenu();
            LoadTheme();
        }


        private async void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal loanAmount = ParseDecimal(loanAmountTextBox.Text, "Loan amount");
                int years = ParseInt(loanDurationYearsTextBox.Text, "Loan duration (years)");
                int months = ParseInt(loanDurationMonthsTextBox.Text, "Loan duration (months)");
                int totalMonths = years * 12 + months;
                decimal annualRate = ParseDecimal(interestRateTextBox.Text, "Interest rate");
                string paymentType = paymentTypeRadioButton1.Checked ? "Annuity" : "Differentiated";

                decimal monthlyPayment = 0;
                decimal totalPayment = 0;

                if (paymentTypeRadioButton1.Checked)
                {
                    monthlyPayment = _loanCalculation.CalculateMonthlyPaymentAnnual(loanAmount, annualRate, totalMonths);
                    totalPayment = monthlyPayment * totalMonths;
                }
                else if (paymentTypeRadioButton2.Checked)
                {
                    totalPayment = _loanCalculation.CalculateTotalPaymentDifferentiated(loanAmount, annualRate, totalMonths);
                    monthlyPaymentTextBox.Text = "—";
                }
                else
                {
                    ShowError("Select payment type.");
                    return;
                }

                decimal overpayment = totalPayment - loanAmount;

                _historyManager.AddEntry(loanAmount, years, months, annualRate, paymentType);
                RefreshHistoryMenu();

                monthlyPaymentTextBox.Text = monthlyPayment > 0 ? $"{monthlyPayment:C}" : "—";
                totalAmountOfPaymentsTextBox.Text = $"{totalPayment:C}";
                amountOfOverpaymentsTextBox.Text = $"{overpayment:C}";
            }
            catch (Exception ex)
            {
                ShowError($"Calculation error: {ex.Message}");
            }
        }


        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private decimal ParseDecimal(string input, string fieldName)
        {
            if (!decimal.TryParse(input, out decimal result))
            {
                throw new ArgumentException($"Incorrect value for {fieldName}.");
            }
            return result;
        }

        private int ParseInt(string input, string fieldName)
        {
            if (!int.TryParse(input, out int result))
            {
                throw new ArgumentException($"Incorrect value for {fieldName}.");
            }
            return result;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            loanAmountTextBox.Text = "0";
            loanDurationMonthsTextBox.Text = "0";
            loanDurationYearsTextBox.Text = "0";
            interestRateTextBox.Text = "0";
            monthlyPaymentTextBox.Text = string.Empty;
            totalAmountOfPaymentsTextBox.Text = string.Empty;
            amountOfOverpaymentsTextBox.Text = string.Empty;
        }

        private void RefreshHistoryMenu()
        {
            historyToolStripMenuItem.DropDownItems.Clear();
            foreach (var entry in _historyManager.GetHistory())
            {
                var menuItem = new ToolStripMenuItem(entry.ToString())
                {
                    Tag = entry
                };
                menuItem.Click += historyToolStripMenuItem_Click;
                historyToolStripMenuItem.DropDownItems.Add(menuItem);
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var localizationManager = new LocalizationManager();
            localizationManager.UpdateConfig("language", "en");
            Application.Restart();
        }

        private void ukrainianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var localizationManager = new LocalizationManager();
            localizationManager.UpdateConfig("language", "uk");
            Application.Restart();
        }

        private void loanAmountTextBox_Leave(object sender, EventArgs e)
        {
            // треба це пофіксити (коли воно форматує вхідне значення а потім ти знову натискаєш і втрачаєш фокус, то воно каже, що формат неправильний)
            //string input = loanAmountTextBox.Text.Replace(',', '.');
            //if (double.TryParse(input, out double result))
            //{
            //    loanAmountTextBox.Text = string.Format("{0:#,##0.00}", result);
            //}
            //else
            //{
            //    MessageBox.Show("Incorrect loan amount value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && menuItem.Tag is HistoryManager.CalculationEntry entry)
            {
                loanAmountTextBox.Text = entry.LoanAmount.ToString();
                loanDurationYearsTextBox.Text = entry.Years.ToString();
                loanDurationMonthsTextBox.Text = entry.Months.ToString();
                interestRateTextBox.Text = entry.InterestRate.ToString();

                if (entry.PaymentType == "Annuity")
                    paymentTypeRadioButton1.Checked = true;
                else
                    paymentTypeRadioButton2.Checked = true;

                calculateButton_Click(null, null);
            }
        }

        private void LoadTheme()
        {
            if (Enum.TryParse(Properties.Settings.Default.UserTheme, out DarkModeCS.DisplayMode savedTheme))
            {
                _darkMode.ColorMode = savedTheme;
            }
        }

        private void ChangeTheme(DarkModeCS.DisplayMode mode)
        {
            _darkMode.ColorMode = mode;
            Properties.Settings.Default.UserTheme = mode.ToString();
            Properties.Settings.Default.Save();
        }

        private void themeDarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme(DarkModeCS.DisplayMode.DarkMode);
            Application.Restart();
        }

        private void themeLightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme(DarkModeCS.DisplayMode.ClearMode);
            Application.Restart();
        }

        private void systemDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme(DarkModeCS.DisplayMode.SystemDefault);
            Application.Restart();
        }
    }
}
