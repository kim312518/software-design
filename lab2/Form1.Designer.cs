namespace lab2
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
            button1 = new Button();
            txtInput = new TextBox();
            lblResult = new Label();
            btnCalculateSum = new Button();
            label1 = new Label();
            txtArrayInput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBase = new TextBox();
            textBox2 = new TextBox();
            lblSumResult = new Label();
            lblFibo = new Label();
            lblPower = new Label();
            btnFibonacii = new Button();
            btnPower = new Button();
            txtExpo = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(346, 53);
            button1.Name = "button1";
            button1.Size = new Size(64, 27);
            button1.TabIndex = 0;
            button1.Text = "Solve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(188, 53);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(152, 23);
            txtInput.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(188, 79);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(45, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result: ";
            lblResult.UseWaitCursor = true;
            lblResult.Click += label1_Click;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(346, 132);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(64, 27);
            btnCalculateSum.TabIndex = 3;
            btnCalculateSum.Text = "Solve";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 56);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 4;
            label1.Text = "Factorial:";
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(188, 133);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(152, 23);
            txtArrayInput.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 133);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 7;
            label2.Text = "Sum of Array Elements :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 245);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 8;
            label3.Text = "Fibonacci Sequence:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 315);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 9;
            label4.Text = "Power Calculation:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 223);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 10;
            label5.Text = "Task 3:";
            label5.Click += label5_Click;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(188, 350);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(124, 23);
            txtBase.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 245);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(188, 159);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(45, 15);
            lblSumResult.TabIndex = 6;
            lblSumResult.Text = "Result: ";
            // 
            // lblFibo
            // 
            lblFibo.AutoSize = true;
            lblFibo.Location = new Point(188, 271);
            lblFibo.Name = "lblFibo";
            lblFibo.Size = new Size(45, 15);
            lblFibo.TabIndex = 13;
            lblFibo.Text = "Result: ";
            // 
            // lblPower
            // 
            lblPower.AutoSize = true;
            lblPower.Location = new Point(180, 376);
            lblPower.Name = "lblPower";
            lblPower.Size = new Size(45, 15);
            lblPower.TabIndex = 14;
            lblPower.Text = "Result: ";
            // 
            // btnFibonacii
            // 
            btnFibonacii.Location = new Point(346, 242);
            btnFibonacii.Name = "btnFibonacii";
            btnFibonacii.Size = new Size(64, 27);
            btnFibonacii.TabIndex = 15;
            btnFibonacii.Text = "Solve";
            btnFibonacii.UseVisualStyleBackColor = true;
            btnFibonacii.Click += btnFibonacii_Click;
            // 
            // btnPower
            // 
            btnPower.Location = new Point(426, 347);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(64, 27);
            btnPower.TabIndex = 16;
            btnPower.Text = "Solve";
            btnPower.UseVisualStyleBackColor = true;
            btnPower.Click += btnPower_Click;
            // 
            // txtExpo
            // 
            txtExpo.Location = new Point(324, 350);
            txtExpo.Name = "txtExpo";
            txtExpo.Size = new Size(96, 23);
            txtExpo.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(180, 332);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 18;
            label6.Text = "Base:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(324, 332);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 19;
            label7.Text = "Exponent:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 426);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtExpo);
            Controls.Add(btnPower);
            Controls.Add(btnFibonacii);
            Controls.Add(lblPower);
            Controls.Add(lblFibo);
            Controls.Add(textBox2);
            Controls.Add(txtBase);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblSumResult);
            Controls.Add(txtArrayInput);
            Controls.Add(label1);
            Controls.Add(btnCalculateSum);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtInput;
        private Label lblResult;
        private Button btnCalculateSum;
        private Label label1;
        private TextBox txtArrayInput;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBase;
        private TextBox textBox2;
        private Label lblSumResult;
        private Label lblFibo;
        private Label lblPower;
        private Button btnFibonacii;
        private Button btnPower;
        private TextBox txtExpo;
        private Label label6;
        private Label label7;
    }
}
