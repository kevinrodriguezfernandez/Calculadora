using Calculadora.ForeachLoop;
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

namespace Calculadora.ForLoop
{
    public partial class frmForLoop : Form
    {
        public frmForLoop()
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

            //Generic collections
            List<Student> studentList = new List<Student>();

            //Boxing-Polymorphisim
            studentList.Add(student);


           
            for (int i = 0; i < studentList.Count; i++) 
            {
                //Unboxing-Polymorphism
                MessageBox.Show(studentList[i].Name + " " + studentList[i].Surname);
            }
            MessageBox.Show("el numero de estudiantes es: " + Student.STUDENT_COUNTER);
            
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
