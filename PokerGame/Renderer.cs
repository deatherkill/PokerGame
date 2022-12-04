using System;
using System.Collections;
using System.Collections.Generic;
namespace PokerGame
{
  public class Renderer
{
    static char[] b = { };
    int delta = 0;
    char[] e = {' '};
    public Renderer(int a)
    {
        delta = a;
        Console.WriteLine("Таки добро пожаловать");
    }
    string a = string.Concat(b);
    int border = 2;
    public void Render(CharField[][] chars)
    {
        Console.Clear();
        Console.WriteLine("_________________");
        foreach (CharField[] iter in chars) // Это для отрисовки отдельных уровней
        {
            int loong = 7;
            string[] exitLines = new string[loong];
            try
            {
                // for (int i = 0; i < loong; i++)
                // {
                //     exitLines[i] = " ";
                // }
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine($"FillingLinesException at Render{e}");
            }
            

            foreach (CharField xiter in iter) // Это для отрисовки отдельныйх последующих элементов
            {
                int temp = 0;
                try
                {
                    foreach (char[] a in xiter.Image)
                    {
                        //
                        //
                        exitLines[temp] += string.Concat(a) + string.Concat(e);
                        //
                        //
                        temp++;
                    }
                } catch(System.IndexOutOfRangeException e)
                {
                    Console.WriteLine($"Creating lines to release at Render {e}");
                }
                
                // Отрисовка идёт как склейка соответсвующих массивов символов у массивов 
                // изображений

            }
            foreach (string text in exitLines)
            {
                Console.WriteLine(text);
            }
            for (int i = delta; i > 0; i--)
            {
                Console.WriteLine(" ");
            }
            
        }
        Console.WriteLine("_________________");
    }
}
}