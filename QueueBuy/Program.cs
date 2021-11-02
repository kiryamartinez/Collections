using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueBuy
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 0;       
            Queue<int> sumPurchase = new Queue<int>();
            sumPurchase.Enqueue(250);
            sumPurchase.Enqueue(100);
            sumPurchase.Enqueue(300);
            sumPurchase.Enqueue(400);
            while (true)
            {
                Console.WriteLine($"Денег в кассе: {money}");
                int sum = sumPurchase.Dequeue();
                Console.WriteLine("Сумма покупи нового клиента:" + sum);
                money += sum;
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
