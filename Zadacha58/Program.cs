/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

using System;
using static System.Console;

Clear();
WriteLine("Программа находит и выводит произведение двух матриц");
WriteLine("(Массивы размером от 3x3 формируются автоматически ");                                                               
                                                                  WriteLine();            
int[,] arrA = NewArr(); //Генерация случайного двумерного массива 
int[,] arrB = NewArr();
PrintArray (arrA);
WriteLine("x");
PrintArray (arrB);
WriteLine("------------");
PrintArray (productMatrix(arrA, arrB));


int[,] productMatrix (int[,] MatrixA, int[,] MatrixB )
{
    int[,] tempB = new int[MatrixB.GetLength(0), MatrixB.GetLength(1)];
    int[,] productMatr = new int[MatrixA.GetLength(1), MatrixB.GetLength(0)];
    for (int i = 0; i < MatrixB.GetLength(0); i++)// Разворот матрицы
        {
            for (int j = 0; j < MatrixB.GetLength(1); j++)
            {
                tempB[j, i] = MatrixB[i, j];
            }
        }

    int prod;
    for (int i = 0; i < MatrixA.GetLength(0); i++) //Подсчет произведения
    {
        for (int k = 0; k < tempB.GetLength(0); k++)       
        {   
            prod  = 0;
            for (int j = 0; j < tempB.GetLength(1); j++)
            {
                prod += MatrixA[i, j] * tempB[k, j];
            }
           productMatr[i, k] = prod;       
        }    
    }
        return productMatr;
}

int [,] NewArr () 
{
   
   int row = new Random().Next(3, 4);
               
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