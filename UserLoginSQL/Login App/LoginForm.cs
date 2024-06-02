using System.Data;
using System.Data.SqlClient;
namespace Login_App
{
    public partial class frmLogin : Form
    {
        String connectionConfig = @"Data Source=localhost;Initial Catalog=UserRegistration;Integrated Security=True;";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Username and Password are required! Please input Username and Password to Login.");
            else
            {
                using (SqlConnection sQLConnection = new SqlConnection(connectionConfig))
                {
                    sQLConnection.Open();
                    SqlCommand command = new SqlCommand("SELECT COUNT(1) FROM [dbo].[User] WHERE Username = @Username AND Password = @Password", sQLConnection);
                    command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    command.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 1)
                    {
                        // User authenticated successfully
                        MessageBox.Show("Login successful!");
                        // You can add code here to redirect to the main page or another form
                        // Navigate to the main form
                        String userName = txtUsername.Text.Trim();
                        frmMain mainForm = new frmMain(userName);
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // User authentication failed
                        MessageBox.Show("Invalid Username or Password. Please try again.");
                    }
                }
            }
        }
        void clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
