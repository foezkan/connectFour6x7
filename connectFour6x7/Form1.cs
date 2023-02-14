using System;
using System.Drawing;
using System.Windows.Forms;

namespace connectFour6x7
{

    public partial class Form1 : Form
    {
       int schalter = 0;

        public Form1()
        {
            InitializeComponent();
        }
        void dran ()
        {
            if (schalter % 2 == 0)
            {
                btnDran.BackColor = Color.Red;
            }
            else
            {
                btnDran.BackColor = Color.Yellow;
            }
            schalter++;
        }

        void wechseln()
        {
            if (btnDran.BackColor == Color.Red)
            {
                btnDran.BackColor = Color.Yellow;
            }
            else
            {
                btnDran.BackColor = Color.Red;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dran();
            if (btn12.BackColor != Color.Red && btn12.BackColor != Color.Yellow)
            {
                btn12.BackColor = btnDran.BackColor;
            }
            else if (btn11.BackColor != Color.Red && btn11.BackColor != Color.Yellow)
            {
                btn11.BackColor = btnDran.BackColor;
            }
            else if (btn10.BackColor != Color.Red && btn10.BackColor != Color.Yellow)
            {
                btn10.BackColor = btnDran.BackColor;
            }
            else if (btn9.BackColor != Color.Red && btn9.BackColor != Color.Yellow)
            {
                btn9.BackColor = btnDran.BackColor;
            }
            else if (btn8.BackColor != Color.Red && btn8.BackColor != Color.Yellow)
            {
                btn8.BackColor = btnDran.BackColor;
            }
            else if (btn7.BackColor != Color.Red && btn7.BackColor != Color.Yellow)
            {
                btn7.BackColor = btnDran.BackColor;
                button9.Enabled = false;
                button9.BackColor = Color.Gray;
                button9.Text = "voll";
            }
           wechseln();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

            dran();

            if (btn6.BackColor!= Color.Red && btn6.BackColor!=Color.Yellow) 
            { 
            btn6.BackColor = btnDran.BackColor;
            }
            else if (btn5.BackColor != Color.Red && btn5.BackColor != Color.Yellow) 
            {
                btn5.BackColor = btnDran.BackColor;
            }
            else if (btn4.BackColor != Color.Red && btn4.BackColor != Color.Yellow)
            {
                btn4.BackColor = btnDran.BackColor;
            }

            else if (btn3.BackColor != Color.Red && btn3.BackColor != Color.Yellow)
            {
                btn3.BackColor = btnDran.BackColor;
            }

            else if (btn2.BackColor != Color.Red && btn2.BackColor != Color.Yellow)
            {
                btn2.BackColor = btnDran.BackColor;
            }

            else if (btn1.BackColor != Color.Red && btn1.BackColor != Color.Yellow)
            {
                btn1.BackColor = btnDran.BackColor;
                button10.Enabled = false;
                button10.BackColor = Color.Gray;
                button10.Text = "voll";
            }
            wechseln();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dran();
            if (btn18.BackColor != Color.Red && btn18.BackColor != Color.Yellow)
            {
                btn18.BackColor = btnDran.BackColor;
            }
            else if (btn17.BackColor != Color.Red && btn17.BackColor != Color.Yellow)
            {
                btn17.BackColor = btnDran.BackColor;
            }
            else if (btn16.BackColor != Color.Red && btn16.BackColor != Color.Yellow)
            {
                btn16.BackColor = btnDran.BackColor;
            }
            else if (btn15.BackColor != Color.Red && btn15.BackColor != Color.Yellow)
            {
                btn15.BackColor = btnDran.BackColor;
            }
            else if (btn14.BackColor != Color.Red && btn14.BackColor != Color.Yellow)
            {
                btn14.BackColor = btnDran.BackColor;
            }
            else if (btn13.BackColor != Color.Red && btn13.BackColor != Color.Yellow)
            {
                btn13.BackColor = btnDran.BackColor;
                button12.Enabled = false;
                button12.BackColor = Color.Gray;
                button12.Text = "voll";
            }
            wechseln();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dran();
            if (btn24.BackColor != Color.Red && btn24.BackColor != Color.Yellow)
            {
                btn24.BackColor = btnDran.BackColor;
            }
            else if (btn23.BackColor != Color.Red && btn23.BackColor != Color.Yellow)
            {
                btn23.BackColor = btnDran.BackColor;
            }
            else if (btn22.BackColor != Color.Red && btn22.BackColor != Color.Yellow)
            {
                btn22.BackColor = btnDran.BackColor;
            }
            else if (btn21.BackColor != Color.Red && btn21.BackColor != Color.Yellow)
            {
                btn21.BackColor = btnDran.BackColor;
            }
            else if (btn20.BackColor != Color.Red && btn20.BackColor != Color.Yellow)
            {
                btn20.BackColor = btnDran.BackColor;
            }
            else if (btn19.BackColor != Color.Red && btn19.BackColor != Color.Yellow)
            {
                btn19.BackColor = btnDran.BackColor;
                button13.Enabled = false;
                button13.BackColor = Color.Gray;
                button13.Text = "voll";
            }
            wechseln();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dran();
            if (btn30.BackColor != Color.Red && btn30.BackColor != Color.Yellow)
            {
                btn30.BackColor = btnDran.BackColor;
            }
            else if (btn29.BackColor != Color.Red && btn29.BackColor != Color.Yellow)
            {
                btn29.BackColor = btnDran.BackColor;
            }
            else if (btn28.BackColor != Color.Red && btn28.BackColor != Color.Yellow)
            {
                btn28.BackColor = btnDran.BackColor;
            }
            else if (btn27.BackColor != Color.Red && btn27.BackColor != Color.Yellow)
            {
                btn27.BackColor = btnDran.BackColor;
            }
            else if (btn26.BackColor != Color.Red && btn26.BackColor != Color.Yellow)
            {
                btn26.BackColor = btnDran.BackColor;
            }
            else if (btn25.BackColor != Color.Red && btn25.BackColor != Color.Yellow)
            {
                btn25.BackColor = btnDran.BackColor;
                button14.Enabled = false;
                button14.BackColor = Color.Gray;
                button14.Text = "voll";
            }
            wechseln();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dran();
            if (btn36.BackColor != Color.Red && btn36.BackColor != Color.Yellow)
            {
                btn36.BackColor = btnDran.BackColor;
            }
            else if (btn35.BackColor != Color.Red && btn35.BackColor != Color.Yellow)
            {
                btn35.BackColor = btnDran.BackColor;
            }
            else if (btn34.BackColor != Color.Red && btn34.BackColor != Color.Yellow)
            {
                btn34.BackColor = btnDran.BackColor;
            }
            else if (btn33.BackColor != Color.Red && btn33.BackColor != Color.Yellow)
            {
                btn33.BackColor = btnDran.BackColor;
            }
            else if (btn32.BackColor != Color.Red && btn32.BackColor != Color.Yellow)
            {
                btn32.BackColor = btnDran.BackColor;
            }
            else if (btn31.BackColor != Color.Red && btn31.BackColor != Color.Yellow)
            {
                btn31.BackColor = btnDran.BackColor;
                button15.Enabled = false;
                button15.BackColor = Color.Gray;
                button15.Text = "voll";
            }
            wechseln();
        }
    }
}
