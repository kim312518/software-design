namespace lab6
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
            btnFetchBooks = new Button();
            ListBoxBooks = new ListBox();
            lblTitle = new Label();
            btnAddBook = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            progressBar = new ProgressBar();
            txtBookID = new TextBox();
            label1 = new Label();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(626, 194);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(94, 29);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "Fetch";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // ListBoxBooks
            // 
            ListBoxBooks.FormattingEnabled = true;
            ListBoxBooks.Location = new Point(116, 227);
            ListBoxBooks.Name = "ListBoxBooks";
            ListBoxBooks.Size = new Size(631, 244);
            ListBoxBooks.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(194, 77);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Title";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(626, 55);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 29);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(626, 90);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(626, 124);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(626, 159);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search ";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(250, 173);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(349, 29);
            progressBar.TabIndex = 10;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(250, 107);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(349, 27);
            txtBookID.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 110);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 11;
            label1.Text = "Book ID";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(250, 74);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(349, 27);
            txtBookTitle.TabIndex = 5;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(250, 140);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(349, 27);
            txtAuthorName.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 147);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 13;
            label2.Text = "Author";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 545);
            Controls.Add(txtAuthorName);
            Controls.Add(label2);
            Controls.Add(txtBookID);
            Controls.Add(label1);
            Controls.Add(progressBar);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(lblTitle);
            Controls.Add(ListBoxBooks);
            Controls.Add(btnFetchBooks);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetchBooks;
        private ListBox ListBoxBooks;
        private Label txtAuthor;

        private Label lblTitle;
        private Button btnAddBook;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private ProgressBar progressBar;
        private TextBox txtBookID;
        private Label label1;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private Label label2;
    }
}
