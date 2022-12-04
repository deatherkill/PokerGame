using System;
using System.Collections;
using System.Collections.Generic;

namespace PokerGame
{
   public class Player
    {

        public int caps = 1000;
        int turn;
        string nm = "basic";
        bool isPlayAble = false;
        public bool isActive = true;
        public List<Card> hand = new List<Card>(2);

        public Player(string name)
        {
            Console.WriteLine($"{name} подключён к игре");
        }

        public Player(string name, int money)
        {
            nm = name;
            Console.WriteLine($"{nm} подключён к игре с балансом {caps} крышек");
            caps = money;
        }

        public Player(string name, int money, bool player)
        {
            nm = name;
            isPlayAble = true;
            Console.WriteLine($"{nm} подключён к игре с балансом {caps} крышек. За него играет человек");
            caps = money;
        }

        public void MakeBet(int bet, out int bank)
        {
            caps -= bet;
            bank = bet;
        }

        public void MakePass()
        {
            isActive = false;
        }

        public void CompareHand(CharField[] a)
        {

        }

    }
}