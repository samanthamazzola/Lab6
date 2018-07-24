using System;

namespace Lab6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sidesCount = 6;
            random = new Random();

            Rollingdie dice1 = new Rollingdie(10);
            Console.WriteLine(die1.GetSides());
            Rollingdie dice2 = new Rollingdie();
            Console.WriteLine(die2.GetSides());
           

        }
        public static int Rollingdie(int sidesCount)
        {
            sidesCount = GetSides();
            random = new Random();

        }
        public static int GetSides();
            {
                return sidesCount;
            }
        public int Roll()
        {
            return random.Next(1, sidesCount + 1);
        }
    }
}
