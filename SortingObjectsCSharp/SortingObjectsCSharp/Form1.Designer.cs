namespace SortingObjectsCSharp
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
            this.createBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forenameTxt = new System.Windows.Forms.TextBox();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.custLstBox = new System.Windows.Forms.ListBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(190, 204);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(94, 41);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of birth";
            // 
            // forenameTxt
            // 
            this.forenameTxt.Location = new System.Drawing.Point(190, 59);
            this.forenameTxt.Name = "forenameTxt";
            this.forenameTxt.Size = new System.Drawing.Size(200, 29);
            this.forenameTxt.TabIndex = 4;
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(190, 105);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(200, 29);
            this.surnameTxt.TabIndex = 5;
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(190, 146);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(200, 29);
            this.dobPicker.TabIndex = 6;
            // 
            // custLstBox
            // 
            this.custLstBox.FormattingEnabled = true;
            this.custLstBox.ItemHeight = 24;
            this.custLstBox.Location = new System.Drawing.Point(427, 47);
            this.custLstBox.Name = "custLstBox";
            this.custLstBox.Size = new System.Drawing.Size(326, 340);
            this.custLstBox.TabIndex = 7;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(180, 300);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(104, 57);
            this.sortBtn.TabIndex = 8;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.custLstBox);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.forenameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox forenameTxt;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.ListBox custLstBox;
        private System.Windows.Forms.Button sortBtn;
    }
}

