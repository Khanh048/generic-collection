using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bai8
{
    static void Main()
    {
        Console.WriteLine("Ho va ten: Vo Quoc Khanh");
        Console.WriteLine("MSV: 2415053122121");
        Console.WriteLine("Lop: 225LTC#01");
        Console.WriteLine();

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Danh sach ban dau: " + string.Join(", ", numbers));
        numbers.Reverse();
        Console.WriteLine("Danh sach sau khi dao nguoc: " + string.Join(", ", numbers));
    }
}