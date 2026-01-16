using System;
using System.Windows.Forms;

namespace CalculatorWinForms
{
    public partial class MainForm : Form
    {
        private double _firstNumber = 0;
        private double _secondNumber = 0;
        private string _operation = "";
        private bool _isOperationPressed = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtDisplay = new TextBox();
            this.btnClear = new Button();
            this.btnEquals = new Button();
            this.btnAdd = new Button();
            this.btnSubtract = new Button();
            this.btnMultiply = new Button();
            this.btnDivide = new Button();
            this.btn0 = new Button();
            this.btn1 = new Button();
            this.btn2 = new Button();
            this.btn3 = new Button();
            this.btn4 = new Button();
            this.btn5 = new Button();
            this.btn6 = new Button();
            this.btn7 = new Button();
            this.btn8 = new Button();
            this.btn9 = new Button();
            this.btnDecimal = new Button();
            this.SuspendLayout();

            // txtDisplay
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(260, 35);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = HorizontalAlignment.Right;

            // btnClear
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(12, 60);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 50);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler(this.BtnClear_Click);

            // btnDivide
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(147, 60);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 50);
            this.btnDivide.TabIndex = 2;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new EventHandler(this.BtnOperation_Click);

            // btnMultiply
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(213, 60);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 50);
            this.btnMultiply.TabIndex = 3;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new EventHandler(this.BtnOperation_Click);

            // btn7
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(12, 116);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 50);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new EventHandler(this.BtnNumber_Click);

            // btn8
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(78, 116);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 50);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new EventHandler(this.BtnNumber_Click);

            // btn9
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(144, 116);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 50);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new EventHandler(this.BtnNumber_Click);

            // btnSubtract
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtract.Location = new System.Drawing.Point(210, 116);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(60, 50);
            this.btnSubtract.TabIndex = 7;
            this.btnSubtract.Text = "−";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new EventHandler(this.BtnOperation_Click);

            // btn4
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(12, 172);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 50);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new EventHandler(this.BtnNumber_Click);

            // btn5
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(78, 172);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 50);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new EventHandler(this.BtnNumber_Click);

            // btn6
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(144, 172);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 50);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new EventHandler(this.BtnNumber_Click);

            // btnAdd
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(210, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 50);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.BtnOperation_Click);

            // btn1
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(12, 228);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 50);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new EventHandler(this.BtnNumber_Click);

            // btn2
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(78, 228);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 50);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new EventHandler(this.BtnNumber_Click);

            // btn3
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(144, 228);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 50);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new EventHandler(this.BtnNumber_Click);

            // btnEquals
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEquals.Location = new System.Drawing.Point(210, 228);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(60, 110);
            this.btnEquals.TabIndex = 15;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new EventHandler(this.BtnEquals_Click);

            // btn0
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(12, 284);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(125, 50);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new EventHandler(this.BtnNumber_Click);

            // btnDecimal
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecimal.Location = new System.Drawing.Point(144, 284);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(60, 50);
            this.btnDecimal.TabIndex = 17;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new EventHandler(this.BtnDecimal_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 346);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "計算機 (WinForms)";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox txtDisplay;
        private Button btnClear;
        private Button btnEquals;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
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
        private Button btnDecimal;

        private void BtnNumber_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (_isOperationPressed)
                {
                    txtDisplay.Text = "";
                    _isOperationPressed = false;
                }

                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = button.Text;
                }
                else
                {
                    txtDisplay.Text += button.Text;
                }
            }
        }

        private void BtnOperation_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (!string.IsNullOrEmpty(_operation) && !_isOperationPressed)
                {
                    BtnEquals_Click(sender, e);
                }

                _firstNumber = double.Parse(txtDisplay.Text);
                _operation = button.Text;
                _isOperationPressed = true;
            }
        }

        private void BtnEquals_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_operation))
                return;

            _secondNumber = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (_operation)
            {
                case "+":
                    result = _firstNumber + _secondNumber;
                    break;
                case "−":
                    result = _firstNumber - _secondNumber;
                    break;
                case "×":
                    result = _firstNumber * _secondNumber;
                    break;
                case "÷":
                    if (_secondNumber == 0)
                    {
                        MessageBox.Show("不能除以零！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDisplay.Text = "0";
                        _operation = "";
                        return;
                    }
                    result = _firstNumber / _secondNumber;
                    break;
            }

            txtDisplay.Text = result.ToString();
            _operation = "";
            _isOperationPressed = false;
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            _firstNumber = 0;
            _secondNumber = 0;
            _operation = "";
            _isOperationPressed = false;
        }

        private void BtnDecimal_Click(object? sender, EventArgs e)
        {
            if (_isOperationPressed)
            {
                txtDisplay.Text = "0";
                _isOperationPressed = false;
            }

            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }
    }
}
