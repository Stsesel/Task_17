using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовой номер\t");
            int accountNumberInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баланс счета\t");
            double accountBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО\t");
            string name = Console.ReadLine();
            
            AccountOwner<int> accountOwner1 = new AccountOwner<int> (accountNumberInt, accountBalance, name );
            Console.WriteLine(accountOwner1.GetInfo()+ "\n");
            Console.WriteLine();

            Console.WriteLine("Введите строковый номер\t");
            string accountNumberString = Console.ReadLine();
            Console.WriteLine("Введите баланс счета\t");
            accountBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО\t");
            name = Console.ReadLine();

            AccountOwner<string> accountOwner2 = new AccountOwner<string>(accountNumberString, accountBalance, name);
            Console.WriteLine(accountOwner2.GetInfo());

            Console.ReadKey();
        }
    }
}
