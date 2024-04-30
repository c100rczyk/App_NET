namespace BoardUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ChangeCompletedButton_Click(object sender, EventArgs e)
        {

        }

        private void CreatePersonFormButton_Click(object sender, EventArgs e)
        {
            CreatePersonForm person = new CreatePersonForm();
            person.ShowDialog();
            LoadPeopleToListBox();
        }

        private void CreateTaskFormButton_Click(object sender, EventArgs e)
        {
            CreateTaskForm task = new CreateTaskForm();
            task.ShowDialog();
            LoadTaskToListBox();
        }

        private void CreateProjectFormButton_Click(object sender, EventArgs e)
        {
            CreateProjectForm project = new CreateProjectForm();
            project.ShowDialog();
            LoadProjectToListBox();
        }
    }
}
