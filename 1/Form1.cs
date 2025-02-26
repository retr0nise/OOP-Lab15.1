namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.num1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            this.num2.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(this.num1.Text);
            double y = double.Parse(this.num2.Text);
            double result = Math.Pow((x+1)/(x-1),x)+18*x * y*y;
            label1.Text = result.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
            }
            if (e.KeyChar == '.')
            {
                if (num1.Text == "" && num1.Focused)
                {
                    e.Handled = true;

                }
                if (num1.Text.IndexOf('.') != -1 && num1.Focused)
                {
                    e.Handled = true;
                }
                return;

               }
            if (e.KeyChar == '-')
            {
                if (num1.Text != "" && num1.Focused)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1.Focus();
                return;
            }
            e.Handled = true;

            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
            }
            if (e.KeyChar == '.')
            {
                if (num2.Text == "" && num2.Focused)
                {
                    e.Handled = true;

                }
                if (num2.Text != "" && num2.Focused)
                {
                    e.Handled = true;
                }
                return;
            }
            
            if (e.KeyChar == '-')
            {
                if (num2.Text.IndexOf('-') != -1 && num2.Focused)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1.Focus();
                return;
            }
            e.Handled = true;
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
