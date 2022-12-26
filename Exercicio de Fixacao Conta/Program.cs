using Exercicio_de_Fixacao_Conta.Entities;
using Exercicio_de_Fixacao_Conta.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_Fixacao_Conta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string holder;
            double Ibalance, WithdrawL, withdraw;
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                Ibalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit:");
                WithdrawL = double.Parse(Console.ReadLine());
                Account account = new Account(number, holder, Ibalance, WithdrawL);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                withdraw = double.Parse(Console.ReadLine());
                account.Withdraw(withdraw);
                Console.WriteLine($"New balance: {account.Balance.ToString("F2")}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error. {e.Message}");
            }
        }
    }
}
