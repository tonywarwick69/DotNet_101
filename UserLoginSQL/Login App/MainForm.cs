using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_App
{
    public partial class frmMain : Form
    {
        public frmMain(String userName)
        {
            InitializeComponent();
            displayUserName(userName);
        }
        void displayUserName(String userName)
        {
            if (userName != null)
            {
                lblHello.Text = "Hello "+ userName;
            }

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblHello_Click(object sender, EventArgs e)
        {

        }
    }
}
