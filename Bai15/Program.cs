using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bai15
{
    static void Main()
    {
        Console.WriteLine("Ho va ten: Vo Quoc Khanh");
        Console.WriteLine("MSV: 2415053122121");
        Console.WriteLine("Lop: 225LTC#01");
        Console.WriteLine();

        Dictionary<string, string> dict = new Dictionary<string, string> {
            { "hello", "xin chao" },
            { "goodbye", "tam biet" },
            { "thank you", "cam on" },
            { "book", "sach" },
            { "cat", "meo" }
        };
        Console.Write("Nhap tu tieng Anh can tra: ");
        string word = Console.ReadLine().ToLower();
        if (dict.ContainsKey(word))
            Console.WriteLine($"Nghia: {dict[word]}");
        else
            Console.WriteLine("Khong tim thay tu nay trong tu dien.");
        Console.ReadKey();
    }
}