using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg282Project
{
    internal class DataHandler
    {
        public string filename = @"students.txt";
        public int totalStudents = 0;
        public int averageStudentsAge = 0;

        /// <summary>
        /// Generates amount of students in students.txt
        /// </summary>
        public void AmountOfStudents()
        {
            // Read students file
            if (File.Exists(filename))
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string txt;
                    while ((txt = reader.ReadLine()) != null)
                    {
                        totalStudents++;
                    }
                }
            }
        }

        /// <summary>
        /// Generates Average Age of students in students.txt
        /// </summary>
        public void AverageStudentAge()
        {
            string CurrentLine;
            using (StreamReader reader = new StreamReader(filename))
            {
                reader.ReadLine();
                while ((CurrentLine = reader.ReadLine()) != null)
                {

                    string[] Students = CurrentLine.Split(',');
                    int age = int.Parse(Students[2]);
                    averageStudentsAge += age;

                }
                averageStudentsAge = averageStudentsAge / totalStudents;
            }
        }
    }
    
}
