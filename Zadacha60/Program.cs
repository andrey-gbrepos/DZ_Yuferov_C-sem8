/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

using System;
using static System.Console;

Clear();
WriteLine("Программа формирует 3-х мерный массив размером 2х2х2 из неповторяющихся ");
WriteLine("двухзначных чисел, и выводит его построчно с индексами элементов.");

                                                                    WriteLine();            
int[, ,] Arr = NewArr3x(); //Генерация случайного двумерного массива 
PrintArray3x (Arr); //Вывод массива


//Генератор трехмерного массива
int [, ,] NewArr3x ()
{ 
   int row = new Random().Next(2, 3);          
   int col = row;
   int wight = row;


int[, ,] res = new int[row,col,wight];
int[] numRand = new int[8];//вспомогательный массив для повторяющихся чисел
int count = 0; //счетчик для вспомогательного массива
 
    for (int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            for (int k = 0; k < wight; k++ )
            {      
                    res[i, j, k] = InOrOut(count, numRand);
                    count++;                     
            }
        }
    } 
    return res;
}
//Генерирование чисел и проверка на повторяемость
int InOrOut (int number, int[] tempAr) //Передаются вспомогательный массив и его счетчик
{                                           //Возвращает неповторяющееся число
    int num = new Random().Next(10,19);
    int coun = 0;
        for (int i = 0; i < tempAr.Length; i++)
            {      
                if (tempAr[i] == num) coun++;
            }
            if ( coun == 0)
            {
                tempAr[number] = num;
                return tempAr[number];
            }
            else return InOrOut (number, tempAr);
}    

void PrintArray3x (int[, ,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            WriteLine();
            for (int k = 0; k < inArray.GetLength(2); k++)
        {
            
            Write($"{inArray[i, j, k]} ({j} {k} {i}) ");
        }
        }
        
    }
}