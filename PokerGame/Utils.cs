using System;
using System.Collections;
using System.Collections.Generic;
namespace PokerGame
{
    public static class Utils
    {
        public static int GetKey()
        {
            return Convert.ToInt32(Console.Read());
        } // для выбора 
        
        public static void setDifficult(out int diff)
        {
        
            Console.WriteLine("Добро пожаловать в цирк уродов!");
            Console.WriteLine("Выберите, пожалуйста, сколько игроков у вас будет\n1 - два игрока\n2 = три игрока\n3 - четыре игрока");
            diff = GetKey()-48; //ASCII to int
            Console.WriteLine("Удачки UwU");
        }

        public static int  moveChoose()
        {
            Console.WriteLine("Выберите действие : 0 - пасс, 1 - ставка");
            int temp = GetKey()- 48; //ASCII to int
        
            if (temp != 0 | temp != 1)
            {
                while((temp != 0 | temp != 1) || temp == 10)
                {
                    Console.WriteLine($"Недействительное действие {temp}. Выберите только из предложеных вариантов ");
                    Console.WriteLine("Выберите действие : 0 - пасс, 1 - ставка");
                    temp = GetKey();
                }
            }
            return temp;
        }
    }
}