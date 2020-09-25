using Sobreposicao_PalavraVirtual_Override_Base.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* * CLASSES ABSTRATAS:
               - São classes que não podem ser instanciadas.
               - É uma forma de garantir herança total: somente subclasses não abstratas podem ser instanciadas, mas nunca a superclasse abstrata.
             */

            //Account acc1 = new Account(1001, "Alex", 500.0); - Com a classe Account como abstrata ela não pode ser instanciada
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            /* * QUESTIONAMENTO:
               - Se a classe Account não pode ser instanciada, porque simplesmente não criar somente SavingsAccount e BusinessAccount?
              -- RESPOSTA:
               - Reuso
               - Polimorfismo: A superclasse classe generica nos permite tratar de forma fácil e uniforme todos os tipos de conta, incluse com polimorfismo se for o caso(Como fizemos nos últimos exercícios). Por exemplo, você pode colocar todos tipos de contas em uma mesma coleção.
               
               * DEMOSTRAÇÃO: SUPONHA QUE VOCÊ QUEIRA:
               - Totalizar o saldo de todas as contas.
               - Sacar 10.00 de todas as contas.
             */

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1003, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1004, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1005, "José", 500.0, 500.0));

            double sum = 0.0;
            foreach(Account acc in list) //Percorrendo a lista e totalizando o saldo de todas as contas, pois temos uma classe genérica(Account) que possibilita misturar tipos diferentes em uma mesma lista, caso não houvesse a classe genérica isso não seria possível.
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account acc in list) //E ainda podemos usar métodos que serão executados de forma polimórfica
            {
                acc.Withdraw(10.0); //Irá sacar 10.00 de cada conta.
            }

            foreach(Account acc in list)
            {
                Console.WriteLine("Update balance for account: " + acc.Number + ": " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture)); //Irá mostrar o saldo restante após o saque com suas devidas taxas descontadas.
            }
        }
    }
}
