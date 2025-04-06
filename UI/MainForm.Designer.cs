namespace LoanCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeLightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeDarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukrainianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyPaymentLabel = new System.Windows.Forms.Label();
            this.monthlyPaymentTextBox = new System.Windows.Forms.TextBox();
            this.totalAmountOfPaymentsTextBox = new System.Windows.Forms.TextBox();
            this.amountOfOverpaymentsTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.amountOfOverpaymentsLabel = new System.Windows.Forms.Label();
            this.totalLoanCostLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.loanAmountLabel = new System.Windows.Forms.Label();
            this.percentLabel = new System.Windows.Forms.Label();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.monthsLabel = new System.Windows.Forms.Label();
            this.loanAmountTextBox = new System.Windows.Forms.TextBox();
            this.paymentTypeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.loanDurationMonthsTextBox = new System.Windows.Forms.TextBox();
            this.paymentTypeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.loanDurationLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.loanDurationYearsTextBox = new System.Windows.Forms.TextBox();
            this.mainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormMenuStrip
            // 
            resources.ApplyResources(this.mainFormMenuStrip, "mainFormMenuStrip");
            this.mainFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            // 
            // saveAsToolStripMenuItem
            // 
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem,
            this.jSONToolStripMenuItem});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            // 
            // cSVToolStripMenuItem
            // 
            resources.ApplyResources(this.cSVToolStripMenuItem, "cSVToolStripMenuItem");
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            // 
            // jSONToolStripMenuItem
            // 
            resources.ApplyResources(this.jSONToolStripMenuItem, "jSONToolStripMenuItem");
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            // 
            // propertiesToolStripMenuItem
            // 
            resources.ApplyResources(this.propertiesToolStripMenuItem, "propertiesToolStripMenuItem");
            this.propertiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            // 
            // themeToolStripMenuItem
            // 
            resources.ApplyResources(this.themeToolStripMenuItem, "themeToolStripMenuItem");
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeLightToolStripMenuItem,
            this.themeDarkToolStripMenuItem,
            this.themeDefaultToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            // 
            // themeLightToolStripMenuItem
            // 
            resources.ApplyResources(this.themeLightToolStripMenuItem, "themeLightToolStripMenuItem");
            this.themeLightToolStripMenuItem.Name = "themeLightToolStripMenuItem";
            this.themeLightToolStripMenuItem.Click += new System.EventHandler(this.themeLightToolStripMenuItem_Click);
            // 
            // themeDarkToolStripMenuItem
            // 
            resources.ApplyResources(this.themeDarkToolStripMenuItem, "themeDarkToolStripMenuItem");
            this.themeDarkToolStripMenuItem.Name = "themeDarkToolStripMenuItem";
            this.themeDarkToolStripMenuItem.Click += new System.EventHandler(this.themeDarkToolStripMenuItem_Click);
            // 
            // themeDefaultToolStripMenuItem
            // 
            resources.ApplyResources(this.themeDefaultToolStripMenuItem, "themeDefaultToolStripMenuItem");
            this.themeDefaultToolStripMenuItem.Name = "themeDefaultToolStripMenuItem";
            this.themeDefaultToolStripMenuItem.Click += new System.EventHandler(this.systemDefaultToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.ukrainianToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // ukrainianToolStripMenuItem
            // 
            resources.ApplyResources(this.ukrainianToolStripMenuItem, "ukrainianToolStripMenuItem");
            this.ukrainianToolStripMenuItem.Name = "ukrainianToolStripMenuItem";
            this.ukrainianToolStripMenuItem.Click += new System.EventHandler(this.ukrainianToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            resources.ApplyResources(this.historyToolStripMenuItem, "historyToolStripMenuItem");
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // monthlyPaymentLabel
            // 
            resources.ApplyResources(this.monthlyPaymentLabel, "monthlyPaymentLabel");
            this.monthlyPaymentLabel.Name = "monthlyPaymentLabel";
            // 
            // monthlyPaymentTextBox
            // 
            resources.ApplyResources(this.monthlyPaymentTextBox, "monthlyPaymentTextBox");
            this.monthlyPaymentTextBox.Name = "monthlyPaymentTextBox";
            this.monthlyPaymentTextBox.ReadOnly = true;
            // 
            // totalAmountOfPaymentsTextBox
            // 
            resources.ApplyResources(this.totalAmountOfPaymentsTextBox, "totalAmountOfPaymentsTextBox");
            this.totalAmountOfPaymentsTextBox.Name = "totalAmountOfPaymentsTextBox";
            this.totalAmountOfPaymentsTextBox.ReadOnly = true;
            // 
            // amountOfOverpaymentsTextBox
            // 
            resources.ApplyResources(this.amountOfOverpaymentsTextBox, "amountOfOverpaymentsTextBox");
            this.amountOfOverpaymentsTextBox.Name = "amountOfOverpaymentsTextBox";
            this.amountOfOverpaymentsTextBox.ReadOnly = true;
            // 
            // ClearButton
            // 
            resources.ApplyResources(this.ClearButton, "ClearButton");
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // amountOfOverpaymentsLabel
            // 
            resources.ApplyResources(this.amountOfOverpaymentsLabel, "amountOfOverpaymentsLabel");
            this.amountOfOverpaymentsLabel.Name = "amountOfOverpaymentsLabel";
            // 
            // totalLoanCostLabel
            // 
            resources.ApplyResources(this.totalLoanCostLabel, "totalLoanCostLabel");
            this.totalLoanCostLabel.Name = "totalLoanCostLabel";
            // 
            // calculateButton
            // 
            resources.ApplyResources(this.calculateButton, "calculateButton");
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // loanAmountLabel
            // 
            resources.ApplyResources(this.loanAmountLabel, "loanAmountLabel");
            this.loanAmountLabel.Name = "loanAmountLabel";
            // 
            // percentLabel
            // 
            resources.ApplyResources(this.percentLabel, "percentLabel");
            this.percentLabel.Name = "percentLabel";
            // 
            // interestRateTextBox
            // 
            resources.ApplyResources(this.interestRateTextBox, "interestRateTextBox");
            this.interestRateTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.interestRateTextBox.Name = "interestRateTextBox";
            // 
            // monthsLabel
            // 
            resources.ApplyResources(this.monthsLabel, "monthsLabel");
            this.monthsLabel.Name = "monthsLabel";
            // 
            // loanAmountTextBox
            // 
            resources.ApplyResources(this.loanAmountTextBox, "loanAmountTextBox");
            this.loanAmountTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loanAmountTextBox.Name = "loanAmountTextBox";
            this.loanAmountTextBox.Leave += new System.EventHandler(this.loanAmountTextBox_Leave);
            // 
            // paymentTypeRadioButton2
            // 
            resources.ApplyResources(this.paymentTypeRadioButton2, "paymentTypeRadioButton2");
            this.paymentTypeRadioButton2.Name = "paymentTypeRadioButton2";
            this.paymentTypeRadioButton2.TabStop = true;
            this.paymentTypeRadioButton2.UseVisualStyleBackColor = true;
            // 
            // loanDurationMonthsTextBox
            // 
            resources.ApplyResources(this.loanDurationMonthsTextBox, "loanDurationMonthsTextBox");
            this.loanDurationMonthsTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loanDurationMonthsTextBox.Name = "loanDurationMonthsTextBox";
            // 
            // paymentTypeRadioButton1
            // 
            resources.ApplyResources(this.paymentTypeRadioButton1, "paymentTypeRadioButton1");
            this.paymentTypeRadioButton1.Name = "paymentTypeRadioButton1";
            this.paymentTypeRadioButton1.TabStop = true;
            this.paymentTypeRadioButton1.UseVisualStyleBackColor = true;
            // 
            // paymentTypeLabel
            // 
            resources.ApplyResources(this.paymentTypeLabel, "paymentTypeLabel");
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            // 
            // loanDurationLabel
            // 
            resources.ApplyResources(this.loanDurationLabel, "loanDurationLabel");
            this.loanDurationLabel.Name = "loanDurationLabel";
            // 
            // interestRateLabel
            // 
            resources.ApplyResources(this.interestRateLabel, "interestRateLabel");
            this.interestRateLabel.Name = "interestRateLabel";
            // 
            // yearsLabel
            // 
            resources.ApplyResources(this.yearsLabel, "yearsLabel");
            this.yearsLabel.Name = "yearsLabel";
            // 
            // loanDurationYearsTextBox
            // 
            resources.ApplyResources(this.loanDurationYearsTextBox, "loanDurationYearsTextBox");
            this.loanDurationYearsTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loanDurationYearsTextBox.Name = "loanDurationYearsTextBox";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.loanDurationYearsTextBox);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.monthlyPaymentLabel);
            this.Controls.Add(this.monthlyPaymentTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalAmountOfPaymentsTextBox);
            this.Controls.Add(this.mainFormMenuStrip);
            this.Controls.Add(this.amountOfOverpaymentsTextBox);
            this.Controls.Add(this.loanAmountLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.amountOfOverpaymentsLabel);
            this.Controls.Add(this.loanDurationLabel);
            this.Controls.Add(this.totalLoanCostLabel);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.interestRateTextBox);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.paymentTypeRadioButton1);
            this.Controls.Add(this.monthsLabel);
            this.Controls.Add(this.loanDurationMonthsTextBox);
            this.Controls.Add(this.paymentTypeRadioButton2);
            this.Controls.Add(this.loanAmountTextBox);
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeLightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeDarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukrainianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.Label monthlyPaymentLabel;
        private System.Windows.Forms.TextBox monthlyPaymentTextBox;
        private System.Windows.Forms.TextBox totalAmountOfPaymentsTextBox;
        private System.Windows.Forms.TextBox amountOfOverpaymentsTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label amountOfOverpaymentsLabel;
        private System.Windows.Forms.Label totalLoanCostLabel;
        private System.Windows.Forms.Label loanAmountLabel;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.Label monthsLabel;
        private System.Windows.Forms.TextBox loanAmountTextBox;
        private System.Windows.Forms.RadioButton paymentTypeRadioButton2;
        private System.Windows.Forms.TextBox loanDurationMonthsTextBox;
        private System.Windows.Forms.RadioButton paymentTypeRadioButton1;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.Label loanDurationLabel;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ToolStripMenuItem themeDefaultToolStripMenuItem;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.TextBox loanDurationYearsTextBox;
    }
}

