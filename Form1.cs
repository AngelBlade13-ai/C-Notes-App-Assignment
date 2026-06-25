namespace C__Notes_App
{
    public partial class Form1 : Form
    {
        private readonly System.Data.DataTable table = new();

        public Form1()
        {
            InitializeComponent();
            InitializeNotesTable();
        }

        private void InitializeNotesTable()
        {
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Message", typeof(string));

            notesGridView.DataSource = table;
            notesGridView.Columns["Message"]!.Visible = false;
            notesGridView.Columns["Title"]!.Width = notesGridView.Width - 3;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearInputs();
            txtTitle.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string message = txtMessage.Text.Trim();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show(
                    "Please enter both a title and a message before saving.",
                    "Missing note information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            table.Rows.Add(title, message);
            ClearInputs();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int rowIndex = GetSelectedRowIndex();

            if (rowIndex < 0)
            {
                ShowSelectNoteMessage();
                return;
            }

            txtTitle.Text = table.Rows[rowIndex]["Title"].ToString();
            txtMessage.Text = table.Rows[rowIndex]["Message"].ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = GetSelectedRowIndex();

            if (rowIndex < 0)
            {
                ShowSelectNoteMessage();
                return;
            }

            table.Rows.RemoveAt(rowIndex);
            ClearInputs();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string message = txtMessage.Text.Trim();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show(
                    "Please enter or read a note before opening it in Form2.",
                    "No note to display",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            Form2 secondForm = new(title, message);
            secondForm.Show();
        }

        private int GetSelectedRowIndex()
        {
            if (notesGridView.CurrentCell == null)
            {
                return -1;
            }

            int rowIndex = notesGridView.CurrentCell.RowIndex;
            return rowIndex >= 0 && rowIndex < table.Rows.Count ? rowIndex : -1;
        }

        private void ClearInputs()
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private static void ShowSelectNoteMessage()
        {
            MessageBox.Show(
                "Please select a note first.",
                "No note selected",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
