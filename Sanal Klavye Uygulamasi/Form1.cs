using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanal_Klavye_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void a_Click(object sender, EventArgs e)
        {
            SendKeys.Send("a");
            label2.Text = "[LOG]";
            label1.Text = "A Tuşuna Basıldı";
        }

        private void q_Click(object sender, EventArgs e)
        {
            SendKeys.Send("q");
            label2.Text = "[LOG]";
            label1.Text = "Q Tuşuna Basıldı";
        }

        private void w_Click(object sender, EventArgs e)
        {
            SendKeys.Send("w");
            label2.Text = "[LOG]";
            label1.Text = "W Tuşuna Basıldı";
        }

        private void e_Click(object sender, EventArgs e)
        {
            SendKeys.Send("e");
            label2.Text = "[LOG]";
            label1.Text = "E Tuşuna Basıldı";
        }

        private void r_Click(object sender, EventArgs e)
        {
            SendKeys.Send("r");
            label2.Text = "[LOG]";
            label1.Text = "R Tuşuna Basıldı";
        }

        private void t_Click(object sender, EventArgs e)
        {
            SendKeys.Send("t");
            label2.Text = "[LOG]";
            label1.Text = "T Tuşuna Basıldı";
        }

        private void y_Click(object sender, EventArgs e)
        {
            SendKeys.Send("y");
            label2.Text = "[LOG]";
            label1.Text = "Y Tuşuna Basıldı";
        }

        private void u_Click(object sender, EventArgs e)
        {
            SendKeys.Send("u");
            label2.Text = "[LOG]";
            label1.Text = "U Tuşuna Basıldı";
        }

        private void ı_Click(object sender, EventArgs e)
        {
            SendKeys.Send("ı");
            label2.Text = "[LOG]";
            label1.Text = "I Tuşuna Basıldı";
        }

        private void o_Click(object sender, EventArgs e)
        {
            SendKeys.Send("o");
            label2.Text = "[LOG]";
            label1.Text = "O Tuşuna Basıldı";
        }

        private void p_Click(object sender, EventArgs e)
        {
            SendKeys.Send("p");
            label2.Text = "[LOG]";
            label1.Text = "P Tuşuna Basıldı";
        }

        private void ğ_Click(object sender, EventArgs e)
        {
            SendKeys.Send("ğ");
            label2.Text = "[LOG]";
            label1.Text = "Ğ Tuşuna Basıldı";
        }

        private void ü_Click(object sender, EventArgs e)
        {
            SendKeys.Send("ü");
            label2.Text = "[LOG]";
            label1.Text = "Ü Tuşuna Basıldı";
        }

        private void virgul_Click(object sender, EventArgs e)
        {
            SendKeys.Send(",");
            label2.Text = "[LOG]";
            label1.Text = ", Tuşuna Basıldı";
        }

        private void s_Click(object sender, EventArgs e)
        {
            SendKeys.Send("s");
            label2.Text = "[LOG]";
            label1.Text = "S Tuşuna Basıldı";
        }

        private void d_Click(object sender, EventArgs e)
        {
            SendKeys.Send("d");
            label2.Text = "[LOG]";
            label1.Text = "D Tuşuna Basıldı";
        }

        private void f_Click(object sender, EventArgs e)
        {
            SendKeys.Send("f");
            label2.Text = "[LOG]";
            label1.Text = "F Tuşuna Basıldı";
        }

        private void g_Click(object sender, EventArgs e)
        {
            SendKeys.Send("g");
            label2.Text = "[LOG]";
            label1.Text = "G Tuşuna Basıldı";
        }

        private void h_Click(object sender, EventArgs e)
        {
            SendKeys.Send("h");
            label2.Text = "[LOG]";
            label1.Text = "H Tuşuna Basıldı";
        }

        private void j_Click(object sender, EventArgs e)
        {
            SendKeys.Send("j");
            label2.Text = "[LOG]";
            label1.Text = "J Tuşuna Basıldı";
        }

        private void k_Click(object sender, EventArgs e)
        {
            SendKeys.Send("k");
            label2.Text = "[LOG]";
            label1.Text = "K Tuşuna Basıldı";
        }

        private void l_Click(object sender, EventArgs e)
        {
            SendKeys.Send("l");
            label2.Text = "[LOG]";
            label1.Text = "L Tuşuna Basıldı";
        }

        private void ş_Click(object sender, EventArgs e)
        {
            SendKeys.Send("ş");
            label2.Text = "[LOG]";
            label1.Text = "Ş Tuşuna Basıldı";
        }

        private void i_Click(object sender, EventArgs e)
        {
            SendKeys.Send("i");
            label2.Text = "[LOG]";
            label1.Text = "İ Tuşuna Basıldı";
        }

        private void z_Click(object sender, EventArgs e)
        {
            SendKeys.Send("z");
            label2.Text = "[LOG]";
            label1.Text = "Z Tuşuna Basıldı";
        }

        private void x_Click(object sender, EventArgs e)
        {
            SendKeys.Send("x");
            label2.Text = "[LOG]";
            label1.Text = "X Tuşuna Basıldı";
        }

        private void c_Click(object sender, EventArgs e)
        {
            SendKeys.Send("c");
            label2.Text = "[LOG]";
            label1.Text = "C Tuşuna Basıldı";
        }

        private void v_Click(object sender, EventArgs e)
        {
            SendKeys.Send("v");
            label2.Text = "[LOG]";
            label1.Text = "V Tuşuna Basıldı";
        }

        private void b_Click(object sender, EventArgs e)
        {
            SendKeys.Send("b");
            label2.Text = "[LOG]";
            label1.Text = "B Tuşuna Basıldı";
        }

        private void n_Click(object sender, EventArgs e)
        {
            SendKeys.Send("n");
            label2.Text = "[LOG]";
            label1.Text = "N Tuşuna Basıldı";
        }

        private void m_Click(object sender, EventArgs e)
        {
            SendKeys.Send("m");
            label2.Text = "[LOG]";
            label1.Text = "M Tuşuna Basıldı";
        }

        private void ö_Click(object sender, EventArgs e)
        {
            SendKeys.Send("ö");
            label2.Text = "[LOG]";
            label1.Text = "Ö Tuşuna Basıldı";
        }

        private void ç_Click(object sender, EventArgs e)
        {
            SendKeys.Send("ç");
            label2.Text = "[LOG]";
            label1.Text = "Ç Tuşuna Basıldı";
        }

        private void nokta_Click(object sender, EventArgs e)
        {
            SendKeys.Send(".");
            label2.Text = "[LOG]";
            label1.Text = ". Tuşuna Basıldı";
        }

        private void star_Click(object sender, EventArgs e)
        {
            SendKeys.Send("*");
            label2.Text = "[LOG]";
            label1.Text = "* Tuşuna Basıldı";
        }

        private void eksi_Click(object sender, EventArgs e)
        {
            SendKeys.Send("-");
            label2.Text = "[LOG]";
            label1.Text = "- Tuşuna Basıldı";
        }

        private void top_v_Click(object sender, EventArgs e)
        {
            SendKeys.Send("''");
            label2.Text = "[LOG]";
            label1.Text = "'' Tuşuna Basıldı";
        }

        private void enter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
            label2.Text = "[LOG]";
            label1.Text = "ENTER Tuşuna Basıldı";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DELETE}");
            label2.Text = "[LOG]";
            label1.Text = "DELETE Tuşuna Basıldı";
        }

        private void up_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
            label2.Text = "[LOG]";
            label1.Text = "UP Tuşuna Basıldı";
        }

        private void down_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
            label2.Text = "[LOG]";
            label1.Text = "DOWN Tuşuna Basıldı";
        }

        private void left_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
            label2.Text = "[LOG]";
            label1.Text = "Left Tuşuna Basıldı";
        }

        private void right_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
            label2.Text = "[LOG]";
            label1.Text = "RIGHT Tuşuna Basıldı";
        }

        private void esc_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
            label2.Text = "[LOG]";
            label1.Text = "ESC Tuşuna Basıldı";
        }

        private void tab_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
            label2.Text = "[LOG]";
            label1.Text = "TAB Tuşuna Basıldı";
        }

        private void fn_Click(object sender, EventArgs e)
        {
            SendKeys.Send("@");
            label2.Text = "[LOG]";
            label1.Text = "@ Tuşuna Basıldı";
        }

        private void one_Click(object sender, EventArgs e)
        {
            SendKeys.Send("1");
            label2.Text = "[LOG]";
            label1.Text = "1 Tuşuna Basıldı";
        }

        private void two_Click(object sender, EventArgs e)
        {
            SendKeys.Send("2");
            label2.Text = "[LOG]";
            label1.Text = "2 Tuşuna Basıldı";
        }

        private void three_Click(object sender, EventArgs e)
        {
            SendKeys.Send("3");
            label2.Text = "[LOG]";
            label1.Text = "3 Tuşuna Basıldı";
        }

        private void four_Click(object sender, EventArgs e)
        {
            SendKeys.Send("4");
            label2.Text = "[LOG]";
            label1.Text = "4 Tuşuna Basıldı";
        }

        private void five_Click(object sender, EventArgs e)
        {
            SendKeys.Send("5");
            label2.Text = "[LOG]";
            label1.Text = "5 Tuşuna Basıldı";
        }

        private void six_Click(object sender, EventArgs e)
        {
            SendKeys.Send("6");
            label2.Text = "[LOG]";
            label1.Text = "6 Tuşuna Basıldı";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            SendKeys.Send("7");
            label2.Text = "[LOG]";
            label1.Text = "7 Tuşuna Basıldı";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            SendKeys.Send("8");
            label2.Text = "[LOG]";
            label1.Text = "8 Tuşuna Basıldı";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            SendKeys.Send("9");
            label2.Text = "[LOG]";
            label1.Text = "9 Tuşuna Basıldı";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0");
            label2.Text = "[LOG]";
            label1.Text = "0 Tuşuna Basıldı";
        }

        private void shift_Click(object sender, EventArgs e)
        {
            SendKeys.Send("+");
            label2.Text = "[LOG]";
            label1.Text = "SHIFT Tuşuna Basıldı";
        }

        private void shift_2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("+");
            label2.Text = "[LOG]";
            label1.Text = "SHIFT Tuşuna Basıldı";
        }

        private void alt_Click(object sender, EventArgs e)
        {
            SendKeys.Send("%");
            label2.Text = "[LOG]";
            label1.Text = "ALT Tuşuna Basıldı";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
            label2.Text = "[LOG]";
            label1.Text = "BACKSPACE Tuşuna Basıldı";
        }

        private void space_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
            label2.Text = "[LOG]";
            label1.Text = "Boşluk (SPACE) Tuşuna Basıldı";
        }

        private void copypaste_Click(object sender, EventArgs e)
        {
            SendKeys.Send("+");
            label2.Text = "[LOG]";
            label1.Text = "+ Tuşuna Basıldı";
        }

        private void ctrl_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^");
            label2.Text = "[LOG]";
            label1.Text = "CTRL Tuşuna Basıldı";
        }

        private void ctrl_2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^");
            label2.Text = "[LOG]";
            label1.Text = "CTRL Tuşuna Basıldı";
        }

        private void alt_2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("%");
            label2.Text = "[LOG]";
            label1.Text = "ALT Tuşuna Basıldı";
        }

        private void capslock_Click(object sender, EventArgs e)
        {
            q.Text = "Q";
            w.Text = "W";
            ee.Text = "E";
            r.Text = "R";
            y.Text = "Y";
            u.Text = "U";
            ı.Text = "I";
            o.Text = "O";
            p.Text = "P";
            ğ.Text = "Ğ";
            ü.Text = "Ü";
            a.Text = "A";
            s.Text = "S";
            d.Text = "D";
            f.Text = "F";
            g.Text = "G";
            h.Text = "H";
            j.Text = "J";
            k.Text = "K";
            l.Text = "L";
            ş.Text = "Ş";
            i.Text = "İ";
            z.Text = "Z";
            x.Text = "X";
            c.Text = "C";
            v.Text = "V";
            b.Text = "B";
            n.Text = "N";
            m.Text = "M";
            ö.Text = "Ö";
            ç.Text = "Ç";
        }

            //q.Text = "q";
            //w.Text = "w";
            //ee.Text = "e";
            //r.Text = "r";
            //y.Text = "y";
            //u.Text = "u";
            //ı.Text = "ı";
            //o.Text = "o";
            //p.Text = "o";
            //ğ.Text = "ğ";
            //ü.Text = "ü";
            //a.Text = "a";
            //s.Text = "s";
            //d.Text = "d";
            //f.Text = "f";
            //g.Text = "g";
            //h.Text = "h";
            //j.Text = "j";
            //k.Text = "k";
            //l.Text = "l";
            //ş.Text = "ş";
            //i.Text = "i";
            //z.Text = "z";
            //x.Text = "x";
            //c.Text = "c";
            //v.Text = "v";
            //b.Text = "b";
            //n.Text = "n";
            //m.Text = "m";
            //ö.Text = "ö";
            //ç.Text = "ç";

        private void windows_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
            label2.Text = "[LOG]";
            label1.Text = "Home Tuşuna Basıldı";
        }
    }
}
