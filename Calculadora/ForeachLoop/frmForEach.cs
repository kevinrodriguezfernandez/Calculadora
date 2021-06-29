using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.ForeachLoop
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            var studentList = new ArrayList();

            //Boxing-Polymorphisim
            studentList.Add(student);

            foreach (var _student in studentList)
            {
                //Unboxing-Polymorphism
                MessageBox.Show(((Student)_student).Name + " " + ((Student)_student).Surname);
                
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
