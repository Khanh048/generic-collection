using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bai5
{
    static void Main()
    {
        Console.WriteLine("Ho va ten: Vo Quoc Khanh");
        Console.WriteLine("MSV: 2415053122121");
        Console.WriteLine("Lop: 225LTC#01");
        Console.WriteLine();

        List<string> students = new List<string> { "An", "Binh", "Chau", "Dung", "Em" };
        Console.WriteLine("Danh sach hien tai: " + string.Join(", ", students));
        Console.Write("Nhap ten can xoa: ");
        string name = Console.ReadLine();
        if (students.Remove(name))
            Console.WriteLine($"Da xoa '{name}' khoi danh sach.");
        else
            Console.WriteLine("Khong tim thay ten nay.");
        Console.WriteLine("Danh sach sau khi xoa: " + string.Join(", ", students));
    }
}