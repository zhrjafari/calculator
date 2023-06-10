namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int number1;
        int number2;
        int result;
        string str = "";

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            if (str != "")
                button11_Click(sender, e);
            else
                number1 = int.Parse(textBox1.Text);

            textBox1.Text = "";
            str = "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            if (str != "")
                button11_Click(sender, e);
            else
                number1 = int.Parse(textBox1.Text);

            textBox1.Text = "";
            str = "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            if (str != "")
                button11_Click(sender, e);
            else
                number1 = int.Parse(textBox1.Text);

            textBox1.Text = "";
            str = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            if (str != "")
                button11_Click(sender, e);
            else
                number1 = int.Parse(textBox1.Text);

            textBox1.Text = "";
            str = "*";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            number2 = int.Parse(textBox1.Text);

            switch (str)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
            }
            textBox1.Text = result.ToString();
            number1 = result;
            str = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            str = "";
        }
    }
}