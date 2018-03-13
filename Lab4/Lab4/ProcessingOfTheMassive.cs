using System;

namespace Lab4
{
    class ProcessingOfTheMassive
    {
        public int[] FindAndSwapSumClosestToMaxNumber(int[] arrayOfNumbers)
        {
            int maxNumber = MaxNumberInMassive(arrayOfNumbers);
            int firstElement = 0;
            int secondElement = 1;
            int differenceWithMax = Math.Abs(maxNumber - (arrayOfNumbers[0] + arrayOfNumbers[1]));
            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayOfNumbers.Length; j++)
                {
                    if (differenceWithMax > (Math.Abs(maxNumber - (arrayOfNumbers[i] + arrayOfNumbers[j]))))
                    {
                        firstElement = i;
                        secondElement = j;
                        differenceWithMax = Math.Abs(maxNumber - (arrayOfNumbers[i] + arrayOfNumbers[j]));
                    }
                }
            }
            arrayOfNumbers = Swap2NumbersInArray(arrayOfNumbers, firstElement, secondElement);
            return arrayOfNumbers;
        }

        private int MaxNumberInMassive(int[] arrayOfNumbers)
        {
            int maxNumber = arrayOfNumbers[0];
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (maxNumber < arrayOfNumbers[i])
                {
                    maxNumber = arrayOfNumbers[i];
                }
            }
            return maxNumber;
        }

        private int[] Swap2NumbersInArray(int[] arrayOfNumbers, int indexOf1stElem, int indexOf2ndElem)
        {
            int saverOf1stElem = arrayOfNumbers[indexOf1stElem];
            arrayOfNumbers[indexOf1stElem] = arrayOfNumbers[indexOf2ndElem];
            arrayOfNumbers[indexOf2ndElem] = saverOf1stElem;
            return arrayOfNumbers;
        }
    }
}
