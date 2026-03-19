using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public int Id;
    public string Name;
}

class Bai11
{
    static void Main()
    {
        Console.WriteLine("Ho va ten: Vo Quoc Khanh");
        Console.WriteLine("MSV: 2415053122121");
        Console.WriteLine("Lop: 225LTC#01");
        Console.WriteLine();

        List<Student> students = new List<Student> {
            new Student { Id = 1, Name = "Nguyen Van An" },
            new Student { Id = 2, Name = "Tran Thi Binh" },
            new Student { Id = 3, Name = "Le Van Chau" }
        };
        Console.WriteLine("Danh sach sinh vien:");
        foreach (var s in students)
            Console.WriteLine($"ID: {s.Id} - Ten: {s.Name}");
        Console.ReadKey();
    }
}