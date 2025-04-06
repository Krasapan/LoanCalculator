using LoanCalculator.AdditionalFeatures;
using LoanCalculator.BusinessLogic;
using System;
using System.Configuration;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static async Task Main()
        {
            var loanCalculation = new LoanCalculation();
            var historyManger = new HistoryManager();
            var language = ConfigurationManager.AppSettings["language"];
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(loanCalculation, historyManger));
        }
    }
}
