namespace BMS
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
            this.report = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.assignButton = new System.Windows.Forms.Button();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nextShiftbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(17, 139);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(273, 112);
            this.report.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.assignButton);
            this.panel1.Controls.Add(this.shifts);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 123);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Worker bee job";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shifts";
            // 
            // assignButton
            // 
            this.assignButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.assignButton.Location = new System.Drawing.Point(12, 95);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(137, 23);
            this.assignButton.TabIndex = 2;
            this.assignButton.Text = "Assign this job to bee";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(12, 69);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(76, 20);
            this.shifts.TabIndex = 1;
            this.shifts.Tag = "";
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // nextShiftbutton
            // 
            this.nextShiftbutton.Location = new System.Drawing.Point(215, 12);
            this.nextShiftbutton.Name = "nextShiftbutton";
            this.nextShiftbutton.Size = new System.Drawing.Size(75, 123);
            this.nextShiftbutton.TabIndex = 2;
            this.nextShiftbutton.Text = "Work the next shift";
            this.nextShiftbutton.UseVisualStyleBackColor = true;
            this.nextShiftbutton.Click += new System.EventHandler(this.nextShiftbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 262);
            this.Controls.Add(this.nextShiftbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.report);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox report;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button nextShiftbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

