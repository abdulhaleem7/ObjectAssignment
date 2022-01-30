using System;
using ObjectAssignment;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            AllQuestion();

        }
        public static void AllQuestion()
        {
            Console.Write("1.QUSTION1\n" + "2.QUESTION2\n" + "3.QUESTION3\n" + "4.QUESTION4\n" + "6.QUESTION6\n" + "7.QUESTION7\n" + "8.QUESTION8\n" +
                   "9.QUESTION9\n" + "10.QUESTION10\n" + "11.QUESTION11\n");
            while (true)
            {
                Console.Write("Question: ");
                int respond = int.Parse(Console.ReadLine());
                if (respond == 1)
                {
                    Question1();
                    Console.WriteLine();
                }
                else if (respond == 2)
                {
                    Question2();
                    Console.WriteLine();
                }
                else if (respond == 3)
                {
                    Question3();
                    Console.WriteLine();
                }
                else if (respond == 4)
                {
                    Question4();
                    Console.WriteLine();
                }
                else if (respond == 5)
                {
                    Question5();
                    Console.WriteLine();
                }
                else if (respond == 6)
                {
                    Question6();
                    Console.WriteLine();
                }
                else if (respond == 7)
                {
                    Question8();
                    Console.WriteLine();
                }
                else if (respond == 8)
                {
                    Question8();
                    Console.WriteLine();
                }
                else if (respond == 9)
                {
                    Question9();
                    Console.WriteLine();
                }
                else if (respond == 10)
                {
                    Question10();
                    Console.WriteLine();
                }
                else if (respond == 11)
                {
                    Question11();
                    Console.WriteLine();
                }
                else
                {
                    break;
                }


            }
        }
        public static void Question1()
        {
            Console.Write("enter a year:");
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(num));

        }
        public static void Question2()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int r = rand.Next(100, 200);
                Console.WriteLine(r);
            }

        }
        public static void Question3()
        {
            DayOfWeek day = DateTime.Now.DayOfWeek;
            Console.WriteLine(day);
        }
        public static void Question4()
        {

            int r = Environment.TickCount;
            decimal second = r / 1440;
            decimal minute = second / 60;
            decimal hour = minute / 60;
            decimal days = hour / 24;
            Console.WriteLine(r);
            Console.WriteLine(second);
            Console.WriteLine(minute);
            Console.WriteLine(hour);
            Console.WriteLine(days);
        }
        public static void Question5()
        {
            Console.Write("enter Side A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter side b: ");
            int b = int.Parse(Console.ReadLine());
            double c = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine(c);
        }
        public static void Question6()
        {
            Console.Write("enter side A: ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("enter side b: ");
            var b = int.Parse(Console.ReadLine());
            Console.Write("enter side c: ");
            var c = int.Parse(Console.ReadLine());
            Console.Write("enter h: ");
            var h = int.Parse(Console.ReadLine());
            Console.Write("enter angle: ");
            var angle = int.Parse(Console.ReadLine());

            Console.WriteLine("area");
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - c) * (p - c));
            Console.WriteLine(area);

            Console.WriteLine();
            Console.WriteLine("ALTITUDE");
            var altitude = (a * h) / 2;
            Console.WriteLine(altitude);
            Console.WriteLine();
            Console.WriteLine("ANGLE SIN");
            Console.WriteLine();
            var ang = (a * b * Math.Sin(angle));
            Console.WriteLine(ang);







        }
        public static void Question8()
        {
            List<Cat> cats = new List<Cat>()
            {
                new Cat("Cat"),
                new Cat("Cat"),
                new Cat("Cat"),
                new Cat("Cat"),
                new Cat("Cat"),
                new Cat("Cat"),
                new Cat("Cat"),
                new Cat("Cat"),
                new Cat("Cat"),
            };
            foreach (var cat in cats)
            {
                Console.WriteLine($"{cat.Name} {Sequence.NextValue()} {Cat.sayMiau()}");
            }
        }
        public static void Question10()
        {
            string number = "43 68 9 23 318";
            var num = number.Split(" ");
            int sum = 0;
            foreach (var n in num)
            {
                int a = int.Parse(n);
                sum+= a;
            }
            Console.WriteLine(sum);
        }
        public static void Question11()
        {
            Random rnd = new Random();
            string[] firstNames ={ "Dayan", "Stella", "Hellen", "Kate" };
            string[]lastname ={ "Johnson", "Peterson", "Charls" };
            string[] cities ={ "London", "Paris", "Berlin", "New York", "Madrid" };
            string[] laundryStory ={ "Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied." };
            string[] laundaryAuthor = { "The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category." };
           
                Console.WriteLine($"{firstNames[rnd.Next(0,firstNames.Length)]} {lastname[rnd.Next(0,lastname.Length)]} {cities[rnd.Next(0,cities.Length)]} {laundryStory[rnd.Next(0,laundryStory.Length)]} {laundaryAuthor[rnd.Next(0,laundryStory.Length)]}");
            
        }
        public static void Question9()
        {
            Console.Write("Enter a date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            int count = 0;
            for (DateTime i= DateTime.Now; i.Date <=date; i=i.AddDays(1))
            {
                if (i.DayOfWeek!=DayOfWeek.Saturday&&i.DayOfWeek!=DayOfWeek.Sunday)
                {

                    count++;
                    //Console.WriteLine(i.DayOfWeek);
                    
                }
            }
            Console.WriteLine(count);
        }
    }
}
