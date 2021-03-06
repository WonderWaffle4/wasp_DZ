using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А4.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию ListOfSums(List<int> list), которая получает на вход
    // список чисел и возвращает только те, которые равны сумме всех
    // предшествующих элементов этого списка.
    //
    // Пример:
    // ListOfSums([2,3,5,6]) ==> [5] -> 5 = 2 + 3;
    // ListOfSums([10,20,30,60,-120,0]) ==> [30,60,0].
    public static class TaskA4
    {
        public static List<int> ListOfSums(List<int> list)
        {
            // Здесь необходимо написать код.
            List<int> sums = new List<int>();
            int sum = 0;
            for(int i = 1; i < list.Count; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    sum += list[j];
                }
                if (sum == list[i]) sums.Add(sum);
                sum = 0;
            }
            return sums;
        }
    }
}
