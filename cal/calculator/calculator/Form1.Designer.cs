namespace calculator
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            btnClear = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 18F);
            txtDisplay.Location = new Point(61, 35);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(437, 47);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 13F);
            btn0.Location = new Point(61, 297);
            btn0.Name = "btn0";
            btn0.Size = new Size(68, 39);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 13F);
            btn1.Location = new Point(61, 248);
            btn1.Name = "btn1";
            btn1.Size = new Size(68, 43);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 13F);
            btn2.Location = new Point(183, 248);
            btn2.Name = "btn2";
            btn2.Size = new Size(62, 43);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 13F);
            btn3.Location = new Point(293, 248);
            btn3.Name = "btn3";
            btn3.Size = new Size(61, 43);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 13F);
            btn4.Location = new Point(61, 204);
            btn4.Name = "btn4";
            btn4.Size = new Size(68, 38);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 13F);
            btn5.Location = new Point(183, 204);
            btn5.Name = "btn5";
            btn5.Size = new Size(62, 38);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button6_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 13F);
            btn6.Location = new Point(293, 204);
            btn6.Name = "btn6";
            btn6.Size = new Size(61, 38);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 13F);
            btn7.Location = new Point(61, 157);
            btn7.Name = "btn7";
            btn7.Size = new Size(68, 41);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 13F);
            btn8.Location = new Point(183, 157);
            btn8.Name = "btn8";
            btn8.Size = new Size(62, 41);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 13F);
            btn9.Location = new Point(293, 157);
            btn9.Name = "btn9";
            btn9.Size = new Size(61, 41);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 13F);
            btnAdd.Location = new Point(404, 248);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(73, 43);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 13F);
            btnSub.Location = new Point(404, 297);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(73, 39);
            btnSub.TabIndex = 12;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("Segoe UI", 13F);
            btnMul.Location = new Point(293, 297);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(61, 39);
            btnMul.TabIndex = 13;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 13F);
            btnDiv.Location = new Point(183, 297);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(62, 39);
            btnDiv.TabIndex = 14;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 13F);
            btnClear.Location = new Point(404, 156);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(73, 42);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 13F);
            btnEqual.Location = new Point(404, 204);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(73, 38);
            btnEqual.TabIndex = 16;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEqual);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
        private Button btnClear;
        private Button btnEqual;
    }
}
