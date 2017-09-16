using System;
using System.Windows.Forms;

namespace Edison_Properties_Payment
{
    class Card_Processor
    {
        private ICard card;
        protected short fullyValid;
        
        
        public Card_Processor()
        {
            card = new Card_Application();
            card.startProcess += new EventHandler(processCard);
            
            Application.Run((Form)card);
        }
        protected void processCard(object sender, EventArgs e)
        {
            fullyValid = 0;
            if(!card.cardValid(card.cardNumber))
            {
                fullyValid += 1;
            }
            if(!card.expValid(card.expDate))
            {
                fullyValid += 2;
            }
            if(!card.cvvValid(card.cvv))
            {
                fullyValid += 4;
            }
            card.validNumber = fullyValid;

            if (fullyValid == 0)
                processCard(card.balance);
        }
        private void processCard(int balance)
        {  
            Random rnd = new Random();
            int price = rnd.Next(1, 100);
            card.completeTransaction = balance > price ? true : false;
            
        }
    }
}
