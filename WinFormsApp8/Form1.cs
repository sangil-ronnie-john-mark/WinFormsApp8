namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPin.Text == "0000") {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
            } else
            {
                MessageBox.Show("Invalid Username or Password");
            }

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                txtPin.UseSystemPasswordChar = false;
                txtPin.PasswordChar = '\0';
            }
            else
            {
                txtPin.UseSystemPasswordChar = true;
            }
        }
    }
}