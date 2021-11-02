
namespace LAB2
{
    partial class StudentGrades
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.Label();
            this.comboGrade = new System.Windows.Forms.ComboBox();
            this.grades_view = new System.Windows.Forms.DataGridView();
            this.names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addbtn = new System.Windows.Forms.Button();
            this.statbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grades_view)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(54, 73);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(82, 29);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(170, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 22);
            this.txtName.TabIndex = 1;
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade.Location = new System.Drawing.Point(54, 145);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(85, 29);
            this.grade.TabIndex = 2;
            this.grade.Text = "Grade";
            // 
            // comboGrade
            // 
            this.comboGrade.FormattingEnabled = true;
            this.comboGrade.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.comboGrade.Location = new System.Drawing.Point(170, 152);
            this.comboGrade.Name = "comboGrade";
            this.comboGrade.Size = new System.Drawing.Size(242, 24);
            this.comboGrade.TabIndex = 3;
            this.comboGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboGrade_KeyPress);
            // 
            // grades_view
            // 
            this.grades_view.BackgroundColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grades_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grades_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grades_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.names,
            this.GRADES});
            this.grades_view.GridColor = System.Drawing.SystemColors.Desktop;
            this.grades_view.Location = new System.Drawing.Point(472, 73);
            this.grades_view.Name = "grades_view";
            this.grades_view.RowHeadersWidth = 51;
            this.grades_view.RowTemplate.Height = 24;
            this.grades_view.Size = new System.Drawing.Size(398, 280);
            this.grades_view.TabIndex = 4;
            // 
            // names
            // 
            this.names.HeaderText = "Name";
            this.names.MinimumWidth = 6;
            this.names.Name = "names";
            this.names.Width = 180;
            // 
            // GRADES
            // 
            this.GRADES.HeaderText = "Grade";
            this.GRADES.MinimumWidth = 6;
            this.GRADES.Name = "GRADES";
            this.GRADES.Width = 125;
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(59, 216);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(138, 39);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "Add Grade";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // statbtn
            // 
            this.statbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statbtn.Location = new System.Drawing.Point(608, 373);
            this.statbtn.Name = "statbtn";
            this.statbtn.Size = new System.Drawing.Size(125, 39);
            this.statbtn.TabIndex = 6;
            this.statbtn.Text = "Statistics";
            this.statbtn.UseVisualStyleBackColor = true;
            this.statbtn.Click += new System.EventHandler(this.statbtn_Click);
            // 
            // StudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 500);
            this.Controls.Add(this.statbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.grades_view);
            this.Controls.Add(this.comboGrade);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.name);
            this.Name = "StudentGrades";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grades_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.ComboBox comboGrade;
        private System.Windows.Forms.DataGridView grades_view;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn names;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRADES;
        private System.Windows.Forms.Button statbtn;
    }
}

