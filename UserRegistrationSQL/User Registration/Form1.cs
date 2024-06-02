using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.Windows.Forms;

namespace User_Registration
 
{
    public partial class Form1 : Form
    {
        String connectionConfig = @"Data Source=localhost;Initial Catalog=UserRegistration;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="" || txtPassword.Text == "")
            {
                MessageBox.Show("Please input Username and Password");
            }
            else if(txtPassword.Text == txtPassword2.Text)
            {
                //using SqlClient lib
                
                using (SqlConnection sQLConnection = new SqlConnection(connectionConfig))
                {
                    sQLConnection.Open();
                    SqlCommand command = new SqlCommand("UserAdd", sQLConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", txtFName.Text.Trim());
                    command.Parameters.AddWithValue("@LastName", txtLName.Text.Trim());
                    command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    command.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    command.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    command.ExecuteNonQuery();
                    MessageBox.Show("registration is successful!");
                    clear();
                }
                
                //Using entity framework
                /*
                using (var context = new AppContext())
                {
                    //var hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text.Trim());
                    // Query data
                    var data = context.Users.ToList();
                    var newUser = new User
                    {
                        FirstName = txtFName.Text.Trim(),
                        LastName = txtLName.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Address = txtAddress.Text.Trim(),
                        Username = txtUsername.Text.Trim(),
                        Password = txtPassword.Text.Trim(),
                    };

                    context.Users.Add(newUser);
                    context.SaveChanges();
                    MessageBox.Show("Registration is successful!");
                    clear();
                }
                */
            } else if(txtPassword.Text != txtPassword2.Text)
            {
                MessageBox.Show("Password and Confirm password didn't match. Please input again.");
            } else
            {
                MessageBox.Show("Error: Registration failed.");
            }
        }
        void clear()
        {
            txtFName.Text = txtLName.Text = txtEmail.Text = txtAddress.Text = txtUsername.Text = txtPassword.Text = txtPassword2.Text="";
        }
    }
}
