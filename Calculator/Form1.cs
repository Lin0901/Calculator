namespace Calculator
{
    public partial class Form1 : Form
    {
        //���ʽ����
        public static string ShowTextBox = "";
        public Form1()
        {
            InitializeComponent();
        }

        public void NumAndSymbol(string num)
        {
            //�ж�������ǲ������ֻ���С����
            string numAndPoint = "0,1,2,3,4,5,6,7,8,9,.";
            //���ص�ǰ�ַ����ַ����е�λ�� 
            if(numAndPoint.IndexOf(num) >= 0)
            {
                //˵�� �� "0,1,2,3,4,5,6,7,8,9,." ��һ��
                ShowTextBox += num;
            }
            else
            {
                //˵�� ����"0,1,2,3,4,5,6,7,8,9,." ��һ�ѣ����Ƿ���
                //���Ĭ��û���������֣�����Ӽ��˳����߽����߼�
                if(!string.IsNullOrEmpty(ShowTextBox))
                {
                    //��Ϊ�յ�ʱ�� ������ �ж����һλ substing����ȡ�Ŀ�ʼλ�ã���ȡ���ȣ���Ҳ����˵ ��ȡ���һλ
                    string lastString = ShowTextBox.Substring(ShowTextBox.Length - 1, 1);
                    //�ٴκ˲�λ��
                    if(numAndPoint.IndexOf(lastString) >= 0)
                    {
                        //��������һ�����֣����֮ǰ����һ�飬��׷���µļ������
                        ShowTextBox = Operation(num);
                    }
                }

            }
            //ȫ�ֱ��ʽ�����ۼ�    
            result2.Text = ShowTextBox;
        }

        public string Operation(string symbol)
        {
            if (ShowTextBox.Contains("+"))
            {
                // split�����и��ַ���  1 + 1  ���  1 ��1 ��new char ���ƶ����ţ�  Ȼ���ٸ�һ��������
                // StringSplitOptions.RemoveEmptyEntries �ų��ո��϶ �ų���ֵ
                string[] way = ShowTextBox.Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
                // left way right
                //������ַ���1+�ַ���1 ��õ� 11��Ҫ�����ֵ������ҲŻ�ִ����ѧ���㡣
                ShowTextBox = (Convert.ToDecimal(way[0]) + Convert.ToDecimal(way[1])).ToString();
            }
            else if (ShowTextBox.Contains("��"))
            {

                string[] way = ShowTextBox.Split(new char[] { '��' }, StringSplitOptions.RemoveEmptyEntries);
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
            //�������
        }
        private void result2_TextChanged(object sender, EventArgs e)
        {
            //�������
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
            NumAndSymbol("��");
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
            //������

        }

        private void DEC_Click(object sender, EventArgs e)
        {
            //ʮ����
            NumAndSymbol("DEC");
        }

        private void LOC_Click(object sender, EventArgs e)
        {
            //�˽���
            NumAndSymbol("LOC");
        }


    }
}