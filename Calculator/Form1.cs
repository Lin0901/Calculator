using System.Collections.Generic;
using System.Text.RegularExpressions;

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
            if (numAndPoint.IndexOf(num) >= 0)
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
            result2.Text = "";
        }

        private void BIN_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
            {
                result.Text = "";
                result2.Text = "";
                return;
            }

            // ������ʾ���� BIN to LOC ����Ϊ result2 = LOC ��ʼ�������³���
            if (result2.Text == "LOC")
            {
                // using ASCII code 
                double show = 0;
                int lengh = result.Text.Length;
                string temp = result.Text.ToString();
                result.Text = "";

                for (int x = lengh - 1; x >= 0; x--)
                {
                    int pow = (int)temp[x] - 97;
                    show += Math.Pow(2, pow);
                }

                result.Text = DecToBin(show).ToString();
                result2.Text = "BIN";
            }

            else
            {
                // �����һ������ ����ʹ��Bin
                try
                {
                    double num1 = double.Parse(result2.Text);
                    result.Text = DecToBin(num1).ToString();
                    result2.Text = "BIN";
                }
                // �������õ��Ľ�� ʹ��Bin
                catch
                {
                    double num2 = double.Parse(result.Text);
                    result.Text = DecToBin(num2).ToString();
                    result2.Text = "BIN";
                }
            }

        }
        private double DecToBin(double num)
        {
            //����������ֵ
            double max = 0;
            int maxNum = 0;
            string BinNum = "";

            //maxNum�Ǵ�0��ʼ������ָ��
            while (Math.Pow(2, maxNum) <= num)
            {
                maxNum++;
            }

            //���� ��� >= �ͼ�¼1�� �����¼0
            for (int x = maxNum - 1; x >= 0; x--)
            {
                if (num >= Math.Pow(2, x))
                {
                    num = num - Math.Pow(2, x);
                    BinNum += "1";
                }
                else
                {
                    BinNum += "0";
                }
            }
            //�����ֵ��ַ�����ʾ��ʽת��Ϊ���Ч�� 32 λ�з�������
            max = double.Parse(BinNum);
            return max;
        }

        private void DEC_Click(object sender, EventArgs e)
        {
            //ʮ����
            // ������ʾ���� LOC to DEC ����Ϊ result2 = LOC ��ʼ�������³���
            if (result2.Text == "LOC")
            {
                double end = 0;
                int lengh = result.Text.Length;
                string s = result.Text.ToString();

            // Pow  2 �ǵ��� �� pow ��ָ����  �����ָ��������97 ����Ϊ ASCII�� a=97��
                for (int x = lengh - 1; x >= 0; x--)
                {
                    int pow = (int)s[x] - 97;
                    end += Math.Pow(2, pow);
                }
                //���������������ʾ
                result.Text = end.ToString();
                result2.Text = "DEC";
            }

            else
            {
                double NumDec = 0;

                for (int x = 0; x < result.Text.Length; x++)
                {
                    NumDec += double.Parse(result.Text[result.Text.Length - x - 1].ToString()) * Math.Pow(2, x);
                }

                result.Text = NumDec.ToString();
                result2.Text = "DEC";
            }
        }

        private void LOC_Click(object sender, EventArgs e)
        {
            //ʮ����ת����λ������
            // LOC �� BIN ֮����໥ת��
            if (result2.Text == "BIN")
            {     
                var Bin = result.Text;
                var resultLength = result.Text.Count();
                result.Text = "";

                for (int x = 0; x < resultLength; x++)
                {
                    if (Bin[x] == '1')
                    {
                        result.Text += (char)(resultLength - 1 + 97 - x);
                    }
                }
                var charArr = result.Text.ToCharArray();
                Array.Reverse(charArr);

                result.Text = new String(charArr);
                result2.Text = "LOC";
            }
            else
            {
                // ����ָ��������������Ļ���
                double num = double.Parse(result.Text);
                int maxIndex = 0; 
                result.Text = "";

                // ָ��������
                while (Math.Pow(2, maxIndex) <= num)
                {
                    maxIndex++;
                }

                //��ĸ�任д��   a = 97
                for (int x = maxIndex - 1; x >= 0; x--)
                {
                    if (num >= Math.Pow(2, x))
                    {
                        num = num - Math.Pow(2, x);
                        int ascii = x + 97;
                        result.Text += $"{(char)ascii}";
                    }

                }
                //�������ĸ����ʾ ��任��LOC
                var arrayOfChar = result.Text.ToCharArray();
                if (arrayOfChar.All(a => char.IsLetter(a)))
                {
                    Array.Reverse(arrayOfChar);

                    result.Text = new String(arrayOfChar);
                    result2.Text = "LOC";
                }
            }
        }


    }
}