
/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

using System;
using static System.Console;

Clear();
WriteLine("Программа упорядочит по убыванию элементы каждой строки двумерного массива");
WriteLine("(Двумерный массив генерируется случайным образом.");
WriteLine(" Минимальный размер возможного массива 2х2; Максимальный 8х8)");
                                                                    WriteLine();            
int[,] Arr = NewArr(); //Генерация случайного двумерного массива 
WriteLine("Исходный массив: "); 
PrintArray (Arr);
WriteLine(); 
WriteLine("Отсортированный массив: "); 
PrintArray (sortArr(Arr));


int[,] copyArr2x (int[,] forCopy)
{
    int[,] newAr = new int[forCopy.GetLength(0),forCopy.GetLength(1)];
    for (int i = 0; i < forCopy.GetLength(0); i++)
    {
       for (int j = 0; j < forCopy.GetLength(0); j++) 
       {
        newAr[i, j] = forCopy[i, j];
       }
    } 
    return newAr;
}

int[,] sortArr(int[,] inAr)
{ 
    int[,] forSort = copyArr2x(inAr);
    int min;
    for (int i = 0; i < forSort.GetLength(0); i++ ) //Перебор строк
    {
        for (int k = 0; k < forSort.GetLength(1)-1; k++) //счетчик переборов по строке
        {
            min = forSort[i, 0];
           for (int j = 1; j < forSort.GetLength(1); j++) //Перебор столбцов
           {
                if (forSort[i, j] > min)
                    { 
                        forSort[i, j-1] = forSort[i, j];
                        forSort[i, j] = min;
                    }
                else 
                    {
                        min = forSort[i, j];
                    }   
           }
        }
    }
    return forSort;
}

int [,] NewArr () //генератор двумерного массива
{
   
   int row = new Random().Next(2, 9);
               
   int col = row;
              
    int[,] res = new int[row,col];
    for (int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            res [i,j] = new Random().Next(0,10); 
        }
    }
    return res;
}

void PrintArray (int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}