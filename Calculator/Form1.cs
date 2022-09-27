namespace Calculator
{
    public partial class Form1 : Form
    {
        //表达式变量
        public static string ShowResult = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void result_TextChanged(object sender, EventArgs e)
        {

        }
        private void n7_Click(object sender, EventArgs e)
        {
            ShowResult += "7";
            result.Text = ShowResult;
        }

        private void n8_Click(object sender, EventArgs e)
        {
            ShowResult += "8";
            result.Text = ShowResult;
        }

        private void n9_Click(object sender, EventArgs e)
        {
            ShowResult += "9";
            result.Text = ShowResult;
        }

        private void n4_Click(object sender, EventArgs e)
        {
            ShowResult += "4";
            result.Text = ShowResult;
        }

        private void n5_Click(object sender, EventArgs e)
        {
            ShowResult += "5";
            result.Text = ShowResult;
        }

        private void n6_Click(object sender, EventArgs e)
        {
            ShowResult += "6";
            result.Text = ShowResult;
        }
        private void n1_Click(object sender, EventArgs e)
        {
            ShowResult += "1";
            result.Text = ShowResult;
        }

        private void n2_Click(object sender, EventArgs e)
        {
            ShowResult += "2";
            result.Text = ShowResult;
        }

        private void n3_Click(object sender, EventArgs e)
        {
            ShowResult += "3";
            result.Text = ShowResult;
        }

        private void n0_Click(object sender, EventArgs e)
        {
            ShowResult += "0";
            result.Text = ShowResult;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            
        }

        private void point_Click(object sender, EventArgs e)
        {
            // 只能加一次
            result.Text = result.Text + ".";
        }
        private void add_Click(object sender, EventArgs e)
        {

        }
        private void minus_Click(object sender, EventArgs e)
        {

        }

        private void multiply_Click(object sender, EventArgs e)
        {

        }

        private void divide_Click(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {

        }

        private void BIN_Click(object sender, EventArgs e)
        {

        }

        private void DEC_Click(object sender, EventArgs e)
        {

        }

        private void LOC_Click(object sender, EventArgs e)
        {

        }

    }
}