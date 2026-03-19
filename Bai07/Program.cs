using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bai7
{
    static void Main()
    {
        Console.WriteLine("Ho va ten: Vo Quoc Khanh");
        Console.WriteLine("MSV: 2415053122121");
        Console.WriteLine("Lop: 225LTC#01");
        Console.WriteLine();

        List<int> numbers = new List<int>();
        Console.Write("Nhap so luong phan tu: ");
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Nhap phan tu {i + 1}: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        numbers.Sort();
        Console.WriteLine("Danh sach sau khi sap xep tang dan:");
        foreach (int n in numbers)
            Console.Write(n + " ");
        Console.WriteLine();
        Console.ReadKey();
    }
}