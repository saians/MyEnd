namespace SubProjForFirstRace
    {
    partial class GuyForm
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.atifCashLabel = new System.Windows.Forms.Label();
            this.molanaCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // atifCashLabel
            // 
            this.atifCashLabel.AutoSize = true;
            this.atifCashLabel.Location = new System.Drawing.Point(42, 35);
            this.atifCashLabel.Name = "atifCashLabel";
            this.atifCashLabel.Size = new System.Drawing.Size(35, 13);
            this.atifCashLabel.TabIndex = 0;
            this.atifCashLabel.Text = "label1";
            // 
            // molanaCashLabel
            // 
            this.molanaCashLabel.AutoSize = true;
            this.molanaCashLabel.Location = new System.Drawing.Point(42, 65);
            this.molanaCashLabel.Name = "molanaCashLabel";
            this.molanaCashLabel.Size = new System.Drawing.Size(35, 13);
            this.molanaCashLabel.TabIndex = 1;
            this.molanaCashLabel.Text = "label2";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(42, 98);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bankCashLabel.TabIndex = 2;
            this.bankCashLabel.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "Give atif 60SEK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 61);
            this.button2.TabIndex = 4;
            this.button2.Text = "Recieve 10 from saif";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.molanaCashLabel);
            this.Controls.Add(this.atifCashLabel);
            this.Name = "GuyForm";
            this.Text = "GuyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label atifCashLabel;
        private System.Windows.Forms.Label molanaCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        }
    }