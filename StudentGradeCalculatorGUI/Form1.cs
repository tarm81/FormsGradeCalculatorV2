namespace StudentGradeCalculatorGUI
{
    public partial class frmGradeCalculator : Form
    {
        public frmGradeCalculator()
        {
            InitializeComponent();
        }

        // My additional methods
        private bool ValidateInput(out double grade1, out double grade2, out double grade3)
        {
            grade1 = 0;
            grade2 = 0;
            grade3 = 0;

            if (txtStudent.Text == "")
            {
                MessageBox.Show("Enter the student's name!");
                txtStudent.Focus();
                return false;
            }

            // Using TryParse now for input validation as Professor Gordon suggested
            if (!double.TryParse(txtGrade1.Text, out grade1) || grade1 < 1 || grade1 > 100)
            {
                MessageBox.Show("Enter a valid grade! (Grade 1)");
                txtGrade1.Focus();
                return false;
            }

            if (!double.TryParse(txtGrade2.Text, out grade2) || grade2 < 1 || grade2 > 100)
            {
                MessageBox.Show("Enter a valid grade! (Grade 2)");
                txtGrade2.Focus();
                return false;
            }

            if (!double.TryParse(txtGrade3.Text, out grade3) || grade3 < 1 || grade3 > 100)
            {
                MessageBox.Show("Enter a valid grade! (Grade 3)");
                txtGrade3.Focus();
                return false;
            }

            return true;
        }

        private void DisplayResults(double average, char letterGrade)
        {
            lblAverageNum.Text = average.ToString("F2");
            lblLetterChar.Text = letterGrade.ToString();
        }

        private void frmGradeCalculator_Load(object sender, EventArgs e)
        {
            txtStudent.Focus(); // Captures focus on student name textbox
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double grade1;
            double grade2;
            double grade3;

            if (!ValidateInput(out grade1, out grade2, out grade3))
            {
                return;
            }

            Student student;

            if (chkHonors.Checked)
            {
                student = new HonorsStudent(txtStudent.Text, grade1, grade2, grade3);
            }
            else
            {
                student = new RegularStudent(txtStudent.Text, grade1, grade2, grade3);
            }

            double average = student.CalculateAverage();
            char letterGrade = student.DetermineLetterGrade();

            DisplayResults(average, letterGrade);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudent.Clear();
            txtGrade1.Clear();
            txtGrade2.Clear();
            txtGrade3.Clear();

            chkHonors.Checked = false;

            lblAverageNum.Text = "";
            lblLetterChar.Text = "";

            txtStudent.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
