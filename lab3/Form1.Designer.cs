namespace lab3
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
            btnShowInfo_Click = new Button();
            SuspendLayout();
            // 
            // btnShowInfo_Click
            // 
            btnShowInfo_Click.Location = new Point(122, 129);
            btnShowInfo_Click.Name = "btnShowInfo_Click";
            btnShowInfo_Click.Size = new Size(66, 23);
            btnShowInfo_Click.TabIndex = 0;
            btnShowInfo_Click.Text = "Show";
            btnShowInfo_Click.UseVisualStyleBackColor = true;
            btnShowInfo_Click.Click += btnShowInfo_Click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 257);
            Controls.Add(btnShowInfo_Click);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowInfo_Click;
    }
}
