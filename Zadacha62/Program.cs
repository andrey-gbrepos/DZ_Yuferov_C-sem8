/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


using System;
using static System.Console;

Clear();
WriteLine("Программа заполнит спирально массив 4х4");
                                                                    WriteLine();
            
WriteLine("Исходный массив: "); 
int[] arr1x = {00,01,02,03,04,05,06,07,08,09,10,11,12,13,14,15};
WriteLine($"{String.Join(" ",arr1x)}");
int[,] newArr = new int[4,4];//Пустой двумерный массив
WriteLine("Пустой двумерный массив ");
PrintArray (newArr); 
FillSpir(arr1x, newArr);
WriteLine("Заполненный двумерный массив по 'улитке' ");
PrintArray (newArr);
WriteLine(); 

void FillSpir(int[]arr, int[,] Arr2x)
{
    int diff = 0;
    int row = 0;
    int col = 0;
    for (int i=col; i< Arr2x.GetLength(1); i++)
        {
            Arr2x[row,i] = arr[i];                                
        }
            diff += Arr2x.GetLength(1)-1;         
            col = Arr2x.GetLength(1)-1;                   
            //row - 0, col - 3, diff - 3 
                                
                                for (int i=row+1; i< Arr2x.GetLength(0); i++)
                                    {
                                        Arr2x[i,col] = arr[i+diff]; 
                                    }
                                        diff += Arr2x.GetLength(0)-1;
                                        row = Arr2x.GetLength(0)-1;                     
                                                     //row - 3, col - 3, diff - 6
    
    for (int i=col-1; i >= 0; i--)
        {
            Arr2x[row,i] = arr[col-i+diff];
        }
            diff += Arr2x.GetLength(1)-1;
            col = Arr2x.GetLength(1)-1-col;
            //row - 3, col - 0, diff - 9  

                                for (int i=row-1; i > 0; i--)
                                    {
                                        Arr2x[i,col] = arr[row-i+diff];
            
                                    }  
                                        diff += Arr2x.GetLength(0)-2;  
                                        row = Arr2x.GetLength(0)-row;                                                               
                                        //row - 1, col - 0, diff - 11 

    for (int i=col+1; i < Arr2x.GetLength(1)-1; i++)
        {
            Arr2x[row,i] = arr[i+diff];
        }
            diff += Arr2x.GetLength(1)-2;
            col = Arr2x.GetLength(1)-2-col;                         
            //row - 1, col - 2, diff - 13
                                
                                for (int i=row+1; i< Arr2x.GetLength(0)-1; i++)
                                    {
                                        Arr2x[i,col] = arr[i-1+diff];
                                    }  
                                        diff += Arr2x.GetLength(0)-3;
                                        row = Arr2x.GetLength(0)-1-row;  
                                        //row - 2, col - 2, diff - 14

    for (int i=col-1; i > Arr2x.GetLength(1)-4; i--)
        {
            Arr2x[row,i] = arr[col-i+diff];
        }
            //row - 2, col - 1, diff - 15 
}
void PrintArray (int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}\t");
        }
        WriteLine();
    }
}
