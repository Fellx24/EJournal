namespace EJournal
{
    partial class MenuForm
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
            this.ProfileButton = new System.Windows.Forms.Button();
            this.MainLabelDeleted = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ClassesCB = new System.Windows.Forms.ComboBox();
            this.SubjectsCB = new System.Windows.Forms.ComboBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.StudentsListButton = new System.Windows.Forms.Button();
            this.TeachersListButton = new System.Windows.Forms.Button();
            this.JournalOpenLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.StudentListCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ProfileButton
            // 
            this.ProfileButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileButton.Location = new System.Drawing.Point(172, 111);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(99, 28);
            this.ProfileButton.TabIndex = 12;
            this.ProfileButton.Text = "Профиль";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // MainLabelDeleted
            // 
            this.MainLabelDeleted.AutoSize = true;
            this.MainLabelDeleted.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabelDeleted.Location = new System.Drawing.Point(23, 46);
            this.MainLabelDeleted.Name = "MainLabelDeleted";
            this.MainLabelDeleted.Size = new System.Drawing.Size(0, 36);
            this.MainLabelDeleted.TabIndex = 13;
            this.MainLabelDeleted.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenButton.Location = new System.Drawing.Point(234, 210);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(99, 28);
            this.OpenButton.TabIndex = 15;
            this.OpenButton.Text = "Открыть";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ClassesCB
            // 
            this.ClassesCB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassesCB.FormattingEnabled = true;
            this.ClassesCB.Items.AddRange(new object[] {
            "8Б"});
            this.ClassesCB.Location = new System.Drawing.Point(94, 194);
            this.ClassesCB.Name = "ClassesCB";
            this.ClassesCB.Size = new System.Drawing.Size(121, 23);
            this.ClassesCB.TabIndex = 16;
            this.ClassesCB.SelectedIndexChanged += new System.EventHandler(this.ClassesCB_SelectedIndexChanged);
            // 
            // SubjectsCB
            // 
            this.SubjectsCB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectsCB.FormattingEnabled = true;
            this.SubjectsCB.Items.AddRange(new object[] {
            "Информатика",
            "Математика"});
            this.SubjectsCB.Location = new System.Drawing.Point(94, 232);
            this.SubjectsCB.Name = "SubjectsCB";
            this.SubjectsCB.Size = new System.Drawing.Size(121, 23);
            this.SubjectsCB.TabIndex = 18;
            this.SubjectsCB.Visible = false;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(128, 46);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(197, 36);
            this.MainLabel.TabIndex = 19;
            this.MainLabel.Text = "Здравствуйте, ";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StudentsListButton
            // 
            this.StudentsListButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsListButton.Location = new System.Drawing.Point(12, 111);
            this.StudentsListButton.Name = "StudentsListButton";
            this.StudentsListButton.Size = new System.Drawing.Size(143, 28);
            this.StudentsListButton.TabIndex = 20;
            this.StudentsListButton.Text = "Список учеников";
            this.StudentsListButton.UseVisualStyleBackColor = true;
            this.StudentsListButton.Visible = false;
            this.StudentsListButton.Click += new System.EventHandler(this.StudentsListButton_Click);
            // 
            // TeachersListButton
            // 
            this.TeachersListButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeachersListButton.Location = new System.Drawing.Point(283, 111);
            this.TeachersListButton.Name = "TeachersListButton";
            this.TeachersListButton.Size = new System.Drawing.Size(143, 28);
            this.TeachersListButton.TabIndex = 21;
            this.TeachersListButton.Text = "Список учителей";
            this.TeachersListButton.UseVisualStyleBackColor = true;
            this.TeachersListButton.Visible = false;
            this.TeachersListButton.Click += new System.EventHandler(this.TeachersListButton_Click);
            // 
            // JournalOpenLabel
            // 
            this.JournalOpenLabel.AutoSize = true;
            this.JournalOpenLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JournalOpenLabel.Location = new System.Drawing.Point(158, 162);
            this.JournalOpenLabel.Name = "JournalOpenLabel";
            this.JournalOpenLabel.Size = new System.Drawing.Size(115, 18);
            this.JournalOpenLabel.TabIndex = 22;
            this.JournalOpenLabel.Text = "Открыть журнал";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassLabel.Location = new System.Drawing.Point(121, 199);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(65, 18);
            this.ClassLabel.TabIndex = 23;
            this.ClassLabel.Text = "Класс: 8Б";
            this.ClassLabel.Visible = false;
            // 
            // StudentListCB
            // 
            this.StudentListCB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentListCB.FormattingEnabled = true;
            this.StudentListCB.Items.AddRange(new object[] {
            "Все",
            "8Б"});
            this.StudentListCB.Location = new System.Drawing.Point(29, 145);
            this.StudentListCB.Name = "StudentListCB";
            this.StudentListCB.Size = new System.Drawing.Size(113, 23);
            this.StudentListCB.TabIndex = 24;
            this.StudentListCB.Visible = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 286);
            this.Controls.Add(this.StudentListCB);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.JournalOpenLabel);
            this.Controls.Add(this.TeachersListButton);
            this.Controls.Add(this.StudentsListButton);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.SubjectsCB);
            this.Controls.Add(this.ClassesCB);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.MainLabelDeleted);
            this.Controls.Add(this.ProfileButton);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Label MainLabelDeleted;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.ComboBox ClassesCB;
        private System.Windows.Forms.ComboBox SubjectsCB;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button StudentsListButton;
        private System.Windows.Forms.Button TeachersListButton;
        private System.Windows.Forms.Label JournalOpenLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.ComboBox StudentListCB;
    }
}