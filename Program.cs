using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Напишите метод, фильтрующий массив на основании переданных параметров. 
    Метод принимает параметры:
        оригинальный_массив, 
        массив_с_данными_для_фильтрации.
    Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
    Например:
        1 2 6 -1 88 7 6 — оригинальный массив;
        6 88 7 — массив для фильтрации;
        1 2 -1 — результат работы метода.
 */
namespace Task4_2
{
    class Program
    {
        static void FiteredArray(int[] originArray, int[] filterArray, object[] filteredArray, int size)
        {
            bool flag = false;
            int k = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (originArray[i] == filterArray[j])
                    { 
                        flag = false;
                        break; 
                    }
                    else 
                        flag = true;
                }
                if(flag)
                {
                    filteredArray[k] = originArray[i];
                    k++;
                }
            }
        }

        static void PrintFilteredArray(object[] filteredArray/*, int size*/)
        {
            Console.WriteLine("\n Массив полученный в результате применения фильтра: ");
            foreach (var item in filteredArray)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine("\n\n");
        }


        static void Main(string[] args)
        {
            Console.Write("\n Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] originArray = new int[size];
            object[] filteredArray = new object[size];
            int[] filterArray = new int[5];

            Random rand = new Random();
            Console.WriteLine("\n Полученный массив: ");
            for (int i = 0; i < size; i++)
            {
                originArray[i] = rand.Next(0, 99);
                Console.Write($" {originArray[i]}");
            }

            Console.WriteLine("\n\n Введите 5 чисел которые необходимо исключить из полученного массива: ");
            for (int i = 0; i < 5; i++)
            {
                filterArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            FiteredArray(originArray, filterArray, filteredArray, size); ;
            PrintFilteredArray(filteredArray);

        }
    }
}
