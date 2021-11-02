using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B2.
    // Кол-во стингеров: 🔹
    //
    // Написать функцию OrderWeight(List<int> list), которая сортирует список положительных чисел.
    // Критерий сортировки - возрастание веса числа (сумма всех цифр числа).
    // Если два числа имеют одинаковый вес, сортировать их так, словно они строки.
    //
    // Пример:
    // [56, 65, 74, 100, 99, 68, 86, 180, 90] ==>
    // [100, 180, 90, 56, 65, 74, 68, 86, 99]
    public static class TaskB2
    {
        public static List<int> OrderWeight(List<int> list)
        {
            // Здесь необходимо написать код.
            bool flag = true;
            int buffer;
            int sum1 = 0, sum2 = 0;
            while (flag)
            {
                flag = false;
                for(int i = 0; i < list.Count - 1; i++)
                {
                    buffer = list[i];
                    while(buffer.ToString().Length > 1)
                    {
                        sum1 += buffer % 10;
                        buffer /= 10;
                    }
                    sum1 += buffer;
                    buffer = list[i + 1];
                    while (buffer.ToString().Length > 1)
                    {
                        sum2 += buffer % 10;
                        buffer /= 10;
                    }
                    sum2 += buffer;
                    if(sum1 > sum2)
                    {
                        buffer = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = buffer;
                        flag = true;
                    }
                    if (sum1 == sum2 && list[i] > list[i + 1])
                    {
                        buffer = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = buffer;
                        flag = true;
                    }
                    sum1 = 0;
                    sum2 = 0;
                }
            }
            return list;
        }
    }
}
