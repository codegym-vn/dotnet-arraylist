﻿using System;
using System.Collections;

namespace ArrayListDemo
{
    public class StudentManagement
    {
        public static void Main()
        {
            ArrayList studentList = new ArrayList();

            //Thêm danh sách sinh viên
            studentList.Add(new Student { Name = "Peter", Age = 20 });
            studentList.Add(new Student { Name = "John", Age = 21 });
            studentList.Add(new Student { Name = "Mark", Age = 19 });

            Console.WriteLine("Add students to ArrayList");
            foreach (Student student in studentList)
                Console.WriteLine(student.Name + " " + student.Age);

            Console.WriteLine();


            //Sửa tên, tuổi sinh viên 
            studentList[0] = new Student { Name = "Michael", Age = 21 };

            Console.WriteLine("Edit student at a specific index");
            foreach (Student student in studentList)
                Console.WriteLine(student.Name + " " + student.Age);

            Console.WriteLine();


            //Xoá một sinh viên
            studentList.RemoveAt(1);

            Console.WriteLine("Remove student at a specific index");
            foreach (Student student in studentList)
                Console.WriteLine(student.Name + " " + student.Age);
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
