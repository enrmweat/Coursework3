namespace Coursework3
{
    partial class studentdetails
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.plEdit = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.plEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(210, 65);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(210, 104);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(100, 20);
            this.txtMiddleName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(210, 144);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(210, 180);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(100, 20);
            this.txtDOB.TabIndex = 3;
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(210, 220);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(100, 20);
            this.txtgender.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCount);
            this.panel1.Controls.Add(this.btn_first);
            this.panel1.Controls.Add(this.btn_prev);
            this.panel1.Controls.Add(this.btn_Last);
            this.panel1.Controls.Add(this.btn_next);
            this.panel1.Location = new System.Drawing.Point(131, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 38);
            this.panel1.TabIndex = 10;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(94, 8);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(85, 20);
            this.txtCount.TabIndex = 11;
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(12, 6);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(37, 23);
            this.btn_first.TabIndex = 3;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(55, 6);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(32, 23);
            this.btn_prev.TabIndex = 2;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(229, 6);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(30, 23);
            this.btn_Last.TabIndex = 1;
            this.btn_Last.Text = ">>";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_next
            // 
            this.btn_next.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_next.Location = new System.Drawing.Point(188, 6);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(38, 23);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // plEdit
            // 
            this.plEdit.Controls.Add(this.btn_save);
            this.plEdit.Controls.Add(this.btn_update);
            this.plEdit.Location = new System.Drawing.Point(177, 309);
            this.plEdit.Name = "plEdit";
            this.plEdit.Size = new System.Drawing.Size(200, 100);
            this.plEdit.TabIndex = 11;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(105, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(9, 12);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // studentdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 421);
            this.Controls.Add(this.plEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "studentdetails";
            this.Text = "studentdetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Panel plEdit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
    }
}