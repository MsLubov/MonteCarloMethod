using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace ChM_Monte_Karlo
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class Monte_Karlo
    {
        double eps = 1e-14;
        double nu = 0.01;
        public double Eps
        {
            get { return eps; }
            set
            {
                if (value > 0) eps = value;
                else throw new ArgumentException();
            }
        }
        public double Nu
        {
            get { return nu; }
            set
            {
                if (value > 0 && value < 1) nu = value;
                else throw new ArgumentException();
            }
        }
        public ArrayList InfixToPostfix(string expr)
        {
            expr += "=";
            ArrayList result = new ArrayList();
            Stack stack = new Stack();
            double d=0;
            bool intPart = true;
            char ch = ' ';
            int k = 1;
            while (expr.Length != 0)
            {
                ch = expr[0];
                expr = expr.Remove(0, 1);
                if (char.IsDigit(ch))
                {
                    if (intPart) d = d * 10 + double.Parse(ch.ToString());
                    else
                    {
                        d = d + double.Parse(ch.ToString()) * Math.Pow(0.1,k);
                        k++;
                    }
                    if (!char.IsDigit(expr[0]) && expr[0]!='.' && expr[0]!=',')
                    {
                        result.Add(d);
                        d = 0;
                        intPart = true;
                    }
                }
                else if (ch == '.' || ch == ',')
                {
                    intPart = false;
                }
                else
                {
                    if (ch == '^')
                    {
                        if (stack.Count != 0)
                        {
                            string s = stack.Peek().ToString();
                            while (s!="(" && s!="+" && s!="-" && s!="*" && s!="/")
                            {
                                result.Add(s);
                                stack.Pop();
                                if (stack.Count != 0) s = stack.Peek().ToString();
                                else break;
                            }
                        }
                        stack.Push(ch);
                    }
                    else if (ch == '*' || ch == '/')
                    {
                        if (stack.Count != 0)
                        {
                            string s = stack.Peek().ToString();
                            while (s != "(" && s != "+" && s != "-")
                            {
                                result.Add(s);
                                stack.Pop();
                                if (stack.Count != 0) s = stack.Peek().ToString();
                                else break;
                            }
                        }
                        stack.Push(ch);
                    }
                    else if (ch == '+' || ch == '-')
                    {
                        if (stack.Count != 0)
                        {
                            string s = stack.Peek().ToString();
                            while (s != "(")
                            {
                                result.Add(s);
                                stack.Pop();
                                if (stack.Count != 0) s = stack.Peek().ToString();
                                else break;
                            }
                        }
                        stack.Push(ch);
                    }
                    else if (ch == '(')
                    {
                        stack.Push(ch);
                    }
                    else if (ch == ')')
                    {
                        object s = stack.Pop();
                        while (stack.Count >= 0 && s.ToString() != "(")
                        {
                            result.Add(s);
                            s = stack.Pop();
                        }
                    }
                    else if (ch == 'x' || ch == 'y')
                    {
                        result.Add(ch);
                    }
                    else if (ch == 'p')
                    {
                        result.Add("pi");
                        expr = expr.Remove(0, 1);
                    }
                    else if (ch == 's' || ch == 'c' || ch == 'l' || ch == 't' || ch == 'e')
                    {
                        switch (ch)
                        {
                            case 's':
                                ch = expr[0];
                                expr = expr.Remove(0, 1);
                                if (ch == 'i')
                                {
                                    expr = expr.Remove(0, 1);
                                    stack.Push("sin");
                                }
                                if (ch == 'q')
                                {
                                    expr = expr.Remove(0, 2);
                                    stack.Push("sqrt");
                                }
                                if (ch == 'h')
                                {
                                    stack.Push("sh");
                                }
                                break;
                            case 'c':
                                ch = expr[0];
                                expr = expr.Remove(0, 1);
                                if (ch == 'o')
                                {
                                    expr = expr.Remove(0, 1);
                                    stack.Push("cos");
                                }
                                if (ch == 'h')
                                {
                                    stack.Push("ch");
                                }
                                if (ch == 't')
                                {
                                    expr = expr.Remove(0, 1);
                                    stack.Push("ctg");
                                }
                                break;
                            case 'l':
                                expr = expr.Remove(0, 1);
                                stack.Push("ln");
                                break;
                            case 't':
                                expr = expr.Remove(0, 1);
                                stack.Push("tg");
                                break;
                            case 'e':
                                expr = expr.Remove(0, 2);
                                stack.Push("exp");
                                break;
                        }
                    }
                }
            }
            while (stack.Count != 0)
            {
                result.Add(stack.Pop());
            }
            return result;
        } // InfixToPostfix

        /*public double F(ArrayList postfix, double x, double y)
        {
            Stack<double> stack = new Stack<double>();
            foreach (object o in postfix)
            {
                string s = o.ToString();
                double d;
                if (double.TryParse(s, out d)) stack.Push(d);
                else if (s == "x") stack.Push(x);
                else if (s == "y") stack.Push(y);
                else if (s == "pi") stack.Push(Math.PI);
                else if (s == "+") stack.Push(stack.Pop() + stack.Pop());
                else if (s == "-")
                {
                    double d1 = stack.Pop();
                    stack.Push(stack.Pop() - d1);
                }
                else if (s == "*") stack.Push(stack.Pop() * stack.Pop());
                else if (s == "/")
                {
                    double d1 = stack.Pop();
                    stack.Push(stack.Pop() / d1);
                }
                else if (s == "^")
                {
                    double d1 = stack.Pop();
                    stack.Push(Math.Pow(stack.Pop(),d1));
                }
                else if (s == "sin") stack.Push(Math.Sin(stack.Pop()));
                else if (s == "sh") stack.Push(Math.Sinh(stack.Pop()));
                else if (s == "sqrt") stack.Push(Math.Sqrt(stack.Pop()));
                else if (s == "cos") stack.Push(Math.Cos(stack.Pop()));
                else if (s == "ch") stack.Push(Math.Cosh(stack.Pop()));
                else if (s == "ctg") stack.Push(1 / Math.Tan(stack.Pop()));
                else if (s == "ln") stack.Push(Math.Log(stack.Pop()));
                else if (s == "tg") stack.Push(Math.Tan(stack.Pop()));
                else if (s == "exp") stack.Push(Math.Exp(stack.Pop()));
            }
            return stack.Pop();
        } // F*/

        public double SimpleMethod(double x1, double x2, double y1, double y2)
        {
            double y = 0;
            double phi = 0;
            try
            {
                StreamReader file = new StreamReader("erf.txt");
                while (!file.EndOfStream)
                {
                    string[] inf = file.ReadLine().Trim().Split(new char[] { '\t' }, 2);
                    if (inf.Length == 2 && double.TryParse(inf[1], out phi) && phi >= (1 - Math.Sqrt(Math.PI / 2) * nu) / Math.Sqrt(2 * Math.PI) && double.TryParse(inf[0], out y))
                    {
                        break;
                    }
                }
                file.Close();
            }
            catch
            {
                MessageBox.Show("Файл erf.txt не найден!");
                return 0;
            }
            Random rnd = new Random(DateTime.Now.Second);
            int N = 1;
            double f = F(x1 + rnd.NextDouble() * (x2 - x1), y1 + rnd.NextDouble() * (y2 - y1));
            double t = f;
            double S = t;
            double d = 0, D = 0;
            double dx = x2 - x1, dy = y2 - y1;
            double lambda = double.MaxValue;
            while (lambda > eps*eps)
            {
                N++;
                if (N > 10000000)
                {
                    MessageBox.Show("N > 10000000!");
                    return S;
                }
                f = F(x1 + rnd.NextDouble() * dx, y1 + rnd.NextDouble() * dy);
                t += f;
                S = t/N;
                d += (f - S)*(f - S)*N/(N-1.0);
                D = d/(N-1.0);
                lambda = y*y * (D / N);
            }
            return dx*dy*S;
        } // SimpleMethod

        public double GeometricMethod(double x1, double x2, double y1, double y2)
        {
            int N = 1000000;
            Random rnd = new Random(DateTime.Now.Millisecond);
            double maxF = 0, minF = 0;
            int N1 = 0;
            for (double i = x1; i < x2; i+=(x2-x1)/100)
                for (double j = y1; j < y2; j+=(y2-y1)/100)
                {
                    double f = F(i,j);
                    if (f > maxF) maxF = f;
                    else if (f < minF) minF = f;
                }
            for (int i = 0; i < N; i++)
            {
                if (minF + rnd.NextDouble() * (maxF - minF) < F(x1 + rnd.NextDouble() * (x2 - x1), y1 + rnd.NextDouble() * (y2 - y1)))
                    N1++;
            }
            return (x2 - x1) * (y2 - y1) * (maxF - minF) * N1 / N;
        } // GeometricMethod

        public double FunctionMethod(double x1, double x2, double y1, double y2)
        {
            double y = 0;
            double phi = 0;
            try
            {
                StreamReader file = new StreamReader("erf.txt");
                while (!file.EndOfStream)
                {
                    string[] inf = file.ReadLine().Trim().Split(new char[] { '\t' }, 2);
                    if (inf.Length == 2 && double.TryParse(inf[1], out phi) && phi >= (1 - Math.Sqrt(Math.PI / 2) * nu) / Math.Sqrt(2 * Math.PI) && double.TryParse(inf[0], out y))
                    {
                        break;
                    }
                }
                file.Close();
            }
            catch
            {
                MessageBox.Show("Файл erf.txt не найден!");
                return 0;
            }
            Random rnd = new Random(DateTime.Now.Second);
            int N = 1;
            double dx = x2 - x1, dy = y2 - y1;
            double f = F1(x1 + rnd.NextDouble() * (x2 - x1), y1 + rnd.NextDouble() * (y2 - y1),dx/2,dy/2);
            double t = f;
            double S = t;
            double d = 0, D = 0;
            double lambda = double.MaxValue;
            while (lambda > eps * eps)
            {
                N++;
                if (N > 10000000)
                {
                    MessageBox.Show("N > 10000000!");
                    return S;
                }
                f = F1(x1 + rnd.NextDouble() * dx, y1 + rnd.NextDouble() * dy,dx/2,dy/2);
                t += f;
                S = t / N;
                d += (f - S) * (f - S) * N / (N - 1.0);
                D = d / (N - 1.0);
                lambda = y * y * (D / N);
            }
            return dx * dy * S + Int(x1, x2, y1, y2);
        } // FunctionMethod

        private double Teylor1(double x, double y, double a, double b)
        {
            double e = 1e-5;
            return F(a, b) + (x - a) * (F(a + e, b) - F(a - e, b)) / (2 * e) + (y - a) * (F(a, b + e) - F(a, b - e)) / (2 * e);
        } // Teylor1

        private double F1(double x, double y, double a, double b)
        {
            return F(x, y) - Teylor1(x, y, a, b);
        } // F1

        private double Int(double x1, double x2, double y1, double y2)
        {
            double e = 1e-5;
            double dx = (x2 - x1), dy = (y2 - y1), a = x1+dx/2, b = y1+dy/2;
            return F(a, b) * dx * dy + (F(a + e, b) - F(a - e, b)) / (4 * e) * (x1 * x1 - 2 * a * x1 - x2 * x2 + 2 * x2 * a) * dy + (F(a, b + e) - F(a, b - e)) / (4 * e) * (y1 * y1 - 2 * a * y1 - y2 * y2 + 2 * y2 * a) * dx;
        } // Int

        public double F(double x, double y)
        {
            return Math.Cos(x+y);
        } // F
    }
}
