namespace lab7
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
            lblPageNumber = new Label();
            btnNextPage = new Button();
            ListBookBox = new ListBox();
            btnPreviousPage = new Button();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnExportBooks = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageNumber.Location = new Point(374, 386);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(55, 23);
            lblPageNumber.TabIndex = 0;
            lblPageNumber.Text = "label1";
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(532, 380);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(94, 29);
            btnNextPage.TabIndex = 1;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // ListBookBox
            // 
            ListBookBox.FormattingEnabled = true;
            ListBookBox.Location = new Point(147, 174);
            ListBookBox.Name = "ListBookBox";
            ListBookBox.Size = new Size(510, 184);
            ListBookBox.TabIndex = 2;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(181, 380);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(94, 29);
            btnPreviousPage.TabIndex = 3;
            btnPreviousPage.Text = "Previous";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(662, 81);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 93);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 5;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 130);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 6;
            label2.Text = "Title";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(218, 90);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(408, 27);
            txtAuthorName.TabIndex = 7;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(218, 123);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(408, 27);
            txtBookTitle.TabIndex = 8;
            // 
            // btnExportBooks
            // 
            btnExportBooks.Location = new Point(663, 151);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(94, 29);
            btnExportBooks.TabIndex = 9;
            btnExportBooks.Text = "Export";
            btnExportBooks.UseVisualStyleBackColor = true;
            btnExportBooks.Click += btnExportBooks_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(663, 116);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(btnExportBooks);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnPreviousPage);
            Controls.Add(ListBookBox);
            Controls.Add(btnNextPage);
            Controls.Add(lblPageNumber);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageNumber;
        private Button btnNextPage;
        private ListBox ListBookBox;
        private Button btnPreviousPage;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnExportBooks;
        private Button btnSearch;
    }
}
