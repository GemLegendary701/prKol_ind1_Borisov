using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prKol_ind1_Borisov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string infix = textBoxInfix.Text;
            if (string.IsNullOrWhiteSpace(infix))
            {
                MessageBox.Show("Введите выражение");
            }
            try
            {
                string delSpase = String.Join("", infix.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                char[] sim = delSpase.ToCharArray();
                Array.Reverse(sim);
                string reverseInfix = new string(sim).Replace('(', '\0').Replace(')', '(').Replace('\0', ')');
                Stack<char> stack = new Stack<char>();
                List<char> output = new List<char>();
                foreach (char c in reverseInfix)
                {
                    if (char.IsLetterOrDigit(c))
                    {
                        output.Add(c);
                    }
                    else if (c == '(')
                    {
                        stack.Push(c);
                    }
                    else if (c == ')')
                    {
                        while (stack.Peek() != '(' && stack.Count > 0)
                        {
                            output.Add(stack.Pop());
                        }
                        stack.Pop();
                    }
                    else
                    {
                        int op = 0;
                        int stackOp = 0;
                        if (c == '+' || c == '-')
                        {
                            op = 1;
                        }
                        else if (c == '*' || c == '/')
                        {
                            op = 2;
                        }
                        else if (c == '^')
                        {
                            op = 3;
                        }
                        while (stack.Count > 0)
                        {
                            char newStackOp = stack.Peek();
                            if (newStackOp == '+' || newStackOp == '-')
                            {
                                stackOp = 1;
                            }
                            else if (newStackOp == '*' || newStackOp == '/')
                            {
                                stackOp = 2;
                            }
                            else if (newStackOp == '^')
                            {
                                stackOp = 3;
                            }
                            else break;
                            if (op <= stackOp)
                            {
                            output.Add(stack.Pop());

                            }
                        }
                        stack.Push(c);
                    }
                }
                while (stack.Count > 0)
                {
                    output.Add(stack.Pop());
                }
                char[] outArr = output.ToArray();
                Array.Reverse(outArr);
                string prefix = string.Join(" ", outArr);
                textBoxprefix.Text = prefix;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка преобразования");
            }

        }
    }
}
