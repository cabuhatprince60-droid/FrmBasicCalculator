namespace FrmBasicCalculator
{
    partial class FrmBasicCalculator
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
            this.btnCompute = new System.Windows.Forms.Button();
            this.rtbTotal = new System.Windows.Forms.RichTextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.AccessibleDescription = "Calculate the result using the selected operation.";
            this.btnCompute.AccessibleName = "Compute result";
            this.btnCompute.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCompute.Location = new System.Drawing.Point(73, 272);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(116, 43);
            this.btnCompute.TabIndex = 3;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // rtbTotal
            // 
            this.rtbTotal.AccessibleDescription = "Displays the result of the calculation.";
            this.rtbTotal.AccessibleName = "Calculation result";
            this.rtbTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.rtbTotal.BackColor = System.Drawing.Color.Black;
            this.rtbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rtbTotal.Location = new System.Drawing.Point(35, 206);
            this.rtbTotal.Name = "rtbTotal";
            this.rtbTotal.ReadOnly = true;
            this.rtbTotal.Size = new System.Drawing.Size(203, 60);
            this.rtbTotal.TabIndex = 4;
            this.rtbTotal.Text = "";
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.AccessibleDescription = "Enter the second number.";
            this.txtSecondNumber.AccessibleName = "Second number";
            this.txtSecondNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondNumber.Location = new System.Drawing.Point(35, 161);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(203, 26);
            this.txtSecondNumber.TabIndex = 2;
            // 
            // cmbOperator
            // 
            this.cmbOperator.AccessibleDescription = "Select the arithmetic operation.";
            this.cmbOperator.AccessibleName = "Operation";
            this.cmbOperator.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.cmbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(73, 110);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(121, 32);
            this.cmbOperator.TabIndex = 1;
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.AccessibleDescription = "Enter the first number.";
            this.txtFirstNumber.AccessibleName = "First number";
            this.txtFirstNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNumber.Location = new System.Drawing.Point(35, 63);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(203, 26);
            this.txtFirstNumber.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AccessibleName = "Basic Calculator";
            this.lblTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(49, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 25);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Basic Calculator";
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AccessibleName = "First number";
            this.lblFirstNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(35, 47);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(64, 13);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "&First number";
            // 
            // lblOperator
            // 
            this.lblOperator.AccessibleName = "Operation";
            this.lblOperator.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(70, 94);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(53, 13);
            this.lblOperator.TabIndex = 2;
            this.lblOperator.Text = "&Operation";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AccessibleName = "Second number";
            this.lblSecondNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(35, 145);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(82, 13);
            this.lblSecondNumber.TabIndex = 4;
            this.lblSecondNumber.Text = "&Second number";
            // 
            // lblResult
            // 
            this.lblResult.AccessibleName = "Result";
            this.lblResult.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(32, 190);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result";
            this.lblResult.UseMnemonic = false;
            // 
            // FrmBasicCalculator
            // 
            this.AcceptButton = this.btnCompute;
            this.AccessibleDescription = "A calculator for adding, subtracting, multiplying, and dividing two numbers.";
            this.AccessibleName = "Basic Calculator";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 352);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.rtbTotal);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmBasicCalculator";
            this.Text = "Basic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.RichTextBox rtbTotal;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblResult;
    }
}

