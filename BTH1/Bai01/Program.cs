using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập một số nguyên dương: ");
            string input = Console.ReadLine();
            foreach(char c in input)
            {
                if (!char.IsDigit(c))
                {
                    Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ.");
                    return;
                }
            }
            int sum = input.Sum(c => c - '0');
            Console.WriteLine($"Tổng các chữ số của {input} là: {sum}");
        }
    }
}
