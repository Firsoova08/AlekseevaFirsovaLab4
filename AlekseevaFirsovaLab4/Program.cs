namespace AlekseevaFirsovaLab4
{
    enum Hero { Воин, Маг, Вор }
    enum TimeOfDay { Утро, День, Вечер, Ночь }
    enum TrafficLight { Red, Yellow, Green }
    enum ORstate { New, Processing, Shipped, Delivered }
    internal class Program
    {
        static void Main(string[] args)
        { //LAB 3
            ///*
            //for(действие до выполнения;условие;действие после выполнения цикла) {
            //    тело цикла
            //}
            //*/
            ////for (int i = 0, j = 0; i < 10; i++, j++)
            ////{
            ////    Console.WriteLine($"{i*j}");
            ////}

            ////int sum = 0;
            ////for (int i = 1; i <= 10; i++)
            ////{
            ////    sum += i;
            ////}
            ////Console.WriteLine(sum);

            ////int i = 10;
            ////while(i > 0)
            ////{
            ////    Console.WriteLine(i);
            ////    i--;
            ////}

            //int j = -1;
            //do
            //{
            //    Console.WriteLine(j);
            //    j--;
            //}
            //while(j > 0);

            //string text = "hello world";
            //foreach(var symbol in text)
            //{
            //    Console.WriteLine(symbol);
            //}

            //for (int i = 1; i < 10; i ++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i * j} \t");
            //    }
            //    Console.WriteLine();
            //}

            ///*
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("введите фразы для повторения или 'выход'");
            //while (true)
            //{ Console.Write("> ");
            //    string us = Console.ReadLine();
            //    ().ToLower();
            //    if (us == "выход") break;
            //    Console.WriteLine(us);
            //}
            //int number = 10;
            //DayOfWeek day = DayOfWeek.Суббота;   
            //Console.WriteLine((int)day);
            //switch (day)
            //{
            //    case DayOfWeek.Суббота:
            //    case DayOfWeek.Воскресенье:
            //        Console.WriteLine("Выходной");
            //            break; 
            //    default:
            //        Console.WriteLine("Будний день");
            //            break;
            //}
            //enum DayOfWeek
            //{
            //    Понедельник = 1, Вторник, Среда = 2, Четверг = 2, Пятница, Суббота, Воскресенье
            //}

            //var times = Enum.GetValues(typeof(TimeOfDay));
            //var heroes = Enum.GetValues(typeof(Hero));

            //for (int i = 0; i < times.Length; i++)
            //{
            //    TimeOfDay time = (TimeOfDay)times.GetValue(i);
            //    Console.WriteLine($"\nВремя сейчас {time}:");

            //    for (int j = 0; j < heroes.Length; j++)
            //    {
            //        Hero h = (Hero)heroes.GetValue(j);
            //        Console.Write($"{h} - ");

            //        switch (time)
            //        {
            //            case TimeOfDay.Утро:
            //                Console.WriteLine(h switch
            //                {
            //                    Hero.Воин => "делает зарядку",
            //                    Hero.Маг => "заваривает зелья",
            //                    Hero.Вор => "крадётся по базару",
            //                    _ => "ничего не делает"
            //                });
            //                break;
            //            case TimeOfDay.День:
            //                Console.WriteLine(h switch
            //                {
            //                    Hero.Воин => "тренируется на арене",
            //                    Hero.Маг => "изучает древние книги",
            //                    Hero.Вор => "прячется в тенях",
            //                    _ => "ничего не делает"
            //                });
            //                break;
            //            case TimeOfDay.Вечер:
            //                Console.WriteLine(h switch
            //                {
            //                    Hero.Воин => "ест мясо у костра",
            //                    Hero.Маг => "создаёт магический щит",
            //                    Hero.Вор => "планирует налет",
            //                    _ => "ничего не делает"
            //                });
            //                break;
            //            case TimeOfDay.Ночь:
            //                Console.WriteLine(h switch
            //                {
            //                    Hero.Воин => "спит в палатке",
            //                    Hero.Маг => "медитирует под луной",
            //                    Hero.Вор => "лезет в чужой дом",
            //                    _ => "ничего не делает"
            //                });
            //                break;
            //        }
            //    }

            //LAB 4
            //int[] number = [12, 23, 45, 56];
            //int[] num = { 12, 23, 45, 56 };
            //int[] number3 =new int[] { 12, 23, 45, 56 };
            //int[] number4 = new int[4] { 12, 23, 45, 56 };
            //int[] number5 = new [] { 12, 23, 45, 56 };
            //foreach (var i in number)
            //{
            //    Console.WriteLine(i);
            //}
            //number[0] = 345;
            //Console.WriteLine(number.Length);
            //Console.WriteLine(number3[^1]);    


            //int[] numbers = [-1, -2, -3, 4,5, 6, 0,43, 56, -34, 12, 45, 102,76, -45, 96,-4, -3,5,76, 6,8,2,0,5, 9];
            //int result = 0;
            //foreach (int number in numbers)
            //{
            //    if (number > 0)
            //        result++;
            //}
            //Console.WriteLine($"Число элементов больше нуля: {result}");

            int[] numbers = [-1, -2, -3, 4, 5, 6, 0, 43, 56, -34, 12, 45, 102, 76, -45, 96, -4, -3, 5, 76, 6, 8, 2, 0, 5, 9];
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    result++;
            }
            Console.WriteLine($"Число элементов больше нуля: {result}");
        }
    }
}
