namespace ConsoleApplication1
{

    class DayOfTheWeek
    {
        enum DayOfTheWeek
        {
            Tuesday,
            Monday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public enum Color
        {
            Red,
            Green,
            Blue,
            Yellow,
            Cyan,
            Magenta
        }
        enum Opers
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }
        public static string GetHexCode(Color color)
        {
            string hexCode = string.Empty;
            switch (color)
            {
                case Color.Red: hexCode = "FF0000"; break;
                case Color.Green: hexCode = "00FF00"; break;
                case Color.Blue: hexCode = "0000FF"; break;
                case Color.Yellow: hexCode = "FFFF00"; break;
                case Color.Cyan: hexCode = "00FFFF"; break;
                case Color.Magenta: hexCode = "FF00FF"; break;
            }
            return hexCode;
        }
        static void Main()
        {
            foreach (var day in Enum.GetValues(typeof(DayOfTheWeek)))
            {
                DayOfTheWeek days = (DayOfTheWeek)day;
                Console.Write($"{days} - ");

                switch (days)
                {
                    case DayOfTheWeek.Monday:
                        Console.WriteLine("понедельник");
                        break;
                    case DayOfTheWeek.Tuesday:
                        Console.WriteLine("вторник");
                        break;
                    case DayOfTheWeek.Wednesday:
                        Console.WriteLine("среда");
                        break;
                    case DayOfTheWeek
                    .Thursday:
                        Console.WriteLine("четверг");
                        break;
                    case DayOfTheWeek.Friday:
                        Console.WriteLine("пятница");
                        break;
                    case DayOfTheWeek.Saturday:
                        Console.WriteLine("Cуббота");
                        break;
                    default:
                        Console.WriteLine("Воскресенье");
                        break;
                }
            }
            Console.WriteLine("-------------------");
            foreach (var colorr in Enum.GetValues(typeof(Color)))
            {
                Color colorrr = (Color)colorr;
                Console.Write($"{colorrr} - ");

                switch (colorrr)
                {
                    case Color.Red:
                        Console.WriteLine("FF0000");
                        break;
                    case Color.Green:
                        Console.WriteLine("00FF00");
                        break;
                    case Color.Blue:
                        Console.WriteLine("0000FF");
                        break;
                    case Color.Yellow:
                        Console.WriteLine("FFFF00");
                        break;
                    case Color.Cyan:
                        Console.WriteLine("00FFFF");
                        break;
                    case Color.Magenta:
                        Console.WriteLine("FF00FF");
                        break;
                    default:
                        Console.WriteLine("Другой цвет");
                        break;
                }
            }
            Console.WriteLine("-------------------");
            int a = 100;
            int b = 50;
            Opers op = Opers.Subtract;

            Console.WriteLine($"Ответ из чисел {a} и {b} при операции {Opers.Add}: {UseOp(a, b, op)}");
        }
        static int UseOp(int a, int b, Opers op)
        {
            switch (op)
            {
                case Opers.Add:
                    return a + b;
                case Opers.Subtract:
                    return a - b;
                case Opers.Multiply:
                    return a * b;
                default:
                case Opers.Divide:
                    return a / b;
            }
        }
    }
}