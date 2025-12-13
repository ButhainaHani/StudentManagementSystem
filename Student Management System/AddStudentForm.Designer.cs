namespace Student_Management_System
{
    partial class AddStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(29, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 53);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(29, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 53);
            this.label4.TabIndex = 3;
            this.label4.Text = "GPA:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkRed;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaShell;
            this.label5.Location = new System.Drawing.Point(29, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 53);
            this.label5.TabIndex = 4;
            this.label5.Text = "Faculty:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.SeaShell;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(264, 12);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(447, 57);
            this.txtName.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.SeaShell;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(264, 80);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(447, 53);
            this.txtID.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.SeaShell;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(264, 224);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(447, 51);
            this.txtAge.TabIndex = 7;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // txtGPA
            // 
            this.txtGPA.BackColor = System.Drawing.Color.SeaShell;
            this.txtGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPA.Location = new System.Drawing.Point(264, 153);
            this.txtGPA.Multiline = true;
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(447, 49);
            this.txtGPA.TabIndex = 8;
            this.txtGPA.TextChanged += new System.EventHandler(this.txtGPA_TextChanged);
            // 
            // txtFaculty
            // 
            this.txtFaculty.BackColor = System.Drawing.Color.SeaShell;
            this.txtFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaculty.ForeColor = System.Drawing.Color.Black;
            this.txtFaculty.Location = new System.Drawing.Point(264, 302);
            this.txtFaculty.Multiline = true;
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(447, 51);
            this.txtFaculty.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaShell;
            this.btnSave.Font = new System.Drawing.Font("Lucida Bright", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSave.Location = new System.Drawing.Point(628, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 63);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::Student_Management_System.Properties.Resources.photo_2025_12_13_15_54_53;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddStudentForm";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.Button btnSave;
    }
}