using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortDuration
{
    class Sorts
    {
        private static readonly Random r = new Random();

        public static void QuickSort(int[] arr)
        {
            QSort(arr, 0, arr.Length - 1);
        }

        private static void QSort(int[] arr, int start, int finish)
        {
            if (start != finish)
            {
                int ind = r.Next(start, finish);
                int item = arr[ind];
                int ind1 = start, ind2 = finish;
                int temp;
                while (ind1 <= ind2)
                {
                    while ((ind1 <= ind2) && (arr[ind1] < item)) ind1++;
                    while ((ind1 <= ind2) && (arr[ind2] >= item)) ind2--;
                    if (ind1 < ind2)
                    {
                        temp = arr[ind1];
                        arr[ind1] = arr[ind2];
                        arr[ind2] = temp;
                        ind1++;
                        ind2--;
                    }
                }

                if (ind1 == start)
                {
                    temp = arr[start];
                    arr[start] = item;
                    arr[ind] = temp;
                    QSort(arr, start + 1, finish);
                }
                else
                {
                    QSort(arr, start, ind1 - 1);
                    QSort(arr, ind2 + 1, finish);
                }

            }
        }

        public static void PyramidSort(int[] arr)
        {
            int heapSize = arr.Length;
            MakePyramid(arr, heapSize);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var temp = arr[0]; arr[0] = arr[heapSize - 1];
                arr[heapSize - 1] = temp; heapSize--;
                Seed(0, arr, heapSize);
            }
        }

        private static void MakePyramid(int[] arr, int heapSize)
        {
            int m = (arr.Length - 2) / 2;
            //m- индекс последнего элемента, имеющего потомков
            //элементы с индексами, большими m, являются листьями пирамиды
            for (int k = m; k >= 0; k--)
                Seed(k, arr, heapSize);
        }

        private static void Seed(int i, int[] arr, int heapSize)
        {
            //просеивание элемента с индексом i,
            //нарушающего свойство пирамидальности массива
            int l = 2 * i + 1, r = l + 1;   //индексы левого и правого потомка
            int temp = 0;
            if (l > heapSize - 1) return;  //это лист пирамиды
            int cand = i;
            if (arr[i] < arr[l]) cand = l;
            if ((r < heapSize) && (arr[cand] < arr[r])) cand = r;
            if (cand != i) //обмен
            {
                temp = arr[i]; arr[i] = arr[cand]; arr[cand] = temp;
                Seed(cand, arr, heapSize);     //Просеивание вниз
            }
        }

        public static void MergeSort(int[] arr)
        {
            int[] temp = new int[arr.Length];
            SortM(arr,0, arr.Length - 1, temp);
        }

        private static void SortM(int[] arr,int start, int finish, int[] temp)
        {
            if (start < finish)
            {
                int mid = (start + finish) / 2;
                SortM(arr, start, mid, temp);
                SortM(arr, mid + 1, finish, temp);
                Merge(arr, start, mid, finish, temp);
            }
        }

        private static void Merge(int[] arr,int start, int mid, int finish, int[] temp)
        {
            int topl = start, topr = mid + 1, topt = start;
            //Слияние, пока не завершится одна из частей массива
            while ((topl <= mid) && (topr <= finish))
            {
                if (arr[topl] <= arr[topr])
                    temp[topt++] = arr[topl++];
                else
                    temp[topt++] = arr[topr++];
            }
            //дописывание остатка незавершенной части массива
            while (topl <= mid)
                temp[topt++] = arr[topl++];
            while (topr <= finish)
                temp[topt++] = arr[topr++];
            //переливаем элементы в исходный массив
            for (int i = start; i <= finish; i++)
                arr[i] = temp[i];
        }

        public static int Find(int[] arr, int k)
        {
            int l = 0, r = arr.Length - 1;
            int x = 0;
            while (l < r)
            {
                x = arr[k]; //барьер
                //Разбиение на два подмножества
                int i = l, j = r;
                do
                {
                    while (arr[i] < x) i++;
                    while (x < arr[j]) j--;
                    if (i <= j)
                    {
                        if (arr[i] != arr[j])
                        {//обмен
                            int w = arr[i]; arr[i] = arr[j]; arr[j] = w;
                        }
                        i++; j--;
                    }
                }
                while (i <= j);
                //Изменение границ интервала поиска
                if (j < k) l = i;
                if (k < i) r = j;
            }
            return (arr[k]);
        }

    }
}
