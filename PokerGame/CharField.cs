namespace PokerGame
{
    public abstract class CharField
    {
        static  char[][] freeSpace = {
            new char[]{' ', ' ', ' ', ' ', ' ', ' ' },
            new char[]{' ', ' ', ' ', ' ', ' ', ' ' },
            new char[]{' ', ' ', ' ', ' ', ' ', ' ' },
            new char[]{' ', ' ', ' ', ' ', ' ', ' ' },
            new char[]{' ', ' ', ' ', ' ', ' ', ' ' },
            new char[]{' ', ' ', ' ', ' ', ' ', ' ' },
            new char[]{' ', ' ', ' ', ' ', ' ', ' ' },
        };
        public virtual char[][] Image
        {
            get => freeSpace;set => freeSpace = value;
        }
    }
}