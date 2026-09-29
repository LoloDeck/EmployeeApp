using EmployeeNamespace;
namespace EmployeeApp

{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }
        public void ComputeBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTxtbox.Text;
            string lastName = lastNametxtbox.Text;
            string department = departmentTxtbox.Text;
            string jobTitle = jobTitleTxtbox.Text;
            int ratePerHour = int.Parse(ratePerHourTxtbox.Text);
            double totalHoursWorked = double.Parse(totalHoursWorkedTxtbox.Text);
            PartTimeEmployee employee = new(department);
            double salary = ratePerHour * totalHoursWorked;
            firstNamelbl.Text = firstName;
            lastNameLbl.Text = lastName;
            label1.Text = salary.ToString("C");

        }
    }
}
