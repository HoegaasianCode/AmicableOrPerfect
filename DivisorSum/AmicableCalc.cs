using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisorSum
{
    public class AmicableCalc
    {
        private int _x; // input number
        private int _y; // divisor-sum
        private readonly short[] A = new short[] { 0, 0, 0, 0 };
        // A = { [0] = Perfect, [1] = Lesser amicable, [2] = Greater Amicable, [3] = Neither } 
        public AmicableCalc(int x)
        {
            _x = x;
        }

        public void SumDivisors()
        {
            for (int i = 1; i <= _x; i++) _y += _x / i; // need a function to detect "proper divisors"
        }

        public void IsPerfect()
        {
            if (_x == _y) A[0] = 1;
        }

        public void CheckAmicable()
        {
            if (_y > _x) IsAmicable(true);
            if (_y < _x) IsAmicable(false);
        }

        private void IsAmicable(bool index) // 220 -> 284
        {
            bool isLesser = index;
            int x1 = _x;
            _x = _y;
            _y = 0;
            SumDivisors();
            if (x1 == _x && isLesser)  A[1] = 1;
            if (x1 == _x && !isLesser) A[2] = 1;
            if (x1 != _x && A[0] == 0) A[3] = 1;
        }

        public void Print()
        {
            if (A[0] == 1) Console.Write("Perfect number!");
            if (A[1] == 1) Console.Write("Lesser of amicable pair!");
            if (A[2] == 1) Console.Write("Greater of amicable pair!");
            if (A[3] == 1) Console.Write("Neither!");
        }
    }
}
