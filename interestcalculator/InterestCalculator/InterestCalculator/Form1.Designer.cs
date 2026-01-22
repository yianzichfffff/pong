namespace InterestCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 0;
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Interest Rate";
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(42, 67);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(165, 20);
            this.txtInterest.TabIndex = 4;
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(42, 171);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(165, 20);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(42, 118);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(165, 20);
            this.txtMonths.TabIndex = 6;
            this.txtMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(235, 212);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 36);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(456, 335);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtMonths);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interest Rate";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.Button btnCalculate;
    }
}

