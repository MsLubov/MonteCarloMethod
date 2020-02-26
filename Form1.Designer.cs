namespace ChM_Monte_Karlo
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.nSqrt = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnSkobki = new System.Windows.Forms.Button();
            this.btnCTan = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnCh = new System.Windows.Forms.Button();
            this.btnSh = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtSimple = new System.Windows.Forms.TextBox();
            this.btnY = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGeometric = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEps = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 25);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(351, 20);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "x+y";
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(12, 196);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(45, 23);
            this.btnPlus.TabIndex = 30;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(63, 196);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(45, 23);
            this.btnMinus.TabIndex = 30;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(114, 196);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(45, 23);
            this.btnMult.TabIndex = 30;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(165, 196);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(45, 23);
            this.btnDiv.TabIndex = 30;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(216, 196);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(45, 23);
            this.btnPower.TabIndex = 30;
            this.btnPower.Text = "^";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // nSqrt
            // 
            this.nSqrt.Location = new System.Drawing.Point(12, 225);
            this.nSqrt.Name = "nSqrt";
            this.nSqrt.Size = new System.Drawing.Size(45, 23);
            this.nSqrt.TabIndex = 30;
            this.nSqrt.Text = "sqrt";
            this.nSqrt.UseVisualStyleBackColor = true;
            this.nSqrt.Click += new System.EventHandler(this.nSqrt_Click);
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(63, 225);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(45, 23);
            this.btnExp.TabIndex = 30;
            this.btnExp.Text = "exp";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnSkobki
            // 
            this.btnSkobki.Location = new System.Drawing.Point(267, 196);
            this.btnSkobki.Name = "btnSkobki";
            this.btnSkobki.Size = new System.Drawing.Size(45, 23);
            this.btnSkobki.TabIndex = 13;
            this.btnSkobki.Text = "( )";
            this.btnSkobki.UseVisualStyleBackColor = true;
            this.btnSkobki.Click += new System.EventHandler(this.btnSkobki_Click);
            // 
            // btnCTan
            // 
            this.btnCTan.Location = new System.Drawing.Point(318, 225);
            this.btnCTan.Name = "btnCTan";
            this.btnCTan.Size = new System.Drawing.Size(45, 23);
            this.btnCTan.TabIndex = 12;
            this.btnCTan.Text = "ctg";
            this.btnCTan.UseVisualStyleBackColor = true;
            this.btnCTan.Click += new System.EventHandler(this.btnCTan_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(267, 225);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(45, 23);
            this.btnTan.TabIndex = 11;
            this.btnTan.Text = "tg";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(216, 225);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(45, 23);
            this.btnCos.TabIndex = 30;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(165, 225);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(45, 23);
            this.btnSin.TabIndex = 30;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnLn
            // 
            this.btnLn.Location = new System.Drawing.Point(114, 225);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(45, 23);
            this.btnLn.TabIndex = 30;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(318, 196);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(267, 254);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(96, 23);
            this.btnEqual.TabIndex = 7;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(114, 254);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(45, 23);
            this.btnX.TabIndex = 17;
            this.btnX.Text = "x";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnCh
            // 
            this.btnCh.Location = new System.Drawing.Point(63, 254);
            this.btnCh.Name = "btnCh";
            this.btnCh.Size = new System.Drawing.Size(45, 23);
            this.btnCh.TabIndex = 16;
            this.btnCh.Text = "ch";
            this.btnCh.UseVisualStyleBackColor = true;
            this.btnCh.Click += new System.EventHandler(this.btnCh_Click);
            // 
            // btnSh
            // 
            this.btnSh.Location = new System.Drawing.Point(12, 254);
            this.btnSh.Name = "btnSh";
            this.btnSh.Size = new System.Drawing.Size(45, 23);
            this.btnSh.TabIndex = 15;
            this.btnSh.Text = "sh";
            this.btnSh.UseVisualStyleBackColor = true;
            this.btnSh.Click += new System.EventHandler(this.btnSh_Click);
            // 
            // btnPi
            // 
            this.btnPi.Location = new System.Drawing.Point(216, 254);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(45, 23);
            this.btnPi.TabIndex = 21;
            this.btnPi.Text = "pi";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Подынтегральная функция:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Пределы интегрирования:";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(31, 64);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(74, 20);
            this.txtX1.TabIndex = 1;
            this.txtX1.Text = "0";
            this.txtX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtSimple
            // 
            this.txtSimple.Location = new System.Drawing.Point(111, 116);
            this.txtSimple.Name = "txtSimple";
            this.txtSimple.Size = new System.Drawing.Size(252, 20);
            this.txtSimple.TabIndex = 27;
            this.txtSimple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRes_KeyPress);
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(165, 254);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(45, 23);
            this.btnY.TabIndex = 28;
            this.btnY.Text = "y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Y:";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(111, 64);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(74, 20);
            this.txtX2.TabIndex = 2;
            this.txtX2.Text = "2";
            this.txtX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(289, 64);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(74, 20);
            this.txtY2.TabIndex = 4;
            this.txtY2.Text = "2";
            this.txtY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(209, 64);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(74, 20);
            this.txtY1.TabIndex = 3;
            this.txtY1.Text = "0";
            this.txtY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Простейший ММК:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Геометрический ММК:";
            // 
            // txtGeometric
            // 
            this.txtGeometric.Location = new System.Drawing.Point(137, 142);
            this.txtGeometric.Name = "txtGeometric";
            this.txtGeometric.Size = new System.Drawing.Size(226, 20);
            this.txtGeometric.TabIndex = 36;
            this.txtGeometric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRes_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Точность:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Уровень надёжности:";
            // 
            // txtEps
            // 
            this.txtEps.Location = new System.Drawing.Point(75, 90);
            this.txtEps.Name = "txtEps";
            this.txtEps.Size = new System.Drawing.Size(74, 20);
            this.txtEps.TabIndex = 5;
            this.txtEps.Text = "0,001";
            this.txtEps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(289, 90);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(74, 20);
            this.txtP.TabIndex = 6;
            this.txtP.Text = "99,997";
            this.txtP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 165);
            this.label10.MaximumSize = new System.Drawing.Size(150, 28);
            this.label10.MinimumSize = new System.Drawing.Size(50, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 28);
            this.label10.TabIndex = 41;
            this.label10.Text = "Частичное аналитическое интегрирование:";
            // 
            // txtFunc
            // 
            this.txtFunc.Location = new System.Drawing.Point(156, 170);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(207, 20);
            this.txtFunc.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 300);
            this.Controls.Add(this.txtFunc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtEps);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGeometric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.txtSimple);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnCh);
            this.Controls.Add(this.btnSh);
            this.Controls.Add(this.btnSkobki);
            this.Controls.Add(this.btnCTan);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.nSqrt);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.textBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Метод Монте-Карло";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button nSqrt;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnSkobki;
        private System.Windows.Forms.Button btnCTan;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnCh;
        private System.Windows.Forms.Button btnSh;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtSimple;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGeometric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEps;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFunc;
    }
}

