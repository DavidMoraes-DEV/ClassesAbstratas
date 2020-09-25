using System;
using System.Collections.Generic;
using System.Text;

namespace Sobreposicao_PalavraVirtual_Override_Base.Entities
{
    abstract class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) //É preciso utilizar a palavra Virtual para que seja possível que o método de saque(Withdraw) poderá ser sobreposto nas subclasses.
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
