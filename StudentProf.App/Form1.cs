using StudentBusinesslogic.Controller;
using StudentModel;

namespace StudentProf.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            UserModel user = controller.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (user != null)
            {
                if (user.Role == "Admin")
                {
                    frmAdmin adminForm = new frmAdmin();
                    adminForm.Show();
                }
                else if (user.Role == "Student")
                {
                    frmStudent studentForm = new frmStudent();
                    studentForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
