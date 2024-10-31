using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;


namespace Prg282Project
{
    public partial class StudentEntryForm : Form
    {
        public BindingSource bs = new BindingSource();
        List<Student> students = new List<Student>();
        DataHandler dh = new DataHandler();
        FileHandler fh = new FileHandler();

        public StudentEntryForm()
        {
            InitializeComponent();

            this.ControlBox = false; // Removes top exit, minimize and maximize
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void StudentEntryForm_Load(object sender, EventArgs e)
        {
            students = fh.CreateStudentTextFile();
            bs.DataSource = students;
            dgvDisplay.DataSource = bs;
        }

        private void GenerateSummaryButton_Click(object sender, EventArgs e)
        { 
            dh.AmountOfStudents();
            dh.AverageStudentAge();
            fh.GenerateSummary();

            AverageAgeTextBox.Text = dh.averageStudentsAge.ToString();
            StudentsInListTextBox.Text = dh.totalStudents.ToString();
        }

        /// <summary>
        /// Adds new students to the student.txt file from the textboxes on the form.
        /// Validates all input fields and ensures correct data format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if any fields are empty
                if (string.IsNullOrWhiteSpace(txtStudentID.Text) || string.IsNullOrWhiteSpace(txtStudentName.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtCourse.Text))
                {
                    MessageBox.Show("All fields must be filled.");
                    return;
                }
                
                if(txtStudentID.Text.Length !=6) //Validates ID length
                {
                    MessageBox.Show("Student ID must be a 6-digit number.");
                    return;
                }

                int age;
                bool isNumber = int.TryParse(txtAge.Text, out age); // Validates age data type
                if(!isNumber)
                {
                    MessageBox.Show("Please enter a valid numeric age.");
                    return;
                }

                if (int.Parse(txtAge.Text) <= 0) // Validates age is greater than 0
                {
                    MessageBox.Show("Please enter a valid age greater than zero.");
                    return;
                }

                Student student = new Student(int.Parse(txtStudentID.Text), txtStudentName.Text, int.Parse(txtAge.Text), txtCourse.Text);
                students.Add(student);

                // Updates student list displayed
                fh.WriteStudentsToFile(students);
                students = fh.ReadStudentTextFile();

                //Resets Data grid view display
                dgvDisplay.DataSource = ""; 
                bs.DataSource = students;
                dgvDisplay.DataSource = bs;

                // Resets student data textboxes
                txtStudentID.Text = null;
                txtStudentName.Text = "";
                txtAge.Text = null;
                txtCourse.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}