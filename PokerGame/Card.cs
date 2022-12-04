using System;
using System.Collections;
using System.Collections.Generic;
namespace PokerGame
{
  public class Card : CharField
{
    private int CardNumber = 0;
    private Maste CardMaste;// = Maste.heart;
    char[][] card;
    CardType a;
    bool isHidden = true;
    public Card(int number, Maste maste)
    {
        CardMaste = maste;
        CardNumber = number > 0 ? number : 0 ;
        card = MakeCard();
    }
    public void SwitchSide()
    {
        isHidden = !isHidden;    }
    
    public override char[][] Image
    {
        get => isHidden? closedCard : card;
        set => card = value;
    } // Если карта открыта, то выводит её переднюю часть, в ином случае обложку
    private char[][] MakeCard() // С помощью этого метода мы сможем создавать карты.
    {
       
        switch (CardNumber)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            a = CardType.Number; break;
            case 11: a = CardType.Ritter; break;
            case 12: a = CardType.Frau; break;
            case 13: a = CardType.Herrn; break;
            default: a = CardType.Number; break;
        }
        char addTab = ' ';
        char secndCHR = ' ';
        if (CardNumber <= 9)
        {
            secndCHR = Convert.ToChar(CardNumber);
        }
        if(CardNumber == 10)
        {
            addTab = '1';
            secndCHR = '0';
        }
        if(a != CardType.Number)
        {
            switch (a)
            {
                case CardType.Ritter:
                secndCHR = 'R'; break;
                case CardType.Frau: secndCHR = 'F'; break;
                case CardType.Herrn: secndCHR = 'K'; break;
            }

        }
        char[] cardRole = { '|', ' ', ' ', addTab, secndCHR, '|' };
        
      
        char[] s = { 
            'H',  // Серце
            'P',  // Пика
            'T',  // Трефа
            'D'}; // Алмаз
        // Если честно, тебе лучше самому написать нужные коды Unicode

        char[][] vs = {     new char[]{'_', '_', '_', '_', '_', '_' },
                            new char[]{'|', ' ', ' ', ' ', s[(int)CardMaste], '|' },
                            new char[]{'|', ' ', ' ', ' ', ' ', '|' },
                            new char[]{'|', ' ', ' ', ' ', ' ', '|' },
                            new char[]{'|', ' ', ' ', ' ', ' ', '|' },
                                            cardRole,
                            new char[]{'-', '-', '-', '-', '-', '-' }
            };
        return vs;
    }
    public  char[][] closedCard = {
                            new char[]{'_', '_', '_', '_', '_', '_' },
                            new char[]{'|', ' ', '@', '@', ' ', '|' },
                            new char[]{'|', '@', '|', '|', '@', '|' },
                            new char[]{'|', '@', '|', '|', '@', '|' },
                            new char[]{'|', '@', '|', '|', '@', '|' },
                            new char[]{'|', ' ', '@', '@', ' ', '|' },
                            new char[]{'-', '-', '-', '-', '-', '-' }
    };
}
}