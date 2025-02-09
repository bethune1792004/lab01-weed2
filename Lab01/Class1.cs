using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab01
{
    internal class Student
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

 