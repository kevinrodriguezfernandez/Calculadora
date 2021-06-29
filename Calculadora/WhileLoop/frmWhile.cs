using Calculadora.ForeachLoop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.WhileLoop
{
    public partial class frmWhile : Form
    {
        public frmWhile()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            var students = new Dictionary<int, Student>();

            students.Add(student.StudentId, student);

            int i = 0;
            while (i < students.Count)
            {
                KeyValuePair<int, Student> entry = students.ElementAt(i);

                if (entry.Value.Name.Equals("pepe"))
                {
                    // en vez de un Console.Write.Line hacemos un message box
                    MessageBox.Show("Pepe is found " + ": " + entry.Value.Name +
                        " is welcome");
                }


                i++;
            }

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
