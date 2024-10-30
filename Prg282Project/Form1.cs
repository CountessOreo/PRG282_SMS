using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prg282Project
{
    public partial class StudentEntryForm : Form
    {
        public BindingSource bs = new BindingSource();

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
            FileHandler fileHandler = new FileHandler();
            fileHandler.CreateStudentTextFile();
            List<Student> students = fileHandler.ReadStudentTextFile();
            bs.DataSource = students;
            dgvDisplay.DataSource = bs;
        }

    }
}