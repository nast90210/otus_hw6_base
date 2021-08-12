using System;
using System.Linq;

namespace otus_hw6_base
{
    class Program
    {
        static void Main(string[] args)
        {
            using(sberContext context = new sberContext())
            {
                Console.WriteLine("Список клиентов СберБанка");
                
                var clients = context.Clients.ToList();
                foreach (var client in clients)
                {
                    Console.WriteLine($"Фамилия: {client.LastName}, Имя: {client.FirstName}, Отчество: {client.MiddleName}");//, Дата рождения: {client.Birthday}");
                
                }
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("Список счетов");

                var accounts = context.Accounts.ToList();
                foreach (var account in accounts)
                {
                    Console.WriteLine($"Номер счета {account.Account1}, Валюта счета {account.Currency}, Дата открытия {account.OpenDate}, Дата закрытия {account.CloseDate}");
                }
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("Список транзакций");

                var transactions = context.Transactions.ToList();
                foreach (var transaction in transactions)
                {
                    Console.WriteLine($"Сумма {transaction.Ammount}, Описание {transaction.Description}, Дата {transaction.DateTime}");
                }
                Console.WriteLine(Environment.NewLine);

                AddTrans(context);
                
                
            }

            
        }
        public static void AddTrans(sberContext context)
        {
            Console.WriteLine("Adding new transaction");
            var trans = new Transaction{Ammount = 5000, Description = "Оплата посылки из CDEC", DateTime = DateTime.Now, Id = 4, AccountId = 1};
            context.Transactions.Add(trans);
            context.SaveChanges();
            Console.WriteLine("New transaction was added");
        }
    }
}
