/* Задача 56: Задайте прямоугольный двумерный массив. Напишите 
программу, которая будет находить строку с наименьшей суммой 
элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка*/

using System;
using static System.Console;

Clear();
WriteLine("Программа находит строку с наименьшей суммой элементов");
WriteLine("(Двумерный массив генерируется случайным образом.");
WriteLine(" Минимальный размер возможного массива 2х2; Максимальный 8х8)");
                                                                    WriteLine();            
int[,] Arr = NewArr(); //Генерация случайного двумерного массива                                                                 
MinSumArr (PrntarrAndlineSum(Arr));  //Вывоод номера строки с минимальной суммой                                  

void MinSumArr (int[] minSumArr)
{
    //Ищем минимальное значение
    int min = minSumArr[0];
    for (int i = 0; i < minSumArr.Length-1; i++)
    {
        if(min > minSumArr[i+1]) min = minSumArr[i+1];
    }
    
    //Проверяем и выводим если есть несколько строк с минимальной суммой
                                                                     WriteLine();
    for (int i = 0; i < minSumArr.Length; i++ )
    {                                                    
        if (minSumArr[i] == min)                                                             
        WriteLine($"Номер строки {i}, Минимальная сумма  {min}");
    }
}

int [,] NewArr () 
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


int[] PrntarrAndlineSum (int[,] inArray) //Вывод двумерного массива вместе с суммой
{
    int[] Array = new int[inArray.GetLength(0)]; 
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Array[(i)] += inArray[i, j];
            Write($"{inArray[i, j]} ");
        }
        Write($"  Sum {Array[i]}");
                                                                    WriteLine();
    }
    return Array;
}

