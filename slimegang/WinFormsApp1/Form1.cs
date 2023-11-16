namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("vbucks have been transferd to account");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            var newform = new Form2();
            newform.ShowDialog();
        }
    }
}