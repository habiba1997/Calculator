using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections; // for arraylist
//public static string[] Foo = new string[16];

namespace Calculator
{
    public partial class Form1 : Form
    {
        // Small letter array lists have an Ambugity problem if not placed in
        // a class due to the fact that the nuames are as buttons 
        public static class data
        {
            public static ArrayList Sum = new ArrayList();
            public static ArrayList Multiplication = new ArrayList();
            public static ArrayList Divide = new ArrayList();
            public static ArrayList Subtract = new ArrayList();
            public static Stack myStack = new Stack(); // for answers to be pushed in stack so when ans button pressen pop can be used
            public static Char operation; // for equal button to distinguish each operation
            // the augmented variable that will contain the equalization whole variable 
            public static float sum_variable = 0;
            public static float multipy_variable = 1;
            public static float divide_variable;
            public static float subtract_variable;
            public static float last_answer = 0; // when AC pressen last answer will be poped here
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Calculator ON");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text +  "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text +  "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text +  "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text +  "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }
        private void dot_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ".";
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        { }

        private void delete_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            data.Sum.Clear();
            data.Divide.Clear();
            data.Subtract.Clear();
            data.Multiplication.Clear();
            data.last_answer = (float)data.myStack.Pop();
            data.myStack.Clear();
            data.myStack.Push(data.last_answer);
            data.multipy_variable = 1;
            data.sum_variable = 0;

        }

        private void ans_Click(object sender, EventArgs e)
        {
            float last = (float)data.myStack.Pop();
            textBox.Text = last.ToString();
            data.myStack.Push(last);
        }

        //Array Lists doesn't have a Sum ( a loop would suffice) While Array does have a sum function
        // operation Buttons 
        private void multi_Click(object sender, EventArgs e)
        {
            try
            {
                data.Multiplication.Add(float.Parse(textBox.Text));
                textBox.Clear();
                data.operation = 'x';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            try
            {
                data.Divide.Add(float.Parse(textBox.Text));
                textBox.Clear();
                data.operation = '/';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void sum_Click(object sender, EventArgs e)
        {
            try
            {
                data.Sum.Add(float.Parse(textBox.Text));
                textBox.Clear();
                data.operation = '+';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            try
            {
                data.Subtract.Add(float.Parse(textBox.Text));
                textBox.Clear();
                data.operation = '-';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (data.operation)
            {
                case 'x':
                    {
                        data.Multiplication.Add(float.Parse(textBox.Text));
                        textBox.Clear();
                        foreach (float value in data.Multiplication)
                        {
                            data.multipy_variable = data.multipy_variable * value;
                        }
                        textBox.Text = data.multipy_variable.ToString();
                        data.myStack.Push(data.multipy_variable);
                        //data.multipy_variable = 1;
                        break;
                    }
                case '/':
                    {
                        data.Divide.Add(float.Parse(textBox.Text));
                        textBox.Clear();
                        data.divide_variable = (float) data.Divide[0];
                        for (int i=1 ; i < data.Divide.Count; ++i)
                        {
                            try
                            {
                                data.divide_variable = data.divide_variable / (float)data.Divide[i];
                            }
                            catch (Exception a)
                            {
                                MessageBox.Show(a.Message.ToString()); // take care tostring+()
                            }
                        }
                        textBox.Text = data.divide_variable.ToString();
                        data.myStack.Push(data.divide_variable);
                        break;
                    }
                case '+':
                    {
                        data.Sum.Add(float.Parse(textBox.Text));
                        textBox.Clear();
                        foreach (float value in data.Sum)
                        {
                            data.sum_variable = data.sum_variable + value;

                        }
                        textBox.Text = data.sum_variable.ToString();
                        data.myStack.Push(data.sum_variable);
                        //data.sum_variable = 0;
                        break;
                    }
                case '-':
                    {
                        data.Subtract.Add(float.Parse(textBox.Text));
                        textBox.Clear();
                        data.subtract_variable = (float) data.Subtract[0];
                        for(int i =1; i < data.Subtract.Count; ++i)
                        {
                            try
                            {
                                data.subtract_variable = data.subtract_variable - (float) data.Subtract[i];
                            }
                            catch (Exception a)
                            {
                                MessageBox.Show(a.Message.ToString());
                            }
                        }
                        textBox.Text = data.subtract_variable.ToString();
                        data.myStack.Push(data.subtract_variable);
                        break;
                    }
                default:
                    MessageBox.Show("Error" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                    break;
            }
            data.Sum.Clear();
            data.Divide.Clear();
            data.Subtract.Clear();
            data.Multiplication.Clear();
            data.last_answer = (float)data.myStack.Pop();
            data.myStack.Clear();
            data.myStack.Push(data.last_answer);
            data.multipy_variable = 1;
            data.sum_variable = 0;

        } //button end 

        private void tab2_Click(object sender, EventArgs e)
        {}
        private void square_Click(object sender, EventArgs e)
        {
            textBox.Text = Math.Pow(float.Parse(textBox.Text),2).ToString();
        }

        private void square_root_Click(object sender, EventArgs e)
        {
            textBox.Text = Math.Sqrt(float.Parse(textBox.Text)).ToString();
        }

        private void math_equation_Click(object sender, EventArgs e)
        {
            math.Hide();
            equation.Show();
        }

        private void math_arduino_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculator.Form2 arduino_form = new Calculator.Form2();
            arduino_form.Show();
        }


        
        // Tab number 2 (   Equation    )
        private void buttonAns_Click(object sender, EventArgs e)
        {
            float a, b, c, X1, X2;
            a = float.Parse(textBoxA.Text);
            b = float.Parse(textBoxB.Text);
            c = float.Parse(textBoxC.Text);
            try
            {
                X1 = -b + (float) Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)); //Math.Pow retuen double
                X1 = X1 / (2 * a);
                X2 = -b - (float) Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c));
                X2 = X2 / (2 * a);
            }
            catch (Exception ex) // for when there is a problem in X1 and X2, label would shpw X1=X2=0
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                X1 = 0;
                X2 = 0;
            }
            labelAns1.Text = X1.ToString();
            labelAns2.Text = X2.ToString();
        }

        private void arduinoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculator.Form2 arduino_form = new Calculator.Form2();
            arduino_form.Show();
        }
    } // form end
} //namespace
