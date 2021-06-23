namespace EJournal
{
    partial class MarksViewForm
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
            this.MarksDGV = new System.Windows.Forms.DataGridView();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameResultLabel = new System.Windows.Forms.Label();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DateResultLabel = new System.Windows.Forms.Label();
            this.TeacherNameLabel = new System.Windows.Forms.Label();
            this.TeacherLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.MarkCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.MarksDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MarksDGV
            // 
            this.MarksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarksDGV.Location = new System.Drawing.Point(10, 43);
            this.MarksDGV.Name = "MarksDGV";
            this.MarksDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MarksDGV.Size = new System.Drawing.Size(735, 338);
            this.MarksDGV.TabIndex = 0;
            this.MarksDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(58, 398);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 19);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "ФИО:";
            // 
            // NameResultLabel
            // 
            this.NameResultLabel.AutoSize = true;
            this.NameResultLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameResultLabel.Location = new System.Drawing.Point(109, 398);
            this.NameResultLabel.Name = "NameResultLabel";
            this.NameResultLabel.Size = new System.Drawing.Size(296, 19);
            this.NameResultLabel.TabIndex = 9;
            this.NameResultLabel.Text = "Александров Александр Александрович";
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarkLabel.Location = new System.Drawing.Point(471, 398);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(61, 19);
            this.MarkLabel.TabIndex = 11;
            this.MarkLabel.Text = "Оценка";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(471, 435);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(45, 19);
            this.EmailLabel.TabIndex = 17;
            this.EmailLabel.Text = "Дата:";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(56, 431);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 28);
            this.BackButton.TabIndex = 28;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(616, 431);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(99, 28);
            this.SaveButton.TabIndex = 29;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // DateResultLabel
            // 
            this.DateResultLabel.AutoSize = true;
            this.DateResultLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateResultLabel.Location = new System.Drawing.Point(518, 435);
            this.DateResultLabel.Name = "DateResultLabel";
            this.DateResultLabel.Size = new System.Drawing.Size(65, 19);
            this.DateResultLabel.TabIndex = 30;
            this.DateResultLabel.Text = "12.12.12";
            // 
            // TeacherNameLabel
            // 
            this.TeacherNameLabel.AutoSize = true;
            this.TeacherNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherNameLabel.Location = new System.Drawing.Point(471, 9);
            this.TeacherNameLabel.Name = "TeacherNameLabel";
            this.TeacherNameLabel.Size = new System.Drawing.Size(222, 19);
            this.TeacherNameLabel.TabIndex = 32;
            this.TeacherNameLabel.Text = "Ивановна Мария Дмитриевна";
            // 
            // TeacherLabel
            // 
            this.TeacherLabel.AutoSize = true;
            this.TeacherLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherLabel.Location = new System.Drawing.Point(356, 9);
            this.TeacherLabel.Name = "TeacherLabel";
            this.TeacherLabel.Size = new System.Drawing.Size(118, 19);
            this.TeacherLabel.TabIndex = 31;
            this.TeacherLabel.Text = "Преподаватель:";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectLabel.Location = new System.Drawing.Point(12, 9);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(103, 19);
            this.SubjectLabel.TabIndex = 33;
            this.SubjectLabel.Text = "Информатика";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassLabel.Location = new System.Drawing.Point(129, 9);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(67, 19);
            this.ClassLabel.TabIndex = 34;
            this.ClassLabel.Text = "8Б класс";
            // 
            // MarkCB
            // 
            this.MarkCB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarkCB.FormattingEnabled = true;
            this.MarkCB.Items.AddRange(new object[] {
            "н",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.MarkCB.Location = new System.Drawing.Point(539, 399);
            this.MarkCB.Name = "MarkCB";
            this.MarkCB.Size = new System.Drawing.Size(32, 23);
            this.MarkCB.TabIndex = 35;
            this.MarkCB.Text = "5";
            // 
            // MarksViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 471);
            this.Controls.Add(this.MarkCB);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.TeacherNameLabel);
            this.Controls.Add(this.TeacherLabel);
            this.Controls.Add(this.DateResultLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.NameResultLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MarksDGV);
            this.Name = "MarksViewForm";
            this.Text = "EJournal";
            this.Load += new System.EventHandler(this.MarksViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MarksDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MarksDGV;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label NameResultLabel;
        private System.Windows.Forms.Label MarkLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label DateResultLabel;
        private System.Windows.Forms.Label TeacherNameLabel;
        private System.Windows.Forms.Label TeacherLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.ComboBox MarkCB;
    }
}

