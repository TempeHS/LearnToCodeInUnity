using System; //needed if working with arrays
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArrayAdvanced : MonoBehaviour
{
    void Start()
    {


        // UNCOMMENT THE FUNCTION YOU WANT TO RUN
        // ALL FUNCTIONS PRINT TO THE CONSOLE

        //SingleDimensionalArray();
        //MultiDimensionalArray();
        //CloneArray();
        //ClearArray();
        //ReverseArray();
        //GetSetMultidimensionalArrayValues();
        //SortAndSearchArray();
        //ArrayClassProperties();

    }

    // NOTE: Region tages are to make code more manageable (so you can expand and contract regions)
    // they are treated as comments and ignored by the program

    #region Sort and Search Array

    private void SortAndSearchArray()
    {
        // Create an array and add 5 items to it
        string[] stringArray = { "Mahesh", "Raj", "Neel", "Beniwal", "Chand" };

        // Find an item
        object name = "Neel";
        int nameIndex = Array.BinarySearch(stringArray, name);
        if (nameIndex >= 0)
        {
            Debug.Log("Item was at " + nameIndex.ToString() + "th position");
        }
        else
        {
            Debug.Log("Item not found");
        }

        Debug.Log("Original Array");
        Debug.Log("---------------------");
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        Debug.Log("Sorted Array");
        Debug.Log("---------------------");
        Array.Sort(stringArray);
        //  Array.Sort(stringArray, 2, 3);
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }
    }
    #endregion

    #region Array Class Properties

    private void ArrayClassProperties()
        {
            int[] intArray = new int[3] { 0, 1, 2 };
            if (intArray.IsFixedSize)
            {
                Debug.Log("Array is fixed size");
                Debug.Log("Size :" + intArray.Length.ToString());
                Debug.Log("Rank :" + intArray.Rank.ToString());
            }

    }
    #endregion

    #region CloneArray
    private void CloneArray()
        {
        string[] stringArray = { "Mahesh", "Raj", "Neel", "Beniwal", "Chand" };
        Debug.Log("Original Array");
        Debug.Log("---------------------");
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        // Clone 
        string[] clonedArray = (string[])stringArray.Clone();
        Debug.Log("Cloned Array");
        Debug.Log("---------------------");
        foreach (string str in clonedArray)
        {
            Debug.Log(str);
        }

        // Mannually Clone An Array Using ForLoop
        string[] clonedArrayLoop = new string[stringArray.Length]; ;
        for (int i = 0; i < stringArray.Length; i++ )
        {
            clonedArrayLoop[i] = stringArray[i];
        }

        Debug.Log("Cloned Array using for loop");
        Debug.Log("---------------------");    
        foreach (string str in clonedArrayLoop)
        {
            Debug.Log(str);
        }

    }
    #endregion

    #region ClearArray

    private void ClearArray()
    {
        string[] stringArray = new string [5];
        stringArray.SetValue("Mahesh", 0);
        stringArray.SetValue("Raj", 1);
        stringArray.SetValue("Neel", 2);
        stringArray.SetValue("Beniwal", 3);
        stringArray.SetValue("Chand", 4);
        Debug.Log("Original Array");
        Debug.Log("---------------------");
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        Debug.Log(" ");
        Debug.Log("Clear Items");
        Debug.Log("---------------------");
        Array.Clear(stringArray, 1, 2);

        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        Debug.Log(stringArray.GetLength(0).ToString());
        Debug.Log(stringArray.GetLowerBound(0).ToString());
        Debug.Log(stringArray.GetUpperBound(0).ToString());

    }
    #endregion

    #region ReverseArray

    private void ReverseArray()
    {
        // Create an array and add 5 items to it
        string[] stringArray = new string[5];
        stringArray.SetValue("Mahesh", 0);
        stringArray.SetValue("Raj", 1);
        stringArray.SetValue("Neel", 2);
        stringArray.SetValue("Beniwal", 3);
        stringArray.SetValue("Chand", 4);

        Debug.Log("Original stringArray");
        Debug.Log("---------------------");
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        // Reverse the array using the Array.Reverse method
        Debug.Log(" ");
        Debug.Log("Reversed stringArray");
        Debug.Log("---------------------");
        Array.Reverse(stringArray);
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        //Clone the array and then reverse it using for loops
        Debug.Log(" ");
        Debug.Log("Manually Reversed stringArray After Manually Cloning");
        Debug.Log("---------------------");
        string[] clonedArray = new string[stringArray.Length]; ;
        for (int i = 0; i < clonedArray.Length; i++)
        {
            clonedArray[i] = stringArray[i];
        }
        for (int i = 0; i < clonedArray.Length; i++)
        {
            int index = i - clonedArray.Length + 1;
            Debug.Log(-index);
            stringArray[i] = clonedArray[-index] ;
        }
        Debug.Log("Reversed Array using for loop");
        Debug.Log("---------------------");
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

    }
    #endregion

    #region SingleDimensionalArray

    private void SingleDimensionalArray()
    {
        int[] intArray;
        intArray = new int[100];
        double[] doubleArray = new double[5];
        char[] charArray = new char[5];
        bool[] boolArray = new bool[2];
        string[] stringArray = new string[10];

        // Initialize a fixed array 
        // int[] staticIntArray = new int[3] {1, 3, 5};

        // Initialize a fixed array one item at a time
        int[] staticIntArray = new int[3];

        staticIntArray[0] = 1;
        staticIntArray[1] = 3;
        staticIntArray[2] = 5;

        // Read array items one by one 
        Debug.Log(staticIntArray[0]);
        Debug.Log(staticIntArray[1]);
        Debug.Log(staticIntArray[2]);

        // Initialize a dynamic array items during declaration 
        string[] strArray = new string[] { "Mahesh Chand", "Mike Gold", "Raj Beniwal", "Praveen Kumar", "Dinesh Beniwal" };

        // Read array items using foreach loop
        foreach (string str in strArray)
        {
            Debug.Log(str);
        }
    }
    #endregion

    #region MultiDimensionalArray

    private void MultiDimensionalArray()
    {
        Debug.Log("Multidimensional arrays");
        //string[,] mutliDimStringArray;

        int[,] numbers = new int[3, 2];
        numbers[0, 0] = 1;
        numbers[1, 0] = 2;
        numbers[2, 0] = 3;
        numbers[0, 1] = 4;
        numbers[1, 1] = 5;
        numbers[2, 1] = 6;

        // int[,] numbers = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        // int[,] numbers = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        Debug.Log(numbers[0, 0]);
        Debug.Log(numbers[1, 0]);
        Debug.Log(numbers[2, 0]);
        Debug.Log(numbers[0, 1]);
        Debug.Log(numbers[1, 1]);
        Debug.Log(numbers[2, 1]);
    }
    #endregion

    #region GetSetMultidimensionalArrayValues

    private void GetSetMultidimensionalArrayValues()
    {
        string[,] playerNames = new string[2, 4];
        playerNames.SetValue("Ben", 0, 0);
        playerNames.SetValue("David", 0, 1);
        playerNames.SetValue("Michael", 0, 2);
        playerNames.SetValue("Grant Lee", 0, 3);
        playerNames.SetValue("Jones", 1, 0);
        playerNames.SetValue("Bowie", 1, 1);
        playerNames.SetValue("Franti", 1, 2);
        playerNames.SetValue("Buffalo", 1, 3);
        int items1 = playerNames.GetLength(0);
        int items2 = playerNames.GetLength(1);
        Debug.Log("Get Multidimensional Array as a list");
        Debug.Log("---------------------");
        Debug.Log("The array is " + items1 + " : " + items2);
        for (int i = 0; i < items1; i++)
        {
            for (int j = 0; j < items2; j++)
            {
                Debug.Log(i.ToString() + "," + j.ToString() + ": " + playerNames.GetValue(i, j));
            }
        }
        Debug.Log("Get Multidimensional Array in pairs");
        Debug.Log("---------------------");
        Debug.Log("Firstname : Surname");
        Debug.Log(items2);
        for (int i = 0; i < items2; i++)
        {
            Debug.Log(playerNames.GetValue(0, i) + " : " + playerNames.GetValue(1, i));
        }
    }
    #endregion

}