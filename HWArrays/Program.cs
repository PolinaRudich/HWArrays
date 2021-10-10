using System;

namespace HWArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Найти индекс минимального элемента массива
            Console.WriteLine("Array1");

            int[] array = new int[10];
            Random random = new Random();
            int minItem = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);

                if (minItem > array[i])
                {
                    minItem = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine($"\n{minItem}");

            Console.WriteLine("Array2");
            int[] arraySecond = new int[10];
            int maxItem = arraySecond[0];
            for (int i = 0; i < arraySecond.Length; i++)
            {
                arraySecond[i] = random.Next(-100, 100);
                if (maxItem < arraySecond[i])
                {
                    maxItem = arraySecond[i];
                };
            }
            for (int i = 0; i < arraySecond.Length; i++)
            {
                Console.Write(arraySecond[i] + " ");
            }
            Console.WriteLine($"\n{maxItem}");


            //////Найти индекс минимального элемента массиваs
            Console.WriteLine("Array3");
            int[] arrayThird = new int[10];
            for (int i = 0; i < arrayThird.Length; i++)
            {
                arrayThird[i] = random.Next(1, 100);
            }
            int indexOfMinElement = 0;
            int minElement = arrayThird[0];
            for (int i = 0; i < arrayThird.Length; i++)
            {
                if (minElement > arrayThird[i])
                {
                    minElement = arrayThird[i];
                    indexOfMinElement = i;
                }
                Console.Write(arrayThird[i] + " ");
            }
            Console.WriteLine($"\n{indexOfMinElement}");

            //////Найти индекс максимального элемента массива
            Console.WriteLine("Array4");
            int[] arrayFourth = new int[10];
            for (int i = 0; i < arrayFourth.Length; i++)
            {
                arrayFourth[i] = random.Next(1, 100);
            }
            int indexOfMaxElement = 0;
            int maxElement = arrayFourth[0];
            for (int i = 0; i < arrayFourth.Length; i++)
            {
                if (maxElement < arrayFourth[i])
                {
                    maxElement = arrayFourth[i];
                    indexOfMaxElement = i;
                }
                Console.Write(arrayFourth[i] + " ");
            }
            Console.WriteLine($"\n{indexOfMaxElement}");

            ////Посчитать сумму элементов массива с нечетными индексами
            Console.WriteLine("Array5");
            int[] arrayFifth = new int[10];
            for (int i = 0; i < arrayFifth.Length; i++)
            {
                arrayFifth[i] = random.Next(1, 100);
               
            }
            int sumNechet = 0;
            
            for (int i = 0; i < arrayFifth.Length; i++)
            {
                int nechElemnt = arrayFifth[i];
                if (nechElemnt % 2 != 0)
                {

                    sumNechet = sumNechet + nechElemnt;
                }

                Console.Write(arrayFifth[i] + " ");
            }
            Console.WriteLine($"\n{sumNechet}");


            ////Сделать реверс массива (массив в обратном направлении)



            Console.WriteLine("Array6");

            int[] arraySix = new int[10];
            for (int i = 0; i < arraySix.Length; i++)
            {
                arraySix[i] = random.Next(1, 100);
            }
            for (int i = 0; i < arraySix.Length; i++)
            {
                Console.Write(arraySix[i] + " ");
            }
            Console.WriteLine();
            int c = 0;

            for (int i = 0; i < arraySix.Length / 2; i++)
            {
                c = arraySix[i];
                arraySix[i] = arraySix[arraySix.Length - i - 1];
                arraySix[arraySix.Length - i - 1] = c;

            }

            for (int i = 0; i < arraySix.Length; i++)
            {
                Console.Write(arraySix[i] + " ");
            }
            Console.WriteLine();

            //////Посчитать количество нечетных элементов массива
            Console.WriteLine("Задание 7");
            int[] array7 = new int[10];
            for (int i = 0; i < array7.Length; i++)
            {
                array7[i] = random.Next(1, 100);
            }
            int sumnecht = 0;

            int nechet7 = array7[0];
            for (int i = 0; i < array7.Length; i++)
            {
                if (nechet7 % 2 != 0)
                {

                    sumnecht = sumnecht + 1;
                }
                nechet7 = array7[i];
                Console.Write(array7[i] + " ");
            }

            Console.WriteLine($"\n{sumnecht}");



            //Поменять местами первую и вторую половину массива, например,
            //для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
            Console.WriteLine("Array8");

            int[] arrayEight = new int[10];

            for (int i = 0; i < arrayEight.Length; i++)
            {
                arrayEight[i] = random.Next(1, 100);
            }
            for (int i = 0; i < arrayEight.Length; i++)
            {
                Console.Write(arrayEight[i] + " ");
            }

            Console.WriteLine();
            int tmp = 0;
            int odd = 0;
            int j = arrayEight.Length / 2;
            if (arrayEight.Length % 2 != 0)
            {
                odd = 1;
            }
            for (int i = 0; i < j; i++)
            {
                tmp = arrayEight[i];
                arrayEight[i] = arrayEight[j + i + odd];
                arrayEight[j + i + odd] = tmp;

            }
            for (int i = 0; i < arrayEight.Length; i++)
            {
                Console.Write(arrayEight[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array9");
            int[] arrayNine = new int[10];
            for (int i = 0; i < arrayNine.Length; i++)
            {
                arrayNine[i] = random.Next(1, 100);
                Console.Write( arrayNine[i]+ " ");
            }
            Console.WriteLine();
            int l = arrayNine.Length;
            for (int i = 0; i < l-1; i++)
            {
                int minValue = arrayNine[i];
                int minIndex = i; 
                for (int o = i+1; o < l; o++)
                {
                    if(minValue>arrayNine[o])
                    {
                        minValue = arrayNine[o];
                        minIndex = o;
                    }
                }

                    minValue = arrayNine[i];
                    arrayNine[i] = arrayNine[minIndex];
                    arrayNine[minIndex] = minValue;
                    foreach (var item in arrayNine)
                     {
                    Console.Write(item + " ");
                     }
                Console.WriteLine();
            }
            
            Console.WriteLine("Array10");

            int[] arrayTen = new int[10];

            for (int i1 = 0; i1 < arrayTen.Length; i1++)
            {
                arrayTen[i1] = random.Next(1, 100);
            }
            for (int i1 = 0; i1 < arrayTen.Length; i1++)
            {
                Console.Write(arrayTen[i1] + " ");
            }
            Console.WriteLine();

            for (int i1 = 1; i1 < arrayTen.Length; i1++)
            {
                int tmp10 = arrayTen[i1];
                int j1 = i1;
                while (j1 > 0 && tmp10 < arrayTen[j1 - 1])
                {
                    arrayTen[j1] = arrayTen[j1 - 1];
                    j1--;
                }
                arrayTen[j1] = tmp10;
            }
            for (int i1 = 0; i1 < arrayTen.Length; i1++)
            {
                Console.Write(arrayTen[i1] + " ");
            }
            return;


        }
    }

}

    

                   
                    
                       
                    


