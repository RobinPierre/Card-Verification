using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edison_Properties_Payment
{
    internal interface ICard
    {
        string cardNumber { get; }
        string expDate { get; }
        string cvv { get; }
        int balance { get; }
        short validNumber { set; }
        bool completeTransaction { set; }

        event EventHandler startProcess;

        bool cardValid(string cardNumber);
        bool expValid(string expDate);
        bool cvvValid(string cvv);
    }
}
