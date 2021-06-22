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
            this.MarkTB = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DateResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MarksDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MarksDGV
            // 
            this.MarksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarksDGV.Location = new System.Drawing.Point(10, 12);
            this.MarksDGV.Name = "MarksDGV";
            this.MarksDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MarksDGV.Size = new System.Drawing.Size(735, 369);
            this.MarksDGV.TabIndex = 0;
            this.MarksDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.MarksDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // MarkTB
            // 
            this.MarkTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarkTB.Location = new System.Drawing.Point(538, 395);
            this.MarkTB.Name = "MarkTB";
            this.MarkTB.Size = new System.Drawing.Size(32, 27);
            this.MarkTB.TabIndex = 10;
            this.MarkTB.Text = "н/б";
            this.MarkTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // MarksViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 471);
            this.Controls.Add(this.DateResultLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.MarkTB);
            this.Controls.Add(this.NameResultLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MarksDGV);
            this.Name = "MarksViewForm";
            this.Text = "8Б класс - Информатика";
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
        private System.Windows.Forms.TextBox MarkTB;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label DateResultLabel;
    }
}

