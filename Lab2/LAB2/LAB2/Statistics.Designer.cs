
namespace LAB2
{
    partial class Statistics
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
            this.grades_count = new System.Windows.Forms.DataGridView();
            this.letter_grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headinglbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totlbl = new System.Windows.Forms.Label();
            this.totcountlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grades_count)).BeginInit();
            this.SuspendLayout();
            // 
            // grades_count
            // 
            this.grades_count.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grades_count.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.letter_grade,
            this.count});
            this.grades_count.Location = new System.Drawing.Point(269, 95);
            this.grades_count.Name = "grades_count";
            this.grades_count.RowHeadersWidth = 51;
            this.grades_count.RowTemplate.Height = 24;
            this.grades_count.Size = new System.Drawing.Size(301, 343);
            this.grades_count.TabIndex = 0;
            // 
            // letter_grade
            // 
            this.letter_grade.HeaderText = "Letter Grade";
            this.letter_grade.MinimumWidth = 6;
            this.letter_grade.Name = "letter_grade";
            this.letter_grade.ReadOnly = true;
            this.letter_grade.Width = 125;
            // 
            // count
            // 
            this.count.HeaderText = "Count";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 125;
            // 
            // headinglbl
            // 
            this.headinglbl.AutoSize = true;
            this.headinglbl.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headinglbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.headinglbl.Location = new System.Drawing.Point(276, 35);
            this.headinglbl.Name = "headinglbl";
            this.headinglbl.Size = new System.Drawing.Size(294, 40);
            this.headinglbl.TabIndex = 1;
            this.headinglbl.Text = "Grades Statistics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // totlbl
            // 
            this.totlbl.AutoSize = true;
            this.totlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totlbl.Location = new System.Drawing.Point(266, 460);
            this.totlbl.Name = "totlbl";
            this.totlbl.Size = new System.Drawing.Size(73, 29);
            this.totlbl.TabIndex = 3;
            this.totlbl.Text = "Total";
            // 
            // totcountlbl
            // 
            this.totcountlbl.AutoSize = true;
            this.totcountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totcountlbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.totcountlbl.Location = new System.Drawing.Point(413, 465);
            this.totcountlbl.Name = "totcountlbl";
            this.totcountlbl.Size = new System.Drawing.Size(20, 29);
            this.totcountlbl.TabIndex = 4;
            this.totcountlbl.Text = " ";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 512);
            this.Controls.Add(this.totcountlbl);
            this.Controls.Add(this.totlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headinglbl);
            this.Controls.Add(this.grades_count);
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.grades_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grades_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn letter_grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.Label headinglbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totlbl;
        private System.Windows.Forms.Label totcountlbl;
    }
}