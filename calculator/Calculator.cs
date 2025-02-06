namespace calculator
{
    public partial class Calculator : Form
    {
        double stat;
        double prvstat;
        string op;

        public Calculator()
        {
            InitializeComponent();
            pre.Text = string.Empty;
            prv.Text = string.Empty;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            pre.Text += "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            pre.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            pre.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            pre.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            pre.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            pre.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            pre.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            pre.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            pre.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            pre.Text += "9";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            pre.Text += ".";
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (pre.Text.Length > 0)
                pre.Text = Convert.ToString(Convert.ToInt64(pre.Text) / 10);
        }

        private void clr_Click(object sender, EventArgs e)
        {
            pre.Text = string.Empty;
        }

        private void sum_Click(object sender, EventArgs e)
        {
            op = "+";
            stat = Convert.ToDouble(pre.Text);
            prv.Text = pre.Text + "+";
            pre.Text = string.Empty;
        }

        private void mins_Click(object sender, EventArgs e)
        {
            op = "-";
            stat = Convert.ToDouble(pre.Text);
            prv.Text = pre.Text + "-";
            pre.Text = string.Empty;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            op = "*";
            stat = Convert.ToDouble(pre.Text);
            prv.Text = pre.Text + "*";
            pre.Text = string.Empty;
        }

        private void div_Click(object sender, EventArgs e)
        {
            op = "/";
            stat = Convert.ToDouble(pre.Text);
            prv.Text = pre.Text + "/";
            pre.Text = string.Empty;
        }

        private void pow_Click(object sender, EventArgs e)
        {
            op = "^";
            stat = Convert.ToDouble(pre.Text);
            prv.Text = pre.Text + "^";
            pre.Text = string.Empty;
        }

        private void prsnt_Click(object sender, EventArgs e)
        {
            op = "%";
            stat = Convert.ToDouble(pre.Text);
            prv.Text = pre.Text + "%";
            pre.Text = string.Empty;
        }
        private void sqrt_Click(object sender, EventArgs e)
        {
            op = "sqr";
            stat = Convert.ToDouble(pre.Text);
            prv.Text = "sqrt (" + pre.Text + ")";
            pre.Text = string.Empty;
        }

        private void calc_Click(object sender, EventArgs e)
        {
            if (op.Length > 0 && pre.Text.Length > 0)
                switch (op)
                {
                case "+":
                    stat += Convert.ToDouble(pre.Text);
                    prv.Text = prv.Text + pre.Text;
                    pre.Text = Convert.ToString(stat);
                    break;
                case "-":
                    stat -= Convert.ToDouble(pre.Text);
                    prv.Text = prv.Text + pre.Text;
                    pre.Text = Convert.ToString(stat);
                    break;
                case "*":
                    stat *= Convert.ToDouble(pre.Text);
                    prv.Text = prv.Text + pre.Text;
                    pre.Text = Convert.ToString(stat);
                    break;
                case "/":
                    stat /= Convert.ToDouble(pre.Text);
                    prv.Text = prv.Text + pre.Text;
                    pre.Text = Convert.ToString(stat);
                    break;
                case "^":
                    stat = Math.Pow(stat,Convert.ToDouble(pre.Text));
                    prv.Text = prv.Text + pre.Text;
                    pre.Text = Convert.ToString(stat);
                    break;
                case "sqr":
                    stat = Math.Sqrt(stat);
                    pre.Text = Convert.ToString(stat);
                    break;
                }
        }
    }
}
