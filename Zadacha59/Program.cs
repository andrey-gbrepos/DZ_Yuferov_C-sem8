/* Задача 59: Из двумерного массива целых чисел удалить строку и столбец, 
на пересечении которых расположен наименьший элемент */

using System;
using static System.Console;

Clear();
WriteLine("Программа удаляет из двумерного массива строку и столбец на пересечении которых расположен наименьший элемент");
                                                                    WriteLine();            
int[,] Arr = NewArr(); //Генерация случайного двумерного массива 
WriteLine("Исходный массив: "); 
PrintArray (Arr);
WriteLine(); 
WriteLine($"Массив после удаления строки {minElem(Arr)[0]} и столбца {minElem(Arr)[1]} "); 
WriteLine($"с минимальным значением  {Arr[minElem(Arr)[0], minElem(Arr)[1]]}:"); 
PrintArray (delCrossMinElem(minElem(Arr), Arr)); 
WriteLine(); 


int[,] delCrossMinElem (int[] Adr, int[,] Matr)
{
    int[,] tempAr1 = new int[Matr.GetLength(0), Matr.GetLength(1)-1];
    int[,] tempAr = new int[Matr.GetLength(0)-1, Matr.GetLength(1)-1];
    int[] adres = Adr;
    

    for (int i = 0; i < Matr.GetLength(0); i++) // Копируем столбцы до столбца с мин. значением
    {
        for (int j = 0; j < adres[1]; j++)
        {
          tempAr1[i,j] = Matr[i, j];
        }  
    } 

    for (int i = 0; i < Matr.GetLength(0); i++) // Копируем столбцы после столбца с мин. значением
    {
        for (int j = adres[1]+1; j < Matr.GetLength(1); j++)
        {
          tempAr1[i,j-1] = Matr[i, j];
        }  
    } 

    for (int i = 0; i < tempAr1.GetLength(1); i++) // Копируем строки до строки с мин. значением
    {
        for (int j = 0; j < adres[0]; j++)
        {
          tempAr[j,i] = tempAr1[j, i];
        }  
    } 

    for (int i = 0; i < tempAr1.GetLength(1); i++) // Копируем строки после строки с мин. значением
    {
        for (int j = adres[0]+1; j < tempAr1.GetLength(0); j++)
        {
          tempAr[j-1,i] = tempAr1[j, i];
        }  
    } 
    return tempAr;
}

int[] minElem (int[,] Matr)
{
    int [] adres = {0,0};
    int min = Matr[0,0];
    for (int i = 0; i < Matr.GetLength(0); i++)
    {
        for (int j = 0; j < Matr.GetLength(1); j++)
        {
            if (min > Matr[i,j]) 
            {
                min = Matr[i,j];
                adres[0] = i;
                adres[1] = j;
            }
        }
    }
    return adres;
}

int [,] NewArr () //генератор двумерного массива
{
   
   int row = new Random().Next(3, 6);
               
   int col = row;
              
    int[,] res = new int[row,col];
    for (int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            res [i,j] = new Random().Next(0,100); 
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
            Write($"{inArray[i, j]}  ");
        }
        WriteLine();
    }
}