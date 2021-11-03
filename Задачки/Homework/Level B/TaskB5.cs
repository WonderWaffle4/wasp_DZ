using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B5.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Frame(string text, char symbol), которая заключает
    // список строк text в рамку из символов char и возвращает данную строку.
    //
    // Пример:
    // frame(['Create', 'a', 'frame'], '+') ==>
    // ++++++++++
    // + Create +
    // + a      +
    // + frame  +
    // ++++++++++
    public static class TaskB5
    {
        public static string Frame(List<string> text, char symbol)
        {
            // Здесь необходимо написать код.
            string stroke = "";
            int[] longest = new int[text.Count];
            for(int i = 0; i < text.Count; i++)
            {
                longest[i] = text[i].Length;
            }
            int maxlen = longest.Max();
            for (int i = 0; i < maxlen + 4; i++)
            {
                stroke += symbol;
            }
            stroke += "\n";
            foreach(string i in text)
            {
                stroke += symbol + " " + i;
                for(int j = 0; j < maxlen - i.Length + 1; j++)
                {
                    stroke += " ";
                }
                stroke += symbol + "\n";
            }
            for (int i = 0; i < maxlen + 4; i++)
            {
                stroke += symbol;
            }
            return stroke;
        }
    }
}
