using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211
{
    public partial class CreateStudent : Form
    {
        List<Student> students = new List<Student>();
        public CreateStudent()
        {

            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            int id = int.Parse(txtID.Text);
            int age = int.Parse(txtAge.Text);

            var student = new Student();
            student.Id = id;
            student.Name = username;
            student.Age = age;
            student.Created = DateTime.Now;
            students.Add(student);



            this.Hide();
            Form form = new Management();
            form.ShowDialog();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Management();
            form.ShowDialog();
        }

        private void CreateStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
