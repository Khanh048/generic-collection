using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bai1
{
    static void Main()
    {
        Console.WriteLine("Ho va ten: Vo Quoc Khanh");
        Console.WriteLine("MSV: 2415053122121");
        Console.WriteLine("Lop: 225LTC#01");
        Console.WriteLine();

        List<int> numbers = new List<int> { 10, 25, 37, 42, 58 };
        Console.WriteLine("Cac phan tu trong danh sach:");
        foreach (int n in numbers)
            Console.WriteLine(n);
    }
}