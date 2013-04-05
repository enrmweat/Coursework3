namespace Coursework3
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
            this.btnstudentdetails = new System.Windows.Forms.Button();
            this.studentsDataSet = new Coursework3.StudentsDataSet();
            this.studentstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentstblTableAdapter = new Coursework3.StudentsDataSetTableAdapters.StudentstblTableAdapter();
            this.tableAdapterManager = new Coursework3.StudentsDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentstblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstudentdetails
            // 
            this.btnstudentdetails.Location = new System.Drawing.Point(206, 276);
            this.btnstudentdetails.Name = "btnstudentdetails";
            this.btnstudentdetails.Size = new System.Drawing.Size(75, 23);
            this.btnstudentdetails.TabIndex = 0;
            this.btnstudentdetails.Text = "Edit Records";
            this.btnstudentdetails.UseVisualStyleBackColor = true;
            this.btnstudentdetails.Click += new System.EventHandler(this.btnstudentdetails_Click);
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "StudentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentstblBindingSource
            // 
            this.studentstblBindingSource.DataMember = "Studentstbl";
            this.studentstblBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentstblTableAdapter
            // 
            this.studentstblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentstblTableAdapter = this.studentstblTableAdapter;
            this.tableAdapterManager.UpdateOrder = Coursework3.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 380);
            this.Controls.Add(this.btnstudentdetails);
            this.Name = "Form1";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentstblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstudentdetails;
        private StudentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource studentstblBindingSource;
        private StudentsDataSetTableAdapters.StudentstblTableAdapter studentstblTableAdapter;
        private StudentsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

