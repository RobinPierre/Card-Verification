using System;
using System.Linq;
using System.Windows.Forms;
namespace Edison_Properties_Payment
{
    public partial class Card_Application : Form, ICard
    {
        public event EventHandler startProcess;
        string ICard.cardNumber { get { return textBoxCCNum.Text; } }
        string ICard.expDate { get { return textBoxExpiration.Text; } }
        string ICard.cvv { get { return textBoxCVV.Text; } }
        int ICard.balance { get { return rnd.Next(1, 50); } }
        bool ICard.completeTransaction { set { approved = value; } }
        private bool approved;
        short ICard.validNumber
        {
            set
            {
                if (value > 0)
                    validNumber = (errorValid)value;
                else 
                    MessageBox.Show("Your transaction has been " +  (approved ? "approved." : "declined."),
                    "Transaction Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateError();
            }
        }
        private errorValid validNumber;

        private void updateError()
        {
            labelValidation.Visible = false;
            labelValidation.Text = "Please check the following:\n";
            if ((validNumber & errorValid.CardNumber) == errorValid.CardNumber)
                labelValidation.Text += "\u2022 Credit/Debit Card Number\n";
            if((validNumber & errorValid.ExpDate) == errorValid.ExpDate)
                labelValidation.Text += "\u2022 Expiration Date\n";
            if((validNumber & errorValid.Cvv) == errorValid.Cvv)
                labelValidation.Text += "\u2022 CVV";
            if(validNumber > 0)
                labelValidation.Visible = true;
        }

        [FlagsAttribute]
        public enum errorValid : short
        {
            CardNumber = 1,
            ExpDate = 2,
            Cvv = 4,
        };
        private Random rnd;
        public Card_Application()
        {
            InitializeComponent();
            rnd = new Random();
        }
        /// <summary>
        /// I found that Microsoft has a Credit Card Validation tool but I don't have that dll file.
        /// Howeever I was able to find the syntax on how they validated card numbers on their reference website.
        /// http://referencesource.microsoft.com/#System.ComponentModel.DataAnnotations/DataAnnotations/CreditCardAttribute.cs
        /// I modified the code for this particular program.
        /// </summary>
        /// <param name="value">The Card Number inputted into the textbox</param>
        /// <returns></returns>
        bool ICard.cardValid(string cardNumber)
        {
            if (cardNumber == "")
            {
                return false;
            }
            cardNumber = cardNumber.Replace("-", "");
            cardNumber = cardNumber.Replace(" ", "");

            int checksum = 0;
            bool evenDigit = false;

            foreach (char digit in cardNumber.Reverse())
            {
                if (digit < '0' || digit > '9')
                {
                    return false;
                }

                int digitValue = (digit - '0') * (evenDigit ? 2 : 1);
                evenDigit = !evenDigit;

                while (digitValue > 0)
                {
                    checksum += digitValue % 10;
                    digitValue /= 10;
                }
            }

            return (checksum % 10) == 0;
        }


        bool ICard.expValid(string expDate)
        {
            expDate = expDate.Replace("/", "");
            if (expDate.Length != 4)
                return false;
            string month = expDate.Substring(0, 2);
            string year =  expDate.Substring(2, 2);

            if (Convert.ToInt32(year) < 17)
                return false;
            else if (Convert.ToInt32(month) < 6 && Convert.ToInt32(year) == 17 || Convert.ToInt32(month) > 12)
                return false;
            return true;
        }
         bool ICard.cvvValid(string cvv)
        {
            int temp;
            try
            {
                temp = Convert.ToInt32(cvv);
            }
            catch
            {
                return false;
            }
            return temp > 99 ? true : false;
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (startProcess != null)
                startProcess(this, EventArgs.Empty);
        }
    }
}
