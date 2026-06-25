namespace C__Notes_App
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
            lblTitle = new Label();
            lblMessage = new Label();
            txtTitle = new TextBox();
            txtMessage = new TextBox();
            notesGridView = new DataGridView();
            btnNew = new Button();
            btnSave = new Button();
            btnRead = new Button();
            btnDelete = new Button();
            btnOpenForm2 = new Button();
            ((System.ComponentModel.ISupportInitialize)notesGridView).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(24, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(24, 82);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(53, 15);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Message";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(24, 42);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(286, 23);
            txtTitle.TabIndex = 1;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(24, 100);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ScrollBars = ScrollBars.Vertical;
            txtMessage.Size = new Size(286, 160);
            txtMessage.TabIndex = 3;
            // 
            // notesGridView
            // 
            notesGridView.AllowUserToAddRows = false;
            notesGridView.AllowUserToDeleteRows = false;
            notesGridView.AllowUserToResizeColumns = false;
            notesGridView.AllowUserToResizeRows = false;
            notesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            notesGridView.Location = new Point(336, 42);
            notesGridView.MultiSelect = false;
            notesGridView.Name = "notesGridView";
            notesGridView.ReadOnly = true;
            notesGridView.RowHeadersVisible = false;
            notesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            notesGridView.Size = new Size(220, 218);
            notesGridView.TabIndex = 4;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(24, 286);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(92, 32);
            btnNew.TabIndex = 5;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(122, 286);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 32);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(220, 286);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(92, 32);
            btnRead.TabIndex = 7;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(318, 286);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 32);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnOpenForm2
            // 
            btnOpenForm2.Location = new Point(416, 286);
            btnOpenForm2.Name = "btnOpenForm2";
            btnOpenForm2.Size = new Size(140, 32);
            btnOpenForm2.TabIndex = 9;
            btnOpenForm2.Text = "Open Second Form";
            btnOpenForm2.UseVisualStyleBackColor = true;
            btnOpenForm2.Click += btnOpenForm2_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 351);
            Controls.Add(btnOpenForm2);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(notesGridView);
            Controls.Add(txtMessage);
            Controls.Add(txtTitle);
            Controls.Add(lblMessage);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notes App";
            ((System.ComponentModel.ISupportInitialize)notesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblMessage;
        private TextBox txtTitle;
        private TextBox txtMessage;
        private DataGridView notesGridView;
        private Button btnNew;
        private Button btnSave;
        private Button btnRead;
        private Button btnDelete;
        private Button btnOpenForm2;
    }
}
