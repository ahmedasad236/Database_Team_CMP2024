using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class StudentGrades : Form
    {
        public static int[] gradesRecurrences;
        public static string[] _grades; 
        public StudentGrades()
        {
            InitializeComponent();
            _grades = new string[] { "A", "B", "C", "D", "E", "F" };
            gradesRecurrences = new int[6];
            for (int i = 0; i < 6; i++)
                gradesRecurrences[i] = 0;
        }

        private void add_grade()
        {
            // Check the length of the name
            if (txtName.Text.Length < 3 || txtName.Text.Length > 100)
            {
                MessageBox.Show("Invalid Name :(");
                return;
            }


            // Check if the grade is already in the combobox
            
            bool test = false;
            foreach (string c in _grades)
            {
                if (c == comboGrade.Text)
                {
                    test = true;
                    break;
                }
            }

            if (!test)
            {
                MessageBox.Show("Invalid Grade :(");
                return;
            }

            // Add the name and the grade to the table
            string[] row = { txtName.Text, comboGrade.Text };
            grades_view.Rows.Add(row);

            // Increment the count for this current grade
            char indx = comboGrade.Text[0];
            gradesRecurrences[indx - 'A']++; // get the right index
            // Reset the textBox and the comboBox to their initial state
            txtName.Text = "";
            comboGrade.Text = "";
        }

        // To click the add button and insert the grade and the name.
        private void addbtn_Click(object sender, EventArgs e)
        {
            add_grade();
        }

        // To Press Enter after writing the grade.
        private void comboGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
                add_grade();
        }

        private void statbtn_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hide the current window
            Statistics stat = new Statistics();
            stat.Show(); // Show the statistics window

        }
    }
}
