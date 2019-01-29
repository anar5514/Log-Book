using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBook
{
    public partial class Student : UserControl
    {
        public string Fullname { get => studentName.Text; set => studentName.Text = value; }
        public string LastSeen { get => lastSeen.Text; set => lastSeen.Text = value; }
        public MetroFramework.Controls.MetroRadioButton Participates { get => participates; set => participates= value; }
        public MetroFramework.Controls.MetroRadioButton Delayed { get => delayed; set => delayed = value; }
        public MetroFramework.Controls.MetroRadioButton Absent { get => absent; set => absent = value; }
        public bool ControlWorkMark { get => controlWorkMark.Enabled; set => controlWorkMark.Enabled = value; }
        public bool PracticeWorkMark { get => practiceWorkMark.Enabled; set => practiceWorkMark.Enabled = value; }
        public PictureBox OneCrystal { get; set; }
        public PictureBox TwoCrystal { get; set; }
        public PictureBox ThreeCrystal { get; set; }
        public int NumberStudent { get => int.Parse(numberStudent.Text) ; set => numberStudent.Text = value.ToString(); }
        public PictureBox Xicon{ get => xIcon; set => xIcon = value; }
        public PictureBox CommentForStudent { get => commentForStudent; set => commentForStudent = value; }
        LogBook logBook;

        public Student(LogBook logbook)
        {
            logBook = logbook;
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            participates.CheckedChanged += ParticipatesOrDelayed_CheckedChanged;
            delayed.CheckedChanged += ParticipatesOrDelayed_CheckedChanged;

            controlWorkMark.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            practiceWorkMark.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });

            //studentPhoto.Image = Properties.Resources.pencil;
            studentPhoto.SizeMode = PictureBoxSizeMode.StretchImage;

            //commentForStudent.Image = Properties.Resources.comment;
            commentForStudent.SizeMode = PictureBoxSizeMode.StretchImage;

            //oneCrystal.Image = Properties.Resources.enabledcrystal;
            oneCrystal.SizeMode = PictureBoxSizeMode.StretchImage;

            //twoCrystal.Image = Properties.Resources.enabledcrystal;
            twoCrystal.SizeMode = PictureBoxSizeMode.StretchImage;

            //threeCrystal.Image = Properties.Resources.enabledcrystal;
            threeCrystal.SizeMode = PictureBoxSizeMode.StretchImage;

            //xIcon.Image = Properties.Resources.;
            xIcon.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ParticipatesOrDelayed_CheckedChanged(object sender, EventArgs e)
        {
            if (participates.Checked || delayed.Checked)
            {
                ControlWorkMark = true;
                PracticeWorkMark = true;
            }
            else
            {
                ControlWorkMark = false;
                PracticeWorkMark = false;
            }
        }

        private void absent_CheckedChanged(object sender, EventArgs e)
        {
            if (absent.Checked)
            {
                controlWorkMark.SelectedItem = null;
                practiceWorkMark.SelectedItem = null;
            }           
        }

        private void oneCrystal_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void twoCrystal_MouseClick(object sender, MouseEventArgs e)
        {
            twoCrystal.Image = Properties.Resources.crystal;
            twoCrystal.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void oneCrystal_MouseClick_1(object sender, MouseEventArgs e)
        {
            oneCrystal.Image = Properties.Resources.crystal;
            oneCrystal.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void twoCrystal_MouseClick_1(object sender, MouseEventArgs e)
        {
            twoCrystal.Image = Properties.Resources.crystal;
            twoCrystal.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void threeCrystal_MouseClick(object sender, MouseEventArgs e)
        {
            threeCrystal.Image = Properties.Resources.crystal;
            threeCrystal.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
