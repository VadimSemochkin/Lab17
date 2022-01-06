using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите даные для счета представленного числом");
            Bank<int> bank1 = new Bank<int>();
            bank1.Input();
            Console.WriteLine(bank1.GetInfo());

            Console.WriteLine("Введите даные для счета представленного строкой");
            Bank<string> bank2 = new Bank<string>();
            bank2.Input();
            Console.WriteLine(bank2.GetInfo());

            Console.ReadKey();
        }
    }

    class Bank<T>
    {
        public T Num { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }

        public string GetInfo()
        {
            return $"{Num} {Balance} {Name}";
        }

        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите баланс счета");
            Balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите имя владельца счета");
            Name = Console.ReadLine();

        }
    }
}

