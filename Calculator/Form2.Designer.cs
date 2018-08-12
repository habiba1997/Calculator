namespace Calculator
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minus = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.AC = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.arduinoPort = new System.IO.Ports.SerialPort(this.components);
            this.textBoxArd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arduino";
            // 
            // but1
            // 
            this.but1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.but1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but1.Location = new System.Drawing.Point(12, 15);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(86, 71);
            this.but1.TabIndex = 1;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = false;
            // 
            // but2
            // 
            this.but2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.but2.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but2.Location = new System.Drawing.Point(104, 15);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(86, 71);
            this.but2.TabIndex = 2;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = false;
            // 
            // but3
            // 
            this.but3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.but3.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but3.Location = new System.Drawing.Point(196, 15);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(86, 71);
            this.but3.TabIndex = 3;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = false;
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.WhiteSmoke;
            this.multiply.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.ForeColor = System.Drawing.SystemColors.Desktop;
            this.multiply.Location = new System.Drawing.Point(288, 15);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(86, 71);
            this.multiply.TabIndex = 4;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minus);
            this.panel1.Controls.Add(this.equal);
            this.panel1.Controls.Add(this.but0);
            this.panel1.Controls.Add(this.AC);
            this.panel1.Controls.Add(this.plus);
            this.panel1.Controls.Add(this.but9);
            this.panel1.Controls.Add(this.but8);
            this.panel1.Controls.Add(this.but7);
            this.panel1.Controls.Add(this.divide);
            this.panel1.Controls.Add(this.but6);
            this.panel1.Controls.Add(this.but5);
            this.panel1.Controls.Add(this.but4);
            this.panel1.Controls.Add(this.multiply);
            this.panel1.Controls.Add(this.but3);
            this.panel1.Controls.Add(this.but2);
            this.panel1.Controls.Add(this.but1);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 334);
            this.panel1.TabIndex = 5;
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.minus.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.minus.Location = new System.Drawing.Point(288, 246);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(86, 71);
            this.minus.TabIndex = 16;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.equal.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.equal.Location = new System.Drawing.Point(104, 246);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(86, 71);
            this.equal.TabIndex = 15;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            // 
            // but0
            // 
            this.but0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.but0.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but0.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but0.Location = new System.Drawing.Point(12, 246);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(86, 71);
            this.but0.TabIndex = 14;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = false;
            this.but0.Click += new System.EventHandler(this.but0_Click);
            // 
            // AC
            // 
            this.AC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AC.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AC.Location = new System.Drawing.Point(196, 246);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(86, 71);
            this.AC.TabIndex = 13;
            this.AC.Text = "AC";
            this.AC.UseVisualStyleBackColor = false;
            this.AC.Click += new System.EventHandler(this.AC_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plus.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.plus.Location = new System.Drawing.Point(288, 169);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(86, 71);
            this.plus.TabIndex = 12;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            // 
            // but9
            // 
            this.but9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.but9.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but9.Location = new System.Drawing.Point(196, 169);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(86, 71);
            this.but9.TabIndex = 11;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = false;
            // 
            // but8
            // 
            this.but8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.but8.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but8.Location = new System.Drawing.Point(104, 169);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(86, 71);
            this.but8.TabIndex = 10;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = false;
            // 
            // but7
            // 
            this.but7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.but7.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but7.Location = new System.Drawing.Point(12, 169);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(86, 71);
            this.but7.TabIndex = 9;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = false;
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.divide.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.ForeColor = System.Drawing.SystemColors.Desktop;
            this.divide.Location = new System.Drawing.Point(288, 92);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(86, 71);
            this.divide.TabIndex = 8;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            // 
            // but6
            // 
            this.but6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.but6.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but6.Location = new System.Drawing.Point(196, 92);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(86, 71);
            this.but6.TabIndex = 7;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = false;
            // 
            // but5
            // 
            this.but5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.but5.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but5.Location = new System.Drawing.Point(104, 92);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(86, 71);
            this.but5.TabIndex = 6;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = false;
            // 
            // but4
            // 
            this.but4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.but4.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but4.Location = new System.Drawing.Point(12, 92);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(86, 71);
            this.but4.TabIndex = 5;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Firebrick;
            this.start.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(465, 213);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(252, 89);
            this.start.TabIndex = 7;
            this.start.Text = "New Cycle";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Lavender;
            this.back.ForeColor = System.Drawing.Color.CadetBlue;
            this.back.Location = new System.Drawing.Point(543, 400);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(226, 76);
            this.back.TabIndex = 8;
            this.back.Text = "Back to Calculator";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // arduinoPort
            // 
            this.arduinoPort.PortName = "COM5";
            // 
            // textBoxArd
            // 
            this.textBoxArd.AutoSize = true;
            this.textBoxArd.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArd.Location = new System.Drawing.Point(431, 147);
            this.textBoxArd.Name = "textBoxArd";
            this.textBoxArd.Size = new System.Drawing.Size(314, 43);
            this.textBoxArd.TabIndex = 9;
            this.textBoxArd.Text = "Arduino_Value";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(781, 497);
            this.Controls.Add(this.textBoxArd);
            this.Controls.Add(this.back);
            this.Controls.Add(this.start);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.Button AC;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button back;
        private System.IO.Ports.SerialPort arduinoPort;
        private System.Windows.Forms.Label textBoxArd;
    }
}