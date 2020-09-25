using System;
using System.Collections.Generic;
using System.Text;

namespace Sobreposicao_PalavraVirtual_Override_Base.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        /*public override void Withdraw(double amount) - É utilizado o override para que seja possível sobrescrever o método da superclasse implementando um comportamento diferente do método existente na SuperClasse.
        {
            Balance -= amount; - Agora é possível descontar o valor do saque sem a taxa de 5.00 da conta comum.      
        }
        */

        /*
        * PALAVRA BASE:
        - Neste contexto é possível chamar a implementação da superclasse usando a palavra base.

        Exemplo: Suponha que a regra para saque para a conta poupança seja realizar o saque normalmente da superclasse(Account), e depois descontar mais 2.00.
        */
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); //Com a palavra BASE é possível utilizar o método(Withdraw) da superclasse "Account" normalmente conforme a regra implementada na superclasse conseguindo reaproveitar o método e mesmo assim depois podendo acrescentar outra operação depois
            Balance -= 2.0; //Desconta mais 2.00 reais do valor da conta no momento do saque.
        }

    }
}
