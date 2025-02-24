using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasB.Model
{
    public class CheckingAccount : Account
    {
        public override void Deposit(double value)
        {
            Balance += value;
            Console.WriteLine("Deposito de " + value + " realizado com sucesso, seu saldo atual e de " + Balance);
        }

        public override void Withdraw(double value)
        {
            if (Balance < value)
            {
                Console.WriteLine("Saldo insuficiente para o saque, seu saldo atual e de " + Balance + " .Voce tentou sacar " + value);
            }
            else
            {
                Balance -= value;
            }
        }

        public void Transfer(double value, Account account)
        {
            if (Balance < value)
            {
                Console.WriteLine($"Saldo insuficiente para a transferência, {User.Name}. Seu saldo atual é de R$ {Balance}. Você tentou transferir R$ {value}.");
            }
            else
            {
                Balance -= value;
                account.Deposit(value);
                Console.WriteLine($"Transferencia de " + value + $" da conta {User.Name} para " + account.User.Name + " realizada com sucesso, seu saldo atual e de " + Balance);
            }
        }
    }
}
