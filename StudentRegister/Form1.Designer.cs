
namespace StudentRegister
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBoxAge = new System.Windows.Forms.TextBox();
            this.TBoxGrade = new System.Windows.Forms.TextBox();
            this.InsertBT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.UpBT = new System.Windows.Forms.Button();
            this.DeBT = new System.Windows.Forms.Button();
            this.SeBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student Name";
            // 
            // TBoxName
            // 
            this.TBoxName.Location = new System.Drawing.Point(143, 115);
            this.TBoxName.Name = "TBoxName";
            this.TBoxName.Size = new System.Drawing.Size(248, 23);
            this.TBoxName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Age";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Student Grede ";
            // 
            // TBoxAge
            // 
            this.TBoxAge.Location = new System.Drawing.Point(143, 156);
            this.TBoxAge.Name = "TBoxAge";
            this.TBoxAge.Size = new System.Drawing.Size(248, 23);
            this.TBoxAge.TabIndex = 1;
            // 
            // TBoxGrade
            // 
            this.TBoxGrade.Location = new System.Drawing.Point(143, 194);
            this.TBoxGrade.Name = "TBoxGrade";
            this.TBoxGrade.Size = new System.Drawing.Size(248, 23);
            this.TBoxGrade.TabIndex = 7;
            // 
            // InsertBT
            // 
            this.InsertBT.BackColor = System.Drawing.Color.LawnGreen;
            this.InsertBT.Location = new System.Drawing.Point(143, 245);
            this.InsertBT.Name = "InsertBT";
            this.InsertBT.Size = new System.Drawing.Size(75, 23);
            this.InsertBT.TabIndex = 4;
            this.InsertBT.Text = "Insert";
            this.InsertBT.UseVisualStyleBackColor = false;
            this.InsertBT.Click += new System.EventHandler(this.InsertBT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(542, 164);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Student ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 63);
            this.panel1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(169, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "Student Recod Data";
            // 
            // UpBT
            // 
            this.UpBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UpBT.Location = new System.Drawing.Point(251, 245);
            this.UpBT.Name = "UpBT";
            this.UpBT.Size = new System.Drawing.Size(75, 23);
            this.UpBT.TabIndex = 11;
            this.UpBT.Text = "Update";
            this.UpBT.UseVisualStyleBackColor = false;
            this.UpBT.Click += new System.EventHandler(this.UpBT_Click);
            // 
            // DeBT
            // 
            this.DeBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeBT.Location = new System.Drawing.Point(366, 245);
            this.DeBT.Name = "DeBT";
            this.DeBT.Size = new System.Drawing.Size(75, 23);
            this.DeBT.TabIndex = 12;
            this.DeBT.Text = "Delete";
            this.DeBT.UseVisualStyleBackColor = false;
            this.DeBT.Click += new System.EventHandler(this.DeBT_Click);
            // 
            // SeBT
            // 
            this.SeBT.BackColor = System.Drawing.SystemColors.GrayText;
            this.SeBT.Location = new System.Drawing.Point(408, 69);
            this.SeBT.Name = "SeBT";
            this.SeBT.Size = new System.Drawing.Size(75, 23);
            this.SeBT.TabIndex = 13;
            this.SeBT.Text = "Search";
            this.SeBT.UseVisualStyleBackColor = false;
            this.SeBT.Click += new System.EventHandler(this.SeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(742, 472);
            this.Controls.Add(this.SeBT);
            this.Controls.Add(this.DeBT);
            this.Controls.Add(this.UpBT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.InsertBT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxGrade);
            this.Controls.Add(this.TBoxAge);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TBoxName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBoxAge;
        private System.Windows.Forms.TextBox TBoxGrade;
        private System.Windows.Forms.Button InsertBT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UpBT;
        private System.Windows.Forms.Button DeBT;
        private System.Windows.Forms.Button SeBT;
    }
}

