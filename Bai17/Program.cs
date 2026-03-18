using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bai17
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
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int n in numbers)
        {
            if (freq.ContainsKey(n)) freq[n]++;
            else freq[n] = 1;
        }
        int maxVal = 0, maxCount = 0;
        foreach (var pair in freq)
        {
            if (pair.Value > maxCount)
            {
                maxCount = pair.Value;
                maxVal = pair.Key;
            }
        }
        Console.WriteLine($"So xuat hien nhieu nhat: {maxVal} ({maxCount} lan)");
    }
}