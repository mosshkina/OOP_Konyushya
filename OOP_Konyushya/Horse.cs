using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Konyushya
{
    public class Horse
    {
        public string color { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public string poroda { get; set; }
        public Horse(string name, string color, int id, string poroda)
        {
            this.name = name;
            this.color = color;
            this.id = id;
            this.poroda = poroda;

        }
        public static void Horses(Horse horse)
        {
            Console.WriteLine($"Имя: {horse.name}\n Цвет:{horse.color}\n ID:{horse.id}\n Порода:{horse.poroda} ");
        }
        public static void Voice(string horse)
        {
            if (horse == "скакун") Console.WriteLine("Иго-го иго-го иго-го иго-го");
            else if (horse == "не скакун") Console.WriteLine("Иго-го иго-го");
        }
        public static void HorseRacing(string horse)
        {
            if (horse == "скакун") Console.WriteLine("Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок");
            else
            if (horse == "пони") Console.WriteLine("Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок-Цок");
        }
        public static void Delete(Horse horse)
        {
            Console.WriteLine("Иго-го иго-го иго-го");
            horse = null;
        }
        public static void Govno()
        {
            Console.WriteLine("Иго-го иго-го *как как как*");
        }
    }
}
