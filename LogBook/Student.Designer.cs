namespace LogBook
{
    partial class Student
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.absent = new MetroFramework.Controls.MetroRadioButton();
            this.delayed = new MetroFramework.Controls.MetroRadioButton();
            this.participates = new MetroFramework.Controls.MetroRadioButton();
            this.studentName = new System.Windows.Forms.Label();
            this.practiceWorkMark = new MetroFramework.Controls.MetroComboBox();
            this.controlWorkMark = new MetroFramework.Controls.MetroComboBox();
            this.lastSeen = new System.Windows.Forms.Label();
            this.twoCrystal = new System.Windows.Forms.PictureBox();
            this.threeCrystal = new System.Windows.Forms.PictureBox();
            this.oneCrystal = new System.Windows.Forms.PictureBox();
            this.numberStudent = new System.Windows.Forms.Label();
            this.commentForStudent = new System.Windows.Forms.PictureBox();
            this.studentPhoto = new System.Windows.Forms.PictureBox();
            this.xIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.twoCrystal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeCrystal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneCrystal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentForStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // absent
            // 
            this.absent.AutoSize = true;
            this.absent.BackColor = System.Drawing.SystemColors.Window;
            this.absent.CustomBackground = true;
            this.absent.Enabled = false;
            this.absent.Location = new System.Drawing.Point(665, 29);
            this.absent.Name = "absent";
            this.absent.Size = new System.Drawing.Size(26, 15);
            this.absent.Style = MetroFramework.MetroColorStyle.Red;
            this.absent.TabIndex = 67;
            this.absent.TabStop = true;
            this.absent.Text = " ";
            this.absent.UseVisualStyleBackColor = false;
            this.absent.CheckedChanged += new System.EventHandler(this.absent_CheckedChanged);
            // 
            // delayed
            // 
            this.delayed.AutoSize = true;
            this.delayed.BackColor = System.Drawing.SystemColors.Window;
            this.delayed.CustomBackground = true;
            this.delayed.Enabled = false;
            this.delayed.Location = new System.Drawing.Point(633, 29);
            this.delayed.Name = "delayed";
            this.delayed.Size = new System.Drawing.Size(26, 15);
            this.delayed.Style = MetroFramework.MetroColorStyle.Yellow;
            this.delayed.TabIndex = 66;
            this.delayed.TabStop = true;
            this.delayed.Text = " ";
            this.delayed.UseVisualStyleBackColor = false;
            // 
            // participates
            // 
            this.participates.AutoSize = true;
            this.participates.BackColor = System.Drawing.SystemColors.Window;
            this.participates.CustomBackground = true;
            this.participates.Enabled = false;
            this.participates.Location = new System.Drawing.Point(601, 29);
            this.participates.Name = "participates";
            this.participates.Size = new System.Drawing.Size(26, 15);
            this.participates.Style = MetroFramework.MetroColorStyle.Green;
            this.participates.TabIndex = 65;
            this.participates.TabStop = true;
            this.participates.Text = " ";
            this.participates.UseVisualStyleBackColor = false;
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(85, 23);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(158, 23);
            this.studentName.TabIndex = 64;
            this.studentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // practiceWorkMark
            // 
            this.practiceWorkMark.Enabled = false;
            this.practiceWorkMark.FormattingEnabled = true;
            this.practiceWorkMark.ItemHeight = 23;
            this.practiceWorkMark.Location = new System.Drawing.Point(1025, 17);
            this.practiceWorkMark.Name = "practiceWorkMark";
            this.practiceWorkMark.Size = new System.Drawing.Size(81, 29);
            this.practiceWorkMark.TabIndex = 63;
            // 
            // controlWorkMark
            // 
            this.controlWorkMark.Enabled = false;
            this.controlWorkMark.FormattingEnabled = true;
            this.controlWorkMark.ItemHeight = 23;
            this.controlWorkMark.Location = new System.Drawing.Point(861, 17);
            this.controlWorkMark.Name = "controlWorkMark";
            this.controlWorkMark.Size = new System.Drawing.Size(81, 29);
            this.controlWorkMark.TabIndex = 62;
            // 
            // lastSeen
            // 
            this.lastSeen.AutoSize = true;
            this.lastSeen.Location = new System.Drawing.Point(303, 29);
            this.lastSeen.Name = "lastSeen";
            this.lastSeen.Size = new System.Drawing.Size(61, 13);
            this.lastSeen.TabIndex = 61;
            this.lastSeen.Text = "21.05.2019";
            // 
            // twoCrystal
            // 
            this.twoCrystal.Enabled = false;
            this.twoCrystal.ErrorImage = null;
            this.twoCrystal.Image = ((System.Drawing.Image)(resources.GetObject("twoCrystal.Image")));
            this.twoCrystal.InitialImage = null;
            this.twoCrystal.Location = new System.Drawing.Point(1218, 19);
            this.twoCrystal.Name = "twoCrystal";
            this.twoCrystal.Size = new System.Drawing.Size(25, 24);
            this.twoCrystal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twoCrystal.TabIndex = 70;
            this.twoCrystal.TabStop = false;
            this.twoCrystal.Click += new System.EventHandler(this.twoCrystal_Click);
            // 
            // threeCrystal
            // 
            this.threeCrystal.Enabled = false;
            this.threeCrystal.ErrorImage = null;
            this.threeCrystal.Image = ((System.Drawing.Image)(resources.GetObject("threeCrystal.Image")));
            this.threeCrystal.InitialImage = null;
            this.threeCrystal.Location = new System.Drawing.Point(1249, 19);
            this.threeCrystal.Name = "threeCrystal";
            this.threeCrystal.Size = new System.Drawing.Size(25, 24);
            this.threeCrystal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.threeCrystal.TabIndex = 71;
            this.threeCrystal.TabStop = false;
            this.threeCrystal.Click += new System.EventHandler(this.threeCrystal_Click);
            // 
            // oneCrystal
            // 
            this.oneCrystal.Enabled = false;
            this.oneCrystal.ErrorImage = null;
            this.oneCrystal.Image = ((System.Drawing.Image)(resources.GetObject("oneCrystal.Image")));
            this.oneCrystal.InitialImage = null;
            this.oneCrystal.Location = new System.Drawing.Point(1187, 19);
            this.oneCrystal.Name = "oneCrystal";
            this.oneCrystal.Size = new System.Drawing.Size(25, 24);
            this.oneCrystal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oneCrystal.TabIndex = 69;
            this.oneCrystal.TabStop = false;
            this.oneCrystal.Click += new System.EventHandler(this.oneCrystal_Click);
            // 
            // numberStudent
            // 
            this.numberStudent.Location = new System.Drawing.Point(3, 23);
            this.numberStudent.Name = "numberStudent";
            this.numberStudent.Size = new System.Drawing.Size(35, 23);
            this.numberStudent.TabIndex = 72;
            this.numberStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // commentForStudent
            // 
            this.commentForStudent.Enabled = false;
            this.commentForStudent.ErrorImage = null;
            this.commentForStudent.Image = ((System.Drawing.Image)(resources.GetObject("commentForStudent.Image")));
            this.commentForStudent.InitialImage = null;
            this.commentForStudent.Location = new System.Drawing.Point(1342, 18);
            this.commentForStudent.Name = "commentForStudent";
            this.commentForStudent.Size = new System.Drawing.Size(25, 24);
            this.commentForStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commentForStudent.TabIndex = 73;
            this.commentForStudent.TabStop = false;
            // 
            // studentPhoto
            // 
            this.studentPhoto.Image = ((System.Drawing.Image)(resources.GetObject("studentPhoto.Image")));
            this.studentPhoto.InitialImage = null;
            this.studentPhoto.Location = new System.Drawing.Point(44, 19);
            this.studentPhoto.Name = "studentPhoto";
            this.studentPhoto.Size = new System.Drawing.Size(35, 27);
            this.studentPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentPhoto.TabIndex = 68;
            this.studentPhoto.TabStop = false;
            // 
            // xIcon
            // 
            this.xIcon.Enabled = false;
            this.xIcon.ErrorImage = null;
            this.xIcon.Image = ((System.Drawing.Image)(resources.GetObject("xIcon.Image")));
            this.xIcon.InitialImage = null;
            this.xIcon.Location = new System.Drawing.Point(1280, 19);
            this.xIcon.Name = "xIcon";
            this.xIcon.Size = new System.Drawing.Size(25, 24);
            this.xIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xIcon.TabIndex = 74;
            this.xIcon.TabStop = false;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.xIcon);
            this.Controls.Add(this.commentForStudent);
            this.Controls.Add(this.numberStudent);
            this.Controls.Add(this.threeCrystal);
            this.Controls.Add(this.twoCrystal);
            this.Controls.Add(this.oneCrystal);
            this.Controls.Add(this.studentPhoto);
            this.Controls.Add(this.absent);
            this.Controls.Add(this.delayed);
            this.Controls.Add(this.participates);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.practiceWorkMark);
            this.Controls.Add(this.controlWorkMark);
            this.Controls.Add(this.lastSeen);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(1399, 64);
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.twoCrystal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeCrystal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneCrystal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentForStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton absent;
        private MetroFramework.Controls.MetroRadioButton delayed;
        private MetroFramework.Controls.MetroRadioButton participates;
        private System.Windows.Forms.Label studentName;
        private MetroFramework.Controls.MetroComboBox practiceWorkMark;
        private MetroFramework.Controls.MetroComboBox controlWorkMark;
        private System.Windows.Forms.Label lastSeen;
        private System.Windows.Forms.PictureBox studentPhoto;
        private System.Windows.Forms.PictureBox oneCrystal;
        private System.Windows.Forms.PictureBox twoCrystal;
        private System.Windows.Forms.PictureBox threeCrystal;
        private System.Windows.Forms.Label numberStudent;
        private System.Windows.Forms.PictureBox commentForStudent;
        private System.Windows.Forms.PictureBox xIcon;
    }
}
