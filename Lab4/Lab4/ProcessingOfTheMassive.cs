using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ProcessingOfTheMassive
    {
        public int[] FindSumClosestToMaxNumber(int[] massiveOfNumbers)
        {
            int MaxNumber = MaxNumberInMassive(massiveOfNumbers);
            int[] firstElem= {massiveOfNumbers[0],0 };
            int[] secondElem = { massiveOfNumbers[0], 0 };
            for(int i = 0; i < massiveOfNumbers.Length; i++)
            {

            }
            return massiveOfNumbers;
        }
        private int MaxNumberInMassive(int[] massiveOfNumbers)
        {
            int MaxNumber = massiveOfNumbers[0];
            for(int i = 0; i < massiveOfNumbers.Length; i++)
            {
                if (MaxNumber < massiveOfNumbers[i])
                {
                    MaxNumber = massiveOfNumbers[i];
                }
            }
            return MaxNumber;
        }
        private int[] Swap2NumbersInMassive(int[] massiveOfNumbers, int indexOf1stElem,int indexOf2ndElem)
        {
            int saverOf1stElem = massiveOfNumbers[indexOf1stElem];
            massiveOfNumbers[indexOf1stElem] = massiveOfNumbers[indexOf2ndElem];
            massiveOfNumbers[indexOf1stElem] = saverOf1stElem;
            return massiveOfNumbers;
        }
    }
}
