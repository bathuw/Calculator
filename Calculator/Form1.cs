using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtsoA.Text);
            b = int.Parse(txtsoB.Text);
            Calculation c = new Calculation(a, b);
            ketQua = c.Execute("+");
            txtKQ.Text = ketQua.ToString();

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtsoA.Text);
            b = int.Parse(txtsoB.Text);
            Calculation c = new Calculation(a, b);
            ketQua = c.Execute("-");
            txtKQ.Text = ketQua.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtsoA.Text);
            b = int.Parse(txtsoB.Text);
            Calculation c = new Calculation(a, b);
            ketQua = c.Execute("*");
            txtKQ.Text = ketQua.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtsoA.Text);
            b = int.Parse(txtsoB.Text);
            Calculation c = new Calculation(a, b);
            ketQua = c.Execute("/");
            txtKQ.Text = ketQua.ToString();
        }

        private void btnMu_Click(object sender, EventArgs e)
        {
            int n;
            double x,ketQua;
            x = double.Parse(txtsoA.Text);
            n = int.Parse(txtsoB.Text);
            ketQua = Calculation.Power(x,n);
            txtKQ.Text = ketQua.ToString();
        }



        /* private void btnCong_Click(object sender, EventArgs e)
         {
             double a = double.Parse(txtsoA.Text);
             double b = double.Parse(txtsoB.Text);
             double c = a + b;
             txtKQ.Text=c.ToString();
         }*/
    }
}
