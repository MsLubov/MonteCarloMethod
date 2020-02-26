using System;
using System.Collections.Generic;
using System.Collections;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
//using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ChM_Monte_Karlo
{
    public partial class Form1 : Form
    {
        Monte_Karlo mk = new Monte_Karlo();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch!=',')
            {
                e.Handled = true;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "+";
            textBox.Focus();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "-";
            textBox.Focus();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "*";
            textBox.Focus();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "/";
            textBox.Focus();
        }

        private void btnSkobki_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "()";
            textBox.Focus();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "^";
            textBox.Focus();
        }

        private void nSqrt_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "sqrt()";
            textBox.Focus();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtX1.Text == string.Empty || txtX2.Text == string.Empty || txtY1.Text == string.Empty || txtY2.Text == string.Empty || textBox.Text == string.Empty || txtEps.Text == string.Empty || txtP.Text == string.Empty)
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            double x1 = double.Parse(txtX1.Text);
            double x2 = double.Parse(txtX2.Text);
            double y1 = double.Parse(txtY1.Text);
            double y2 = double.Parse(txtY2.Text);
            if ((x1 > x2) || (y1 > y2)) 
            {
                MessageBox.Show("Неверно указаны пределы интегрирования!");
                return;
            }
            if (double.Parse(txtP.Text) >= 100)
            {
                MessageBox.Show("Уровень надёжности находится в пределах от 0% до 100%!");
                return;
            }
            mk.Eps = double.Parse(txtEps.Text);
            mk.Nu = 1 - double.Parse(txtP.Text)*0.01;
            ArrayList postfix = mk.InfixToPostfix(textBox.Text);
            Cursor.Current = Cursors.WaitCursor;
            txtSimple.Text = " = " + mk.SimpleMethod(x1, x2, y1, y2);
            txtGeometric.Text = " = " + mk.GeometricMethod(x1, x2, y1, y2);
            //txtParts.Text = " = " + mk.PartsMethod(x1, x2, y1, y2);
            txtFunc.Text = " = " + mk.FunctionMethod(x1, x2, y1, y2);
            Cursor.Current = Cursors.Arrow;
            }
            catch
            {
                MessageBox.Show("Неверно введено выражение!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            txtX1.Clear();
            txtX2.Clear();
            txtY1.Clear();
            txtY2.Clear();
            txtSimple.Clear();
            textBox.Focus();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "x";
            textBox.Focus();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "exp()";
            textBox.Focus();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "ln()";
            textBox.Focus();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "sin()";
            textBox.Focus();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "cos()";
            textBox.Focus();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "tg()";
            textBox.Focus();
        }

        private void btnCTan_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "ctg()";
            textBox.Focus();
        }

        private void btnSh_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "sh()";
            textBox.Focus();
        }

        private void btnCh_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "ch()";
            textBox.Focus();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "pi";
            textBox.Focus();
        }

        private void txtRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            textBox.SelectedText += "y";
            textBox.Focus();
        }
    }
}
