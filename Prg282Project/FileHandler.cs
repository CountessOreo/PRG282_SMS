using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.DirectoryServices;

namespace Prg282Project
{
    internal class FileHandler
    {
        public string filename = @"students.txt";
        public string summaryFilename = @"summary.txt";
        public int totalStudents = 0;
        public int averageStudentsAge = 0;
        public static List<Student> studentTextList = new List<Student>();

        /// <summary>
        /// Checks if the student text file exists and creates it if not.
        /// </summary>
        public List<Student> CreateStudentTextFile()
        {
            if (!File.Exists(filename))
            {
                List<Student> initialStudents = new List<Student>
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
                WriteStudentsToFile(initialStudents);
            }
            studentTextList = ReadStudentTextFile();
            return studentTextList;
        }

        /// <summary>
        /// Writes a list of students to the student text file.
        /// </summary>
        public void WriteStudentsToFile(List<Student> students)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Student student in students)
                {
                    writer.WriteLine($"{student.StudentID},{student.StudentName},{student.StudentAge},{student.Course}");
                }
            }
        }

        /// <summary>
        /// Reads all data in the student text file and updates the in-memory list of students.
        /// </summary>
        public List<Student> ReadStudentTextFile()
        {
            studentTextList.Clear();
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            using (StreamReader reader = new StreamReader(fs))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[]  fields = line.Split(',');
                    Student st = new Student(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), fields[3]);
                    studentTextList.Add(st);
                }
            }
            return studentTextList;
        }

        /// <summary>
        /// Generates summary.txt
        /// </summary>
        public void GenerateSummary()
        {
            //Create File
            if (!File.Exists(summaryFilename))
            {
                File.Create(summaryFilename);
            }
            else
            {
                using(StreamWriter writer = new StreamWriter(summaryFilename))
                {
                    writer.Write($"Amount of students: {totalStudents}, Average Age: {averageStudentsAge}, Date: {DateTime.Now:yyyy-MM-dd}");
                }
            }
        }
    }
}
