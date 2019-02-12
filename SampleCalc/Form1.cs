using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StringBuilder stringBuilder = new StringBuilder();

        private void btn0_Click(object sender, EventArgs e)
        {
            //test12345
            stringBuilder.Append(btn0.Text);
            txtValue.Text = stringBuilder.ToString();

        }

        private void btn1_Click(object sender, EventArgs e)
        {//test12345xxxx
            stringBuilder.Append(btn1.Text);
            txtValue.Text = stringBuilder.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            stringBuilder.Append(btn2.Text);
            txtValue.Text = stringBuilder.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            stringBuilder.Append(btn3.Text);
            txtValue.Text = stringBuilder.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            stringBuilder.Append(btn4.Text);
            txtValue.Text = stringBuilder.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            stringBuilder.Append(btn5.Text);
            txtValue.Text = stringBuilder.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            stringBuilder.Append(btn6.Text);
            txtValue.Text = stringBuilder.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            stringBuilder.Append(btn7.Text);
            txtValue.Text = stringBuilder.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            stringBuilder.Append(btn8.Text);
            txtValue.Text = stringBuilder.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            stringBuilder.Append(btn9.Text);
            txtValue.Text = stringBuilder.ToString();
        }
        
        private void btnMult_Click(object sender, EventArgs e)
        {
            stringBuilder.Append(btnMult.Text);
            txtValue.Text = stringBuilder.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            stringBuilder.Append(btnDiv.Text);
            txtValue.Text = stringBuilder.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            stringBuilder.Append(btnSubtract.Text);
            txtValue.Text = stringBuilder.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            stringBuilder.Append(btnAdd.Text);
            txtValue.Text = stringBuilder.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = "";
            stringBuilder = new StringBuilder();
        }


        private int calculationStr()
        {
            string input = txtValue.Text.ToString();
            HashSet<char> hsOperators = new HashSet<char> { '+', '-', '/', '*' };
            HashSet<char> hsNumbers = new HashSet<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            List<string> ls = new List<string>();
            StringBuilder st = new StringBuilder();
            int number = 0;
            char prevOperator = 'c';
            char[] chArray = input.ToCharArray();

            for (int i = 0; i <= chArray.Length - 1; i++)
            {
                int count = chArray.Length - 1;
                char cha = chArray[i];
                if (hsNumbers.Contains(chArray[i]))
                    st.Append(chArray[i]);

                if (hsOperators.Contains(chArray[i]) || chArray.Length - 1 == i)
                {
                    if (prevOperator == '+')
                        number = number + int.Parse(st.ToString());
                    if (prevOperator == '-')
                        number = number - int.Parse(st.ToString());
                    if (prevOperator == '*')
                        number = number * int.Parse(st.ToString());
                    if (prevOperator == '/')
                        number = number / int.Parse(st.ToString());

                    if (number == 0)
                        number = int.Parse(st.ToString());

                    st.Clear();
                    prevOperator = chArray[i];
                }
            }
            return number;
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            stringBuilder.Clear();
            stringBuilder.Append(calculationStr().ToString());
            txtValue.Text = calculationStr().ToString();
        }
    }
}
