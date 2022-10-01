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
                //说明 是 "0,1,2,3,4,5,6,7,8,9,." 这一堆
                ShowTextBox += num;
            }
            else
            {
                //说明 不是"0,1,2,3,4,5,6,7,8,9,." 这一堆，而是符号
                //如果默认没有输入数字，点击加减乘除不走解析逻辑
                if(!string.IsNullOrEmpty(ShowTextBox))
                {
                    //不为空的时候 非数字 判断最后一位 substing（截取的开始位置，截取长度），也就是说 截取最后一位
                    string lastString = ShowTextBox.Substring(ShowTextBox.Length - 1, 1);
                    //再次核查位置
                    if(numAndPoint.IndexOf(lastString) >= 0)
                    {
                        //如果最后是一个数字，则把之前的算一遍，再追加新的计算符号
                        ShowTextBox = Operation(num);
                    }
                }

            }
            //全局表达式变量累计    
            result2.Text = ShowTextBox;
        }

        public string Operation(string symbol)
        {
            if (ShowTextBox.Contains("+"))
            {
                // split方法切割字符串  1 + 1  拆成  1 ，1 ，new char 是制定符号；  然后再给一个参数，
                // StringSplitOptions.RemoveEmptyEntries 排除空格空隙 排除空值
                string[] way = ShowTextBox.Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
                // left way right
                //如果是字符串1+字符串1 会得到 11，要变成数值类型向家才会执行数学计算。
                ShowTextBox = (Convert.ToDecimal(way[0]) + Convert.ToDecimal(way[1])).ToString();
            }
            else if (ShowTextBox.Contains("－"))
            {

                string[] way = ShowTextBox.Split(new char[] { '－' }, StringSplitOptions.RemoveEmptyEntries);
                ShowTextBox = (Convert.ToDecimal(way[0]) - Convert.ToDecimal(way[1])).ToString();
            }
            else if (ShowTextBox.Contains("*"))
            {
                string[] way = ShowTextBox.Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries);
                ShowTextBox = (Convert.ToDecimal(way[0]) * Convert.ToDecimal(way[1])).ToString();
            }
            else if (ShowTextBox.Contains("/"))
            {
                string[] way = ShowTextBox.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                if (Convert.ToDecimal(way[1]) != 0)
                {
                    ShowTextBox = (Convert.ToDecimal(way[0]) / Convert.ToDecimal(way[1])).ToString();
                }
                else
                {
                    ShowTextBox = "0";
                }    
            }

            if (symbol != "=")
            {
                ShowTextBox += symbol;
            }
            
            return ShowTextBox;
        }

        public string BINDECLOC(string n)
        {
            return ShowTextBox;
        }

        private void result_TextChanged(object sender, EventArgs e)
        {
            //上输出框
        }
        private void result2_TextChanged(object sender, EventArgs e)
        {
            //下输出框
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
            NumAndSymbol("－");
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
            result.Text = Operation("=");
        }
        private void clear_Click(object sender, EventArgs e)
        {
            ShowTextBox = "";
            result.Text = "";
        }

        private void BIN_Click(object sender, EventArgs e)
        {
            //二进制

        }

        private void DEC_Click(object sender, EventArgs e)
        {
            //十进制
            NumAndSymbol("DEC");
        }

        private void LOC_Click(object sender, EventArgs e)
        {
            //八进制
            NumAndSymbol("LOC");
        }


    }
}