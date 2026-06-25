namespace C__Notes_App
{
    public partial class Form2 : Form
    {
        public Form2(string title, string message)
        {
            InitializeComponent();
            lblNoteTitle.Text = title;
            txtNoteMessage.Text = message;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
