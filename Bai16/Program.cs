using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bai16
{
    static void Main()
    {
        Console.WriteLine("Ho va ten: Vo Quoc Khanh");
        Console.WriteLine("MSV: 2415053122121");
        Console.WriteLine("Lop: 225LTC#01");
        Console.WriteLine();

        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (c == ' ') continue;
            if (charCount.ContainsKey(c)) charCount[c]++;
            else charCount[c] = 1;
        }
        Console.WriteLine("Ket qua:");
        foreach (var pair in charCount)
            Console.WriteLine($"{pair.Key} : {pair.Value}");
    }
}