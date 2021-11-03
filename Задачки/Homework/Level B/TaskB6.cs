using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B6.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Reverser, которая меняет порядок букв в каждом слове заданного
    // предложения на противоположный, порядок слов, при этом, должен сохраниться.
    //
    // Пример:
    // Reverser("reverse letters") ==> "esrever srettel".
    public static class TaskB6
    {
        public static string Reverser(string s)
        {
            string answer = "";
            int buffer;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ') answer += " ";
                else
                {
                    buffer = i;
                    while (s[buffer] != ' ' && buffer < s.Length - 1)
                    {
                        buffer++;
                    }
                    if (s[buffer] == ' ') buffer--;
                    for (int j = buffer; j >= i; j--)
                    {
                        answer += s[j];
                    }
                    i = buffer;
                }

            }
            return answer;
        }
    }
}
