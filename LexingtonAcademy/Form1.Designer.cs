namespace LexingtonAcademy
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
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clbClasses = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(724, 227);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(394, 47);
            this.tbFirstName.TabIndex = 0;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(724, 308);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(394, 47);
            this.tbLastName.TabIndex = 2;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(551, 230);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(167, 41);
            this.FirstNameLabel.TabIndex = 3;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Classes:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(551, 696);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(398, 96);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1043, 696);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(398, 96);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // clbClasses
            // 
            this.clbClasses.FormattingEnabled = true;
            this.clbClasses.Items.AddRange(new object[] {
            " Art",
            "Math",
            "P.E.",
            "Science",
            "History",
            "Spanish"});
            this.clbClasses.Location = new System.Drawing.Point(724, 387);
            this.clbClasses.Name = "clbClasses";
            this.clbClasses.Size = new System.Drawing.Size(401, 268);
            this.clbClasses.TabIndex = 9;
            this.clbClasses.SelectedIndexChanged += new System.EventHandler(this.clbClasses_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2283, 948);
            this.Controls.Add(this.clbClasses);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbFirstName;
        private TextBox tbLastName;
        private Label FirstNameLabel;
        private Label label2;
        private Label label3;
        private Button btnSave;
        private Button btnCancel;
        private CheckedListBox clbClasses;
    }
}