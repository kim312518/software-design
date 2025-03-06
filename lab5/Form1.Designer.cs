namespace lab5
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
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            listBoxBooks = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnShow = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            label4 = new Label();
            txtBookID = new TextBox();
            btnInsert = new Button();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(219, 46);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(354, 27);
            txtAuthorName.TabIndex = 1;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(219, 79);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(354, 27);
            txtBookTitle.TabIndex = 2;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(121, 202);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(493, 184);
            listBoxBooks.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 49);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 82);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 5;
            label2.Text = "Title";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(648, 46);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 6;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(648, 185);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(648, 115);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(648, 150);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 115);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 12;
            label4.Text = "Book ID";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(219, 112);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(354, 27);
            txtBookID.TabIndex = 10;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(648, 82);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInsert);
            Controls.Add(label4);
            Controls.Add(txtBookID);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnShow);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxBooks);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private ListBox listBoxBooks;
        private Label label1;
        private Label label2;
        private Button btnShow;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnDelete;
        private Label label4;
        private TextBox txtBookID;
        private Button btnInsert;
    }
}
