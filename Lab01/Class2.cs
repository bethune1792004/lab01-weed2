using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab01
{
    class People
    {
        private string Ten;
        private string Khoa;

        public People()
        {
            Ten = "Unknown";
            Khoa = "Unknown";
        }

        public People(string ten, string khoa)
        {
            Ten = ten;
            Khoa = khoa;
        }

        public string GetTen()
        {
            return Ten;
        }

        public void SetTen(string ten)
        {
            Ten = ten;
        }

        public string GetKhoa()
        {
            return Khoa;
        }

        public void SetKhoa(string khoa)
        {
            Khoa = khoa;
        }

        public void ShowPeopleInfo()
        {
            Console.WriteLine("Ten: {0}", Ten);
            Console.WriteLine("Khoa: {0}", Khoa);
        }
    }

    class Student : People
    {
        private int SID;
        private float DiemTB;

        public Student() : base()
        {
            SID = 0;
            DiemTB = 0;
        }

        public Student(int id, string ten, string khoa, float dtb) : base(ten, khoa)
        {
            SID = id;
            DiemTB = dtb;
        }

        public int GetStudentID()
        {
            return SID;
        }

        public void SetStudentID(int id)
        {
            SID = id;
        }

        public float GetMark()
        {
            return DiemTB;
        }

        public void SetMark(float dtb)
        {
            DiemTB = dtb;
        }

        public void Show()
        {
            ShowPeopleInfo(); // Gọi phương thức của lớp cơ sở
            Console.WriteLine("MSSV: {0}", this.SID);
            Console.WriteLine("Diem TB: {0}", this.DiemTB);
        }
    }

    class Tester
    {
        static Student Nhap1SV()
        {
            Student sv = new Student();

            Console.Write("Nhap MaSV: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid input for Student ID.");
                return null;
            }
            sv.SetStudentID(id);

            Console.Write("Ho ten SV: ");
            sv.SetTen(Console.ReadLine()); // Gọi setter của lớp People

            Console.Write("Nhap khoa: ");
            sv.SetKhoa(Console.ReadLine()); // Gọi setter của lớp People


            Console.Write("Nhap Diem TB: ");
            if (!float.TryParse(Console.ReadLine(), out float mark))
            {
                Console.WriteLine("Invalid input for Mark.");
                return null;
            }
            sv.SetMark(mark);
            return sv;
        }

        static List<Student> NhapDSList(int n)
        {
            List<Student> DSSV = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhap thong tin sinh vien thu {i + 1}:");
                Student sv = Nhap1SV();
                if (sv != null)
                {
                    DSSV.Add(sv);
                }
                else
                {
                    Console.WriteLine("Lỗi nhập liệu sinh viên. Vui lòng thử lại.");
                    return null; // Trả về null nếu có lỗi
                }
            }
            return DSSV;
        }

        static ArrayList NhapDSArrayList(int n)
        {
            ArrayList DSSV = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhap thong tin sinh vien thu {i + 1}:");
                Student sv = Nhap1SV();
                if (sv != null)
                {
                    DSSV.Add(sv);
                }
                else
                {
                    Console.WriteLine("Lỗi nhập liệu sinh viên. Vui lòng thử lại.");
                    return null; // Trả về null nếu có lỗi
                }
            }
            return DSSV;
        }

        static void XuatDS(List<Student> DSSV)
        {
            foreach (Student sv in DSSV)
            {
                sv.Show();
                Console.WriteLine();
            }
        }

        static void XuatDSArrayList(ArrayList DSSV)
        {
            foreach (Student sv in DSSV)
            {
                ((Student)sv).Show(); // Ép kiểu về Student để gọi Show()
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

            // Sử dụng List<Student>
            Console.WriteLine("\nNhap danh sách sinh viên (List):");
            List<Student> DSSVList = NhapDSList(n);

            if (DSSVList != null)
            {
                Console.WriteLine("\n ====XUAT DS SINH VIEN (List)====");
                XuatDS(DSSVList);
            }

            // Sử dụng ArrayList
            Console.WriteLine("\nNhap danh sách sinh viên (ArrayList):");
            ArrayList DSSVArrayList = NhapDSArrayList(n);

            if (DSSVArrayList != null)
            {
                Console.WriteLine("\n ====XUAT DS SINH VIEN (ArrayList)====");
                XuatDSArrayList(DSSVArrayList);
            }


            Console.ReadKey();
        }
    }
}