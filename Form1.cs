namespace Simple_Calculator
{
    public partial class Form1 : Form

    {
        string operation;
        double result, num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "0";
            }
            else { textBox1.Text = textBox1.Text + "0"; }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "1";
            }
            else { textBox1.Text = textBox1.Text + "1"; }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "2";
            }
            else { textBox1.Text = textBox1.Text + "2"; }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "3";
            }
            else { textBox1.Text = textBox1.Text + "3"; }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "4";
            }
            else { textBox1.Text = textBox1.Text + "4"; }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "5";
            }
            else { textBox1.Text = textBox1.Text + "5"; }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "6";
            }
            else { textBox1.Text = textBox1.Text + "6"; }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "7";
            }
            else { textBox1.Text = textBox1.Text + "7"; }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "8";
            }
            else { textBox1.Text = textBox1.Text + "8"; }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "9";
            }
            else { textBox1.Text = textBox1.Text + "9"; }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "*";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "-";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "+";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "/";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            if (operation == "+")
            {
                result = num1 + num2;
                textBox1.Text = Convert.ToString(result);
                num1 = result;
            }
            if (operation == "-")
            {
                result = num1 - num2;
                textBox1.Text = Convert.ToString(result);
                num1 = result;
            }
            if (operation == "*")
            {
                result = num1 * num2;
                textBox1.Text = Convert.ToString(result);
                num1 = result;
            }
         if (operation == "/")
                    {
                        if (num2 == 0) { textBox1.Text = "Cannot divide by zero"; }
                        else
                        {
                            result = num1 / num2;
                            textBox1.Text = Convert.ToString(result);
                            num1 = result;
                        }

                    }
                }
            }
        }
