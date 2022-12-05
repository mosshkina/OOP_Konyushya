using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Konyushya
{
    class Comandir : Person
    {
        public int experience { get; set; }
        public string levelangry { get; set; }
        public Comandir(string name, string surname, int age, int experience, string levelangry)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.experience = experience;
            this.levelangry = levelangry;

        }
        public static void Comandirr(Comandir comandir)
        {
            Console.WriteLine($"Имя: {comandir.name}\n Фамилия:{comandir.surname}\n Возраст:{comandir.age}\n Квалификация:{comandir.experience}\n Агрессивность:{comandir.levelangry} ");
        }

        public static void Tickets()
        {
            int price = 0;
            Console.WriteLine("К вам пришли посетители! Нужно расчитать сумму билета для них. Введите количество взрослых(12+)");
            int oldest=int.Parse(Console.ReadLine());
            price = oldest * 150 + price;
            Console.WriteLine("Введите количество детей");
            int child = int.Parse(Console.ReadLine());
            price = 100 * child + price;
            Console.WriteLine($"Итоговая сумма билетов составляет {price} рублей");


        }

        public static void GovnoInspection()
        {
            int cleaning = 0;
            Console.WriteLine("Пришло время проверить качество уборки ваших сотрудников. Присутсвуют ли разбросанные яблоки в конюшне?");
            bool apple=bool.Parse(Console.ReadLine());
            if (apple) cleaning++;
            Console.WriteLine("Разлита ли воды на полу?");
            bool water=bool.Parse(Console.ReadLine());
            if (water) cleaning++;
            Console.WriteLine("Убрали ли рабочие какашки?");
            bool govno= bool.Parse(Console.ReadLine());
            if (govno==false) cleaning=+2;
            Console.WriteLine("Вымыты ли лошади?");
            bool horse=bool.Parse(Console.ReadLine());
            if (horse==false) cleaning++;
            Console.WriteLine("В кормушках есть старый корм?");
            bool eat=bool.Parse(Console.ReadLine());
            if (eat) cleaning++;
            switch (cleaning)
            {
                case 0: Console.WriteLine("Ваши рабочие молодцы! Можете гордиться ими!");
                    break;
                case 1: Console.WriteLine("Есть маленький недочет, ну ладно");
                    break;
                case 2: Console.WriteLine("2 недочета, халяват ваши рабочие");
                    break ;
                case 3: Console.WriteLine("3 недочета, серьезная заявочка на уволнение");
                    break;
                case 4: Console.WriteLine("4 недочета, завтра же увольняйте их");
                    break;
                case 5: Console.WriteLine("5 недочетов, обматерите рабочих и сейчас же увольняйте");
                    break;
                case 6: Console.WriteLine("6 недочетов это сильно, сами увольняйтесь, раз таких бездарей нанимаете");
                    break;

            }
            
        }
        public static void Purchases()
        {
            Console.WriteLine("Вы сделали запрос на новые закупки в конюшню, введите приблизительный бюджет, на который расчитываете");
            int budget=int.Parse(Console.ReadLine());
            if (budget <= 100000) Console.WriteLine("С таким бюджетом вы можете закупить еду на неделю, на этом все ");
            if (budget <= 200000 && budget>100000) Console.WriteLine("Купите еды и новые поилки");
            if (budget > 200000) Console.WriteLine("Можете скупить весь лошадиный магазин");
        }
        public static void Level(int experience)
        {
            byte level = 0;
            Console.WriteLine("Чтобы повысить квалификацию, Вам надо пройти тест.\n Сколько дней в неделю вы находитесь на работе?");
            byte days=byte.Parse(Console.ReadLine());
            if (days>3) level++;
            Console.WriteLine("Сколько раз в месяц вы делаете закупки?");
            byte buy=byte.Parse(Console.ReadLine());
            if (buy>3) level++;
            Console.WriteLine("Сколько раз в неделю вы проверяете работу рабочих?");
            byte job=byte.Parse(Console.ReadLine());
            if (job>3) level++;
            if (level == 3)
            {
                
                experience++;
                Console.WriteLine($"Поздравляем! Квалификация повышена до {experience} уровня !");
            }
            else if (job < 3) Console.WriteLine("Увы, тест провален");


        }
    }

}
