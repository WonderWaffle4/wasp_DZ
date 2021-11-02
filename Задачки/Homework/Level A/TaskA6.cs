using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А6.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию OddNumbers, которая получает на вход список целых чисел arr и целое число n и
    // возвращает список, состоящий из n последних вхождений нечетных чисел списка arr в том же порядке
    //
    // Пример:
    // ([1, 2, 3, 4, 5, 6, 7, 8, 9], 3) => [5, 7, 9]
    public static class TaskA6
    {
        public static List<int> OddNumbers(List<int> arr, int n)
        {
            // Здесь необходимо написать код.
            List<int> odd = new List<int>(n);
            int len = arr.Count - 1;
            while(n > 0)
            {
                while(arr[len] % 2 == 0)
                {
                    len--;
                }
                odd.Insert(0, arr[len]);
                len--;
                n--;
            }
            return odd;
        }
    }
}
