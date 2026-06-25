namespace C__Notes_App
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblHeading = new Label();
            lblNoteTitle = new Label();
            txtNoteMessage = new TextBox();
            btnGoBack = new Button();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHeading.Location = new Point(24, 20);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(89, 21);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Note View";
            // 
            // lblNoteTitle
            // 
            lblNoteTitle.BorderStyle = BorderStyle.FixedSingle;
            lblNoteTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNoteTitle.Location = new Point(24, 58);
            lblNoteTitle.Name = "lblNoteTitle";
            lblNoteTitle.Size = new Size(340, 32);
            lblNoteTitle.TabIndex = 1;
            lblNoteTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNoteMessage
            // 
            txtNoteMessage.Location = new Point(24, 106);
            txtNoteMessage.Multiline = true;
            txtNoteMessage.Name = "txtNoteMessage";
            txtNoteMessage.ReadOnly = true;
            txtNoteMessage.ScrollBars = ScrollBars.Vertical;
            txtNoteMessage.Size = new Size(340, 150);
            txtNoteMessage.TabIndex = 2;
            // 
            // btnGoBack
            // 
            btnGoBack.Location = new Point(248, 276);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(116, 32);
            btnGoBack.TabIndex = 3;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 331);
            Controls.Add(btnGoBack);
            Controls.Add(txtNoteMessage);
            Controls.Add(lblNoteTitle);
            Controls.Add(lblHeading);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Second Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Label lblNoteTitle;
        private TextBox txtNoteMessage;
        private Button btnGoBack;
    }
}
