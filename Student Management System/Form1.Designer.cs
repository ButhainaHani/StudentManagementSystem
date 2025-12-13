namespace Student_Management_System
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewQueue = new System.Windows.Forms.DataGridView();
            this.colQueueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQueueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQueueGPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQueueFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowQueue = new System.Windows.Forms.Button();
            this.btnServe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(547, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1003, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colID,
            this.colAge,
            this.colGpa,
            this.colFaculty});
            this.dataGridView1.Location = new System.Drawing.Point(53, 155);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 655);
            this.dataGridView1.TabIndex = 1;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 125;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.Width = 125;
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Age";
            this.colAge.MinimumWidth = 6;
            this.colAge.Name = "colAge";
            this.colAge.Width = 125;
            // 
            // colGpa
            // 
            this.colGpa.HeaderText = "GPA";
            this.colGpa.MinimumWidth = 6;
            this.colGpa.Name = "colGpa";
            this.colGpa.Width = 125;
            // 
            // colFaculty
            // 
            this.colFaculty.HeaderText = "Faculty";
            this.colFaculty.MinimumWidth = 6;
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.Width = 125;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Bright", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SeaShell;
            this.btnAdd.Location = new System.Drawing.Point(887, 155);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(235, 91);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Bright", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.SeaShell;
            this.btnDelete.Location = new System.Drawing.Point(887, 286);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(235, 85);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkRed;
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Bright", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.SeaShell;
            this.btnUpdate.Location = new System.Drawing.Point(887, 411);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(235, 84);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.DarkRed;
            this.btnShowAll.Font = new System.Drawing.Font("Lucida Bright", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.SeaShell;
            this.btnShowAll.Location = new System.Drawing.Point(887, 539);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(235, 86);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "ShowAll";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkRed;
            this.btnSearch.Font = new System.Drawing.Font("Lucida Bright", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.SeaShell;
            this.btnSearch.Location = new System.Drawing.Point(53, 833);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 116);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchId
            // 
            this.txtSearchId.BackColor = System.Drawing.Color.SeaShell;
            this.txtSearchId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchId.Location = new System.Drawing.Point(241, 833);
            this.txtSearchId.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtSearchId.Multiline = true;
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(604, 116);
            this.txtSearchId.TabIndex = 7;
            this.txtSearchId.TextChanged += new System.EventHandler(this.txtSearchId_TextChanged);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.DarkRed;
            this.btnSort.ContextMenuStrip = this.contextMenuStrip1;
            this.btnSort.Font = new System.Drawing.Font("Lucida Bright", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.SeaShell;
            this.btnSort.Location = new System.Drawing.Point(887, 666);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(235, 92);
            this.btnSort.TabIndex = 8;
            this.btnSort.Text = "sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(295, 100);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(294, 24);
            this.toolStripMenuItem1.Text = "SortByNametoolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(294, 24);
            this.toolStripMenuItem2.Text = "SortByIDtoolStripMenuItem2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(294, 24);
            this.toolStripMenuItem3.Text = "SortByAgetoolStripMenuItem3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(294, 24);
            this.toolStripMenuItem4.Text = "SortByGPAtoolStripMenuItem4";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // dataGridViewQueue
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridViewQueue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewQueue.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridViewQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQueueID,
            this.colQueueName,
            this.colQueueGPA,
            this.colQueueFaculty});
            this.dataGridViewQueue.Location = new System.Drawing.Point(1139, 155);
            this.dataGridViewQueue.Name = "dataGridViewQueue";
            this.dataGridViewQueue.RowHeadersWidth = 69;
            this.dataGridViewQueue.RowTemplate.Height = 26;
            this.dataGridViewQueue.Size = new System.Drawing.Size(729, 655);
            this.dataGridViewQueue.TabIndex = 9;
            // 
            // colQueueID
            // 
            this.colQueueID.HeaderText = "ID";
            this.colQueueID.MinimumWidth = 6;
            this.colQueueID.Name = "colQueueID";
            this.colQueueID.Width = 125;
            // 
            // colQueueName
            // 
            this.colQueueName.HeaderText = "Name";
            this.colQueueName.MinimumWidth = 6;
            this.colQueueName.Name = "colQueueName";
            this.colQueueName.Width = 125;
            // 
            // colQueueGPA
            // 
            this.colQueueGPA.HeaderText = "GPA";
            this.colQueueGPA.MinimumWidth = 6;
            this.colQueueGPA.Name = "colQueueGPA";
            this.colQueueGPA.Width = 125;
            // 
            // colQueueFaculty
            // 
            this.colQueueFaculty.HeaderText = "Faculty";
            this.colQueueFaculty.MinimumWidth = 6;
            this.colQueueFaculty.Name = "colQueueFaculty";
            this.colQueueFaculty.Width = 125;
            // 
            // btnShowQueue
            // 
            this.btnShowQueue.BackColor = System.Drawing.Color.DarkRed;
            this.btnShowQueue.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowQueue.ForeColor = System.Drawing.Color.SeaShell;
            this.btnShowQueue.Location = new System.Drawing.Point(1888, 155);
            this.btnShowQueue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowQueue.Name = "btnShowQueue";
            this.btnShowQueue.Size = new System.Drawing.Size(146, 200);
            this.btnShowQueue.TabIndex = 10;
            this.btnShowQueue.Text = "Show Queue";
            this.btnShowQueue.UseVisualStyleBackColor = false;
            this.btnShowQueue.Click += new System.EventHandler(this.btnShowQueue_Click_1);
            // 
            // btnServe
            // 
            this.btnServe.BackColor = System.Drawing.Color.DarkRed;
            this.btnServe.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServe.ForeColor = System.Drawing.Color.SeaShell;
            this.btnServe.Location = new System.Drawing.Point(1888, 411);
            this.btnServe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnServe.Name = "btnServe";
            this.btnServe.Size = new System.Drawing.Size(146, 198);
            this.btnServe.TabIndex = 11;
            this.btnServe.Text = "Serve Student";
            this.btnServe.UseVisualStyleBackColor = false;
            this.btnServe.Click += new System.EventHandler(this.btnServe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Management_System.Properties.Resources.photo_2025_12_13_15_23_27;
            this.ClientSize = new System.Drawing.Size(1924, 999);
            this.Controls.Add(this.btnServe);
            this.Controls.Add(this.btnShowQueue);
            this.Controls.Add(this.dataGridViewQueue);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtSearchId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGpa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaculty;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.DataGridView dataGridViewQueue;
        private System.Windows.Forms.Button btnShowQueue;
        private System.Windows.Forms.Button btnServe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQueueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQueueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQueueGPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQueueFaculty;
    }
}

