namespace Project272
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
            this.IDlabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Agelabel = new System.Windows.Forms.Label();
            this.SPlabel = new System.Windows.Forms.Label();
            this.Examlabel = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.SPtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Test1textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Test3textBox = new System.Windows.Forms.TextBox();
            this.Test2textBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(18, 22);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(32, 13);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "ID Nr";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(18, 67);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(35, 13);
            this.Namelabel.TabIndex = 1;
            this.Namelabel.Text = "Name";
            // 
            // Agelabel
            // 
            this.Agelabel.AutoSize = true;
            this.Agelabel.Location = new System.Drawing.Point(18, 119);
            this.Agelabel.Name = "Agelabel";
            this.Agelabel.Size = new System.Drawing.Size(26, 13);
            this.Agelabel.TabIndex = 2;
            this.Agelabel.Text = "Age";
            this.Agelabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // SPlabel
            // 
            this.SPlabel.AutoSize = true;
            this.SPlabel.Location = new System.Drawing.Point(18, 165);
            this.SPlabel.Name = "SPlabel";
            this.SPlabel.Size = new System.Drawing.Size(64, 13);
            this.SPlabel.TabIndex = 3;
            this.SPlabel.Text = "Superpower";
            // 
            // Examlabel
            // 
            this.Examlabel.AutoSize = true;
            this.Examlabel.Location = new System.Drawing.Point(18, 217);
            this.Examlabel.Name = "Examlabel";
            this.Examlabel.Size = new System.Drawing.Size(68, 13);
            this.Examlabel.TabIndex = 4;
            this.Examlabel.Text = "Test 1 Score";
            this.Examlabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(92, 19);
            this.IDtextBox.MaxLength = 10;
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(100, 20);
            this.IDtextBox.TabIndex = 5;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(92, 64);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 20);
            this.NametextBox.TabIndex = 6;
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(92, 112);
            this.AgetextBox.MaxLength = 3;
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.Size = new System.Drawing.Size(100, 20);
            this.AgetextBox.TabIndex = 7;
            // 
            // SPtextBox
            // 
            this.SPtextBox.Location = new System.Drawing.Point(92, 162);
            this.SPtextBox.Name = "SPtextBox";
            this.SPtextBox.Size = new System.Drawing.Size(100, 20);
            this.SPtextBox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 234);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(113, 34);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 40);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(215, 34);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(316, 34);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(416, 34);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 40);
            this.btnReport.TabIndex = 15;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Test1textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Test3textBox);
            this.groupBox1.Controls.Add(this.Test2textBox);
            this.groupBox1.Controls.Add(this.SPtextBox);
            this.groupBox1.Controls.Add(this.AgetextBox);
            this.groupBox1.Controls.Add(this.NametextBox);
            this.groupBox1.Controls.Add(this.IDtextBox);
            this.groupBox1.Controls.Add(this.Examlabel);
            this.groupBox1.Controls.Add(this.SPlabel);
            this.groupBox1.Controls.Add(this.Agelabel);
            this.groupBox1.Controls.Add(this.Namelabel);
            this.groupBox1.Controls.Add(this.IDlabel);
            this.groupBox1.Location = new System.Drawing.Point(24, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 348);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // Test1textBox
            // 
            this.Test1textBox.Location = new System.Drawing.Point(92, 214);
            this.Test1textBox.Name = "Test1textBox";
            this.Test1textBox.Size = new System.Drawing.Size(100, 20);
            this.Test1textBox.TabIndex = 9;
            this.Test1textBox.TextChanged += new System.EventHandler(this.Test1textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Test 3 Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Test 2 Score";
            // 
            // Test3textBox
            // 
            this.Test3textBox.Location = new System.Drawing.Point(92, 312);
            this.Test3textBox.Name = "Test3textBox";
            this.Test3textBox.Size = new System.Drawing.Size(100, 20);
            this.Test3textBox.TabIndex = 11;
            this.Test3textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Test2textBox
            // 
            this.Test2textBox.Location = new System.Drawing.Point(92, 263);
            this.Test2textBox.Name = "Test2textBox";
            this.Test2textBox.Size = new System.Drawing.Size(100, 20);
            this.Test2textBox.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnReport);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Location = new System.Drawing.Point(275, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 94);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buttons";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Agelabel;
        private System.Windows.Forms.Label SPlabel;
        private System.Windows.Forms.Label Examlabel;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox AgetextBox;
        private System.Windows.Forms.TextBox SPtextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Test3textBox;
        private System.Windows.Forms.TextBox Test2textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Test1textBox;
    }
}

