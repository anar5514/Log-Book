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
        public PictureBox OneCrystal { get => oneCrystal; set => oneCrystal = value; }
        public PictureBox TwoCrystal { get => twoCrystal; set => twoCrystal = value; }
        public PictureBox ThreeCrystal { get => threeCrystal; set => threeCrystal = value; }
        public int NumberStudent { get => int.Parse(numberStudent.Text) ; set => numberStudent.Text = value.ToString(); }
        public PictureBox Xicon{ get => xIcon; set => xIcon = value; }
        public PictureBox CommentForStudent { get => commentForStudent; set => commentForStudent = value; }
        public int TotalCrystal { get; set; }
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

            this.toolTip.SetToolTip(studentPhoto, $"{studentName.Text}");
            this.toolTip.SetToolTip(oneCrystal, "1 crystal");
            this.toolTip.SetToolTip(twoCrystal, "2 crystal");
            this.toolTip.SetToolTip(threeCrystal, "3 crystal");
            this.toolTip.SetToolTip(xIcon, "Delete all crystals");
            this.toolTip.SetToolTip(commentForStudent, "Write comment");
        }

        private void ParticipatesOrDelayed_CheckedChanged(object sender, EventArgs e)
        {
            if (participates.Checked || delayed.Checked)
            {
                ControlWorkMark = true;
                PracticeWorkMark = true;
                this.oneCrystal.Enabled = true;
                this.twoCrystal.Enabled = true;
                this.threeCrystal.Enabled = true;
                this.xIcon.Enabled = true;
                this.commentForStudent.Enabled = true;
            }
            else
            {
                ControlWorkMark = false;
                PracticeWorkMark = false;
                this.oneCrystal.Enabled = false;
                this.twoCrystal.Enabled = false;
                this.threeCrystal.Enabled = false;
                this.xIcon.Enabled = false;
                this.commentForStudent.Enabled = false;
                oneCrystal.Image = Properties.Resources.beforecrystal;
                oneCrystal.SizeMode = PictureBoxSizeMode.StretchImage;
                twoCrystal.Image = Properties.Resources.beforecrystal;
                twoCrystal.SizeMode = PictureBoxSizeMode.StretchImage;
                threeCrystal.Image = Properties.Resources.beforecrystal;
                threeCrystal.SizeMode = PictureBoxSizeMode.StretchImage;
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
            //logBook.TotalCrystalCount += 1;
            //logBook.TotalCrystalCountLabel = logBook.TotalCrystalCount.ToString();
            oneCrystal.Image = Properties.Resources.crystal;
            oneCrystal.SizeMode = PictureBoxSizeMode.StretchImage;

            #region Elave Kod!!!
            //for (int i = 0; i < logBook.Students.Count(); i++)
            //{
            //    if ((oneCrystal.Image == Properties.Resources.crystal) &&
            //        (twoCrystal.Image == Properties.Resources.crystal) && (threeCrystal.Image == Properties.Resources.crystal))
            //        TotalCrystal += 3;
            //    else if((oneCrystal.Image == Properties.Resources.crystal) &&
            //        (twoCrystal.Image == Properties.Resources.crystal))
            //        TotalCrystal += 2;
            //    else if(oneCrystal.Image == (Properties.Resources.crystal)as System.Drawing.Image)
            //        TotalCrystal += 1;
            //}
            //logBook.TotalCrystalCountLabel = TotalCrystal.ToString();       
            #endregion
        }

        private void twoCrystal_MouseClick(object sender, MouseEventArgs e)
        {
            //logBook.TotalCrystalCount += 2;
            //logBook.TotalCrystalCountLabel = logBook.TotalCrystalCount.ToString();
            oneCrystal.Image = Properties.Resources.crystal;
            oneCrystal.SizeMode = PictureBoxSizeMode.StretchImage;
            twoCrystal.Image = Properties.Resources.crystal;
            twoCrystal.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void threeCrystal_MouseClick(object sender, MouseEventArgs e)
        {
            //logBook.TotalCrystalCount += 3;
            //logBook.TotalCrystalCountLabel = logBook.TotalCrystalCount.ToString();
            twoCrystal.Image = Properties.Resources.crystal;
            twoCrystal.SizeMode = PictureBoxSizeMode.StretchImage;
            oneCrystal.Image = Properties.Resources.crystal;
            oneCrystal.SizeMode = PictureBoxSizeMode.StretchImage;
            threeCrystal.Image = Properties.Resources.crystal;
            threeCrystal.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void xIcon_MouseClick(object sender, MouseEventArgs e)
        {
            oneCrystal.Image = Properties.Resources.beforecrystal;
            oneCrystal.SizeMode = PictureBoxSizeMode.StretchImage;
            twoCrystal.Image = Properties.Resources.beforecrystal;
            twoCrystal.SizeMode = PictureBoxSizeMode.StretchImage;
            threeCrystal.Image = Properties.Resources.beforecrystal;
            threeCrystal.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void commentForStudent_MouseClick(object sender, MouseEventArgs e)
        {
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Location = new Point(1326, 17);
            richTextBox.Size = new Size(90, 27);
            richTextBox.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(richTextBox);
            commentForStudent.Visible = false;
        }

        private void studentPhoto_MouseEnter(object sender, EventArgs e)
        {
            studentPhoto.Size = new Size(45, 37);
            studentPhoto.Location = new Point(40, 15);
        }

        private void studentPhoto_MouseLeave(object sender, EventArgs e)
        {
            studentPhoto.Size = new Size(35, 27);
            studentPhoto.Location = new Point(44, 19);
        }
    }
}
