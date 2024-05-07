namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hoppiesValidationLabel.Text = "hello";
            //validRegisterationLabel.Text = "hello";
            if (nameTextBox.Text.Length < 5)
            {
                nameValidationLabel.Visible = true;
            }
            else
            {
                nameValidationLabel.Visible = false;
            }

            if (!emailTextBox.Text.Contains('@'))
            {
                emailValidationLabel.Visible = true;
            }
            else
            {
                emailValidationLabel.Visible = false;
            }

            if (!footballChB.Checked && !tennisChB.Checked && !pingChB.Checked)
            {
                hoppyValidationLabel.Visible = true;
            }
            else
            {
                hoppyValidationLabel.Visible = false;
            }

            if (!nameValidationLabel.Visible && !emailValidationLabel.Visible && !hoppyValidationLabel.Visible)
            {
                thanksLabel.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
