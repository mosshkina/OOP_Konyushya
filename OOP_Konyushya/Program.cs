using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Konyushya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поздравляем! Вы попали в конюшню. Впишите свою должность(владелец, рабочий, лошадь)");
            string typeofuser=Console.ReadLine();
            switch(typeofuser)
            {
                case "владелец":
                    Comandir maincomandir = new Comandir("Дмитрий", "Тумаков", 56, 2, "злой");
                    Console.WriteLine("Введите \n регистрация : если хотите зарегистрироваться \n билеты : если вам надо продать билеты \n инспекция : если вам надо проверить чистоту конюшни \n бюджет : если вам надо расчитать бюджет на покупки \n квалификация : если вам надо повысить квалификацию");
                    string reshcomandir=Console.ReadLine();
                    switch (reshcomandir)
                    {
                        case "регистрация":
                            Comandir.Comandirr(maincomandir);
                            break;
                        case "билеты":
                            Comandir.Tickets();
                            break;
                        case "инспекция":
                            Comandir.GovnoInspection();
                            break;
                        case "бюджет":
                            Comandir.Purchases();
                            break;
                        case "квалификация":
                            Comandir.Level(maincomandir.experience);
                            break;
                        default:
                            Console.WriteLine("вы ввели что-то не то");
                            break;

                    }
                    break;
                case "рабочий":
                    Worker mainworker = new Worker("Гарник","Абгарян", 24, 12345, "рабочий");
                    Console.WriteLine("Введите \n регистрация : если хотите зарегистрироваться \n еда: если вам надо покормить лошадь \n вода : если вам надо напоить лошадь \n ублорка: если вам надо убрать какашки лошади \n прогулка : если вам надо узнать, сколько гулять с лошадью");
                    string reshworker = Console.ReadLine();
                    switch (reshworker)
                    {
                        case "регистрация":
                            Worker.Workeddd(mainworker);
                            break;
                        case "еда":
                            Worker.Eating();
                            break;
                        case "уборка":
                            Worker.Govno();
                            break;
                        case "вода":
                            Worker.Water();
                            break;
                        case "прогулка":
                            Worker.Walk();
                            break;
                        default:
                            Console.WriteLine("вы ввели что-то не то");
                            break;

                    }
                    break;

                case "лошадь":
                    Horse mainhorse = new Horse("Яблочко", "серая", 009, "Фризская");
                    Console.WriteLine("Допустим вы лошадь...... ваши действия \n регистрация : ну может вам правда надо зарегистрироваться \n голос : если вы хотите поигогокать \n бег : если вы хотите побегать и поцокцокать \n какать : если вам вдруг приспичило \n побег : если вы уже не можете мириться с таким распорядком и хотите стать вольной лошадью");
                    string reshhorse=Console.ReadLine();
                    switch(reshhorse)
                    {
                        case "регистрация":
                            Horse.Horses(mainhorse);
                            break;
                        case "голос":
                            Console.WriteLine("Напишите, скакун вы или не скакун");
                            string horsetype=Console.ReadLine();
                            Horse.Voice(horsetype);
                            break;
                        case "бег":
                            Console.WriteLine("Напишите, скакун вы или не скакун");
                            string horsetyperun = Console.ReadLine();
                            Horse.Voice(horsetyperun);
                            break;
                        case "какать":
                            Horse.Govno();
                            break;
                        case "побег":
                            Horse.Delete(mainhorse);
                            break;
                        default:
                            Console.WriteLine("вы ввели что-то не то");
                            break;



                    }
                    break;
                default:
                    Console.WriteLine("вы ввели что-то не то");
                    break;

            }
        }
    }
 
}