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
            this.MainLabel = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ClassesCB = new System.Windows.Forms.ComboBox();
            this.SubjectsCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ProfileButton
            // 
            this.ProfileButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileButton.Location = new System.Drawing.Point(167, 107);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(99, 28);
            this.ProfileButton.TabIndex = 12;
            this.ProfileButton.Text = "Профиль";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(23, 46);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(0, 36);
            this.MainLabel.TabIndex = 13;
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenButton.Location = new System.Drawing.Point(237, 181);
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
            this.ClassesCB.Location = new System.Drawing.Point(97, 165);
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
            this.SubjectsCB.Location = new System.Drawing.Point(97, 203);
            this.SubjectsCB.Name = "SubjectsCB";
            this.SubjectsCB.Size = new System.Drawing.Size(121, 23);
            this.SubjectsCB.TabIndex = 18;
            this.SubjectsCB.Visible = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 265);
            this.Controls.Add(this.SubjectsCB);
            this.Controls.Add(this.ClassesCB);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.ProfileButton);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.ComboBox ClassesCB;
        private System.Windows.Forms.ComboBox SubjectsCB;
    }
}