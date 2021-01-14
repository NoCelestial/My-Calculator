using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Form1 : Form
    {
        double x, y, z;
        string op;
        Boolean flag;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtresult_TextChanged(null, null);
            btnoffon_Click(null, null);
            //if ()
        }

        private void btnoffon_Click(object sender, EventArgs e)
        {
            if (btnoffon.Text == "Off")
            {
                btnoffon.Text = "On";
                pnl1.Enabled = true;
                //pnl2.Enabled = true;
                //btnmos.Enabled = true;
                btnfloat.Enabled = false;
                //btnfloat.Enabled = true;
            }

            else
            {
                btnoffon.Text = "Off";
                pnl1.Enabled = false;
                pnl2.Enabled = false;
                btnmos.Enabled = false;
                btnfloat.Enabled = false;

            }


        }

        private void oprator(object sender, MouseEventArgs e)
        {
            if (op != null)
                btnmos_Click(null, null);

            op = ((Control)sender).Text;
            x = Convert.ToDouble(txtresult.Text);
            //txtresult.Text = op;
            //txtresult.Clear();
            flag = true;
            btnfloat.Enabled = false;
            btnmos.Enabled = !txtresult.Text.Contains(op);
        }

        private void btnmos_Click(object sender, MouseEventArgs e)
        {

            y = Convert.ToDouble(txtresult.Text);
            switch (op)
            {
                case "+":
                    z = x + y;
                    break;
                case "-":
                    z = x - y;
                    break;
                case "*":
                    z = x * y;
                    break;
                default:
                    z = x / y;
                    break;
            }
            txtresult.Text = z.ToString();
            op = null;
        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {
            if (txtresult.Text == "")
            {
                pnl2.Enabled = false;
                btnmos.Enabled = false;
            }
            else if (txtresult.Text != "")
            {
                pnl2.Enabled = true;
                btnmos.Enabled = true;
            }
            string target = txtresult.Text;
            btnfloat.Enabled = !target.Contains(".");
            if (target != "")
                btnc.Enabled = true;
            else if (target == "")
                btnc.Enabled = false;
        }


        private void keyfun(object sender, KeyPressEventArgs e)
        {
            Button sen = new Button();
            string key = e.KeyChar.ToString();
            sen.Text = key;
            if (btnoffon.Text != "Off")
            {
                foreach (Button x in  pnl1.Controls)
                    if (x.Text == key)
                        x.Focus();
                foreach (Button m in pnl2.Controls)
                    if (m.Text == key)
                        m.Focus();

                switch (key)
                {
                    case "1":
                        main_func(sen, null);
                        break;
                    case "2":
                        main_func(sen, null);
                        break;
                    case "3":
                        main_func(sen, null);
                        break;
                    case "4":
                        main_func(sen, null);
                        break;
                    case "5":
                        main_func(sen, null);
                        break;
                    case "6":
                        main_func(sen, null);
                        break;
                    case "7":
                        main_func(sen, null);
                        break;
                    case "8":
                        main_func(sen, null);
                        break;
                    case "9":
                        main_func(sen, null);
                        break;
                    case "0":
                        main_func(sen, null);
                        break;
                }
                if (key == "." && txtresult.Text.Contains(".") == false)
                {
                    main_func(sen, null);
                    btnfloat.Focus();
                }
                if (key == "+" || key == "-" || key == "*" || key == "/")
                    oprator(sen, null);
                if (key == "=")
                {
                    btnmos_Click(sen, null);
                    btnmos.Focus();
                }
                if (key == "\b")
                {
                    clear(sen, null);
                    btnc.Focus();
                }
                if (key == "c")
                {
                    clear(sen, null);
                    btnce.Focus();
                }
            }

        }

        private void btn0_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnmos_Click(null, null);
                btnmos.Focus();
            }
        }

        private void main_func(object sender, MouseEventArgs e)
        {
            switch (flag)
            {
                case true:
                    txtresult.Text = "";
                    flag = false;
                    break;

            }
            string txtmy = txtresult.Text;
            string target = ".";
            bool txtorg = txtmy.Contains(target);
            //txtresult.Text = op;
            if (((Control)sender).Text == ".")
                btnfloat.Enabled = false;
            else if (txtorg == false)
                btnfloat.Enabled = true;
            else if (txtorg == true)
                btnfloat.Enabled = false;
            string txt = ((Control)sender).Text;
            txtresult.Text += txt;
            
        }

        private void clear(object sender, MouseEventArgs e)
        {
            string txt = txtresult.Text;
            if (((Control)sender).Text == "CE")
            {
                txtresult.Clear();
                btnfloat.Enabled = false;
            }
            if (((Control)sender).Text == "C")
            {
                int a = txt.Length;
                string txt2 = txt.Substring(0, a - 1);
                txtresult.Text = txt2;
            }
            if (((Control)sender).Text == "\b")
            {
                int a = txt.Length;
                if (txt != "")
                {
                    string txt2 = txt.Substring(0, a - 1);
                    txtresult.Text = txt2;
                }
            }
            if (((Control)sender).Text == "c")
            {
                 txtresult.Clear();
                 btnfloat.Enabled = false;
            }

            
        }
    }
}
