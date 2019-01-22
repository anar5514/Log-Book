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
            metroComboBox1.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            metroComboBox2.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            metroComboBox3.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            metroComboBox4.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            metroComboBox5.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            metroComboBox6.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            metroComboBox7.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            metroComboBox8.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            metroComboBox9.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            metroComboBox10.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            metroComboBox11.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            metroComboBox12.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            metroComboBox13.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            metroComboBox14.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            metroComboBox15.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            metroComboBox16.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });

        }

        private void metroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton.Checked)
            {
                metroRadioButton4.Checked = true;
                metroRadioButton7.Checked = true;
                metroRadioButton10.Checked = true;
                metroRadioButton13.Checked = true;
                metroRadioButton16.Checked = true;
                metroRadioButton19.Checked = true;
                metroRadioButton22.Checked = true;
                metroRadioButton25.Checked = true;
            }         
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            metroComboBox1.Enabled = true;
            metroComboBox2.Enabled = true;
            metroComboBox3.Enabled = true;
            metroComboBox4.Enabled = true;
            metroComboBox5.Enabled = true;
            metroComboBox6.Enabled = true;
            metroComboBox7.Enabled = true;
            metroComboBox8.Enabled = true;
            metroComboBox9.Enabled = true;
            metroComboBox10.Enabled = true;
            metroComboBox11.Enabled = true;
            metroComboBox12.Enabled = true;
            metroComboBox13.Enabled = true;
            metroComboBox14.Enabled = true;
            metroComboBox15.Enabled = true;
            metroComboBox16.Enabled = true;
        }
    }
}
