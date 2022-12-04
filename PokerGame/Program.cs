using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using PokerGame;

internal class Program
{
    static bool isActive = true;
    static Card basic = new Card(13, Maste.heart);
    private static int diff_test;
    static CharField[][] screen = new CharField[][]
    {
        new CharField[]
            { new Card(1, Maste.buttPlug), new Card(2, Maste.hresta), basic }
    };

    static void Main(string[] args)
    {
        // Можно ещё сделать выбор игроков

        basic.SwitchSide();
        Renderer renderer = new Renderer(1);
        //while (isActive) //Не до конца понятно что именно попадает в цикл, инициация игры?
       // {
            Console.Clear();
            List<Card> deck = new List<Card>(56);
            int player = 1;
            int difficult = 1;
            Utils.setDifficult(out difficult);
            List<Player> players = new List<Player>(diff_test);
            players.Add(new Player("Игрок 1", 1000, true));

            for (int i = diff_test; i > 0; i--)
            {
                players.Add(new Player($"Компьютер {i + 1}"));
            }
            GenerateDeck(ref deck);
            renderer.Render(screen);
       // }
        // Закрытие игры
    } // Основной поток

    static void GenerateDeck(ref List<Card> cards)
    {
        for (int i = 0; i <= 3; i++)
        {
            for (int t = 0; t <= 13; t++)
            {
                cards.Add(new Card(t, ChooseMaste(i)));
            }
        }
    }

    static Maste ChooseMaste(int m)
    {
        switch (m)
        {
            case 0: return Maste.heart;
            case 3: return Maste.diamond;
            case 2: return Maste.buttPlug;
            case 1: return Maste.hresta;
            default: return Maste.heart;
        }
    }
}