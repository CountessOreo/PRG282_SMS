using System.Windows.Forms;

namespace Prg282Project
{
    partial class StudentEntryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Label Newtudent;
            Label label1;
            Label UpdateStudents;
            Label DeleteStudent;
            Label SummaryReport;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentEntryForm));
            dgvDisplay = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            AddStudentButton = new Button();
            ViewStudentsButton = new Button();
            UpdateStudentsButton = new Button();
            DeleteStudentDetailsButton = new Button();
            GenerateSummaryButton = new Button();
            NameLabel = new Label();
            SurnameLabel = new Label();
            AgeLabel = new Label();
            IDLabel = new Label();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            ExitButton = new Button();
            pictureBox2 = new PictureBox();
            Newtudent = new Label();
            label1 = new Label();
            UpdateStudents = new Label();
            DeleteStudent = new Label();
            SummaryReport = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Newtudent
            // 
            Newtudent.AutoEllipsis = true;
            Newtudent.AutoSize = true;
            Newtudent.Location = new Point(64, 149);
            Newtudent.Name = "Newtudent";
            Newtudent.Size = new Size(0, 15);
            Newtudent.TabIndex = 2;
            Newtudent.Tag = "";
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Location = new Point(212, 149);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            label1.Tag = "";
            // 
            // UpdateStudents
            // 
            UpdateStudents.AutoEllipsis = true;
            UpdateStudents.AutoSize = true;
            UpdateStudents.Location = new Point(328, 149);
            UpdateStudents.Name = "UpdateStudents";
            UpdateStudents.Size = new Size(0, 15);
            UpdateStudents.TabIndex = 6;
            UpdateStudents.Tag = "";
            // 
            // DeleteStudent
            // 
            DeleteStudent.AutoEllipsis = true;
            DeleteStudent.AutoSize = true;
            DeleteStudent.Location = new Point(431, 149);
            DeleteStudent.Name = "DeleteStudent";
            DeleteStudent.Size = new Size(0, 15);
            DeleteStudent.TabIndex = 8;
            DeleteStudent.Tag = "";
            // 
            // SummaryReport
            // 
            SummaryReport.AutoEllipsis = true;
            SummaryReport.AutoSize = true;
            SummaryReport.Location = new Point(506, 68);
            SummaryReport.Name = "SummaryReport";
            SummaryReport.Size = new Size(102, 15);
            SummaryReport.TabIndex = 10;
            SummaryReport.Tag = "";
            SummaryReport.Text = "Student Summary";
            // 
            // dgvDisplay
            // 
            dgvDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDisplay.BackgroundColor = SystemColors.ButtonShadow;
            dgvDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisplay.Location = new Point(12, 98);
            dgvDisplay.Name = "dgvDisplay";
            dgvDisplay.RowTemplate.Height = 25;
            dgvDisplay.Size = new Size(993, 274);
            dgvDisplay.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AddStudentButton
            // 
            AddStudentButton.ForeColor = SystemColors.ActiveCaptionText;
            AddStudentButton.Location = new Point(24, 98);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(100, 23);
            AddStudentButton.TabIndex = 1;
            AddStudentButton.Text = "Add";
            AddStudentButton.UseVisualStyleBackColor = true;
            // 
            // ViewStudentsButton
            // 
            ViewStudentsButton.ForeColor = SystemColors.ActiveCaptionText;
            ViewStudentsButton.Location = new Point(130, 98);
            ViewStudentsButton.Name = "ViewStudentsButton";
            ViewStudentsButton.Size = new Size(101, 23);
            ViewStudentsButton.TabIndex = 3;
            ViewStudentsButton.Text = "View";
            ViewStudentsButton.UseVisualStyleBackColor = true;
            // 
            // UpdateStudentsButton
            // 
            UpdateStudentsButton.ForeColor = SystemColors.ActiveCaptionText;
            UpdateStudentsButton.Location = new Point(237, 98);
            UpdateStudentsButton.Name = "UpdateStudentsButton";
            UpdateStudentsButton.Size = new Size(100, 23);
            UpdateStudentsButton.TabIndex = 5;
            UpdateStudentsButton.Text = "Update";
            UpdateStudentsButton.UseVisualStyleBackColor = true;
            // 
            // DeleteStudentDetailsButton
            // 
            DeleteStudentDetailsButton.ForeColor = Color.Black;
            DeleteStudentDetailsButton.Location = new Point(343, 98);
            DeleteStudentDetailsButton.Name = "DeleteStudentDetailsButton";
            DeleteStudentDetailsButton.Size = new Size(100, 23);
            DeleteStudentDetailsButton.TabIndex = 7;
            DeleteStudentDetailsButton.Text = "Delete";
            DeleteStudentDetailsButton.UseVisualStyleBackColor = true;
            // 
            // GenerateSummaryButton
            // 
            GenerateSummaryButton.ForeColor = SystemColors.ActiveCaptionText;
            GenerateSummaryButton.Location = new Point(506, 86);
            GenerateSummaryButton.Name = "GenerateSummaryButton";
            GenerateSummaryButton.Size = new Size(102, 23);
            GenerateSummaryButton.TabIndex = 9;
            GenerateSummaryButton.Text = "Generate";
            GenerateSummaryButton.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.ForeColor = SystemColors.ButtonFace;
            NameLabel.Location = new Point(24, 42);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 16;
            NameLabel.Text = "Name";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(130, 42);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(54, 15);
            SurnameLabel.TabIndex = 17;
            SurnameLabel.Text = "Surname";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(237, 42);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(28, 15);
            AgeLabel.TabIndex = 18;
            AgeLabel.Text = "Age";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(343, 42);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(18, 15);
            IDLabel.TabIndex = 19;
            IDLabel.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(IDLabel);
            groupBox1.Controls.Add(AgeLabel);
            groupBox1.Controls.Add(SurnameLabel);
            groupBox1.Controls.Add(NameLabel);
            groupBox1.Controls.Add(SummaryReport);
            groupBox1.Controls.Add(GenerateSummaryButton);
            groupBox1.Controls.Add(DeleteStudent);
            groupBox1.Controls.Add(DeleteStudentDetailsButton);
            groupBox1.Controls.Add(UpdateStudents);
            groupBox1.Controls.Add(UpdateStudentsButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ViewStudentsButton);
            groupBox1.Controls.Add(Newtudent);
            groupBox1.Controls.Add(AddStudentButton);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 378);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1020, 149);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Data";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(343, 60);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 23;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(237, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 20;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(678, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(336, 188);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-438, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Transparent;
            ExitButton.BackgroundImage = (Image)resources.GetObject("ExitButton.BackgroundImage");
            ExitButton.BackgroundImageLayout = ImageLayout.Stretch;
            ExitButton.Location = new Point(978, 32);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(27, 25);
            ExitButton.TabIndex = 29;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-24, -25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // StudentEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1044, 539);
            Controls.Add(ExitButton);
            Controls.Add(pictureBox1);
            Controls.Add(dgvDisplay);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Name = "StudentEntryForm";
            Text = "Student Entry Form";
            Load += StudentEntryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDisplay;
        private ContextMenuStrip contextMenuStrip1;
        private Button AddStudentButton;
        private Button ViewStudentsButton;
        private Button UpdateStudentsButton;
        private Button DeleteStudentDetailsButton;
        private Button GenerateSummaryButton;
        private Label NameLabel;
        private Label SurnameLabel;
        private Label AgeLabel;
        private Label IDLabel;
        protected GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button ExitButton;
        private PictureBox pictureBox2;
    }
}