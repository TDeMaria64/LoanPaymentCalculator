using System;
using System.Windows.Forms;

/* Tristan DeMaria, CSCI-1630, October 17th, 2021
 * Interest-Adjusted Monthly Payment Calculator
 * Create a calculator that will determine the total monthly payments
 * on a given purchase with an interest rate on a loan.
 * User must enter in the purchase price, their down payment,
 * the interest rate of the loan, and the number of months
 * over which they plan to pay off the loan.
 * The program will process the information input in two ways:
 * first it will subtract the down payment from the purchase price,
 * and second it will calculate the monthly interest-adjusted payments
 * via the calcultation outlined in the prompt.
 * The program should notify the user if a field is empty or if
 * the field contains an invalid value. This should be accomplished via
 * validation and the tryparse method.
 * The GUI must include fields to enter all the user data,
 * fields to display the results, labels for the fields,
 * a calculate button that will run the program
 * and a close button to close the program.
 * Almost everything the program does should occur when
 * the Calculate button is pressed.
 */

namespace Exercise4
{
    public partial class monthlyPaymentCalcForm : Form
    {
        double purchasePrice, downPayment, interestRate, interestRatePercent;
        int loanTerm;

        public monthlyPaymentCalcForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable; //turn off auto validation
        }

        /// <summary>
        /// Upon button-click, the program should check if each interactable field
        /// is empty or holding an invalid value via the tryparse method,
        /// then calculate the end results if all fields are valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            bool tryPurchase = double.TryParse(purchasePriceBox.Text, out purchasePrice);
            if (purchasePriceBox.Text == "") {
                purchasePriceBox.BackColor = System.Drawing.Color.Tomato;
                MessageBox.Show("Field cannot be empty.");
            }
            else if (tryPurchase == false) {
                purchasePriceBox.BackColor = System.Drawing.Color.Tomato;
                MessageBox.Show("Entry must be a valid decimal number.");
            }
            else {
                purchasePriceBox.BackColor = System.Drawing.SystemColors.Window;
            }

            bool tryDown = double.TryParse(downPaymentBox.Text, out downPayment);
            if (downPaymentBox.Text == "") {
                downPaymentBox.BackColor = System.Drawing.Color.Tomato;
                MessageBox.Show("Field cannot be empty.");
            }
            else if (tryDown == false) {
                downPaymentBox.BackColor = System.Drawing.Color.Tomato;
                MessageBox.Show("Entry must be a valid decimal number.");
            }
            else {
                downPaymentBox.BackColor = System.Drawing.SystemColors.Window;
            }

            bool tryInterest = double.TryParse(interestRateBox.Text, out interestRate);
            if (interestRateBox.Text == "") {
                interestRateBox.BackColor = System.Drawing.Color.Tomato;
                MessageBox.Show("Field cannot be empty.");
            }
            else if (tryInterest == false) {
                interestRateBox.BackColor = System.Drawing.Color.Tomato;
                MessageBox.Show("Entry must be a valid decimal number.");
            }
            else {
                interestRateBox.BackColor = System.Drawing.SystemColors.Window;
                interestRatePercent = interestRate / 100 / 12;
            }

            bool tryLoan = int.TryParse(loanTermBox.Text, out loanTerm);
            if (loanTermBox.Text == "") {
                loanTermBox.BackColor = System.Drawing.Color.Tomato;
                MessageBox.Show("Field cannot be empty.");
            }
            else if (tryLoan == false) {
                loanTermBox.BackColor = System.Drawing.Color.Tomato;
                MessageBox.Show("Entry must be a valid integer.");
            }
            else {
                loanTermBox.BackColor = System.Drawing.SystemColors.Window;
            }

            if (tryPurchase && tryDown && tryInterest && tryLoan) {
                double financeAmount = purchasePrice - downPayment;
                string financeAmountText = $"{financeAmount:C}";
                financeAmountBox.Text = $"{financeAmountText}";

                double monthlyAmount = interestRatePercent * financeAmount * (((Math.Pow((1 + interestRatePercent), loanTerm))) / ((Math.Pow((1 + interestRatePercent), loanTerm)) - 1));
                string monthlyAmountText = $"{monthlyAmount:C}";
                monthlyAmountBox.Text = $"{monthlyAmountText}";
            }
        } 

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
