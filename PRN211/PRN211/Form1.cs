using Microsoft.VisualBasic.ApplicationServices;
using PRN211.Models;
using PRN211.Repository;

namespace PRN211
{
    public partial class Form1 : Form
    {
        UserRepo user = new UserRepo();
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var check = user.getAll().Where(a => a.UserName == username && a.Password == password).FirstOrDefault();
            if (check != null)
            {
                this.Hide();
                Form form = new Management();
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Login fail! Please try again!", "Notification", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}