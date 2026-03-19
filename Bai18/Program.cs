using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string Name;
    public double Score;
}

class Bai18
{
    static void Main()
    {
        Console.WriteLine("Ho va ten: Vo Quoc Khanh");
        Console.WriteLine("MSV: 2415053122121");
        Console.WriteLine("Lop: 225LTC#01");
        Console.WriteLine();

        List<Student> students = new List<Student> {
            new Student { Name = "Nguyen Van An", Score = 8.5 },
            new Student { Name = "Tran Thi Binh", Score = 9.2 },
            new Student { Name = "Le Van Chau", Score = 7.8 }
        };
        Console.WriteLine("Danh sach sinh vien:");
        foreach (var s in students)
            Console.WriteLine($"Ten: {s.Name} - Diem: {s.Score}");

        Student best = students[0];
        foreach (var s in students)
            if (s.Score > best.Score) best = s;
        Console.WriteLine($"\nSinh vien diem cao nhat: {best.Name} - Diem: {best.Score}");
        Console.ReadKey();
    }
}