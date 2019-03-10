using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class mathMethods
    {
        public int maxScore(int[] numbers)
        {
            int maxTracker = numbers[0];
            // for each loop  
            foreach (int grade in numbers)
            {
                if (grade > maxTracker)
                { maxTracker = grade; }
            }
            return maxTracker;
        }
    }
}
