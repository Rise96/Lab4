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
            int firstElem= 0 ;
            int secondElem =  1 ;
            int differenceWithMax = Math.Abs(MaxNumber - (massiveOfNumbers[0] + massiveOfNumbers[1]));
            for (int i = 0; i < massiveOfNumbers.Length; i++) 
            {
                for(int j=1;j<massiveOfNumbers.Length;j++)
                {
                    if (i != j)
                    {
                        if(differenceWithMax>(Math.Abs(MaxNumber - (massiveOfNumbers[i] + massiveOfNumbers[j]))))
                        {
                            firstElem = i;
                            secondElem = j;
                            differenceWithMax = Math.Abs(MaxNumber - (massiveOfNumbers[i] + massiveOfNumbers[j]));
                        }
                    }
                }
            }
            massiveOfNumbers = Swap2NumbersInMassive(massiveOfNumbers, firstElem, secondElem);
            return massiveOfNumbers;
        }

        private int MaxNumberInMassive(int[] massiveOfNumbers)
        {
            int MaxNumber = massiveOfNumbers[0];
            for (int i = 0; i < massiveOfNumbers.Length; i++)
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
            massiveOfNumbers[indexOf2ndElem] = saverOf1stElem;
            return massiveOfNumbers;
        }
    }
}
