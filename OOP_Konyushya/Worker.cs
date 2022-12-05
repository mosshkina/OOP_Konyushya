using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Konyushya
{
    class Worker : Person
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }

        public Worker(string name, string surname, int age, int Id, string JobTitle)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.Id = Id;
            this.JobTitle = JobTitle;

        }

        public static void Workeddd(Worker worker)
        {
            Console.WriteLine($"Имя: {worker.name}\n Фамилия:{worker.surname}\n Возраст:{worker.age}\n ID:{worker.Id}\n Должность:{worker.JobTitle} ");
        }
        public static void Eating()
        {
            Console.WriteLine("Вы рабочий конюшни. приступайте к обязоностями. Вам нужно покормить лошадь, какую вы выбираете?(ввежите цифру) \n 1)скакун \n 2)пони\n 3)осел");
            int horse = int.Parse(Console.ReadLine());
            switch (horse)
            {
                case 1:
                    Console.WriteLine("Вам нужно 3 кг овса и 10 яблок");
                    break;
                case 2:
                    Console.WriteLine("Вам нужно 4 кг овса и 6 яблок");
                    break;
                case 3:
                    Console.WriteLine("Вам нужно 4 кг овса");
                    break;
                default:
                    Console.WriteLine("У вас в конюшне нет таких зверей, попробуйте снова");
                    break;
            }
        }
        public static void Water()
        {
            Console.WriteLine("Вы рабочий конюшни. приступайте к обязоностями. Вам нужно напоить лошадь, какую вы выбираете?(ввежите цифру) \n 1)скакун \n 2)пони\n 3)осел");
            int horse = int.Parse(Console.ReadLine());
            switch (horse)
            {
                case 1:
                    Console.WriteLine("Вам нужно 10 л воды");
                    break;
                case 2:
                    Console.WriteLine("Вам нужно 6 л воды");
                    break;
                case 3:
                    Console.WriteLine("Вам нужно 4 л воды");
                    break;
                default:
                    Console.WriteLine("У вас в конюшне нет таких зверей, попробуйте снова");
                    break;
            }
        }
        public static void Govno()
        {
            Console.WriteLine("Вам поручили убрать говно, приступайте к делу. Учтите, что если вы некачественно проведете уборку и владелец это заметит, вам придется несладко))))");
            bool resh = bool.Parse(Console.ReadLine());
            if (resh==true)
            {
                Console.WriteLine("Ваше говно убрано!");
            }
            else if (resh == false)
            {
                Console.WriteLine("Ваше говно не убрано(");
            }


        }
        public static void Walk()
        {
            Console.WriteLine("Вам поручено выгулять лошадь, введите тип лошади(скакун, пони, осел) ");
            string horse = Console.ReadLine();
            switch (horse)
            {
                case "скакун": Console.WriteLine("Выгуливайте ее вверхом 3 часа");
                    break;
                case "пони": Console.WriteLine("Выгуливайте ее на лугу 2 часа");
                    break;
                case "осел": Console.WriteLine("Откуда у Вас в конюшне осел????");
                    break;
                default : Console.WriteLine("Ошибка, попробуйте еще раз");
                    break;

            }
        }
    }
}
