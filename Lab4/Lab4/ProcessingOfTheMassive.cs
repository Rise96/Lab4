using System;

namespace Lab4
{
    class ProcessingOfTheMassive
    {
        public int[] FindSumClosestToMaxNumber(int[] arrayOfNumbers)
        {
            int maxNumber = MaxNumberInMassive(arrayOfNumbers);
            int firstElem= 0 ;
            int secondElem =  1 ;
            int differenceWithMax = Math.Abs(maxNumber - (arrayOfNumbers[0] + arrayOfNumbers[1]));
            for (int i = 0; i < arrayOfNumbers.Length; i++) 
            {
                for(int j=1;j<arrayOfNumbers.Length;j++)
                {
                    if (i != j)
                    {
                        if(differenceWithMax>(Math.Abs(maxNumber - (arrayOfNumbers[i] + arrayOfNumbers[j]))))
                        {
                            firstElem = i;
                            secondElem = j;
                            differenceWithMax = Math.Abs(maxNumber - (arrayOfNumbers[i] + arrayOfNumbers[j]));
                        }
                    }
                }
            }
            arrayOfNumbers = Swap2NumbersInArray(arrayOfNumbers, firstElem, secondElem);
            return arrayOfNumbers;
        }

        private int MaxNumberInMassive(int[] arrayOfNumbers)
        {
            int MaxNumber = arrayOfNumbers[0];
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (MaxNumber < arrayOfNumbers[i])
                {
                    MaxNumber = arrayOfNumbers[i];
                }
            }
            return MaxNumber;
        }

        private int[] Swap2NumbersInArray(int[] arrayOfNumbers, int indexOf1stElem,int indexOf2ndElem)
        {
            int saverOf1stElem = arrayOfNumbers[indexOf1stElem];
            arrayOfNumbers[indexOf1stElem] = arrayOfNumbers[indexOf2ndElem];
            arrayOfNumbers[indexOf2ndElem] = saverOf1stElem;
            return arrayOfNumbers;
        }
    }
}
