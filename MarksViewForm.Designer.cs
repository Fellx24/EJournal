namespace DBUse
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.MarkTB = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(735, 369);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SurnameTB
            // 
            this.SurnameTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTB.Location = new System.Drawing.Point(130, 417);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(118, 23);
            this.SurnameTB.TabIndex = 3;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(54, 417);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(73, 19);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(294, 417);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 19);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Имя";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.Location = new System.Drawing.Point(335, 417);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(118, 23);
            this.NameTB.TabIndex = 8;
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarkLabel.Location = new System.Drawing.Point(508, 399);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(61, 19);
            this.MarkLabel.TabIndex = 11;
            this.MarkLabel.Text = "Оценка";
            // 
            // MarkTB
            // 
            this.MarkTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarkTB.Location = new System.Drawing.Point(575, 399);
            this.MarkTB.Name = "MarkTB";
            this.MarkTB.Size = new System.Drawing.Size(118, 23);
            this.MarkTB.TabIndex = 10;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(524, 436);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 19);
            this.EmailLabel.TabIndex = 17;
            this.EmailLabel.Text = "Дата";
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTB.Location = new System.Drawing.Point(575, 436);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(118, 23);
            this.EmailTB.TabIndex = 16;
            // 
            // MarksViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 471);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.MarkTB);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.SurnameTB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MarksViewForm";
            this.Text = "8Б класс - Информатика";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label MarkLabel;
        private System.Windows.Forms.TextBox MarkTB;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTB;
    }
}

