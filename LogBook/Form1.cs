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
        public Student[] Students { get => students; set => students = value; }
        public string TotalCrystal { get => labelTotalCrystal.Text; set => labelTotalCrystal.Text = value; }

        public LogBook()
        {
            InitializeComponent();
        }

        private void LogBook_Load(object sender, EventArgs e)
        {
            Students = new Student[8]
            {
                new Student(this){Fullname = "Abdullabayli Saleh", LastSeen = "21.01.2019", Absent = true, Top = 160},
                new Student(this){Fullname = "Ahmadov Anar", LastSeen = "20.01.2019", Absent = true,Top = 225},
                new Student(this){Fullname = "Jamalzade Elvin", LastSeen = "20.01.2019", Absent = true,Top = 290},
                new Student(this){Fullname = "Mustafayev Nurullah", LastSeen = "20.01.2019", Absent = true,Top = 355},
                new Student(this){Fullname = "Mustafayev Tural", LastSeen = "20.01.2019", Absent = true,Top = 420},
                new Student(this){Fullname = "Naghiyev Elshan", LastSeen = "20.01.2019", Absent = true,Top = 485},
                new Student(this){Fullname = "Omarov Islam", LastSeen = "20.01.2019", Absent = true,Top = 550},
                new Student(this){Fullname = "Osmanov Samir", LastSeen = "20.01.2019", Absent = true,Top = 615}
            };

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
            labelTotalCrystal.BackColor = Color.FromArgb(227, 245, 255);
            labelTotalCrystal.ForeColor = Color.FromArgb(154, 199, 227);
            signAll.BackColor = Color.FromArgb(227, 245, 255);

            this.Controls.AddRange(students);

            //iconPen.Image = Properties.Resources.pencil;
            //iconPen.SizeMode = PictureBoxSizeMode.StretchImage;

            totalCrystal.BackgroundImageLayout = ImageLayout.Stretch;
            totalCrystal.BackColor = Color.Azure;
            //totalCrystal.BackgroundImage = Properties.Resources.crystal;

        }

        private void SignAll_CheckedChanged(object sender, EventArgs e)
        {
            if (signAll.Checked)
            {
                for (int i = 0; i < Students.Count(); i++)
                {
                    Students[i].OneCrystal = new PictureBox();
                    Students[i].TwoCrystal = new PictureBox();
                    Students[i].ThreeCrystal = new PictureBox();
                    Students[i].Xicon = new PictureBox();
                    Students[i].CommentForStudent = new PictureBox();
                    Students[i].Participates = true;
                    Students[i].OneCrystal.Enabled = true;
                    Students[i].TwoCrystal.Enabled = true;
                    Students[i].ThreeCrystal.Enabled = true;
                    Students[i].Xicon.Enabled = true;
                    Students[i].CommentForStudent.Enabled = true;
                    
                }
            }

        }

        private void iconPen_Click(object sender, EventArgs e)
        {
            subject.Enabled = true;
            
        }

    }
}
