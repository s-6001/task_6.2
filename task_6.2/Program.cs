using System;

namespace task_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите предложение без знаков препинания: ");
                string input = Console.ReadLine();                
                input = input.Replace(" ", "").ToLower(); //убираем пробелы и переводим в нижний регистр
                int count = 0; //вспомогательный счетчик совпадений символов
                if (input.Length % 2 == 0 && input.Length != 0) //Случай 1. Если строка без пробелов с четным количеством символов и не пустая
                {
                    for (int i = 0; i < (input.Length / 2); i++)
                    {
                        if (input[i] == input[input.Length - 1 - i])    //проверяем предложение на зеркальность
                        {
                            count++;    //считаем совпадения
                        }
                    }
                    if (count == input.Length / 2) //если число совпадений равно половине символов в строке, то это палиндром
                    {
                        Console.WriteLine("Это палиндром.");
                    }
                    else
                    {
                        Console.WriteLine("Это не палиндром.");
                    }
                }
                if (input.Length % 2 == 1 && input.Length != 0)  //Случай 2. Если строка без пробелов с нечетным количеством символов и не пустая
                {
                    for (int i = 0; i < (input.Length / 2 - 1); i++)
                    {
                        if (input[i] == input[input.Length - 1 - i])    //проверяем предложение на зеркальность
                        {
                            count++;    //считаем совпадения
                        }
                    }
                    if (count == input.Length / 2 - 1) //если число совпадений равно (половине-1) символов в строке, то это палиндром
                    {
                        Console.WriteLine("Это палиндром.");
                    }
                    else
                    {
                        Console.WriteLine("Это не палиндром.");
                    }
                }
            }
        }
    }
}