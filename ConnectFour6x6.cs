using System;
using System.Drawing;
using System.Linq;
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


        void dran()
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

        
        void gewin()
        {      //Vertikale
            if ((btn4.BackColor == Color.Red && btn3.BackColor == Color.Red && btn2.BackColor == Color.Red && btn1.BackColor == Color.Red) ||
                (btn5.BackColor == Color.Red && btn4.BackColor == Color.Red && btn3.BackColor == Color.Red && btn2.BackColor == Color.Red) ||
                (btn6.BackColor == Color.Red && btn5.BackColor == Color.Red && btn4.BackColor == Color.Red && btn3.BackColor == Color.Red) ||
                (btn10.BackColor == Color.Red && btn9.BackColor == Color.Red && btn8.BackColor == Color.Red && btn7.BackColor == Color.Red) ||
                (btn11.BackColor == Color.Red && btn10.BackColor == Color.Red && btn9.BackColor == Color.Red && btn8.BackColor == Color.Red) ||
                (btn12.BackColor == Color.Red && btn11.BackColor == Color.Red && btn10.BackColor == Color.Red && btn9.BackColor == Color.Red) ||
                (btn16.BackColor == Color.Red && btn15.BackColor == Color.Red && btn14.BackColor == Color.Red && btn13.BackColor == Color.Red) ||
                (btn17.BackColor == Color.Red && btn16.BackColor == Color.Red && btn15.BackColor == Color.Red && btn14.BackColor == Color.Red) ||
                (btn18.BackColor == Color.Red && btn17.BackColor == Color.Red && btn16.BackColor == Color.Red && btn15.BackColor == Color.Red) ||
                (btn22.BackColor == Color.Red && btn21.BackColor == Color.Red && btn20.BackColor == Color.Red && btn19.BackColor == Color.Red) ||
                (btn23.BackColor == Color.Red && btn22.BackColor == Color.Red && btn21.BackColor == Color.Red && btn20.BackColor == Color.Red) ||
                (btn24.BackColor == Color.Red && btn23.BackColor == Color.Red && btn22.BackColor == Color.Red && btn21.BackColor == Color.Red) ||
                (btn28.BackColor == Color.Red && btn27.BackColor == Color.Red && btn26.BackColor == Color.Red && btn25.BackColor == Color.Red) ||
                (btn29.BackColor == Color.Red && btn28.BackColor == Color.Red && btn27.BackColor == Color.Red && btn26.BackColor == Color.Red) ||
                (btn30.BackColor == Color.Red && btn29.BackColor == Color.Red && btn28.BackColor == Color.Red && btn27.BackColor == Color.Red) ||
                (btn34.BackColor == Color.Red && btn33.BackColor == Color.Red && btn32.BackColor == Color.Red && btn31.BackColor == Color.Red) ||
                (btn35.BackColor == Color.Red && btn34.BackColor == Color.Red && btn33.BackColor == Color.Red && btn32.BackColor == Color.Red) ||
                (btn36.BackColor == Color.Red && btn35.BackColor == Color.Red && btn34.BackColor == Color.Red && btn33.BackColor == Color.Red) ||
                //horizontal
                (btn1.BackColor == Color.Red && btn7.BackColor == Color.Red && btn13.BackColor == Color.Red && btn19.BackColor == Color.Red) ||
                (btn2.BackColor == Color.Red && btn8.BackColor == Color.Red && btn14.BackColor == Color.Red && btn20.BackColor == Color.Red) ||
                (btn3.BackColor == Color.Red && btn9.BackColor == Color.Red && btn15.BackColor == Color.Red && btn21.BackColor == Color.Red) ||
                (btn4.BackColor == Color.Red && btn10.BackColor == Color.Red && btn16.BackColor == Color.Red && btn22.BackColor == Color.Red) ||
                (btn5.BackColor == Color.Red && btn11.BackColor == Color.Red && btn17.BackColor == Color.Red && btn23.BackColor == Color.Red) ||
                (btn6.BackColor == Color.Red && btn12.BackColor == Color.Red && btn18.BackColor == Color.Red && btn24.BackColor == Color.Red) ||
                (btn7.BackColor == Color.Red && btn13.BackColor == Color.Red && btn19.BackColor == Color.Red && btn25.BackColor == Color.Red) ||
                (btn8.BackColor == Color.Red && btn14.BackColor == Color.Red && btn20.BackColor == Color.Red && btn26.BackColor == Color.Red) ||
                (btn9.BackColor == Color.Red && btn15.BackColor == Color.Red && btn21.BackColor == Color.Red && btn27.BackColor == Color.Red) ||
                (btn10.BackColor == Color.Red && btn16.BackColor == Color.Red && btn22.BackColor == Color.Red && btn28.BackColor == Color.Red) ||
                (btn11.BackColor == Color.Red && btn17.BackColor == Color.Red && btn23.BackColor == Color.Red && btn29.BackColor == Color.Red) ||
                (btn12.BackColor == Color.Red && btn18.BackColor == Color.Red && btn24.BackColor == Color.Red && btn30.BackColor == Color.Red) ||
                (btn13.BackColor == Color.Red && btn19.BackColor == Color.Red && btn25.BackColor == Color.Red && btn31.BackColor == Color.Red) ||
                (btn14.BackColor == Color.Red && btn20.BackColor == Color.Red && btn26.BackColor == Color.Red && btn32.BackColor == Color.Red) ||
                (btn15.BackColor == Color.Red && btn21.BackColor == Color.Red && btn27.BackColor == Color.Red && btn33.BackColor == Color.Red) ||
                (btn16.BackColor == Color.Red && btn22.BackColor == Color.Red && btn28.BackColor == Color.Red && btn34.BackColor == Color.Red) ||
                (btn17.BackColor == Color.Red && btn23.BackColor == Color.Red && btn29.BackColor == Color.Red && btn35.BackColor == Color.Red) ||
                (btn18.BackColor == Color.Red && btn24.BackColor == Color.Red && btn30.BackColor == Color.Red && btn36.BackColor == Color.Red) ||
                //Diagonale
                (btn1.BackColor == Color.Red && btn8.BackColor == Color.Red && btn15.BackColor == Color.Red && btn22.BackColor == Color.Red) ||
                (btn2.BackColor == Color.Red && btn9.BackColor == Color.Red && btn16.BackColor == Color.Red && btn23.BackColor == Color.Red) ||
                (btn3.BackColor == Color.Red && btn10.BackColor == Color.Red && btn17.BackColor == Color.Red && btn24.BackColor == Color.Red) ||
                (btn8.BackColor == Color.Red && btn15.BackColor == Color.Red && btn22.BackColor == Color.Red && btn29.BackColor == Color.Red) ||
                (btn9.BackColor == Color.Red && btn16.BackColor == Color.Red && btn23.BackColor == Color.Red && btn30.BackColor == Color.Red) ||
                (btn15.BackColor == Color.Red && btn22.BackColor == Color.Red && btn29.BackColor == Color.Red && btn36.BackColor == Color.Red) ||
                (btn7.BackColor == Color.Red && btn14.BackColor == Color.Red && btn21.BackColor == Color.Red && btn28.BackColor == Color.Red) ||
                (btn14.BackColor == Color.Red && btn21.BackColor == Color.Red && btn28.BackColor == Color.Red && btn35.BackColor == Color.Red) ||
                (btn13.BackColor == Color.Red && btn20.BackColor == Color.Red && btn27.BackColor == Color.Red && btn34.BackColor == Color.Red) ||
                (btn31.BackColor == Color.Red && btn26.BackColor == Color.Red && btn21.BackColor == Color.Red && btn16.BackColor == Color.Red) ||
                (btn26.BackColor == Color.Red && btn21.BackColor == Color.Red && btn16.BackColor == Color.Red && btn11.BackColor == Color.Red) ||
                (btn21.BackColor == Color.Red && btn16.BackColor == Color.Red && btn11.BackColor == Color.Red && btn6.BackColor == Color.Red) ||
                (btn32.BackColor == Color.Red && btn27.BackColor == Color.Red && btn22.BackColor == Color.Red && btn17.BackColor == Color.Red) ||
                (btn27.BackColor == Color.Red && btn22.BackColor == Color.Red && btn17.BackColor == Color.Red && btn12.BackColor == Color.Red) ||
                (btn33.BackColor == Color.Red && btn28.BackColor == Color.Red && btn23.BackColor == Color.Red && btn18.BackColor == Color.Red) ||
                (btn25.BackColor == Color.Red && btn20.BackColor == Color.Red && btn15.BackColor == Color.Red && btn10.BackColor == Color.Red) ||
                (btn20.BackColor == Color.Red && btn15.BackColor == Color.Red && btn10.BackColor == Color.Red && btn5.BackColor == Color.Red) ||
                (btn19.BackColor == Color.Red && btn14.BackColor == Color.Red && btn9.BackColor == Color.Red && btn4.BackColor == Color.Red))
            {


                MessageBox.Show("Rot hat gewonnen");


                for (int i = 1; i <= 42; i++)
                {
                    Button btn = this.Controls.Find("btn" + i, true)[0] as Button;
                    btn.BackColor = Color.White;
                }

                for (int i = 37; i <= 42; i++)
                {
                    Button btn = this.Controls.Find("btn" + i, true)[0] as Button;
                    btn.Text = "+";
                    btn.Enabled = true;
                }

            }

            if ((btn4.BackColor == Color.Yellow && btn3.BackColor == Color.Yellow && btn2.BackColor == Color.Yellow && btn1.BackColor == Color.Yellow) ||
                (btn5.BackColor == Color.Yellow && btn4.BackColor == Color.Yellow && btn3.BackColor == Color.Yellow && btn2.BackColor == Color.Yellow) ||
                (btn6.BackColor == Color.Yellow && btn5.BackColor == Color.Yellow && btn4.BackColor == Color.Yellow && btn3.BackColor == Color.Yellow) ||
                (btn10.BackColor == Color.Yellow && btn9.BackColor == Color.Yellow && btn8.BackColor == Color.Yellow && btn7.BackColor == Color.Yellow) ||
                (btn11.BackColor == Color.Yellow && btn10.BackColor == Color.Yellow && btn9.BackColor == Color.Yellow && btn8.BackColor == Color.Yellow) ||
                (btn12.BackColor == Color.Yellow && btn11.BackColor == Color.Yellow && btn10.BackColor == Color.Yellow && btn9.BackColor == Color.Yellow) ||
                (btn16.BackColor == Color.Yellow && btn15.BackColor == Color.Yellow && btn14.BackColor == Color.Yellow && btn13.BackColor == Color.Yellow) ||
                (btn17.BackColor == Color.Yellow && btn16.BackColor == Color.Yellow && btn15.BackColor == Color.Yellow && btn14.BackColor == Color.Yellow) ||
                (btn18.BackColor == Color.Yellow && btn17.BackColor == Color.Yellow && btn16.BackColor == Color.Yellow && btn15.BackColor == Color.Yellow) ||
                (btn22.BackColor == Color.Yellow && btn21.BackColor == Color.Yellow && btn20.BackColor == Color.Yellow && btn19.BackColor == Color.Yellow) ||
                (btn23.BackColor == Color.Yellow && btn22.BackColor == Color.Yellow && btn21.BackColor == Color.Yellow && btn20.BackColor == Color.Yellow) ||
                (btn24.BackColor == Color.Yellow && btn23.BackColor == Color.Yellow && btn22.BackColor == Color.Yellow && btn21.BackColor == Color.Yellow) ||
                (btn28.BackColor == Color.Yellow && btn27.BackColor == Color.Yellow && btn26.BackColor == Color.Yellow && btn25.BackColor == Color.Yellow) ||
                (btn29.BackColor == Color.Yellow && btn28.BackColor == Color.Yellow && btn27.BackColor == Color.Yellow && btn26.BackColor == Color.Yellow) ||
                (btn30.BackColor == Color.Yellow && btn29.BackColor == Color.Yellow && btn28.BackColor == Color.Yellow && btn27.BackColor == Color.Yellow) ||
                (btn34.BackColor == Color.Yellow && btn33.BackColor == Color.Yellow && btn32.BackColor == Color.Yellow && btn31.BackColor == Color.Yellow) ||
                (btn35.BackColor == Color.Yellow && btn34.BackColor == Color.Yellow && btn33.BackColor == Color.Yellow && btn32.BackColor == Color.Yellow) ||
                (btn36.BackColor == Color.Yellow && btn35.BackColor == Color.Yellow && btn34.BackColor == Color.Yellow && btn33.BackColor == Color.Yellow) ||
                //horizontal
                (btn1.BackColor == Color.Yellow && btn7.BackColor == Color.Yellow && btn13.BackColor == Color.Yellow && btn19.BackColor == Color.Yellow) ||
                (btn2.BackColor == Color.Yellow && btn8.BackColor == Color.Yellow && btn14.BackColor == Color.Yellow && btn20.BackColor == Color.Yellow) ||
                (btn3.BackColor == Color.Yellow && btn9.BackColor == Color.Yellow && btn15.BackColor == Color.Yellow && btn21.BackColor == Color.Yellow) ||
                (btn4.BackColor == Color.Yellow && btn10.BackColor == Color.Yellow && btn16.BackColor == Color.Yellow && btn22.BackColor == Color.Yellow) ||
                (btn5.BackColor == Color.Yellow && btn11.BackColor == Color.Yellow && btn17.BackColor == Color.Yellow && btn23.BackColor == Color.Yellow) ||
                (btn6.BackColor == Color.Yellow && btn12.BackColor == Color.Yellow && btn18.BackColor == Color.Yellow && btn24.BackColor == Color.Yellow) ||
                (btn7.BackColor == Color.Yellow && btn13.BackColor == Color.Yellow && btn19.BackColor == Color.Yellow && btn25.BackColor == Color.Yellow) ||
                (btn8.BackColor == Color.Yellow && btn14.BackColor == Color.Yellow && btn20.BackColor == Color.Yellow && btn26.BackColor == Color.Yellow) ||
                (btn9.BackColor == Color.Yellow && btn15.BackColor == Color.Yellow && btn21.BackColor == Color.Yellow && btn27.BackColor == Color.Yellow) ||
                (btn10.BackColor == Color.Yellow && btn16.BackColor == Color.Yellow && btn22.BackColor == Color.Yellow && btn28.BackColor == Color.Yellow) ||
                (btn11.BackColor == Color.Yellow && btn17.BackColor == Color.Yellow && btn23.BackColor == Color.Yellow && btn29.BackColor == Color.Yellow) ||
                (btn12.BackColor == Color.Yellow && btn18.BackColor == Color.Yellow && btn24.BackColor == Color.Yellow && btn30.BackColor == Color.Yellow) ||
                (btn13.BackColor == Color.Yellow && btn19.BackColor == Color.Yellow && btn25.BackColor == Color.Yellow && btn31.BackColor == Color.Yellow) ||
                (btn14.BackColor == Color.Yellow && btn20.BackColor == Color.Yellow && btn26.BackColor == Color.Yellow && btn32.BackColor == Color.Yellow) ||
                (btn15.BackColor == Color.Yellow && btn21.BackColor == Color.Yellow && btn27.BackColor == Color.Yellow && btn33.BackColor == Color.Yellow) ||
                (btn16.BackColor == Color.Yellow && btn22.BackColor == Color.Yellow && btn28.BackColor == Color.Yellow && btn34.BackColor == Color.Yellow) ||
                (btn17.BackColor == Color.Yellow && btn23.BackColor == Color.Yellow && btn29.BackColor == Color.Yellow && btn35.BackColor == Color.Yellow) ||
                (btn18.BackColor == Color.Yellow && btn24.BackColor == Color.Yellow && btn30.BackColor == Color.Yellow && btn36.BackColor == Color.Yellow) ||
                //Diagonale
                (btn1.BackColor == Color.Yellow && btn8.BackColor == Color.Yellow && btn15.BackColor == Color.Yellow && btn22.BackColor == Color.Yellow) ||
                (btn2.BackColor == Color.Yellow && btn9.BackColor == Color.Yellow && btn16.BackColor == Color.Yellow && btn23.BackColor == Color.Yellow) ||
                (btn3.BackColor == Color.Yellow && btn10.BackColor == Color.Yellow && btn17.BackColor == Color.Yellow && btn24.BackColor == Color.Yellow) ||
                (btn8.BackColor == Color.Yellow && btn15.BackColor == Color.Yellow && btn22.BackColor == Color.Yellow && btn29.BackColor == Color.Yellow) ||
                (btn9.BackColor == Color.Yellow && btn16.BackColor == Color.Yellow && btn23.BackColor == Color.Yellow && btn30.BackColor == Color.Yellow) ||
                (btn15.BackColor == Color.Yellow && btn22.BackColor == Color.Yellow && btn29.BackColor == Color.Yellow && btn36.BackColor == Color.Yellow) ||
                (btn7.BackColor == Color.Yellow && btn14.BackColor == Color.Yellow && btn21.BackColor == Color.Yellow && btn28.BackColor == Color.Yellow) ||
                (btn14.BackColor == Color.Yellow && btn21.BackColor == Color.Yellow && btn28.BackColor == Color.Yellow && btn35.BackColor == Color.Yellow) ||
                (btn13.BackColor == Color.Yellow && btn20.BackColor == Color.Yellow && btn27.BackColor == Color.Yellow && btn34.BackColor == Color.Yellow) ||
                (btn31.BackColor == Color.Yellow && btn26.BackColor == Color.Yellow && btn21.BackColor == Color.Yellow && btn16.BackColor == Color.Yellow) ||
                (btn26.BackColor == Color.Yellow && btn21.BackColor == Color.Yellow && btn16.BackColor == Color.Yellow && btn11.BackColor == Color.Yellow) ||
                (btn21.BackColor == Color.Yellow && btn16.BackColor == Color.Yellow && btn11.BackColor == Color.Yellow && btn6.BackColor == Color.Yellow) ||
                (btn32.BackColor == Color.Yellow && btn27.BackColor == Color.Yellow && btn22.BackColor == Color.Yellow && btn17.BackColor == Color.Yellow) ||
                (btn27.BackColor == Color.Yellow && btn22.BackColor == Color.Yellow && btn17.BackColor == Color.Yellow && btn12.BackColor == Color.Yellow) ||
                (btn33.BackColor == Color.Yellow && btn28.BackColor == Color.Yellow && btn23.BackColor == Color.Yellow && btn18.BackColor == Color.Yellow) ||
                (btn25.BackColor == Color.Yellow && btn20.BackColor == Color.Yellow && btn15.BackColor == Color.Yellow && btn10.BackColor == Color.Yellow) ||
                (btn20.BackColor == Color.Yellow && btn15.BackColor == Color.Yellow && btn10.BackColor == Color.Yellow && btn5.BackColor == Color.Yellow) ||
                (btn19.BackColor == Color.Yellow && btn14.BackColor == Color.Yellow && btn9.BackColor == Color.Yellow && btn4.BackColor == Color.Yellow))
            {
                
                MessageBox.Show("Gelb hat gewonnen.");

                for (int i = 1; i <= 42; i++)
                {
                    Button btn = this.Controls.Find("btn" + i, true)[0] as Button;
                    btn.BackColor = Color.White;
                }

                for (int i = 37; i <= 42; i++)
                {
                    Button btn = this.Controls.Find("btn" + i, true)[0] as Button;
                    btn.Text = "+";
                    btn.Enabled = true;
                }

            }

        }

        private void btn37_Click_1(object sender, EventArgs e)
        {

            dran();

            if (btn6.BackColor != Color.Red && btn6.BackColor != Color.Yellow)
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
                btn37.Enabled = false;
                btn37.BackColor = Color.Gray;
                btn37.Text = "voll";
            }


            gewin();
            wechseln();
           
        }

        private void btn38_Click(object sender, EventArgs e)
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
                btn38.Enabled = false;
                btn38.BackColor = Color.Gray;
                btn38.Text = "voll";
            }
            gewin();
            wechseln();
            
        }

        private void btn39_Click(object sender, EventArgs e)
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
                btn39.Enabled = false;
                btn39.BackColor = Color.Gray;
                btn39.Text = "voll";
            }
            wechseln();
            gewin();

        }

        private void btn40_Click(object sender, EventArgs e)
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
                btn40.Enabled = false;
                btn40.BackColor = Color.Gray;
                btn40.Text = "voll";
            }
            wechseln();
            gewin();
        }

        private void btn41_Click(object sender, EventArgs e)
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
                btn41.Enabled = false;
                btn41.BackColor = Color.Gray;
                btn41.Text = "voll";
            }
            wechseln();
            gewin();
        }

        private void btn42_Click(object sender, EventArgs e)
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
                btn42.Enabled = false;
                btn42.BackColor = Color.Gray;
                btn42.Text = "voll";
            }

            wechseln();
            gewin();
        }


    }

}

