using System;
using System.Collections.Generic;
using System.Text;

namespace Dices
{
    public class Dice
    {
        private int _res;
        private bool not_thrown;

        public int result => _res;

        public Dice()
        {
            not_thrown = true;
            _res = 0;
        }

        public void Roll()
        {
            Random rnd = new Random();
            _res = rnd.Next(1, 7);
            not_thrown = false;
        }

        public void RollOne()
        {
            _res = 1;
            not_thrown = false;
        }

        public void TakeOff()
        {
            not_thrown = true;
            _res = 0;
        }

        public void ShowTheResult()
        {
            switch (_res)
            {
                case 0:
                    Console.WriteLine("the dice isn't rolled");
                    break;
                case 1:
                    Console.WriteLine("the minimum result");
                    break;
                case 6:
                    Console.WriteLine("the maximum result");
                    break;
                case int n when (n > 6):
                    Console.WriteLine("incorrect value of the dice");
                    break;
                default:
                    Console.WriteLine("a medium result of " + _res);
                    break;
            }
        }
    }
}
