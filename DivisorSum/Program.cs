using System;

namespace DivisorSum
{
    class Program
    {
        //ONGOING CHALLENGE
        //ASSIGNMENT TEXT: https://edabit.com/challenge/iN6jPGkAoBTCT7xoq

        static void Main(string[] args)
        {
            var num = new AmicableCalc(6);
            Console.Write(num.CalcAmicable());
        }
    }
}
