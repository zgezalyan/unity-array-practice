using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class ArrayPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] arrayForSum = new int[10] { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int[] arrayForFirstEntry = new int[10] { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int[] arrayForSort = SetArray(100);
        
        int sumInRange = SumOfEvenInRange(7, 21);
        int sumInArray = SumOfEvenInArray(arrayForSum);
        int firstEntry = FirstEntrySearch(arrayForFirstEntry, 34);

        Debug.Log(sumInRange);
        Debug.Log(sumInArray);
        Debug.Log(firstEntry);
        firstEntry = FirstEntrySearch(arrayForFirstEntry, 55);
        Debug.Log(firstEntry);
        Debug.Log("=====================");
        Debug.Log("Sort of array");
        Debug.Log("=====================");
        PrintArray(ChoiseSort(arrayForSort));
    }

    private int SumOfEvenInRange(int left, int right)
    {
        int sum = 0;
            
        for (int i = left; i < right + 1; i++)
        {
            if (i % 2 == 0)            
                sum = sum + i;            
        }

        return sum;
    }

    private int SumOfEvenInArray(int[] array)
    {
        int sum = 0;
        
        foreach (int a in array)
        {
            if (a % 2 == 0)            
                sum = sum + a;            
        }

        return sum;
    }

    private int FirstEntrySearch(int[] array, int number)
    {
        int entryIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                entryIndex = i;
                break;
            }            
        }

        return entryIndex;
    }

    private void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Debug.Log(array[i]);
    }
    
    private int[] SetArray(int arrayLength)
    {
        int[] array = new int[arrayLength];
        Random rnd = new Random();

        for (int i = 0; i < arrayLength; i++)
            array[i] = rnd.Next(-100, 101);

        return array;
    }

    private int[] ChoiseSort(int[] array)
    {
        int min = array[0];
        int minIndex = 0;
        int currentStart = 0;
        int buf;

        while (currentStart < array.Length - 1)
        {
            for (int i = currentStart; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            if (minIndex > currentStart)
            {
                buf = array[currentStart];
                array[currentStart] = array[minIndex];
                array[minIndex] = buf;
            }
            currentStart++;
            min = array[currentStart];
            minIndex = currentStart;
        }
        
        return array;
    }
}
