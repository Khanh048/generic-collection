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

class Bai12
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
        Console.Write("Nhap ten can tim: ");
        string name = Console.ReadLine();
        bool found = false;
        foreach (var s in students)
        {
            if (s.Name.ToLower().Contains(name.ToLower()))
            {
                Console.WriteLine($"Tim thay - ID: {s.Id} - Ten: {s.Name}");
                found = true;
            }
        }
        if (!found) Console.WriteLine("Khong tim thay sinh vien.");
    }
}