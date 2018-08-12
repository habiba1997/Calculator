using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Calculator
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            try
            { 
            arduinoPort.Open();
            MessageBox.Show("Arduino Connected");
            }
            catch (Exception b)
            {
                MessageBox.Show(b.Message.ToString()+ "Error" + MessageBoxIcon.Error );

            }
        }
        public static class data2
        {
            public static ArrayList operation = new ArrayList();
            public static char oper;
            public static int augmented_variable ;


        }

        private void but0_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculator.Form1 calculator = new Calculator.Form1();
            calculator.Show();
        }
        private void ACbutton()
        {
            AC.BackColor = Color.Firebrick;
            textBoxArd.Text = "";
            data2.operation.Clear();
            but1.BackColor = Color.WhiteSmoke;
            but2.BackColor = Color.WhiteSmoke;
            but3.BackColor = Color.WhiteSmoke;
            but4.BackColor = Color.WhiteSmoke;
            but5.BackColor = Color.WhiteSmoke;
            but6.BackColor = Color.WhiteSmoke;
            but7.BackColor = Color.WhiteSmoke;
            but8.BackColor = Color.WhiteSmoke;
            but9.BackColor = Color.WhiteSmoke;
            but0.BackColor = Color.WhiteSmoke;
            divide.BackColor = Color.WhiteSmoke;
            minus.BackColor = Color.WhiteSmoke;
            plus.BackColor = Color.WhiteSmoke;
            multiply.BackColor = Color.WhiteSmoke;
        }
        private void AC_Click(object sender, EventArgs e)
        {
            ACbutton();
        }

        // I could make it easier by recursion TRY IT LATER
        private void start_Click(object sender, EventArgs e)
        {
            string ardd = arduinoPort.ReadLine();
            textBoxArd.Text =ardd;
            but1.BackColor = Color.WhiteSmoke;
            but2.BackColor = Color.WhiteSmoke;
            but3.BackColor = Color.WhiteSmoke;
            but4.BackColor = Color.WhiteSmoke;
            but5.BackColor = Color.WhiteSmoke;
            but6.BackColor = Color.WhiteSmoke;
            but7.BackColor = Color.WhiteSmoke;
            but8.BackColor = Color.WhiteSmoke;
            but9.BackColor = Color.WhiteSmoke;
            but0.BackColor = Color.WhiteSmoke;
            divide.BackColor = Color.WhiteSmoke;
            minus.BackColor = Color.WhiteSmoke;
            plus.BackColor = Color.WhiteSmoke;
            multiply.BackColor = Color.WhiteSmoke;


            for (int j = 0; j < 5;  ++j)
            {
                char data = ardd[j];

                if (data == 'A')
                {
                    ACbutton();
                    break;

                }

                else if (data != '=' && data != 'A' && data != '/' && data != 'x' && data != '+' && data != '-')
                {
                    
                    data2.operation.Add((int)Char.GetNumericValue(data));
                    switch (data)
                    {
                        case '1':
                            but1.BackColor = Color.Firebrick;
                            break;
                        case '2':
                            but2.BackColor = Color.Firebrick;
                            break;
                        case '3':
                            but3.BackColor = Color.Firebrick;
                            break;
                        case '4':
                            but4.BackColor = Color.Firebrick;
                            break;
                        case '5':
                            but5.BackColor = Color.Firebrick;
                            break;
                        case '6':
                            but6.BackColor = Color.Firebrick;
                            break;
                        case '7':
                            but7.BackColor = Color.Firebrick;
                            break;
                        case '8':
                            but8.BackColor = Color.Firebrick;
                            break;
                        case '9':
                            but9.BackColor = Color.Firebrick;
                            break;
                        case '0':
                            but0.BackColor = Color.Firebrick;
                            break;
                    }
                }
                else if (data == '/' || data == 'x' || data == '+' || data == '-')
                {
                    data2.oper = data;
                    switch (data)
                    {
                        case '/':
                            divide.BackColor = Color.Firebrick;
                            break;
                        case '+':
                            plus.BackColor = Color.Firebrick;
                            break;
                        case '-':
                            minus.BackColor = Color.Firebrick;
                            break;
                        case 'x':
                            multiply.BackColor = Color.Firebrick;
                            break;
                    }
                }
                else if (data == '=')
                {
                    switch (data2.oper)
                    {
                        case 'x':
                            {
                                data2.augmented_variable = (int) data2.operation[0];
                                for (int i = 1; i < data2.operation.Count; ++i)
                                {
                                    data2.augmented_variable = data2.augmented_variable * (int)data2.operation[i];
                                }
                                textBoxArd.Text = textBoxArd.Text + data2.augmented_variable.ToString();
                                break;
                            }
                        case '/':
                            {
                                data2.augmented_variable = (int)data2.operation[0];
                                for (int i = 1; i < data2.operation.Count; ++i)
                                {
                                    data2.augmented_variable = data2.augmented_variable / (int)data2.operation[i];
                                }
                                textBoxArd.Text = textBoxArd.Text + data2.augmented_variable.ToString();
                                break;
                            }
                        case '+':
                            {
                                data2.augmented_variable = (int)data2.operation[0];
                                for (int i = 1; i < data2.operation.Count; ++i)
                                {
                                  
                                    data2.augmented_variable = data2.augmented_variable + (int)data2.operation[i];
                                }
                                textBoxArd.Text = textBoxArd.Text + data2.augmented_variable.ToString();
                                break;
                            }
                        case '-':
                            {
                                data2.augmented_variable = (int)data2.operation[0];
                                for (int i = 1; i < data2.operation.Count; ++i)
                                {
                                    data2.augmented_variable = data2.augmented_variable - (int)data2.operation[i];
                                }
                                textBoxArd.Text = textBoxArd.Text + data2.augmented_variable.ToString();
                                break;
                            }
                        default:
                            MessageBox.Show("Error" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                            break;
                    }
                    data2.operation.Clear();
                    data2.oper = '0';
                    break;
                }
            }
        }

        private void textBoxArd_TextChanged(object sender, EventArgs e)
        {
        }

        
    } // form2 closure
} // namespace closure
