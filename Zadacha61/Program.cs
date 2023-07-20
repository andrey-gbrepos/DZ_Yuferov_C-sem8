 //Задача 61: Показать треугольник Паскаля. *Сделать вывод  
//в виде равнобедренного треугольника */

using System;
using static System.Console;

Clear();
WriteLine("Треугольник Паскаля");

WriteLine("Введите количество строк для расчета треугольника Паскаля:");
                                                                          
int numberPascal = Convert.ToInt32(ReadLine());
int[,] Arr = PascArr(numberPascal*2+2); //Генерация случайного двумерного массива 
WriteLine(); 
PrintArray (Arr);
WriteLine(); 

int [,] PascArr (int num) //генератор двумерного массива
{ 
   int row = num;             
   int col = row;
  int[,] res = new int[row,col];
res[0,col/2-1] = 1;
res[1,col/2-2] = 1;
res[1,col/2] = 1;
  
    for (int i = 2; i < res.GetLength(0); i++)
    {
        for(int j = 1; j < res.GetLength(1)-1; j++)
        {
            res [i,j] = res [i-1,j-1] + res [i-1,j+1];
        }
    }
    return res;
}

void PrintArray (int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0)/2-1; i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j]==0) Write($"   ");
            else
            Write($"{inArray[i, j]}  ");
        }
        WriteLine();
    }
}