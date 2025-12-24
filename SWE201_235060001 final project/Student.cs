using System;

namespace LaptopRental
{
    //öğrenci classı bu da
    public class Student
    {
        public int StudentNumber { get; set; }
        public string FullName { get; set; }

        public Student(int number, string name)
        {
            StudentNumber = number;
            FullName = name;
        }
    }
}