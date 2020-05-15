using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap_maytinh
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

       
        private void btn1_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 1;
            txt_ketqua.Text = ketqua.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 2;
            txt_ketqua.Text = ketqua.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 3;
            txt_ketqua.Text = ketqua.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 4;
            txt_ketqua.Text = ketqua.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 5;
            txt_ketqua.Text = ketqua.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 6;
            txt_ketqua.Text = ketqua.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 7;
            txt_ketqua.Text = ketqua.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 8;
            txt_ketqua.Text = ketqua.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 9;
            txt_ketqua.Text = ketqua.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 0;
            txt_ketqua.Text = ketqua.ToString();
        }

        private void btnbang_Click(object sender, EventArgs e)
        {
            if (co)
            {
                switch (pheptoan)
                {
                    case '+':
                        ketqua += giatrinho;
                        txt_ketqua.Text = ketqua.ToString();
                        giatrinho = 0;
                        co = false;
                        break;
                    case '-':
                        ketqua = giatrinho - ketqua;
                        txt_ketqua.Text = ketqua.ToString();
                        giatrinho = 0;
                        co = false;
                        break;
                    case '*':
                        ketqua = giatrinho * ketqua;
                        txt_ketqua.Text = ketqua.ToString();
                        giatrinho = 0;
                        co = false;
                        break;
                    case '/':
                        ketqua = giatrinho / ketqua;
                        txt_ketqua.Text = ketqua.ToString();
                        giatrinho = 0;
                        co = false;
                        break;
                }
            }

        }

        private void btncong_Click(object sender, EventArgs e)
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
                txt_ketqua.Text = ketqua.ToString();
                giatrinho = ketqua;
                ketqua = 0;
            }

        }

        private void btntru_Click(object sender, EventArgs e)
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
                txt_ketqua.Text = ketqua.ToString();
                giatrinho = ketqua;
                ketqua = 0;
            }
        }

        private void btnchia_Click(object sender, EventArgs e)
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
                txt_ketqua.Text = ketqua.ToString();
                giatrinho = ketqua;
                ketqua = 0;
            }
        }

        private void btnnhan_Click(object sender, EventArgs e)
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
                txt_ketqua.Text = ketqua.ToString();
                giatrinho = ketqua;
                ketqua = 0;
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            ketqua = Math.Sqrt(ketqua);
            txt_ketqua.Text = ketqua.ToString();
            ketqua = 0;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            ketqua = 0;
            co = false;
            giatrinho = 0;
            giatrinhoM = 0;
            txt_ketqua.Clear();
        } 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 96:
                    btn0_Click(sender, e);
                    break;
                case 97:
                    btn1_Click(sender, e);
                    break;
                case 98:
                    btn2_Click(sender, e);
                    break;
                case 99:
                    btn3_Click(sender, e);
                    break;
                case 100:
                    btn4_Click(sender, e);
                    break;
                case 101:
                    btn5_Click(sender, e);
                    break;
                case 102:
                    btn6_Click(sender, e);
                    break;
                case 103:
                    btn7_Click(sender, e);
                    break;
                case 104:
                    btn8_Click(sender, e);
                    break;
                case 105:
                    btn9_Click(sender, e);
                    break;
                case 106:
                    btnnhan_Click(sender, e);
                    break;
                case 107:
                    btncong_Click(sender, e);
                    break;
                case 108:
                    btnbang_Click(sender, e);
                    break;
                case 109:
                    btntru_Click(sender, e);
                    break;
                case 111:
                    btnchia_Click(sender, e);
                    break;
            }
        }
    }
}
