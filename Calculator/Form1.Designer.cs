namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.equation = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.arduinoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAns = new System.Windows.Forms.Button();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelAns2 = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelAns1 = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.math = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.equal = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Equ = new System.Windows.Forms.TabControl();
            this.math_equation = new System.Windows.Forms.Button();
            this.square_root = new System.Windows.Forms.Button();
            this.math_arduino = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.equation.SuspendLayout();
            this.panel2.SuspendLayout();
            this.math.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Equ.SuspendLayout();
            this.SuspendLayout();
            // 
            // equation
            // 
            this.equation.BackColor = System.Drawing.Color.DarkKhaki;
            this.equation.Controls.Add(this.panel2);
            this.equation.Location = new System.Drawing.Point(4, 27);
            this.equation.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.equation.Name = "equation";
            this.equation.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.equation.Size = new System.Drawing.Size(824, 456);
            this.equation.TabIndex = 1;
            this.equation.Text = "Equations";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.arduinoButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonAns);
            this.panel2.Controls.Add(this.textBoxC);
            this.panel2.Controls.Add(this.labelAns2);
            this.panel2.Controls.Add(this.labelC);
            this.panel2.Controls.Add(this.textBoxA);
            this.panel2.Controls.Add(this.textBoxB);
            this.panel2.Controls.Add(this.labelAns1);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Controls.Add(this.labelA);
            this.panel2.Controls.Add(this.labelB);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(49, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 434);
            this.panel2.TabIndex = 14;
            // 
            // arduinoButton
            // 
            this.arduinoButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.arduinoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.arduinoButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.arduinoButton.Location = new System.Drawing.Point(522, 328);
            this.arduinoButton.Name = "arduinoButton";
            this.arduinoButton.Size = new System.Drawing.Size(185, 90);
            this.arduinoButton.TabIndex = 12;
            this.arduinoButton.Text = "Arduino";
            this.arduinoButton.UseVisualStyleBackColor = false;
            this.arduinoButton.Click += new System.EventHandler(this.arduinoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(156, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 43);
            this.label1.TabIndex = 11;
            this.label1.Text = "A(X^2) + B(X) + C = 0";
            // 
            // buttonAns
            // 
            this.buttonAns.BackColor = System.Drawing.Color.Khaki;
            this.buttonAns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAns.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAns.ForeColor = System.Drawing.Color.Black;
            this.buttonAns.Location = new System.Drawing.Point(133, 277);
            this.buttonAns.Name = "buttonAns";
            this.buttonAns.Size = new System.Drawing.Size(142, 78);
            this.buttonAns.TabIndex = 6;
            this.buttonAns.Text = "Answer";
            this.buttonAns.UseVisualStyleBackColor = false;
            this.buttonAns.Click += new System.EventHandler(this.buttonAns_Click);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(212, 211);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(157, 35);
            this.textBoxC.TabIndex = 5;
            // 
            // labelAns2
            // 
            this.labelAns2.AutoSize = true;
            this.labelAns2.BackColor = System.Drawing.Color.Khaki;
            this.labelAns2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAns2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelAns2.Location = new System.Drawing.Point(522, 185);
            this.labelAns2.Name = "labelAns2";
            this.labelAns2.Size = new System.Drawing.Size(130, 31);
            this.labelAns2.TabIndex = 10;
            this.labelAns2.Text = "Answer 2";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(21, 211);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(170, 29);
            this.labelC.TabIndex = 4;
            this.labelC.Text = "C (Constant)";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(212, 104);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(157, 35);
            this.textBoxA.TabIndex = 1;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(212, 156);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(157, 35);
            this.textBoxB.TabIndex = 3;
            // 
            // labelAns1
            // 
            this.labelAns1.AutoSize = true;
            this.labelAns1.BackColor = System.Drawing.Color.Khaki;
            this.labelAns1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAns1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelAns1.Location = new System.Drawing.Point(522, 125);
            this.labelAns1.Name = "labelAns1";
            this.labelAns1.Size = new System.Drawing.Size(127, 31);
            this.labelAns1.TabIndex = 9;
            this.labelAns1.Text = "Answer 1";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(430, 125);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(67, 29);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "X1 =";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(21, 104);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(110, 29);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A (X^2)";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(21, 156);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(78, 29);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "B (X)";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(430, 185);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(70, 29);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "X2 =";
            // 
            // math
            // 
            this.math.BackColor = System.Drawing.Color.Khaki;
            this.math.Controls.Add(this.panel1);
            this.math.Location = new System.Drawing.Point(4, 27);
            this.math.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.math.Name = "math";
            this.math.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.math.Size = new System.Drawing.Size(824, 456);
            this.math.TabIndex = 0;
            this.math.Text = "Mathematics";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.square);
            this.panel1.Controls.Add(this.math_arduino);
            this.panel1.Controls.Add(this.square_root);
            this.panel1.Controls.Add(this.math_equation);
            this.panel1.Controls.Add(this.equal);
            this.panel1.Controls.Add(this.ans);
            this.panel1.Controls.Add(this.subtract);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.multi);
            this.panel1.Controls.Add(this.divide);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.sum);
            this.panel1.Controls.Add(this.dot);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Location = new System.Drawing.Point(87, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 433);
            this.panel1.TabIndex = 6;
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.equal.Location = new System.Drawing.Point(339, 344);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(168, 59);
            this.equal.TabIndex = 23;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // ans
            // 
            this.ans.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ans.Location = new System.Drawing.Point(247, 344);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(76, 59);
            this.ans.TabIndex = 22;
            this.ans.Text = "ANS";
            this.ans.UseVisualStyleBackColor = false;
            this.ans.Click += new System.EventHandler(this.ans_Click);
            // 
            // subtract
            // 
            this.subtract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subtract.Location = new System.Drawing.Point(431, 267);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(76, 59);
            this.subtract.TabIndex = 21;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clear.Location = new System.Drawing.Point(339, 95);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(76, 59);
            this.clear.TabIndex = 20;
            this.clear.Text = "AC";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // multi
            // 
            this.multi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.multi.Location = new System.Drawing.Point(339, 182);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(76, 59);
            this.multi.TabIndex = 19;
            this.multi.Text = "X";
            this.multi.UseVisualStyleBackColor = false;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.divide.Location = new System.Drawing.Point(431, 182);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(76, 59);
            this.divide.TabIndex = 18;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.delete.Location = new System.Drawing.Point(431, 95);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(76, 59);
            this.delete.TabIndex = 17;
            this.delete.Text = "DEL";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sum.Location = new System.Drawing.Point(339, 267);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(76, 59);
            this.sum.TabIndex = 16;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = false;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dot.Location = new System.Drawing.Point(62, 344);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(76, 59);
            this.dot.TabIndex = 14;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button0.Location = new System.Drawing.Point(155, 344);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(76, 59);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(247, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 59);
            this.button3.TabIndex = 12;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(155, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 59);
            this.button2.TabIndex = 11;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(62, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 59);
            this.button1.TabIndex = 10;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(247, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 59);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(155, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 59);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(62, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 59);
            this.button4.TabIndex = 7;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Location = new System.Drawing.Point(247, 95);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 59);
            this.button9.TabIndex = 6;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Location = new System.Drawing.Point(155, 95);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 59);
            this.button8.TabIndex = 5;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(62, 95);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 59);
            this.button7.TabIndex = 4;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(62, 26);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(537, 47);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // Equ
            // 
            this.Equ.Controls.Add(this.math);
            this.Equ.Controls.Add(this.equation);
            this.Equ.Location = new System.Drawing.Point(2, 1);
            this.Equ.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Equ.Name = "Equ";
            this.Equ.SelectedIndex = 0;
            this.Equ.Size = new System.Drawing.Size(832, 487);
            this.Equ.TabIndex = 0;
            // 
            // math_equation
            // 
            this.math_equation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.math_equation.Location = new System.Drawing.Point(523, 267);
            this.math_equation.Name = "math_equation";
            this.math_equation.Size = new System.Drawing.Size(76, 59);
            this.math_equation.TabIndex = 25;
            this.math_equation.Text = "EQU";
            this.math_equation.UseVisualStyleBackColor = false;
            this.math_equation.Click += new System.EventHandler(this.math_equation_Click);
            // 
            // square_root
            // 
            this.square_root.BackColor = System.Drawing.Color.WhiteSmoke;
            this.square_root.Location = new System.Drawing.Point(523, 182);
            this.square_root.Name = "square_root";
            this.square_root.Size = new System.Drawing.Size(76, 59);
            this.square_root.TabIndex = 26;
            this.square_root.Text = "ROOT";
            this.square_root.UseVisualStyleBackColor = false;
            this.square_root.Click += new System.EventHandler(this.square_root_Click);
            // 
            // math_arduino
            // 
            this.math_arduino.BackColor = System.Drawing.Color.WhiteSmoke;
            this.math_arduino.Location = new System.Drawing.Point(523, 344);
            this.math_arduino.Name = "math_arduino";
            this.math_arduino.Size = new System.Drawing.Size(76, 59);
            this.math_arduino.TabIndex = 27;
            this.math_arduino.Text = "Ard";
            this.math_arduino.UseVisualStyleBackColor = false;
            this.math_arduino.Click += new System.EventHandler(this.math_arduino_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.WhiteSmoke;
            this.square.Location = new System.Drawing.Point(523, 95);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(76, 59);
            this.square.TabIndex = 28;
            this.square.Text = "^2";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(836, 493);
            this.Controls.Add(this.Equ);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.equation.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.math.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Equ.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage equation;
        private System.Windows.Forms.TabPage math;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button ans;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TabControl Equ;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button arduinoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAns;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelAns2;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelAns1;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Button math_arduino;
        private System.Windows.Forms.Button square_root;
        private System.Windows.Forms.Button math_equation;
        private System.Windows.Forms.Button square;
    }
}