namespace EJournal
{
    partial class StudentsViewForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.StudentsDGV = new System.Windows.Forms.DataGridView();
            this.FathernameLabel = new System.Windows.Forms.Label();
            this.FathernameTB = new System.Windows.Forms.TextBox();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.BirthdayTB = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.ClassTB = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ListLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(395, 390);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 19);
            this.NameLabel.TabIndex = 22;
            this.NameLabel.Text = "Имя";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.Location = new System.Drawing.Point(439, 390);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(127, 23);
            this.NameTB.TabIndex = 21;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(110, 390);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(73, 19);
            this.SurnameLabel.TabIndex = 20;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // SurnameTB
            // 
            this.SurnameTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTB.Location = new System.Drawing.Point(189, 390);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(127, 23);
            this.SurnameTB.TabIndex = 19;
            // 
            // StudentsDGV
            // 
            this.StudentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDGV.Location = new System.Drawing.Point(12, 31);
            this.StudentsDGV.Name = "StudentsDGV";
            this.StudentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentsDGV.Size = new System.Drawing.Size(912, 343);
            this.StudentsDGV.TabIndex = 18;
            this.StudentsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDGV_CellClick);
            this.StudentsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FathernameLabel
            // 
            this.FathernameLabel.AutoSize = true;
            this.FathernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FathernameLabel.Location = new System.Drawing.Point(652, 390);
            this.FathernameLabel.Name = "FathernameLabel";
            this.FathernameLabel.Size = new System.Drawing.Size(71, 19);
            this.FathernameLabel.TabIndex = 24;
            this.FathernameLabel.Text = "Отчество";
            // 
            // FathernameTB
            // 
            this.FathernameTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FathernameTB.Location = new System.Drawing.Point(729, 390);
            this.FathernameTB.Name = "FathernameTB";
            this.FathernameTB.Size = new System.Drawing.Size(127, 23);
            this.FathernameTB.TabIndex = 23;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayLabel.Location = new System.Drawing.Point(68, 434);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(115, 19);
            this.BirthdayLabel.TabIndex = 26;
            this.BirthdayLabel.Text = "Дата рождения";
            // 
            // BirthdayTB
            // 
            this.BirthdayTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayTB.Location = new System.Drawing.Point(189, 434);
            this.BirthdayTB.Name = "BirthdayTB";
            this.BirthdayTB.Size = new System.Drawing.Size(127, 23);
            this.BirthdayTB.TabIndex = 25;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(388, 434);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(45, 19);
            this.EmailLabel.TabIndex = 28;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTB.Location = new System.Drawing.Point(439, 434);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(156, 23);
            this.EmailTB.TabIndex = 27;
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassLabel.Location = new System.Drawing.Point(675, 434);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(48, 19);
            this.ClassLabel.TabIndex = 30;
            this.ClassLabel.Text = "Класс";
            // 
            // ClassTB
            // 
            this.ClassTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassTB.Location = new System.Drawing.Point(729, 434);
            this.ClassTB.Name = "ClassTB";
            this.ClassTB.Size = new System.Drawing.Size(39, 23);
            this.ClassTB.TabIndex = 29;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(114, 480);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 28);
            this.BackButton.TabIndex = 47;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(729, 480);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(99, 28);
            this.SaveButton.TabIndex = 46;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListLabel.Location = new System.Drawing.Point(12, 9);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(125, 19);
            this.ListLabel.TabIndex = 48;
            this.ListLabel.Text = "Список учеников";
            // 
            // StudentsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 525);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.ClassTB);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.BirthdayTB);
            this.Controls.Add(this.FathernameLabel);
            this.Controls.Add(this.FathernameTB);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.SurnameTB);
            this.Controls.Add(this.StudentsDGV);
            this.Name = "StudentsViewForm";
            this.Text = "EJournal";
            this.Load += new System.EventHandler(this.StudentsViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.DataGridView StudentsDGV;
        private System.Windows.Forms.Label FathernameLabel;
        private System.Windows.Forms.TextBox FathernameTB;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.TextBox BirthdayTB;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.TextBox ClassTB;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label ListLabel;
    }
}