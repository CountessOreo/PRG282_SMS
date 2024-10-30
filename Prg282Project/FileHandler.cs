﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Prg282Project
{
    internal class FileHandler
    {
        public FileHandler() { }

        public string filename = @"students.txt";
        public static List<Student> files = new List<Student>();

        /// <summary>
        /// Initial creation of the students text file.
        /// </summary>
        public void CreateStudentTextFile()
        {
            if (!File.Exists(filename))
            {
                List<Student> students = new List<Student>
                {
                    new Student(578003, "Hayley Treutens", 21, "BComp"),
                    new Student(577999, "Kyle Smith", 24, "BComp"),
                    new Student(600948, "Paul-Dieter Brandt", 25, "BComp"),
                    new Student(697834, "Markiplier", 35, "BIT"),
                    new Student(697834, "PewDiePie", 35, "BIT"),
                    new Student(825395, "Johnny Depp", 61, "BComp"),
                    new Student(364729, "Barack Obama", 63, "BIT"),
                    new Student(278403, "Brad Pit", 60, "BIT"),
                    new Student(579204, "Queen Elizabeth", 96, "BIT"),
                    new Student(529462, "Keanu Reeves", 60, "BIT"),
                };

                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Student student in students)
                    {
                        writer.WriteLine($"{student.StudentID},{student.StudentName},{student.StudentAge},{student.Course}");
                    }
                }
            }
        }

        /// <summary>
        /// Method that reads all data in the student text file.
        /// </summary>
        public List<Student> ReadStudentTextFile()
        {
            files.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[]  fields = line.Split(',');
                    Student st = new Student(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), fields[3]);
                    files.Add(st);
                }
            }
            return files;
        }
    }
}
