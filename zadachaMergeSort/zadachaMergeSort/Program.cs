using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachaMergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[]
        {
            new Worker("Ivan", 1000),
            new Worker("Petko", 9999),
            new Worker("Stefan", 2000),
            new Worker("Goshko", 1234),
            new Worker("Stiliyan", 999)
        };

            Console.WriteLine("Before sort:");
            Workers(workers);

            MergeSort(workers, 0, workers.Length - 1);

            Console.WriteLine("\nAfter sort:");
            Workers(workers);
        }
        static void Workers(Worker[] workers)
        {
            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.Name}: {worker.Salary}");
            }
        }

        static void MergeSort(Worker[] workers, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(workers, left, middle);
                MergeSort(workers, middle + 1, right);

                MergeSort(workers, left, middle, right);
            }
        }

        static void MergeSort(Worker[] workers, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            Worker[] leftArray = new Worker[n1];
            Worker[] rightArray = new Worker[n2];

            Array.Copy(workers, left, leftArray, 0, n1);
            Array.Copy(workers, middle + 1, rightArray, 0, n2);

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                if (leftArray[i].Salary <= rightArray[j].Salary)
                {
                    workers[k] = leftArray[i];
                    i++;
                }
                else
                {
                    workers[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                workers[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                workers[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
