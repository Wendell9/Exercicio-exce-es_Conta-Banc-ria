using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_de_Fixacao_Conta.Entities.Exceptions;

namespace Exercicio_de_Fixacao_Conta.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public void Withdraw(double value)
        {
            if (value > WithdrawLimit)
            {
                throw new DomainException("The value exceeds the withdraw limit");
            }
            else if (Balance - value < 0)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= value;
        }
    }
}
