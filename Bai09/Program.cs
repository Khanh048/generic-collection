using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bai9
{
    static void Main()
    {
        Console.WriteLine("Ho va ten: Vo Quoc Khanh");
        Console.WriteLine("MSV: 2415053122121");
        Console.WriteLine("Lop: 225LTC#01");
        Console.WriteLine();

        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5, 5, 6 };
        Console.WriteLine("Danh sach ban dau: " + string.Join(", ", numbers));
        List<int> unique = new List<int>();
        foreach (int n in numbers)
            if (!unique.Contains(n)) unique.Add(n);
        Console.WriteLine("Danh sach khong trung: " + string.Join(", ", unique));
    }
}