using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B4.
    // Кол-во стингеров: 🔷
    //
    // Написать функцию CheckBrackets(string s), которая определяет,
    // правильно ли расставлены скобки () {} [] <> в предложении.
    //
    // Примеры:
    // CheckBrackets("(abc)[]{0:1}") ==> true;
    // CheckBrackets("(abc)]{0:1}[") ==> false.
    public static class TaskB4
    {
        public static bool CheckBrackets(string s)
        {
            // Здесь необходимо написать код. () 40 41 {} 123 125 [] 91 93 <> 60 62
            Stack<int> brackets = new Stack<int>();
            foreach (int i in s)
            {
                if (brackets.Count == 0 && (i == 41 || i == 125 || i == 93 || i == 62)) return false;
                if (brackets.Count != 0)
                {
                    if (i != brackets.Peek() && (i == 41 || i == 125 || i == 93 || i == 62)) return false;
                    if (i == brackets.Peek()) brackets.Pop();
                }
                if (i == 40) brackets.Push(41);
                if (i == 123) brackets.Push(125);
                if (i == 91) brackets.Push(93);
                if (i == 60) brackets.Push(62);


            }
            return true;
        }
    }
}
