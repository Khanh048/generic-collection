using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bai6
{
    static void Main()
    {
        Console.WriteLine("Ho va ten: Vo Quoc Khanh");
        Console.WriteLine("MSV: 2415053122121");
        Console.WriteLine("Lop: 225LTC#01");
        Console.WriteLine();

        List<string> fruits = new List<string> { "Tao", "Chuoi", "Cam", "Xoai", "Dua hau" };
        Console.Write("Nhap ten can kiem tra: ");
        string input = Console.ReadLine();
        if (fruits.Contains(input))
            Console.WriteLine($"'{input}' ton tai trong danh sach.");
        else
            Console.WriteLine($"'{input}' khong ton tai trong danh sach.");
        Console.ReadKey();
    }
}