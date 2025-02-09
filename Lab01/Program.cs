using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab01
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        public Student() // Default constructor
        {
            SID = 1;
            TenSV = "Nguyen Van Nam";
            Khoa = "CNTT";
            DiemTB = 7;
        }

        public Student(Student stu) // Copy constructor
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }

        public Student(int id, string ten, string kh, float dtb) // Parameterized constructor
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }

        // Getter methods
        public int GetStudentID()
        {
            return SID;
        }

        public string GetName()
        {
            return TenSV;
        }

        public string GetFaculty()
        {
            return Khoa;
        }

        public float GetMark()
        {
            return DiemTB;
        }

        // Setter methods
        public void SetStudentID(int id)
        {
            SID = id;
        }

        public void SetName(string ten)
        {
            TenSV = ten;
        }

        public void SetFaculty(string kh)
        {
            Khoa = kh;
        }

        public void SetMark(float dtb)
        {
            DiemTB = dtb;
        }

        public void Show()
        {
            Console.WriteLine("MSSV: {0}", this.SID);
            Console.WriteLine("Ten SV: {0}", this.TenSV);
            Console.WriteLine("Khoa: {0}", this.Khoa);
            Console.WriteLine("Diem TB: {0}", this.DiemTB);
        }
    }

    class Tester
    {
        // Function to input a single student
        static Student Nhap1SV()
        {
            Student sv = new Student();
            Console.Write("Nhap MaSV: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid input for Student ID.");
                return null; // Or throw an exception
            }
            sv.SetStudentID(id);

            Console.Write("Ho ten SV: ");
            sv.SetName(Console.ReadLine());

            Console.Write("Nhap khoa: ");
            sv.SetFaculty(Console.ReadLine());

            Console.Write("Nhap Diem TB: ");
            if (!float.TryParse(Console.ReadLine(), out float mark))
            {
                Console.WriteLine("Invalid input for Mark.");
                return null;
            }
            sv.SetMark(mark);
            return sv;

        }

        // Function to input a list of students
        static Student[] NhapDS(int n)
        {
            Student[] DSSV = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhap thong tin sinh vien thu {i + 1}:");
                DSSV[i] = Nhap1SV();
                if (DSSV[i] == null)
                {
                    return null; //If any single student input fails, return null
                }
            }
            return DSSV;
        }

        // Function to output a list of students
        static void XuatDS(Student[] DSSV)
        {
            foreach (Student sv in DSSV)
            {
                sv.Show();
                Console.WriteLine();
            }
        }

        public static void Main()
        {
            int n;

            Console.Write("Nhap so luong SV: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Invalid input for number of students.");
                return;
            }

            Student[] DSSV = NhapDS(n);

            if (DSSV == null)
            {
                Console.WriteLine("Student input failed. Cannot display.");
                return;
            }

            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            XuatDS(DSSV);

            Console.ReadKey();
        }
    }
}