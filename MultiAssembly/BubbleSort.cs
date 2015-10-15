using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    public class BubbleSort
    {
        public static int[][] SortBySumIncreasing(int[][] originalArray)
        {
            int lineCount = originalArray.Length;
            int[][] result = new int[lineCount][];
            int[] sum = new int[lineCount];
            if (originalArray == null)
            {
                throw new NullReferenceException();
            }
            for (int i = 0; i < lineCount; i++)
            {
                if (originalArray[i] != null)
                {
                    result[i] = new int[originalArray[i].Length];
                    for (int j = 0; j < originalArray[i].Length; j++)
                    {
                        result[i][j] = originalArray[i][j];
                        sum[i] += result[i][j];
                    }
                }
                else
                {
                    sum[i] = int.MaxValue;
                }
            }
            int swapValue;
            int[] swapArray;
            for (int i = 0; i < sum.Length; i++)
            {
                for (int j = i + 1; j < sum.Length; j++)
                {
                    if (sum[i] > sum[j])
                    {
                        swapValue = sum[i];
                        sum[i] = sum[j];
                        sum[j] = swapValue;
                        swapArray = result[i];
                        result[i] = result[j];
                        result[j] = swapArray;
                    }
                }
            }
            return result;
        }

        public static int[][] SortBySumDecreasing(int[][] originalArray)
        {
            int lineCount = originalArray.Length;
            int[][] result = new int[lineCount][];
            int[] sum = new int[lineCount];
            if (originalArray == null)
            {
                throw new NullReferenceException();
            }
            for (int i = 0; i < lineCount; i++)
            {
                if (originalArray[i] != null)
                {
                    result[i] = new int[originalArray[i].Length];
                    for (int j = 0; j < originalArray[i].Length; j++)
                    {
                        result[i][j] = originalArray[i][j];
                        sum[i] += result[i][j];
                    }
                }
                else
                {
                    sum[i] = int.MinValue;
                }
            }
            int swapValue;
            int[] swapArray;
            for (int i = 0; i < sum.Length; i++)
            {
                for (int j = i + 1; j < sum.Length; j++)
                {
                    if (sum[i] < sum[j])
                    {
                        swapValue = sum[i];
                        sum[i] = sum[j];
                        sum[j] = swapValue;
                        swapArray = result[i];
                        result[i] = result[j];
                        result[j] = swapArray;
                    }
                }
            }
            return result;
        }

        public static int[][] SortByMinValueIncreasing(int[][] originalArray)
        {
            int lineCount = originalArray.Length;
            int[][] result = new int[lineCount][];
            int[] minValues = new int[lineCount];
            if (originalArray == null)
            {
                throw new NullReferenceException();
            }
            int smallestValue;
            for (int i = 0; i < lineCount; i++)
            {
                smallestValue = int.MaxValue;
                if (originalArray[i] != null)
                {
                    result[i] = new int[originalArray[i].Length];
                    for (int j = 0; j < originalArray[i].Length; j++)
                    {
                        result[i][j] = originalArray[i][j];
                        if (result[i][j] < smallestValue)
                        {
                            smallestValue = result[i][j];
                        }
                    }
                }
                minValues[i] = smallestValue;
            }
            int swapValue;
            int[] swapArray;
            for (int i = 0; i < minValues.Length; i++)
            {
                for (int j = i + 1; j < minValues.Length; j++)
                {
                    if (minValues[i] > minValues[j])
                    {
                        swapValue = minValues[i];
                        minValues[i] = minValues[j];
                        minValues[j] = swapValue;
                        swapArray = result[i];
                        result[i] = result[j];
                        result[j] = swapArray;
                    }
                }
            }
            return result;
        }

        public static int[][] SortByMinValueDecreasing(int[][] originalArray)
        {
            int lineCount = originalArray.Length;
            int[][] result = new int[lineCount][];
            int[] minValues = new int[lineCount];
            if (originalArray == null)
            {
                throw new NullReferenceException();
            }
            int smallestValue;
            for (int i = 0; i < lineCount; i++)
            {
                smallestValue = int.MaxValue;
                if (originalArray[i] != null)
                {
                    result[i] = new int[originalArray[i].Length];
                    for (int j = 0; j < originalArray[i].Length; j++)
                    {
                        result[i][j] = originalArray[i][j];
                        if (result[i][j] < smallestValue)
                        {
                            smallestValue = result[i][j];
                        }
                    }
                    minValues[i] = smallestValue;
                }
                else
                {
                    minValues[i] = int.MinValue;
                }
            }
            int swapValue;
            int[] swapArray;
            for (int i = 0; i < minValues.Length; i++)
            {
                for (int j = i + 1; j < minValues.Length; j++)
                {
                    if (minValues[i] < minValues[j])
                    {
                        swapValue = minValues[i];
                        minValues[i] = minValues[j];
                        minValues[j] = swapValue;
                        swapArray = result[i];
                        result[i] = result[j];
                        result[j] = swapArray;
                    }
                }
            }
            return result;
        }

        public static int[][] SortByMaxValueIncreasing(int[][] originalArray)
        {
            int lineCount = originalArray.Length;
            int[][] result = new int[lineCount][];
            int[] maxValues = new int[lineCount];
            if (originalArray == null)
            {
                throw new NullReferenceException();
            }
            int biggestValue;
            for (int i = 0; i < lineCount; i++)
            {
                biggestValue = int.MinValue;
                if (originalArray[i] != null)
                {
                    result[i] = new int[originalArray[i].Length];
                    for (int j = 0; j < originalArray[i].Length; j++)
                    {
                        result[i][j] = originalArray[i][j];
                        if (result[i][j] > biggestValue)
                        {
                            biggestValue = result[i][j];
                        }
                    }
                    maxValues[i] = biggestValue;
                }
                else
                {
                    maxValues[i] = int.MaxValue;
                }
            }
            int swapValue;
            int[] swapArray;
            for (int i = 0; i < maxValues.Length; i++)
            {
                for (int j = i + 1; j < maxValues.Length; j++)
                {
                    if (maxValues[i] > maxValues[j])
                    {
                        swapValue = maxValues[i];
                        maxValues[i] = maxValues[j];
                        maxValues[j] = swapValue;
                        swapArray = result[i];
                        result[i] = result[j];
                        result[j] = swapArray;
                    }
                }
            }
            return result;
        }

        public static int[][] SortByMaxValueDecreasing(int[][] originalArray)
        {
            int lineCount = originalArray.Length;
            int[][] result = new int[lineCount][];
            int[] maxValues = new int[lineCount];
            if (originalArray == null)
            {
                throw new NullReferenceException();
            }
            int biggestValue;
            for (int i = 0; i < lineCount; i++)
            {
                biggestValue = int.MinValue;
                if (originalArray[i] != null)
                {
                    result[i] = new int[originalArray[i].Length];
                    for (int j = 0; j < originalArray[i].Length; j++)
                    {
                        result[i][j] = originalArray[i][j];
                        if (result[i][j] > biggestValue)
                        {
                            biggestValue = result[i][j];
                        }
                    }
                    maxValues[i] = biggestValue;
                }
                else
                {
                    maxValues[i] = int.MinValue;
                }
            }
            int swapValue;
            int[] swapArray;
            for (int i = 0; i < maxValues.Length; i++)
            {
                for (int j = i + 1; j < maxValues.Length; j++)
                {
                    if (maxValues[i] < maxValues[j])
                    {
                        swapValue = maxValues[i];
                        maxValues[i] = maxValues[j];
                        maxValues[j] = swapValue;
                        swapArray = result[i];
                        result[i] = result[j];
                        result[j] = swapArray;
                    }
                }
            }
            return result;
        }
    }
}
