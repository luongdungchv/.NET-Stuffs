using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StoneGame
    {
        static int Winner(int stone, int take, Dictionary<int, int> dict)
        {
            int taker = take == 1 ? 2 : 1;
            if (dict.ContainsKey(stone))
            {
                if (dict[stone] == 1) return take;
                else return taker;
            }
            //if (stone == 0) {
            //    return taker;
            //}
            List<int> winners = new List<int>();
            winners.Add(Winner(stone - 1, taker, dict));
            int b = 0;
            for (double i = 2; ; i++)
            {
                bool canbreak = false;
                for (double j = 2; ; j++)
                {

                    double pow = Math.Pow(i, j);
                    //Console.Write($"{pow} ");
                    if (pow > stone)
                    {
                        if (j == 2) canbreak = true;
                        break;
                    }
                    if (pow <= stone)
                    {

                        winners.Add(Winner(stone - (int)pow, taker, dict));
                    }
                }
                if (canbreak) break;
            }
            if (winners.Contains(take))
            {
                dict.Add(stone, 1);
                return take;
            }
            dict.Add(stone, 2);
            return taker;
        }
    }
}
