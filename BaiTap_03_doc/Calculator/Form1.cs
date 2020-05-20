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
        private double ketqua;
        private double giatrinho;
        private double giatrinhoM;
        private bool co; // cờ kiểm tra
        char pheptoan;

        public Form1()
        {
            InitializeComponent();
            ketqua = 0;
            co = false;
            giatrinho = 0;
            giatrinhoM = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 1;
            txtKq.Text = ketqua.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 2;
            txtKq.Text = ketqua.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 3;
            txtKq.Text = ketqua.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 4;
            txtKq.Text = ketqua.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 5;
            txtKq.Text = ketqua.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 6;
            txtKq.Text = ketqua.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 7;
            txtKq.Text = ketqua.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 8;
            txtKq.Text = ketqua.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 9;
            txtKq.Text = ketqua.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 0;
            txtKq.Text = ketqua.ToString();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (!co)
            {
                giatrinho = ketqua;
                ketqua = 0;
                co = true; // có nhớ giá trị
                pheptoan = '+';
            }
            else
            {
                ketqua += giatrinho;
                txtKq.Text = ketqua.ToString();
                giatrinho = ketqua;
                ketqua = 0;
            }

        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (!co)
            {
                giatrinho = ketqua;
                ketqua = 0;
                co = true; // có nhớ giá trị
                pheptoan = '/';
            }
            else
            {
                ketqua = giatrinho / ketqua;
                txtKq.Text = ketqua.ToString();
                giatrinho = ketqua;
                ketqua = 0;
            }

        }

        private void btnCongTru_Click(object sender, EventArgs e)
        {
            if ((co == true) && (ketqua == 0))
            {
                giatrinho = -giatrinho;
                ketqua = giatrinho;
                txtKq.Text = ketqua.ToString();
                ketqua = 0;
            }
            else
            {
                ketqua = -ketqua;
                txtKq.Text = ketqua.ToString();
            }

        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if (co)
            {
                switch (pheptoan)
                {
                    case '+':
                        ketqua += giatrinho;
                        txtKq.Text = ketqua.ToString();
                        giatrinho = 0;
                        co = false;
                        break;
                    case '-':
                        ketqua = giatrinho - ketqua;
                        txtKq.Text = ketqua.ToString();
                        giatrinho = 0;
                        co = false;
                        break;
                    case '*':
                        ketqua = giatrinho * ketqua;
                        txtKq.Text = ketqua.ToString();
                        giatrinho = 0;
                        co = false;
                        break;
                    case '/':
                        ketqua = giatrinho / ketqua;
                        txtKq.Text = ketqua.ToString();
                        giatrinho = 0;
                        co = false;
                        break;
                }
            }

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            ketqua = Math.Sqrt(ketqua);
            txtKq.Text = ketqua.ToString();
            ketqua = 0;

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ketqua = 0;
            co = false;
            giatrinho = 0;
            giatrinhoM = 0;
            txtKq.Text = "";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (!co)
            {
                giatrinho = ketqua;
                ketqua = 0;
                co = true; // có nhớ giá trị
                pheptoan = '-';
            }
            else
            {
                ketqua -= giatrinho;
                txtKq.Text = ketqua.ToString();
                giatrinho = ketqua;
                ketqua = 0;
            }

        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (!co)
            {
                giatrinho = ketqua;
                ketqua = 0;
                co = true; // có nhớ giá trị
                pheptoan = '*';
            }
            else
            {
                ketqua = giatrinho * ketqua;
                txtKq.Text = ketqua.ToString();
                giatrinho = ketqua;
                ketqua = 0;
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
         
         }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 48:
                    btn0_Click(sender, e);
                    break;
                case 108:
                    btnBang_Click(sender, e);
                    break;
               

            }
        }
    }

}
