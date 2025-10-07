using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random random = new Random();

            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] array = new int[n];
            for (int i = 0; i < n; i++) array[i] = random.Next(0, 1000);

            Console.Write("Mảng đã tạo: ");
            foreach (int num in array) Console.Write(num + " ");
            Console.WriteLine("\n");

            Console.Write("Các số hoàn hảo trong mảng: ");
            foreach (int num in array) if (isPerfectNumber(num)) Console.Write(num + " ");
            Console.WriteLine("\n");

            Console.Write("Các số nguyên tố trong mảng: ");
            foreach (int num in array) if (isPrime(num)) Console.Write(num + " ");
            Console.WriteLine("\n");

            Array.Sort(array);
            Console.Write("Mảng sau khi sắp xếp: ");
            foreach (int num in array) Console.Write(num + " ");
        }

        static bool isPerfectNumber(int num)
        {
            if (num < 2) return false;
            int sum = 1;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    if (i != num / i) sum += num / i;
                }
            }
            return sum == num;
        }

        static bool isPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0) return false;
            return true;
        }
    }
}
