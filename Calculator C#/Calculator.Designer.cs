using System.Drawing;

namespace Calculator_C_
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonDiv;
        private Button buttonAdd;
        private Button buttonEqual;
        private Button buttonSub;
        private Button buttonDec;
        private Button buttonMult;
        private TextBox textBox1;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonDiv = new Button();
            buttonAdd = new Button();
            buttonEqual = new Button();
            buttonSub = new Button();
            buttonDec = new Button();
            buttonMult = new Button();
            textBox1 = new TextBox();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(34, 454);
            button1.Name = "button1";
            button1.Size = new Size(75, 59);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.BackColor = Color.Pink;
            // 
            // button2
            // 
            button2.Location = new Point(176, 454);
            button2.Name = "button2";
            button2.Size = new Size(75, 59);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.BackColor = Color.Pink;
            // 
            // button3
            // 
            button3.Location = new Point(314, 454);
            button3.Name = "button3";
            button3.Size = new Size(75, 59);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button3.BackColor = Color.Pink;
            // 
            // button4
            // 
            button4.Location = new Point(34, 353);
            button4.Name = "button4";
            button4.Size = new Size(75, 59);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            button4.BackColor = Color.Pink;
            // 
            // button5
            // 
            button5.Location = new Point(176, 353);
            button5.Name = "button5";
            button5.Size = new Size(75, 59);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            button5.BackColor = Color.Pink;
            // 
            // button6
            // 
            button6.Location = new Point(314, 353);
            button6.Name = "button6";
            button6.Size = new Size(75, 59);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            button6.BackColor = Color.Pink;
            // 
            // button7
            // 
            button7.Location = new Point(34, 249);
            button7.Name = "button7";
            button7.Size = new Size(75, 59);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            button7.BackColor = Color.Pink;
            // 
            // button8
            // 
            button8.Location = new Point(176, 249);
            button8.Name = "button8";
            button8.Size = new Size(75, 59);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            button8.BackColor = Color.Pink;
            // 
            // button9
            // 
            button9.Location = new Point(314, 249);
            button9.Name = "button9";
            button9.Size = new Size(75, 59);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            button9.BackColor = Color.Pink;
            // 
            // button0
            // 
            button0.Location = new Point(34, 566);
            button0.Name = "button0";
            button0.Size = new Size(75, 59);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            button0.BackColor = Color.Pink;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(454, 353);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(75, 59);
            buttonDiv.TabIndex = 10;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            buttonDiv.BackColor = Color.DeepPink;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(454, 454);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 59);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            buttonAdd.BackColor = Color.DeepPink;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(454, 566);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(75, 59);
            buttonEqual.TabIndex = 12;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            buttonEqual.BackColor = Color.DeepPink;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(314, 566);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(75, 59);
            buttonSub.TabIndex = 13;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            buttonSub.BackColor = Color.DeepPink;
            // 
            // buttonDec
            // 
            buttonDec.Location = new Point(176, 566);
            buttonDec.Name = "buttonDec";
            buttonDec.Size = new Size(75, 59);
            buttonDec.TabIndex = 14;
            buttonDec.Text = ".";
            buttonDec.UseVisualStyleBackColor = true;
            buttonDec.Click += buttonDec_Click;
            buttonDec.BackColor = Color.Pink;
            // 
            // buttonMult
            // 
            buttonMult.Location = new Point(454, 249);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(75, 59);
            buttonMult.TabIndex = 15;
            buttonMult.Text = "*";
            buttonMult.UseVisualStyleBackColor = true;
            buttonMult.Click += buttonMult_Click;
            buttonMult.BackColor = Color.DeepPink;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 37);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(482, 118);
            textBox1.TabIndex = 16;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(454, 161);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 53);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            buttonClear.BackColor = Color.DeepPink;
            // 
            // Calculator
            // 
            ClientSize = new Size(555, 637);
            Controls.Add(buttonClear);
            Controls.Add(textBox1);
            Controls.Add(buttonMult);
            Controls.Add(buttonDec);
            Controls.Add(buttonSub);
            Controls.Add(buttonEqual);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDiv);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Calculator";
            Text = "Calculator";
            BackColor = Color.HotPink;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button buttonClear;
    }
}