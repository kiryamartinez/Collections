using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _dictionary_PersonnelAccounting
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dossier = new Dictionary<string, string>();
            dossier.Add("Катя", "Менеджер");
            bool isWorking = true;
            while (isWorking)
            {
                Console.WriteLine("Выберите действие: \n 1-Добавить досье. \n 2-Вывести все досье. \n 3-Удалить досье.\n 4-Выход ");
                int userInpuct = Convert.ToInt32(Console.ReadLine());
                switch (userInpuct)
                {
                    case 1:
                        Console.Write("Введите имя: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите должность: ");
                        string position = Console.ReadLine();
                        dossier.Add(name, position);
                        Console.WriteLine("Досье добавлено");
                        break;
                    case 2:
                        foreach (var employees in dossier)
                        {
                            Console.WriteLine(employees);
                        }
                         break;
                    case 3:
                        Console.Write("Введите имя досье которого хотите удалить: ");
                        string nameDelete = Console.ReadLine();
                        dossier.Remove(nameDelete);
                        Console.WriteLine("Досье удалено");
                        break;
                    case 4:
                        isWorking = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
