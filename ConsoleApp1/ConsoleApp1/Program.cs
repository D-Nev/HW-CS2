namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.WriteLine("Ввести число от 1 до 100: ");
            //int Vod = Convert.ToInt32(Console.ReadLine());
            //if (Vod < 1 || Vod > 100)
            //{
            //    Console.WriteLine("Диапозон должен быть от 1 до 100. ");
            //}
            //else if (Vod % 3 == 0 && Vod % 5 == 0)
            //{
            //    Console.WriteLine("Fizz Buzz");
            //}
            //else if (Vod % 3 == 0)
            //{
            //    Console.WriteLine("Fizz");
            //}
            //else if (Vod % 5 == 0)
            //{
            //    Console.WriteLine("Buzz");
            //}
            //else
            //{
            //    Console.WriteLine(Vod);
            //}

            //2
            //Console.Write("Ввести два числа: ");
            //int NumOne = Convert.ToInt32(Console.ReadLine());
            //int NumTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(NumTwo + " Процентов от " + NumOne);
            //Console.WriteLine(NumOne / NumTwo);

            //3
            //Console.WriteLine("Ввести четыри цифры: ");
            //int NumOne = Convert.ToInt32(Console.ReadLine());
            //int NumTwo = Convert.ToInt32(Console.ReadLine()); 
            //int NumThree = Convert.ToInt32(Console.ReadLine());
            //int NumFour = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Результат: " + NumOne + NumTwo + NumThree + NumFour);

            //4
            //int fist, two, five, six, osn;
            //Console.Write("Введите 6-значное число -> ");
            //int Num = Convert.ToInt32(Console.ReadLine());

            //if (Num >= 100000 && Num <= 999999)
            //{
            //    six = Num % 10;
            //    five = (Num % 100) / 10;
            //    fist = (Num % 1000000) / 100000;
            //    two = (Num % 100000) / 10000;
            //    osn = (Num % 10000) / 100;

            //    Console.WriteLine("Исходное число: " + six + five + osn + two + fist);
            //}
            //else
            //{
            //    Console.WriteLine("Введено не 6-значное число!");
            //}


            //5
            //String date;
            //Console.WriteLine("Введите дату дд:мм:гггг");
            //date = Console.ReadLine();
            //DateTime dt = Convert.ToDateTime(date);
            //Console.WriteLine(dt.ToLongDateString());

            //6
            //Console.WriteLine("Выберите температуру: ");
            //float Temperature = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("1.По Фаренгейту ");
            //Console.WriteLine("2.По Цельсию: ");
            //double Cels, Faringeit;
            //double VivodCels, VivodFaringeit;
            //int Vibor = Convert.ToInt32(Console.ReadLine());
            //if (Vibor == 2)
            //{
            //   Cels = Temperature * 1.8;
            //   VivodCels = Cels + 32; 
            //   Console.WriteLine(VivodCels + " По Фаренгейту");
            //}
            //else if (Vibor == 1)
            //{
            //    Faringeit = Temperature - 32;
            //    VivodFaringeit = Faringeit / 1.8;
            //    Console.WriteLine(VivodFaringeit + " По Цельсию");
            //}

            //7
            //Console.Write("Введите два числа: ");
            //int NumOne = Convert.ToInt32(Console.ReadLine());
            //int NumTwo = Convert.ToInt32(Console.ReadLine());

            //if (NumOne > NumTwo)
            //{
            //    int temp = NumOne;
            //    NumOne = NumTwo;
            //    NumTwo = temp;
            //}
            //Console.WriteLine($"Парные числа в диапазоне [{NumOne}, {NumTwo}]:");
            //if (NumOne % 2 != 0)
            //{
            //    NumOne++;
            //}

            //for (int i = NumOne; i <= NumTwo; i += 2)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

        }
    }
}
