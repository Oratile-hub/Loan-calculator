namespace Loan_calculator
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
            label1 = new Label();
            txtLoanAmount = new TextBox();
            label2 = new Label();
            txtDownPayment = new TextBox();
            label3 = new Label();
            txtInterestRate = new TextBox();
            label4 = new Label();
            txtTerms = new TextBox();
            btnMortage = new Button();
            btnAuto = new Button();
            lblMonthlyPayment = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 77);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Loan Amount";
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Location = new Point(249, 77);
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Size = new Size(150, 31);
            txtLoanAmount.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 150);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 0;
            label2.Text = "Down Payment";
            // 
            // txtDownPayment
            // 
            txtDownPayment.Location = new Point(249, 150);
            txtDownPayment.Name = "txtDownPayment";
            txtDownPayment.Size = new Size(150, 31);
            txtDownPayment.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 207);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 0;
            label3.Text = "Interest Rate";
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(249, 207);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(150, 31);
            txtInterestRate.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 267);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 0;
            label4.Text = "Terms in Years";
            // 
            // txtTerms
            // 
            txtTerms.Location = new Point(249, 267);
            txtTerms.Name = "txtTerms";
            txtTerms.Size = new Size(150, 31);
            txtTerms.TabIndex = 1;
            // 
            // btnMortage
            // 
            btnMortage.BackColor = SystemColors.ControlLightLight;
            btnMortage.Location = new Point(113, 359);
            btnMortage.Name = "btnMortage";
            btnMortage.Size = new Size(112, 34);
            btnMortage.TabIndex = 2;
            btnMortage.Text = "Mortage";
            btnMortage.UseVisualStyleBackColor = false;
            btnMortage.Click += btnMortage_Click;
            // 
            // btnAuto
            // 
            btnAuto.BackColor = SystemColors.ControlLightLight;
            btnAuto.Location = new Point(276, 359);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(112, 34);
            btnAuto.TabIndex = 2;
            btnAuto.Text = "Auto";
            btnAuto.UseVisualStyleBackColor = false;
            btnAuto.Click += btnAuto_Click;
            // 
            // lblMonthlyPayment
            // 
            lblMonthlyPayment.AutoSize = true;
            lblMonthlyPayment.Location = new Point(530, 273);
            lblMonthlyPayment.Name = "lblMonthlyPayment";
            lblMonthlyPayment.Size = new Size(170, 25);
            lblMonthlyPayment.TabIndex = 3;
            lblMonthlyPayment.Text = "Monthly Payment: $";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMonthlyPayment);
            Controls.Add(btnAuto);
            Controls.Add(btnMortage);
            Controls.Add(txtTerms);
            Controls.Add(txtInterestRate);
            Controls.Add(txtDownPayment);
            Controls.Add(txtLoanAmount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Desktop;
            Name = "Form1";
            Text = "Loan Calculators";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLoanAmount;
        private Label label2;
        private TextBox txtDownPayment;
        private Label label3;
        private TextBox txtInterestRate;
        private Label label4;
        private TextBox txtTerms;
        private Button btnMortage;
        private Button btnAuto;
        private Label lblMonthlyPayment;
    }
}