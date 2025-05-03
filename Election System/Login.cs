using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Election_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = voters_id_login.Text;

            foreach (char c in id)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Please enter a valid ID");
                    voters_id_login.Text = "";
                    return;
                }
            }
            if (id.Length == 8)
            {
                this.Dispose();
                DashboardVoter dashboardVoter = new DashboardVoter();
                dashboardVoter.Show();
            }
            else if (id.Length == 0)
            {
                MessageBox.Show("Please enter your ID");
                voters_id_login.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter your ID");
                voters_id_login.Text = "";
            }

        }
        private void voters_id_login_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
