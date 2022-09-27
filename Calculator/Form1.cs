namespace Calculator
{
    public partial class Form1 : Form
    {
        //表达式变量
        public static string ShowTextBox = "";
        public Form1()
        {
            InitializeComponent();
        }

        public void NumAndSymbol(string num)
        {
            //判断输入的是不是数字或者小数点
            string numAndPoint = "0,1,2,3,4,5,6,7,8,9,.";
            //返回当前字符在字符串中的位置 
            if(numAndPoint.IndexOf(num) >= 0)
            {
                // 说明 是 "0,1,2,3,4,5,6,7,8,9,." 这一堆

            }
            else
            {
                // 说明 不是"0,1,2,3,4,5,6,7,8,9,." 这一堆，而是符号

            }


            //全局表达式变量累计
            ShowTextBox += num;
            result.Text = ShowTextBox;
        }

        private void result_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void n7_Click(object sender, EventArgs e)
        {
            NumAndSymbol("7");
        }

        private void n8_Click(object sender, EventArgs e)
        {
            NumAndSymbol("8");
        }

        private void n9_Click(object sender, EventArgs e)
        {
            NumAndSymbol("9");
        }

        private void n4_Click(object sender, EventArgs e)
        {
            NumAndSymbol("4");
        }

        private void n5_Click(object sender, EventArgs e)
        {
            NumAndSymbol("5");
        }

        private void n6_Click(object sender, EventArgs e)
        {
            NumAndSymbol("6");
        }
        private void n1_Click(object sender, EventArgs e)
        {
            NumAndSymbol("1");
        }

        private void n2_Click(object sender, EventArgs e)
        {
            NumAndSymbol("2");
        }

        private void n3_Click(object sender, EventArgs e)
        {
            NumAndSymbol("3");
        }

        private void n0_Click(object sender, EventArgs e)
        {
            NumAndSymbol("0");
        }

        private void point_Click(object sender, EventArgs e)
        {
            NumAndSymbol(".");
        }
        private void add_Click(object sender, EventArgs e)
        {
            NumAndSymbol("+");
        }
        private void minus_Click(object sender, EventArgs e)
        {
            NumAndSymbol("-");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            NumAndSymbol("*");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            NumAndSymbol("/");
        }

        private void equal_Click(object sender, EventArgs e)
        {

        }
        private void clear_Click(object sender, EventArgs e)
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