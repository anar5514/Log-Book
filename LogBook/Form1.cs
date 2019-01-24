using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBook
{
    public partial class LogBook : Form
    {
        public LogBook()
        {
            InitializeComponent();
        }

        private void LogBook_Load(object sender, EventArgs e)
        {
            Student[] students = new Student[8]
            {
                new Student{Fullname = "Abdullabayli Saleh", LastSeen = "21.01.2019", Absent = true, Top = 125},
                new Student{Fullname = "Ahmadov Anar", LastSeen = "20.01.2019", Absent = true,Top = 190},
                new Student{Fullname = "Jamalzade Elvin", LastSeen = "20.01.2019", Absent = true,Top = 255},
                new Student{Fullname = "Mustafayev Nurullah", LastSeen = "20.01.2019", Absent = true,Top = 320},
                new Student{Fullname = "Mustafayev Tural", LastSeen = "20.01.2019", Absent = true,Top = 385},
                new Student{Fullname = "Naghiyev Elshan", LastSeen = "20.01.2019", Absent = true,Top = 450},
                new Student{Fullname = "Omarov Islam", LastSeen = "20.01.2019", Absent = true,Top = 515},
                new Student{Fullname = "Osmanov Samir", LastSeen = "20.01.2019", Absent = true,Top = 580}
            };

            //foreach (var student in students)
            //{
            //    student.ControlWorkMark = false;
            //    student.PracticeWorkMark = false;
            //    student.NumberStudent = students.
            //}

            for (int i = 0; i < students.Count(); i++)
            {
                students[i].ControlWorkMark = false;
                students[i].PracticeWorkMark = false;
                students[i].NumberStudent = i + 1;
            }

            label1.BackColor = Color.FromArgb(227, 245, 255);
            label1.ForeColor = Color.FromArgb(154, 199, 227);
            label2.BackColor = Color.FromArgb(227, 245, 255);
            label2.ForeColor = Color.FromArgb(154, 199, 227);
            label3.BackColor = Color.FromArgb(227, 245, 255);
            label3.ForeColor = Color.FromArgb(154, 199, 227);
            label4.BackColor = Color.FromArgb(227, 245, 255);
            label4.ForeColor = Color.FromArgb(154, 199, 227);
            label5.BackColor = Color.FromArgb(227, 245, 255);
            label5.ForeColor = Color.FromArgb(154, 199, 227);
            label7.BackColor = Color.FromArgb(227, 245, 255);
            label7.ForeColor = Color.FromArgb(154, 199, 227);
            label8.BackColor = Color.FromArgb(227, 245, 255);
            label8.ForeColor = Color.FromArgb(154, 199, 227);
            label6.BackColor = Color.FromArgb(227, 245, 255);
            label6.ForeColor = Color.FromArgb(154, 199, 227);
            signAll.BackColor = Color.FromArgb(227, 245, 255);

            this.Controls.AddRange(students);

        }

        private void signAll_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (var student in this.Controls.Find("Student", true) as Student[])
            //{
            //    student = new Student();
            //    student.Participates = true;
            //}

        }
    }
}
