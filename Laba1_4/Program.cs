using System;
using System.Windows.Markup;
using Laba1_4;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть розмiр: ");
        string sizeStr;
        sizeStr = Console.ReadLine();
        int SizeInt = Convert.ToInt32(sizeStr);
        BoolArr arr = new BoolArr(SizeInt);
        int counter = 0;
        Console.WriteLine("Введiть значення булевого типу(true/false)");
        Console.WriteLine("Для закiнчення введення напишiть stop");
        for(int i = 0; i<999;)
        {
            Console.Write(i+")");
            string value;
            value = Console.ReadLine();
            if (value == "true")
            {
                arr[i] = true;
                i++;
                counter++;
            }
            else if (value == "false")
            {
                arr[i] = false;
                i++;
                counter++;
            }
            else if (value == "stop")
            {
                break;
            }
            else Console.WriteLine("значення повиннi бути лише true/false");
        }
        Console.WriteLine("______Повернення оберненого значення______");
        for(int i = 0; i<counter;i++)
        {
            Console.Write(i+")"+arr[i]);
            if (arr.exception)
            {
                Console.Write(" - поза межами");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("______Результат логiчного додавання______");
        for (int i = 0; i < SizeInt; i++)
        {
            if (i == SizeInt - 1)
            {
                Console.Write(arr[i] + " = ");
            }
            else
            {
                Console.Write(arr[i] + " || ");
            }
        }
        bool result = arr.Result;
        Console.WriteLine(result);
    }
}