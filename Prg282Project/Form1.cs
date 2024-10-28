namespace Prg282Project
{
    public partial class StudentEntryForm : Form
    {
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


    }
}