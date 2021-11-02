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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            initialize_table(); // Method that initialize the data
        }

        private void initialize_table()
        {
            string[] row = new string[2]; // the row in the table

            int[] grades_recurrences = StudentGrades.gradesRecurrences;//the recurrences of the grades

            string[] grades = StudentGrades._grades; //the grades letters

            int counter = 0;

            for (int i = 0; i < grades_recurrences.Length; i++)
            {
                counter += grades_recurrences[i];
                row[0] = grades[i];
                row[1] = grades_recurrences[i].ToString();
                grades_count.Rows.Add(row);
            }

            totcountlbl.Text = counter.ToString(); //Display the total count of grades

        }
    }
}
