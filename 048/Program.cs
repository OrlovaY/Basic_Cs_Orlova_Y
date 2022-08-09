// Написать программу копирования массива

using System;
/*
int[] arr = { 5, 4, 7, 2, 9 };
 
        int[] copy = new int[arr.Length];
        arr.CopyTo(copy, 0);

Console.WriteLine(String.Join(", ", copy));  
*/

int[] arr = { 5, 4, 7, 2, 9 };
 
        int[] copy = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++) 
        {
            copy[i] = arr[i];
        }
 
        Console.WriteLine(String.Join(", ",copy)); 